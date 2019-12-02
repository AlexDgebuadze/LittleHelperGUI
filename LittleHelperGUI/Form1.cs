using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LittleHelperGUI.Runner;
using LittleHelperGUI.FileManip;


namespace LittleHelperGUI  
{
    public partial class SetUp : Form   
    {
        public SetUp()
        {
            InitializeComponent();
        }


        private void SetUp_Load(object sender, EventArgs e)
        {
            boostrap_combo.Items.Add("None");
            boostrap_combo.Items.Add("With Link");
            boostrap_combo.Items.Add("With Npm");

            jquery_combo.Items.Add("None");
            jquery_combo.Items.Add("With Link");
            jquery_combo.Items.Add("With Npm");
        }

        private void Dir_button_Click(object sender, EventArgs e)
        {
            if (folderBro.ShowDialog() == System.Windows.Forms.DialogResult.OK) 
            {
                DirectoryBox.Clear();
                DirectoryBox.Text = folderBro.SelectedPath;
                MessageBox.Show(folderBro.SelectedPath);

               
            }


        }

        private void start_btn_Click(object sender, EventArgs e)
        {
             FileMan.CreateFolder(folderBro.SelectedPath, FolderNameBox.Text);
             string path = System.IO.Path.Combine(folderBro.SelectedPath , FolderNameBox.Text);
             string JqueryNpm =  "cd " + path + " && "  + " npm update && npm init && npm install jquery";
             string SassNpm = "cd " + path + " && " + " npm update && npm install --global gulp-cli && npm init && npm install --save-dev gulp && npm install gulp-sass --save-dev";
             string BootstrapNpm = "cd " + path + " && " + " npm update && npm install bootstrap";

             string firstCode = "<html lang=\"en\">" + System.Environment.NewLine + "  <head>" + System.Environment.NewLine + " <meta charset= \"UTF-8\"> <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">" + System.Environment.NewLine + "  <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">" + System.Environment.NewLine + " <link rel=\"stylesheet\" href=\"styles/style.css\">" + System.Environment.NewLine + "  </head>" + System.Environment.NewLine + " <body>" + System.Environment.NewLine + " </body>" + System.Environment.NewLine + " </html>";
             string BootstrapLink = "<link rel= \"stylesheet\" href=\"https://stackpath.bootstrapcdn.com/bootstrap/4.4.0/css/bootstrap.min.css\" integrity=\"sha384-SI27wrMjH3ZZ89r4o+fGIJtnzkAnFs3E4qz9DIYioCQ5l9Rd/7UAa8DHcaL8jkWt\" crossorigin=\"anonymous\">";
             string JqueryLink = "<script src=\"https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js\"></script>";


             FileMan.CreateFile(path, FolderNameBox.Text + ".html", firstCode);

             string resetContent = "html, body, div, span, applet, object, iframe, h1, h2, h3, h4, h5, h6, p, blockquote, pre, a, abbr, acronym, address, big, cite, code, del, dfn, em, img, ins, kbd, q, s, samp, small, strike, strong, sub, sup, tt, var, b, u, i, center, dl, dt, dd, ol, ul, li, fieldset, form, label, legend, table, caption, tbody, tfoot, thead, tr, th, td, article, aside, canvas, details, embed, figure, figcaption, footer, header, hgroup, menu, nav, output, ruby, section, summary, time, mark, audio, video {margin: 0; padding: 0; border: 0;font-size: 100%;font: inherit;vertical-align: baseline; } article, aside, details, figcaption, figure, footer, header, hgroup, menu, nav, section {display: block; } body{line-height:1;} ol,ul{list-style:none;} blockquote {&:before, &:after {content: '';content: none; } } q {&:before, &:after {content: '';content: none; } } table {border-collapse: collapse;border-spacing: 0; }";
             string Mixins = "@mixin paddingLR($left,$right){padding-left: $left;padding-right: $right;} @mixin paddingTB($top,$bottom) {padding-top: $top;padding-bottom: $bottom;} @mixin marginLR($left,$right) {margin-left: $left;margin-right: $right;} @mixin marginTB($top,$bottom) {margin-top: $top;margin-bottom: $bottom;} @mixin flex ($justify-content, $align-items) {justify-content: $justify-content;align-items: $align-items;} @mixin border ($size, $type, $color) {border:$size $type $color;}";
             string gulpfileContent =  "'use strict';var gulp = require('gulp');var sass = require('gulp-sass'); gulp.task('sass', function () {return gulp.src('scss/style.scss') .pipe(sass().on('error', sass.logError)) .pipe(gulp.dest('styles'));}); gulp.task('watch', function () {gulp.watch('scss/*.scss',gulp.parallel('sass'));});"; 
             string stScss = "@import 'starter/reset'; @import 'module/var'; @import 'module/fonts';@import 'module/mixins';" ;
             
             

             FileMan.CreateFolder(path, "styles");

             FileMan.CreateFile(System.IO.Path.Combine(path, "styles"), "style.css");
              
             FileMan.CreateFolder(path, "Img");
             FileMan.CreateFolder(path, "Fonts");
             FileMan.CreateFolder(path, "JS");


            if (this.boostrap_combo.SelectedItem.ToString().Equals("With Npm"))
            {
                ScriptRun.ExecuteCommand(BootstrapNpm);
            }
            else if (this.boostrap_combo.SelectedItem.ToString().Equals("With Link"))
            {
                FileMan.ReadAndEdit(System.IO.Path.Combine(path, FolderNameBox.Text + ".html"), "<head>", "<head> " + System.Environment.NewLine + BootstrapLink + System.Environment.NewLine);
            }
            if (this.jquery_combo.SelectedItem.ToString().Equals("With Npm"))
            {
                ScriptRun.ExecuteCommand(JqueryNpm);
            }
            else if (this.jquery_combo.SelectedItem.ToString().Equals("With Link"))
            {
                FileMan.ReadAndEdit(System.IO.Path.Combine(path, FolderNameBox.Text + ".html"), "<head>", "<head> " + System.Environment.NewLine + JqueryLink + System.Environment.NewLine);
            }



            if (SassCheck.Checked)
            {
                FileMan.CreateFile(path,"gulpfile.js",gulpfileContent);
                FileMan.CreateFolder(path, "scss");
                FileMan.CreateFolder(System.IO.Path.Combine(path, "scss"), "base");
                FileMan.CreateFolder(System.IO.Path.Combine(path, "scss"), "module");
                FileMan.CreateFolder(System.IO.Path.Combine(path, "scss"), "starter");

                FileMan.CreateFile(System.IO.Path.Combine(path, "scss"), "style.scss", stScss);
                FileMan.CreateFile(System.IO.Path.Combine(path, "scss", "module"), "mixins.scss", Mixins);
                FileMan.CreateFile(System.IO.Path.Combine(path, "scss", "module"), "fonts.scss");
                FileMan.CreateFile(System.IO.Path.Combine(path, "scss", "module"), "var.scss");

                FileMan.CreateFile(System.IO.Path.Combine(path, "scss", "starter"), "reset.scss", resetContent);

                ScriptRun.ExecuteCommand(SassNpm);
            }


        }

        
       

       
    }
}
