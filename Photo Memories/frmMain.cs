using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Threading;

namespace Back_In_Time_Photo
{
    public partial class frmMain : Form
    {
        List<FileInfo> todays_images = new List<FileInfo>();
        List<DateTime> todays_images_date = new List<DateTime>();
        int current_pic_index;

        List<image_item> images = new List<image_item>();


        public frmMain()
        {
            InitializeComponent();
            this.MinimumSize = new Size(370, 570);
        }

        public class image_item
        {
            public FileInfo fileinfo { get; set; }
            public DateTime datetime { get; set; }
        }

        /// <summary>
        /// Get the datetime from an image with a given path
        /// </summary>
        /// <param name="path">The path of the image</param>
        /// <returns>DateTime of image</returns>
        private DateTime GetDateTakenFromImage(string path)
        {
            Regex r = new Regex(":");

            using (FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read))
            using (Image myImage = Image.FromStream(fs, false, false))
            {
                PropertyItem propItem = myImage.GetPropertyItem(36867);
                string dateTaken = r.Replace(Encoding.UTF8.GetString(propItem.Value), "-", 2);
                return DateTime.Parse(dateTaken);
            }
        }

        /// <summary>
        /// Gets textual representation of a month as an integer. E.g. 1 is January,
        /// 12 is Feburary
        /// </summary>
        /// <param name="month">Month as integer</param>
        /// <returns>Month as string</returns>
        private string int_month_to_text(int month)
        {
            //Get textual representation of month integer
            switch (month)
            {
                case 1: return "January";
                case 2: return "Feburary";
                case 3: return "March";
                case 4: return "April";
                case 5: return "May";
                case 6: return "June";
                case 7: return "July";
                case 8: return "August";
                case 9: return "September";
                case 10: return "October";
                case 11: return "November";
                case 12: return "December";
                default: return "Error";
            }
        }

        /// <summary>
        /// Display either the next or the previous image
        /// </summary>
        /// <param name="forward_by">Amount to proceed by. E.g. 1 = Next, -1 = Previous</param>
        private void show_picture(int forward_by)
        {

            //Calculate the new picture index
            current_pic_index = current_pic_index + forward_by;

            //If overflown, set to zero
            if (current_pic_index >= todays_images.Count)
            {
                current_pic_index = 0;
            }

            //If underflown, set to number of todays images
            else if (current_pic_index < 0)
            {
                current_pic_index = todays_images.Count - 1;
            }

            //If images to be displayed
            if(todays_images.Count > 0)
            {

                //Load the image into the picture box
                pictureBox1.ImageLocation = todays_images[current_pic_index].FullName;
                pictureBox1.Load();

                //Set window title to the filename of the picture
                this.Text = todays_images[current_pic_index].Name;

                //Set label to display date of the picture
                lblDate.Text = Convert.ToString(todays_images_date[current_pic_index].DayOfWeek) + ", " +
                               Convert.ToString(todays_images_date[current_pic_index].Day) + " " +
                               int_month_to_text(Convert.ToInt16(todays_images_date[current_pic_index].Month)) + " " +
                               Convert.ToString(todays_images_date[current_pic_index].Year) + 
                               " (" + Convert.ToString(todays_images_date[current_pic_index].Hour) + ":" + 
                               Convert.ToString(todays_images_date[current_pic_index].Minute) + ")";
            }

            else
            {
                lblDate.Text = "No memories to view today.";
            }
        }








        /// <summary>
        /// Lookup the directory with the photos and rebuild photo cache
        /// </summary>
        private void refresh_images()
        {
            //Get files with the valid file extension
            var files = Directory.EnumerateFiles(@"G:\Pictures\Photos",
                                                 "*.*",
                                                 SearchOption.AllDirectories).Where(
                                                    s => s.ToLower().EndsWith(".png") ||
                                                    s.ToLower().EndsWith(".jpeg") ||
                                                    s.ToLower().EndsWith(".jpg"));

            //For each file in files variable
            foreach (var file in files)
            {

                //Load file info for file
                FileInfo file_info = new FileInfo(file);

                //New instance of date time to store image date
                DateTime image_date;

                //Attempt to get the image date
                try { image_date = GetDateTakenFromImage(file_info.FullName); }

                //If error, use last modified date as date
                catch { image_date = file_info.LastWriteTime; }

                images.Add(new image_item
                {
                    fileinfo = file_info,
                    datetime = image_date
                });
            }
        }

        private void load_images()
        {

            DateTime today = new DateTime(2016, 2, 16);

            //Attempt to load the image cache
            try
            {
                //Declare variable used to open imagecache.json file
                StreamReader sr_cache;

                //Open imagecache.json file
                sr_cache = new StreamReader(Application.StartupPath + @"\imagecache.json");

                //Declare STRING to store contents of imagecache.json
                string images_json = sr_cache.ReadToEnd();

                //Load json object to images
                images = JsonConvert.DeserializeObject<List<image_item>>(images_json);

                //Close file
                sr_cache.Close();
            }

            //If error loading cache
            catch
            {
                refresh_images();

                //Declare variable used to write imagecache.json
                StreamWriter sw_cache;

                //Start writing to imagecache.json file
                sw_cache = new StreamWriter(Application.StartupPath + @"\imagecache.json");

                //Generate JSON string from images
                string images_json = JsonConvert.SerializeObject(images);

                //Write JSON string to file
                sw_cache.Write(images_json);

                //Close file
                sw_cache.Close();
            }

            foreach (var image in images)
            {
                if (image.datetime.Year != today.Year &&
                    image.datetime.Month == today.Month &&
                    image.datetime.Day == today.Day)
                {
                    todays_images.Add(image.fileinfo);
                    todays_images_date.Add(image.datetime);
                }
            }
        }





        /// <summary>
        /// Runs when the form has been loaded. Will rearrange ui elements based on
        /// the current size of the form
        /// </summary>
        private void Form1_Load(object sender, EventArgs e)
        {
            ui();

            lblDate.Text = "Loading...";
            this.backgroundWorker1.RunWorkerAsync();
        }

        /// <summary>
        /// Runs when the form has been shown. Will load images either from the directory
        /// or from the cache
        /// </summary>
        private void frmMain_Shown(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            load_images();
        }

        private void backgroundWorker1_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            show_picture(0);
        }

        private void backgroundWorker1_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            lblDate.Text = "Loading... " + Convert.ToString(e.ProgressPercentage);
        }













        /// <summary>
        /// Command button to display the next picture
        /// </summary>
        private void cmdNextImg_Click(object sender, EventArgs e)
        {
            show_picture(1);
        }

        /// <summary>
        /// Command button to display the previous picture
        /// </summary>
        private void cmdPrevImg_Click(object sender, EventArgs e)
        {
            show_picture(-1);
        }

        /// <summary>
        /// Runs when the form has been resized. Will rearrange ui elements based on
        /// the current size of the form
        /// </summary>
        private void Form1_Resize(object sender, EventArgs e)
        {
            ui();
        }

        /// <summary>
        /// Rearrange ui elements on the form using the forms current size
        /// </summary>
        private void ui()
        {

            //Possition previous image button
            cmdPrevImg.Left = 0;
            cmdPrevImg.Top = this.ClientSize.Height / 2 - cmdPrevImg.Height / 2;

            //Possition next image button
            cmdNextImg.Left = this.ClientSize.Width - cmdNextImg.Width;
            cmdNextImg.Top = this.ClientSize.Height / 2 - cmdNextImg.Height / 2;

            //Position picture box
            pictureBox1.Top = panelInfo.Height;
            pictureBox1.Left = 0;
            pictureBox1.Height = this.ClientSize.Height - panelInfo.Height;
            pictureBox1.Width = this.ClientSize.Width;

            //Positin info panel
            panelInfo.Top = 0;
            panelInfo.Left = 0;
            panelInfo.Width = this.ClientSize.Width;
        }
    }
}
