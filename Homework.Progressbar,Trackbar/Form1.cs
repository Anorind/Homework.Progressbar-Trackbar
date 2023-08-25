namespace Homework.Progressbar_Trackbar
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

            //Завдання 1

            Label labelTask1 = new Label();
            labelTask1.Location = new System.Drawing.Point(10,10);
            labelTask1.Size = new System.Drawing.Size(200, 30);
            labelTask1.Text = "Завдання 1";
            this.Controls.Add(labelTask1);
            // ProgressBar1
            ProgressBar progressBar1 = new ProgressBar();
            progressBar1.Location = new System.Drawing.Point(50, 50);
            progressBar1.Size = new System.Drawing.Size(200, 20);
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;
            progressBar1.Value = 0;
            this.Controls.Add(progressBar1);
            // Создаю кнопку1
            Button button1 = new Button();
            button1.Location = new System.Drawing.Point(50, 100);
            button1.Size = new System.Drawing.Size(200, 30);
            button1.Text = "Читати файл";
            button1.Click += (sender, e) => ReadFile(progressBar1); // Викликаю метод ReadFile
            this.Controls.Add(button1);


            //Завдання 2

            Label labelTask2 = new Label();
            labelTask2.Location = new System.Drawing.Point(10, 150);
            labelTask2.Size = new System.Drawing.Size(200, 30);
            labelTask2.Text = "Завдання 2";
            this.Controls.Add(labelTask2);
            // ProgressBar2
            ProgressBar progressBar2 = new ProgressBar();
            progressBar2.Location = new System.Drawing.Point(50, 200);
            progressBar2.Size = new System.Drawing.Size(200, 20);
            progressBar2.Minimum = 0;
            progressBar2.Maximum = 100;
            progressBar2.Value = 0;
            this.Controls.Add(progressBar2);
            // Создаю кнопку2
            Button button2 = new Button();
            button2.Location = new System.Drawing.Point(50, 250);
            button2.Size = new System.Drawing.Size(250, 30);
            button2.Text = "Запустити цикл";
            button2.Click += (sender, e) => RunLoop(progressBar2); // викликаю метод RunLoop
            this.Controls.Add(button2);

            //Завдання 3

            Label labelTask3 = new Label();
            labelTask3.Location = new System.Drawing.Point(400, 10);
            labelTask3.Size = new System.Drawing.Size(200, 30);
            labelTask3.Text = "Завдання 3";
            this.Controls.Add(labelTask3);
            // trackBarOpacity
            trackBarOpacity.Location = new Point(400, 50);
            trackBarOpacity.Size = new Size(200, 20);
            trackBarOpacity.Minimum = 0;
            trackBarOpacity.Maximum = 100;
            trackBarOpacity.Value = 100;
            trackBarOpacity.TickFrequency = 10;
            trackBarOpacity.Scroll += (sender, e) => ChangeOpacity(); // викликаю метод ChangeOpacity
            this.Controls.Add(trackBarOpacity);
            // trackBarColor
            trackBarColor.Location = new Point(400, 100);
            trackBarColor.Size = new Size(200, 20);
            trackBarColor.Minimum = 0;
            trackBarColor.Maximum = 255;
            trackBarColor.Value = 0;
            trackBarColor.TickFrequency = 10;
            trackBarColor.Scroll += (sender, e) => ChangeColor(); // викликаю метод ChangeColor
            this.Controls.Add(trackBarColor);

        }
        private void InitializeComponent()
        {
            SuspendLayout();
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "Homework.Progressbar_Trackbar";
            Text = "Homework.Progressbar_Trackbar";

            ResumeLayout(false);
        }
    }
}