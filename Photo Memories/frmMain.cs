/* The MIT License (MIT)
 *
 * Copyright (c) 2016 David Southgate
 * 
 * Permission is hereby granted, free of charge, to any person obtaining a copy
 * of this software and associated documentation files (the "Software"), to deal
 * in the Software without restriction, including without limitation the rights
 * to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
 * copies of the Software, and to permit persons to whom the Software is
 * furnished to do so, subject to the following conditions:
 * 
 * The above copyright notice and this permission notice shall be included in all
 * copies or substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
 * IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
 * FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
 * AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
 * LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
 * OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
 * SOFTWARE.
 */
 
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Threading;
using System.Diagnostics;
using System.Reflection;

namespace Photo_Memories
{
    public partial class frmMain : Form
    {

        //String to store default directory
        string default_source = Environment.GetEnvironmentVariable("USERPROFILE") + @"\Pictures\";

        bool refresh_try_cache = true;      //BOOLEAN flag. If true will attempt to load image metadata from cache.
        int current_pic_index;              //Integer to store currently displayed picture index

        config_class config = new config_class();                   //Object used to store the config
        List<image_item> todays_images = new List<image_item>();    //List used to store todays images
        List<image_item> cache_images = new List<image_item>();     //Image item list which stores image details for images in
                                                                    //the directory

        public frmMain()
        {
            InitializeComponent();

            //Set the minimum size that the form can be
            this.MinimumSize = new Size(370, 570);

            //Set the window title
            this.Text = this.ProductName;
        }

        /// <summary>
        /// Class used to store details about the images in the folder
        /// </summary>
        public class image_item
        {
            public FileInfo fileinfo { get; set; }
            public DateTime datetime { get; set; }
        }

        /// <summary>
        /// Class used for config
        /// </summary>
        public class config_class
        {
            public string source { get; set; }
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
        /// Display another image by using an integer to move forward by x images
        /// </summary>
        /// <param name="forward_by">Amount to proceed by. E.g. 1 = Next, -1 = Previous, 0 = Refresh</param>
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

                //Attempt to load the image
                try
                {
                    //Load the image into the picture box
                    picDisplay.ImageLocation = todays_images[current_pic_index].fileinfo.FullName;
                    picDisplay.Load();
                    Debug.WriteLine(picDisplay.ImageLocation);
                }

                catch { }

                //Set window title to the filename of the picture
                this.Text = todays_images[current_pic_index].fileinfo.Name + " - " + this.ProductName;

                //Set label to display date of the picture in format:
                //      Friday, 1 Janurary 2016 (12:00)
                lblHead.Text = Convert.ToString(todays_images[current_pic_index].datetime.DayOfWeek) + ", " +
                               Convert.ToString(todays_images[current_pic_index].datetime.Day) + " " +
                               int_month_to_text(Convert.ToInt16(todays_images[current_pic_index].datetime.Month)) + " " +
                               Convert.ToString(todays_images[current_pic_index].datetime.Year) + 
                               " (" + Convert.ToString(todays_images[current_pic_index].datetime.Hour) + ":" + 
                               Convert.ToString(todays_images[current_pic_index].datetime.Minute) + ")";

                //If only one image, hide the navigation buttons
                if (todays_images.Count == 1)
                {
                    cmdNextImg.Visible = false;
                    cmdPrevImg.Visible = false;
                }

                //If multiple image, show the navigation buttons
                else
                {
                    cmdNextImg.Visible = true;
                    cmdPrevImg.Visible = true;
                }
            }

            //Otherwise, display error that no memories exist for today
            else
            {

                //Hide the navigation buttons
                cmdNextImg.Visible = false;
                cmdPrevImg.Visible = false;

                //Remove existing image from the picture box
                picDisplay.Image = null;

                //Display message
                lblHead.Text = "No memories to view today.";
            }
        }

        /// <summary>
        /// Command button to display the previous picture
        /// </summary>
        private void cmdPrevImg_Click(object sender, EventArgs e)
        {
            show_picture(-1);
        }

        /// <summary>
        /// Command button to display the next picture
        /// </summary>
        private void cmdNextImg_Click(object sender, EventArgs e)
        {
            show_picture(1);
        }

        //=============================================================
        // Form and key events
        //=============================================================

        /// <summary>
        /// Runs when the form has been loaded. Will rearrange ui elements based on the current size of the form
        /// </summary>
        private void frmMain_Load(object sender, EventArgs e)
        {

            //Rearrange ui elements on the form using the forms current size
            ui();

            //Load the config
            config_load();

            //If the background worker is not already doing a refresh, start a refresh
            if (!bgw_refresh_files.IsBusy)
            {

                //Output message that the program is loading 
                lblHead.Text = "Loading...";

                //Start background worker to load images
                bgw_refresh_files.RunWorkerAsync();
            }
        }

        /// <summary>
        /// Runs when the form has been resized. Will rearrange ui elements based on
        /// the current size of the form
        /// </summary>
        private void frmMain_Resize(object sender, EventArgs e)
        {

            //Rearrange ui elements on the form using the current form size
            ui();
        }

        /// <summary>
        /// This method is called during message preprocessing to handle command keys. Command keys are keys that always take precedence over regular input keys. 
        /// </summary>
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            //If left key pressed, show previous picture
            if (keyData == Keys.Left)
            {
                show_picture(-1);
                return true;
            }

            //If right key pressed, show next picture
            else if (keyData == Keys.Right)
            {
                show_picture(-1);
                return true;
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        //=============================================================
        // UI
        //=============================================================

        /// <summary>
        /// Rearrange ui elements on the form using the current form size
        /// </summary>
        private void ui()
        {
            //Position picture panel
            panelPicture.Top = panelInfo.Height;
            panelPicture.Left = 0;
            panelPicture.Height = this.ClientSize.Height - panelInfo.Height;
            panelPicture.Width = this.ClientSize.Width;

            //Settings button
            cmdSettings.Top = 0;
            cmdSettings.Left = this.ClientSize.Width - cmdSettings.Width;

            //Force refresh button
            cmdRefresh.Top = 0;
            cmdRefresh.Left = this.ClientSize.Width - cmdSettings.Width - cmdRefresh.Width;

            //Possition previous image button
            cmdPrevImg.Left = 0;
            cmdPrevImg.Top = this.ClientSize.Height / 2 - cmdPrevImg.Height / 2 - panelInfo.Height;

            //Possition next image button
            cmdNextImg.Left = this.ClientSize.Width - cmdNextImg.Width;
            cmdNextImg.Top = this.ClientSize.Height / 2 - cmdNextImg.Height / 2 - panelInfo.Height;

            //Position picture box
            picDisplay.Top = 0;
            picDisplay.Left = 0;
            picDisplay.Height = panelPicture.Height;
            picDisplay.Width = panelPicture.Width;

            //Position info panel
            panelInfo.Top = 0;
            panelInfo.Left = 0;
            panelInfo.Width = this.ClientSize.Width;

            //Settings page ui
            ui_settings();
        }

        /// <summary>
        /// Rearrange settings ui elements on the form using the current form size
        /// </summary>
        private void ui_settings()
        {

            int draw_top = 10;

            //Panel
            panelSettings.Top = panelInfo.Height;
            panelSettings.Left = 0;
            panelSettings.Height = this.ClientSize.Height - panelInfo.Height;
            panelSettings.Width = this.ClientSize.Width;

            //Source label
            lblSettingsSource.Top = draw_top;
            draw_top = draw_top + lblSettingsSource.Height;

            //Source Button
            cmdSettingsSource.Width = panelSettings.Width - (2 * cmdSettingsSource.Left);
            cmdSettingsSource.Top = draw_top;
            cmdSettingsSource.Left = 10;

            //Using graphics, set the size of the source button depending on the height of the text
            using (Graphics cg = CreateGraphics())
            {

                //Measure the size of the text on the button
                SizeF size = cg.MeasureString(cmdSettingsSource.Text, cmdSettingsSource.Font, cmdSettingsSource.Width);

                //Set the button height to the height of the text
                cmdSettingsSource.Height = (int)size.Height + 10;

                //Move draw top down
                draw_top = draw_top + cmdSettingsSource.Height + 20;
            }

            //ABOUT
            lblSettingsAbout.Top = draw_top;
            draw_top = draw_top + lblSettingsAbout.Height;

            lblSettingsAboutInfo.Top = draw_top;
            lblSettingsAboutInfo.Left = 15;

        }

        //=============================================================
        // USED FOR CONFIG
        //=============================================================

        /// <summary>
        /// Loads the config. If loading the config fails, a new config file is created with default values.
        /// </summary>
        private void config_load()
        {

            //Attempt to load config
            try
            {
                //Declare variable used to open imagecache.json file
                StreamReader sr_config;

                //Open config.json file
                sr_config = new StreamReader(Application.StartupPath + @"\config.json");

                //Declare STRING to store contents of config.json
                string config_json = sr_config.ReadToEnd();

                //Load json object to config
                config = JsonConvert.DeserializeObject<config_class>(config_json);

                //If the directory is empty or null, use the default
                if(config.source == null || config.source == "")
                {
                    config.source = default_source;
                }

                //Close file
                sr_config.Close();
            }
            
            //If error loading config, use default values
            catch
            {

                //Create a new instance of config class, populate it with default values and write it to file
                config = new config_class();
                config.source = default_source;
                config_write();
            }
        }

        /// <summary>
        /// Write the config to the config file
        /// </summary>
        private void config_write()
        {

            //Attempt to write to config file
            try
            {

                //Declare variable used to write config.json
                StreamWriter sw_config;

                //Start writing to config.json file
                sw_config = new StreamWriter(Application.StartupPath + @"\config.json");

                //Generate JSON string from config
                string config_json = JsonConvert.SerializeObject(config);

                //Write JSON string to file
                sw_config.Write(config_json);

                //Close file
                sw_config.Close();
            }

            //If error writing to config file. Give debug error.
            catch
            {
                Debug.WriteLine("Error writing to config");
            }
        }

        //=============================================================
        // USED FOR REFRESHING FILES AND IMAGES
        //=============================================================

        /// <summary>
        /// Refresh images without looking at the cache
        /// </summary>
        private void refresh()
        {

            //If the background worker is not already doing a refresh, start a refresh
            if(!bgw_refresh_files.IsBusy)
            {

                //Change the text on the refresh button to indicate that the program is currently refreshing the metadata
                cmdRefresh.Text = "Refreshing";

                //When refreshing, do not try to load data from the cache.
                refresh_try_cache = false;

                //Start background worker to refresh image cache
                bgw_refresh_files.RunWorkerAsync();
            }

            //Otherwise, output debug message
            else
            {
                Debug.WriteLine("The background worker is already refreshing the image cache");
            }
        }

        /// <summary>
        /// Lookup the directory with the photos and rebuild photo cache
        /// </summary>
        private void refresh_files()
        {

            //Try reading the files
            try
            {

                //Get files with the valid file extension
                var files = Directory.EnumerateFiles(config.source,
                                                     "*.*",
                                                     SearchOption.AllDirectories).Where(
                                                        s => s.ToLower().EndsWith(".png") ||
                                                        s.ToLower().EndsWith(".jpeg") ||
                                                        s.ToLower().EndsWith(".jpg"));

                //Clear images list
                cache_images.Clear();

                //For each file in directory
                foreach (var file in files)
                {

                    //Load file info for file
                    FileInfo file_info = new FileInfo(file);

                    //Write debug line
                    Debug.WriteLine("Examining: " + file_info.FullName);

                    //New instance of date time to store image date
                    DateTime image_date;

                    //Attempt to get the image date
                    try { image_date = GetDateTakenFromImage(file_info.FullName); }

                    //If error, use last modified date as date
                    catch { image_date = file_info.LastWriteTime; }

                    //Add file to image cache
                    cache_images.Add(new image_item
                    {
                        fileinfo = file_info,
                        datetime = image_date
                    });
                }
            }

            //If error reading the files, throw error message
            catch
            {
                MessageBox.Show("Error (1) Loading Directory. Does it exist?");
                picDisplay.Image = null;
                picDisplay.Load();

                //Purge cache and reload
                images_cache_clear();
                refresh_file_or_cache();
            }

            //Write image cache to file
            images_cache_write();

        }

        /// <summary>
        /// Attempt to load the cache. If that fails lookupo directory
        /// </summary>
        private void refresh_file_or_cache()
        {
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
                cache_images = JsonConvert.DeserializeObject<List<image_item>>(images_json);

                //Close file
                sr_cache.Close();
            }

            //If error loading cache, examine folder
            catch
            {

                //Examine the folder
                refresh_files();

                //Write to cache file
                images_cache_write();
            }

        }

        /// <summary>
        /// Determine what images are from today but in a previous year.
        /// </summary>
        private void refresh_memories()
        {
            //DEV: today is a specific date for development
            DateTime today = new DateTime(2016, 2, 16);

            //Clear todays images
            todays_images.Clear();

            //For every image in images
            foreach (var image in cache_images)
            {

                //If image was taken 'on this day in history'
                if (image.datetime.Year != today.Year &&
                    image.datetime.Month == today.Month &&
                    image.datetime.Day == today.Day)
                {

                    //Add details to todays images
                    todays_images.Add(new image_item
                    {
                        fileinfo = image.fileinfo,
                        datetime = image.datetime
                    });
                }
            }
        }

        /// <summary>
        /// Clear image cache stored    `
        /// </summary>
        private void images_cache_clear()
        {

            //Clear old image cache
            cache_images.Clear();

            //Write this change to the cache file
            images_cache_write();
        }

        private void images_cache_write()
        {

            //Declare variable used to write imagecache.json
            StreamWriter sw_cache;

            //Start writing to imagecache.json file
            sw_cache = new StreamWriter(Application.StartupPath + @"\imagecache.json");

            //Generate JSON string from images
            string images_json = JsonConvert.SerializeObject(cache_images);

            //Write JSON string to file
            sw_cache.Write(images_json);

            //Close file
            sw_cache.Close();
        }

        /// <summary>
        /// Background worker that lookups the directory with the photos and rebuild photo cache
        /// </summary>
        private void bgw_refresh_files_DoWork(object sender, DoWorkEventArgs e)
        {

            //If the cache should be tried first, try it
            if (refresh_try_cache)
            {
                refresh_file_or_cache();
            }

            //Otherwise, refresh directory
            else
            {
                refresh_files();
            }
        }

        private void bgw_refresh_files_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            //Redetermine what todays memories are
            refresh_memories();

            //Show picture
            show_picture(0);

            cmdRefresh.Text = "Refresh";
            refresh_try_cache = true;
        }

        //=============================================================
        // USED FOR DISPLAYING A NEW PANEL AS THE PRIMARY SCREEN ITEM
        //=============================================================

        /// <summary>
        /// Display a new panel as the main panel on the screen
        /// </summary>
        /// <param name="panel">The panel to be displayed</param>
        private void displayPanel(Panel panel)
        {
            panelPicture.Visible = false;
            panelSettings.Visible = false;
            panel.Visible = true;
        }

        /// <summary>
        /// Runs when the refresh button at the topof the screen is clicked
        /// </summary>
        private void cmdRefresh_Click(object sender, EventArgs e)
        {
            //Refresh the images cache
            refresh();
        }

        /// <summary>
        /// Runs when gear button at top of screen is clicked
        /// </summary>
        private void cmdSettings_Click(object sender, EventArgs e)
        {

            //If the picture panel is shown, load the settings panel
            if (panelPicture.Visible)
            {

                //Display the settings panel
                displayPanel(panelSettings);

                //Set title of the panel
                lblHead.Text = "Settings";

                //Set the text for the button to change the source
                cmdSettingsSource.Text = config.source;

                lblSettingsAboutInfo.Text = this.ProductName + " [Version " + this.ProductVersion + "]";
                lblSettingsAboutInfo.Text += Environment.NewLine + FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location).LegalCopyright;
                lblSettingsAboutInfo.Text += Environment.NewLine + FileVersionInfo.GetVersionInfo(Assembly.GetEntryAssembly().Location).CompanyName;

                //Update UI for settings
                ui_settings();
            }

            //Otherwise, load the picture panl
            else
            {
                displayPanel(panelPicture);
                show_picture(0);
            }
        }

        //=============================================================
        // SETTINGS PANEL
        //=============================================================

        /// <summary>
        /// Source button (in settings) clicked
        /// </summary>
        private void cmdSettingsSource_Click(object sender, EventArgs e)
        {

            //Create a new file browser dialog
            FolderBrowserDialog fbd = new FolderBrowserDialog();

            //Show the file browser dialog and get the result
            DialogResult result = fbd.ShowDialog();

            //Validate path
            if(fbd.SelectedPath != "")
            {
                //Store the selected directory to the variable
                config.source = fbd.SelectedPath;

                //Set the source button text to the new directory
                cmdSettingsSource.Text = config.source;

                //Write config
                config_write();

                //Refresh files
                refresh();
            }
        }

        /// <summary>
        /// When about information is clicked. Open website.
        /// </summary>
        private void lblSettingsAboutInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://davidsouthgate.co.uk/projects/photomemories/");
        }
    }
}
