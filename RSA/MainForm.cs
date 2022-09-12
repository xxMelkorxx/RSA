using System;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Numerics;

namespace RSA
{
    public partial class MainForm : Form
    {
        private uint e, d, n;
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnLoadMainForm(object sender, EventArgs ea)
        {
            OnClickButtonGenerateKey(null, null);
            OnTextChangedTextBoxOpenKey(null, null);
            OnTextChangedTextBoxCloseKey(null, null);
            OnTextChangedTextBoxModule(null, null);
        }
        /// <summary>
        /// Генерация ключей
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="ea"></param>
        private void OnClickButtonGenerateKey(object sender, EventArgs ea)
        {
            RSA.GenerateKeys(out uint e, out uint d, out uint n);
            textBox_openKey.Text = e.ToString();
            textBox_closeKey.Text = d.ToString();
            textBox_module.Text = n.ToString();
            richTextBox_closedText.Clear();
        }
        /// <summary>
        /// Зашифровка.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="ea"></param>
        private void OnClickButtonEncrypt(object sender, EventArgs ea)
        {
            OnClickButtonClearClosedText(null, null);
            var closeIntsArray = RSA.EncryptRSA(richTextBox_openText.Text.ToCharArray(), e, n);
            for (var i = 0; i < closeIntsArray.Length; i++)
                richTextBox_closedText.Text += closeIntsArray[i] + " ";
        }
        /// <summary>
        /// Дешифровка.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="ea"></param>
        private void OnClickButtonDecrypt(object sender, EventArgs ea)
        {
            OnClickButtonClearOpenText(null, null);
            string[] subs = richTextBox_closedText.Text.Split(' ');         // Разбитие текста на подстроки цифр
            var closeIntsArray = new BigInteger[subs.Length - 1];
            for (var i = 0; i < subs.Length - 1; i++)
                _ = BigInteger.TryParse(subs[i], out closeIntsArray[i]);
            richTextBox_openText.Text = RSA.DecryptRSA(closeIntsArray, d, n);
        }

        /// <summary>
        /// Загрузка открытого текста.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickButtonImportOpenText(object sender, EventArgs ea)
        {
            var dialog = new OpenFileDialog();
            dialog.Filter = "Text files | *.txt";

            if (dialog.ShowDialog() == DialogResult.OK)
                using (var sr = new StreamReader(dialog.OpenFile(), Encoding.Default))
                    richTextBox_openText.Text = sr.ReadToEnd();
            else return;
        }

        /// <summary>
        /// Сохранение открытого текста.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickButtonExportOpenText(object sender, EventArgs ea)
        {
            var saveDialog = new SaveFileDialog();
            saveDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveDialog.FilterIndex = 2;
            saveDialog.RestoreDirectory = true;
            if (saveDialog.ShowDialog() == DialogResult.OK)
                using (var sw = new StreamWriter(saveDialog.OpenFile(), Encoding.Default))
                    sw.WriteLine(richTextBox_openText.Text);
            else return;
        }

        /// <summary>
        /// Загрузка закрытого текста.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickButtonImportClosedText(object sender, EventArgs ea)
        {
            string[] subs;
            var dialog = new OpenFileDialog();
            dialog.Filter = "Text files | *.txt";
            if (dialog.ShowDialog() == DialogResult.OK)
                using (var sr = new StreamReader(dialog.OpenFile(), Encoding.Default))
                {
                    subs = sr.ReadToEnd().Split(' ');
                    richTextBox_closedText.Clear();
                    for (var i = 0; i < subs.Length - 2; i++)
                        richTextBox_closedText.Text += subs[i] + " ";
                }
            else return;

            textBox_closeKey.Text = subs[subs.Length - 2];  // Извлечение из текста закрытого ключа
            textBox_module.Text = subs[subs.Length - 1];    // Извлечение из текста модуля системы
        }

        /// <summary>
        /// Сохранение закрытого текста.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickButtonExportClosedText(object sender, EventArgs ea)
        {
            var saveDialog = new SaveFileDialog();
            saveDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveDialog.FilterIndex = 2;
            saveDialog.RestoreDirectory = true;
            if (saveDialog.ShowDialog() == DialogResult.OK)
                using (var sw = new StreamWriter(saveDialog.OpenFile(), Encoding.Default))
                    sw.WriteLine(richTextBox_closedText.Text + textBox_closeKey.Text + " " + textBox_module.Text);
            else return;
        }
        /// <summary>
        /// Сохранение ключей в файл.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickButtonSaveKeys(object sender, EventArgs e)
        {
            var saveDialog = new SaveFileDialog();
            saveDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            saveDialog.FilterIndex = 2;
            saveDialog.RestoreDirectory = true;
            if (saveDialog.ShowDialog() == DialogResult.OK)
                using (var sw = new StreamWriter(saveDialog.OpenFile(), Encoding.Default))
                    sw.WriteLine("e: " + textBox_openKey.Text + "\nd: " + textBox_closeKey.Text + "\nn: " + textBox_module.Text);
        }

        /// <summary>
        /// Очистка открытого текста.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickButtonClearOpenText(object sender, EventArgs ea)
        {
            richTextBox_openText.Clear();
        }
        /// <summary>
        /// Очистка закрытого текста.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickButtonClearClosedText(object sender, EventArgs ea)
        {
            richTextBox_closedText.Clear();
        }
        /// <summary>
        /// Модуль системы.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTextChangedTextBoxModule(object sender, EventArgs e)
        {
            n = Convert.ToUInt32(textBox_module.Text);
        }
        /// <summary>
        /// Открытый ключ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="ea"></param>
        private void OnTextChangedTextBoxOpenKey(object sender, EventArgs ea)
        {
            e = Convert.ToUInt32(textBox_openKey.Text);
        }
        /// <summary>
        /// Закрытый ключ.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="ea"></param>
        private void OnTextChangedTextBoxCloseKey(object sender, EventArgs ea)
        {
            d = Convert.ToUInt32(textBox_closeKey.Text);
        }
    }
}