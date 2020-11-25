using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Image_Converter
{
    public partial class image_converter : Form
    {

        string[] images_selected;
        System.Drawing.Imaging.Encoder myImage_Encoder = System.Drawing.Imaging.Encoder.Quality;
        ImageCodecInfo image_encoder;
        int new_Width, new_Height;
        string img_extension;
        int total_num_of_files;
        bool input_sanitized;

        BackgroundWorker myWorker = new BackgroundWorker();
        public image_converter()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string main_path = @"C:\Users\" + Environment.UserName+ @"\Documents\Image Converter\";
            create_directories(main_path);
        }

        private static void newThread(Action action)
        {
            var thread = new Thread(new ThreadStart(action));
            thread.Start();
        }

        private void create_directories(string path)
        {
            try
            {
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Something went wrong creating directories" +" "+ ex.Message + " " + "Try again or restart Software.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string create_subDirectories()
        {
            string sub_path = @"C:\Users\" + Environment.UserName + @"\Documents\Image Converter\Output " + DateTime.UtcNow.ToString("dddd, dd MMMM yyyy, HH-mm-ss") + @"\";
            try
            {
                create_directories(sub_path);
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error Creating subdirectory. " + ex.Message + " Restart software", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                return sub_path;
        }

        private string set_file_Names(string folder_path)
        {
            int num_of_files;
            string file_name = "";

            num_of_files = Directory.GetFiles(folder_path).Length;
            num_of_files += 1;
            return file_name = "image" + num_of_files.ToString();
        }

        private void convert_images_but_Click(object sender, EventArgs e)
        {
            sanitize_input();

            if (input_sanitized)
            {
                newThread(manipulate_image);
            }
            else
                return;
        }

        private void browse_images_Click(object sender, EventArgs e)
        {
            //float i = 0.0f;
            //float percentage_done = 0.0f;

            try
            {
                if (openFileDialog1.ShowDialog() != DialogResult.OK)
                    return;

                openFileDialog1.Filter = "Image Files (*.jpg, *.jpeg, *.jpe, *.tfif, *.png) | *.jpg; *.jpeg; *.jpe; *.tiff; *.png";

                images_selected = openFileDialog1.FileNames;
                total_num_of_files = images_selected.Length;
                selected_images_textBox.Text = openFileDialog1.FileName + " * (all selected files)";

                //foreach (string image in images_selected)
                //{
                //    Cursor = Cursors.WaitCursor;

                //    selected_images_textBox.AppendText(image);
                //    selected_images_textBox.AppendText(Environment.NewLine + "; ");

                //    i += 1;
                //    percentage_done = (i / total_num_of_files) * 100;
                //    process_info.Text = string.Format("loading image files . . . {0}% done", percentage_done.ToString("f0"));
                //}

                Cursor = Cursors.Default;
            }
            catch(Exception ex)
            {
                Cursor = Cursors.Default;
                MessageBox.Show("Something went wrong loading image files."+" " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                process_info.Text = "Powered by Cryptech GH";
                Cursor = Cursors.Default;
            }
        }

        private void setEncoder_and_extension()
        {
            switch(imageFormats_dropdown.SelectedIndex)
            {
                case 0:
                    image_encoder = GetEncoder(ImageFormat.Bmp);
                    img_extension = ".bmp";
                    break;
                case 1:
                    image_encoder = GetEncoder(ImageFormat.Tiff);
                    img_extension = ".tiff";
                    break;
                case 2:
                    image_encoder = GetEncoder(ImageFormat.Png);
                    img_extension = ".png";
                    break;
                case 3:
                    image_encoder = GetEncoder(ImageFormat.Jpeg);
                    img_extension = ".jpg";
                    break;
            }
        }

        private ImageCodecInfo GetEncoder(ImageFormat format)
        {
            ImageCodecInfo[] codecs = ImageCodecInfo.GetImageDecoders();

            foreach (ImageCodecInfo codec in codecs)
            {
                if (codec.FormatID == format.Guid)
                {
                    return codec;
                }
            }
            return null;
        }

        void set_controls(bool value)
        {
            convert_images_but.Invoke(new Action(() => convert_images_but.Enabled = value));
            browse_images.Invoke(new Action(() => browse_images.Enabled = value));
            imageFormats_dropdown.Invoke(new Action(() => imageFormats_dropdown.Enabled = value));
        }

        void display_notification()
        {
            var notification = new NotifyIcon()
            {
                Visible = true,
                Icon = SystemIcons.Information,
                BalloonTipIcon = ToolTipIcon.Info,
                BalloonTipTitle = "Success",
                BalloonTipText = "Images converted successfully",
            };

            notification.ShowBalloonTip(10000);
            //notification.Click += new EventHandler(btBallonToolTip_Click);
        }

        void manipulate_image()
        {
            float i = 0.0f;
            float percentage_done = 0.0f;

                string sub_dir_path = create_subDirectories();

                new_Width = Convert.ToInt32(width_textBox.Text.Trim() as string);
                new_Height = Convert.ToInt32(height_textBox.Text.Trim() as string);
                

                try
                {
                    foreach (string image_name in images_selected)
                    {
                        Bitmap new_image = new Bitmap(new_Width, new_Height, PixelFormat.Format24bppRgb);

                        set_controls(false);
                        convert_images_but.Invoke(new Action(()=> convert_images_but.Cursor = Cursors.WaitCursor));

                        Bitmap Original_image = new Bitmap(image_name);

                        using (Graphics graphics = Graphics.FromImage(new_image))
                        {
                            graphics.CompositingQuality = CompositingQuality.HighQuality;
                            graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                            graphics.SmoothingMode = SmoothingMode.HighQuality;
                            graphics.DrawImage(Original_image, 0, 0, new_Width, new_Height);
                        }

                        EncoderParameters myEncoderParameters = new EncoderParameters(1);

                        EncoderParameter myEncoderParameter = new EncoderParameter(myImage_Encoder, 200L);
                        myEncoderParameters.Param[0] = myEncoderParameter;
                        //new_image.Save(sub_dir_path + set_file_Names(sub_dir_path) + img_extension, image_encoder, myEncoderParameters);
                         new_image.Save(sub_dir_path + Path.GetFileNameWithoutExtension(image_name) + img_extension, image_encoder, myEncoderParameters);

                        i += 1;
                        percentage_done = (i / total_num_of_files) * 100;
                        process_info.Invoke(new Action(() =>process_info.Text = string.Format("converting image files . . . {0}% done", percentage_done.ToString("f0"))));

                        GC.Collect();
                     }

                    TextBox[] text_fields = new TextBox[] { selected_images_textBox, width_textBox, height_textBox };
                    foreach (TextBox field in text_fields)
                     {
                         field.Invoke(new Action(()=>field.Clear()));
                     }

                        imageFormats_dropdown.Invoke(new Action(()=>imageFormats_dropdown.SelectedIndex = -1));
                        
                        set_controls(true);
                        convert_images_but.Invoke(new Action(()=> convert_images_but.Cursor = Cursors.Default));    
                        process_info.Invoke(new Action(() =>process_info.Text = "cryptech Links"));

                        display_notification();

                        if (MessageBox.Show(@"Image(s) converted successfully. Files saved in Documents\Image Converter", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                            Process.Start(sub_dir_path);
                }
                catch (Exception ex)
                {
                    set_controls(true);
                    convert_images_but.Invoke(new Action(()=> convert_images_but.Cursor = Cursors.Default));   
                    MessageBox.Show("Something went wrong converting image - " + "" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    set_controls(true);
                    process_info.Invoke(new Action(() => process_info.Text = "Cryptech Links"));
                }
        }

        private void imageFormats_dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            setEncoder_and_extension();
        }

        private void sanitize_input()
        {
            TextBox[] text_fields = { selected_images_textBox, width_textBox, height_textBox };
            foreach(TextBox textField in text_fields)
            {
                if(string.IsNullOrEmpty(textField.Text.Trim().ToString()))
                {
                    input_sanitized = false;
                    errorProvider1.SetError(textField, "this field cannot be empty");
                    return;
                }
                else
                {
                    input_sanitized = true;
                    errorProvider1.SetError(textField, null);
                }
            }

            TextBox[] size_fields = {width_textBox, height_textBox };
            int i;
            foreach(TextBox field in size_fields)
            {
                if (int.TryParse(field.Text, out i) != true)
                {
                    input_sanitized = false;
                    errorProvider1.SetError(field, "this field must be a number");
                    return;
                }
                else if(Convert.ToInt32(field.Text) < 1)
                {
                    input_sanitized = false;
                    errorProvider1.SetError(field, "must be greater than zero");
                    return;
                } 
                else
                {
                    input_sanitized = true;
                    errorProvider1.SetError(field, null);
                }
            }


            if (imageFormats_dropdown.SelectedIndex == -1)
            {
                input_sanitized = false;
                errorProvider1.SetError(imageFormats_dropdown, "select an option");
                return;
            }
            else
            {
                input_sanitized = true;
                errorProvider1.SetError(imageFormats_dropdown, null);
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show(string.Format("This is a free software by Cryptech Links. {0} Lets hear from you mail@cryptechgh.com",Environment.NewLine), "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
