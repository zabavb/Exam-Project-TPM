using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_Project_TPM
{
    public partial class Doc : Form
    {
        public Doc()
        {
            InitializeComponent();
        }

        private void Doc_Load(object sender, EventArgs e)
        {
            label1.Text = "Якщо у вас виникла помилка:\r\n\nError 01 at <i> — Неправильна структура в дужках, помилка на <i> символі. \r\n\nError 02 at <i> — Невідомий оператор на <i> символі.\r\n\nError 03 — Невірна синтаксична конструкція вхідного виразу.\r\n\nError 04 at <i> — Два підряд оператори на <i> символі.\r\n\nError 05 — Незавершений вираз.\r\n\nError 06 — Дуже мале, або дуже велике значення числа для int. \r\n\nЧисла повинні бути в межах від -2147483648 до 2147483647.\r\n\nError 07 — Дуже довгий вираз. Максмальная довжина — 65536 символів.\r\n\nError 08 — Сумарна кількість чисел і операторів перевищує 30.\r\n\nError 09 – Помилка ділення на 0";
        }
    }
}