namespace Homework.Progressbar_Trackbar
{
    public partial class Form1 : Form
    {
        private void ReadFile(ProgressBar progressBar)
        {
            // Відкриваю діалогове вікно для вибору файла
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //Отримую шлях до вибраного файла
                string filePath = openFileDialog.FileName;
                //Отримую довжину файла в байтах
                long fileSize = new FileInfo(filePath).Length;
                FileStream fileStream = new FileStream(filePath, FileMode.Open);
                //Буфер для зберігання зчитаних даних
                byte[] buffer = new byte[1024];
                //Зміна для зберігання кількості зчитаних байтів
                int bytesRead = 0;
                //Зміна для зберігання загальної кількості зчитаних байтіва
                long totalBytesRead = 0;
                //Зчитуємо по 1024 байта до кінця файлу
                while ((bytesRead = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    //Додаємо до загальної кількості зчитаних байтів кількість байтів з цього циклу
                    totalBytesRead += bytesRead;
                    //Визначаю процент кількості зчитаних байтів по відношенню до загальної кількості байтів файлу
                    int percentRead = (int)((totalBytesRead * 100) / fileSize);
                    //Оновлюю прогресбар відповідно до зчитаного відсотка
                    progressBar.Value = percentRead;
                    //Роблю затримку для візуалізації прогресу
                    System.Threading.Thread.Sleep(100);
                }
                fileStream.Close();
                MessageBox.Show("Файл прочитан!");
            }
        }

        // Метод для запуска циклу від 0 до 100 та оновлення ProgressBar
        private void RunLoop(ProgressBar progressBar)
        {
            progressBar.Value = 0;
            // Запускаю цикл від 0 до 100
            for (int i = 0; i <= 100; i++)
            {
                // Оновлюю значення Прогресбару 
                progressBar.Value = i;
                // Роблю затримку
                Thread.Sleep(100);
            }
            MessageBox.Show("Цикл закінчен!");
        }

        // Создаю 2 елемента trackBar
        TrackBar trackBarOpacity = new TrackBar();
        TrackBar trackBarColor = new TrackBar();

        // Метод зміни прозорості форми
        private void ChangeOpacity()
        {
            double opacity = (double)trackBarOpacity.Value / 100;
            this.Opacity = opacity;
        }

        // Метод для зміни кольору форми
        private void ChangeColor()
        {
            int colorValue = (int)trackBarColor.Value;
            Color color = Color.FromArgb(colorValue, 255, 255);
            this.BackColor = color;
        }
    }
}