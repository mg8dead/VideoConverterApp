namespace VideoConverterApp
{
    partial class Form_main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.Button_Convertation = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.Button_SelectFiles = new System.Windows.Forms.Button();
            this.Button_SelectPathToSaveFiles = new System.Windows.Forms.Button();
            this.textBox_pathToSaveFiles = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.label_videosCount = new System.Windows.Forms.Label();
            this.textBox_CountFiles = new System.Windows.Forms.TextBox();
            this.panel_Top = new System.Windows.Forms.Panel();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel_Top.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Button_Convertation
            // 
            this.Button_Convertation.BackColor = System.Drawing.Color.Transparent;
            this.Button_Convertation.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Button_Convertation.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button_Convertation.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_Convertation.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.Button_Convertation.Location = new System.Drawing.Point(0, 479);
            this.Button_Convertation.Name = "Button_Convertation";
            this.Button_Convertation.Size = new System.Drawing.Size(604, 130);
            this.Button_Convertation.TabIndex = 0;
            this.Button_Convertation.Text = "Начать конвертацию";
            this.Button_Convertation.UseVisualStyleBackColor = false;
            this.Button_Convertation.Click += new System.EventHandler(this.Button_Convertation_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Multiselect = true;
            // 
            // Button_SelectFiles
            // 
            this.Button_SelectFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_SelectFiles.ForeColor = System.Drawing.SystemColors.WindowText;
            this.errorProvider.SetIconAlignment(this.Button_SelectFiles, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.Button_SelectFiles.Location = new System.Drawing.Point(393, 12);
            this.Button_SelectFiles.Name = "Button_SelectFiles";
            this.Button_SelectFiles.Size = new System.Drawing.Size(199, 31);
            this.Button_SelectFiles.TabIndex = 3;
            this.Button_SelectFiles.Text = "Выберите файлы";
            this.Button_SelectFiles.UseVisualStyleBackColor = true;
            this.Button_SelectFiles.Click += new System.EventHandler(this.Button_SelectPathToFile_Click);
            // 
            // Button_SelectPathToSaveFiles
            // 
            this.Button_SelectPathToSaveFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Button_SelectPathToSaveFiles.ForeColor = System.Drawing.SystemColors.WindowText;
            this.Button_SelectPathToSaveFiles.Location = new System.Drawing.Point(542, 88);
            this.Button_SelectPathToSaveFiles.Name = "Button_SelectPathToSaveFiles";
            this.Button_SelectPathToSaveFiles.Size = new System.Drawing.Size(50, 31);
            this.Button_SelectPathToSaveFiles.TabIndex = 6;
            this.Button_SelectPathToSaveFiles.Text = "...";
            this.Button_SelectPathToSaveFiles.UseVisualStyleBackColor = true;
            this.Button_SelectPathToSaveFiles.Click += new System.EventHandler(this.Button_SelectPathToSaveFiles_Click);
            // 
            // textBox_pathToSaveFiles
            // 
            this.textBox_pathToSaveFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_pathToSaveFiles.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_pathToSaveFiles.Location = new System.Drawing.Point(258, 88);
            this.textBox_pathToSaveFiles.Name = "textBox_pathToSaveFiles";
            this.textBox_pathToSaveFiles.Size = new System.Drawing.Size(278, 31);
            this.textBox_pathToSaveFiles.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(240, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Папка куда сохранять:";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(0, 479);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(604, 130);
            this.progressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar.TabIndex = 7;
            // 
            // label_videosCount
            // 
            this.label_videosCount.AutoSize = true;
            this.label_videosCount.BackColor = System.Drawing.Color.Transparent;
            this.label_videosCount.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label_videosCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_videosCount.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label_videosCount.Location = new System.Drawing.Point(12, 15);
            this.label_videosCount.Name = "label_videosCount";
            this.label_videosCount.Size = new System.Drawing.Size(189, 25);
            this.label_videosCount.TabIndex = 8;
            this.label_videosCount.Text = "Выбрано файлов:";
            // 
            // textBox_CountFiles
            // 
            this.textBox_CountFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox_CountFiles.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox_CountFiles.Location = new System.Drawing.Point(258, 12);
            this.textBox_CountFiles.Name = "textBox_CountFiles";
            this.textBox_CountFiles.ReadOnly = true;
            this.textBox_CountFiles.Size = new System.Drawing.Size(30, 31);
            this.textBox_CountFiles.TabIndex = 9;
            // 
            // panel_Top
            // 
            this.panel_Top.Controls.Add(this.comboBox);
            this.panel_Top.Controls.Add(this.label1);
            this.panel_Top.Controls.Add(this.textBox_CountFiles);
            this.panel_Top.Controls.Add(this.label2);
            this.panel_Top.Controls.Add(this.label_videosCount);
            this.panel_Top.Controls.Add(this.Button_SelectFiles);
            this.panel_Top.Controls.Add(this.textBox_pathToSaveFiles);
            this.panel_Top.Controls.Add(this.Button_SelectPathToSaveFiles);
            this.panel_Top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Top.Location = new System.Drawing.Point(0, 0);
            this.panel_Top.Name = "panel_Top";
            this.panel_Top.Size = new System.Drawing.Size(604, 130);
            this.panel_Top.TabIndex = 10;
            // 
            // comboBox
            // 
            this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "mp4",
            "webm"});
            this.comboBox.Location = new System.Drawing.Point(258, 49);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(86, 33);
            this.comboBox.TabIndex = 11;
            this.comboBox.Text = "mp4";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(231, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Формат конвертации:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::VideoConverterApp.Properties.Resources.photo_2024_05_08_06_05_35;
            this.ClientSize = new System.Drawing.Size(604, 609);
            this.Controls.Add(this.panel_Top);
            this.Controls.Add(this.Button_Convertation);
            this.Controls.Add(this.progressBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Конвертер екалэмэнэ";
            this.panel_Top.ResumeLayout(false);
            this.panel_Top.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Button_Convertation;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button Button_SelectFiles;
        private System.Windows.Forms.Button Button_SelectPathToSaveFiles;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox textBox_pathToSaveFiles;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label label_videosCount;
        private System.Windows.Forms.TextBox textBox_CountFiles;
        private System.Windows.Forms.Panel panel_Top;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}

