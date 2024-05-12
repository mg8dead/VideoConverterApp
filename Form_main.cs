using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NReco.VideoConverter;

namespace VideoConverterApp
{
    public partial class Form_main : Form
    {
        public Form_main()
        {
            InitializeComponent();
        }

        string[] pathToFiles = { };

        private void Button_Convertation_Click(object sender, EventArgs e)
        {
            progressBar.Value = 0;
            try
            {
                if(pathToFiles.Length != 0)
                {
                    Button_Convertation.Visible = false;
                    FFMpegConverter ffmpeg = new FFMpegConverter
                    {
                        FFMpegExeName = "ffmpeg.exe"
                    };
                    for (int i = 0; i < pathToFiles.Length; i++)
                    {
                        progressBar.Maximum = pathToFiles.Length;
                        ffmpeg.ConvertMedia(pathToFiles[i], textBox_pathToSaveFiles.Text + $"\\Файл {i + 1}.{comboBox.Text}", comboBox.Text);
                        progressBar.Value++;
                    }

                    MessageBox.Show("Успешная конвертация!", "Уведомление", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Button_Convertation.Visible = true;
                }
                else
                {
                    errorProvider.SetError(Button_SelectFiles,"Ошибка. Не выбраны файлы");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(),"Ошибка", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void Button_SelectPathToFile_Click(object sender, EventArgs e)
        {
            openFileDialog.Title = "Выберите файлы";
            openFileDialog.Filter = "(*.webm)|*.webm|(*.mp4)|*.mp4";

            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pathToFiles = openFileDialog.FileNames;
                textBox_CountFiles.Text = pathToFiles.Length.ToString();
            }
            else
            {
                textBox_CountFiles.Clear();
            }

        }

        private void Button_SelectPathToSaveFiles_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                textBox_pathToSaveFiles.Text = folderBrowserDialog.SelectedPath;
            }
            else
            {
                textBox_pathToSaveFiles.Clear();
            }
        }
    }
}
