﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenerateRandomStrings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region 生成按钮单击事件
        private void btn_generate_Click(object sender, EventArgs e)
        {
            //richTextBox1.Text = getready(txtbox_length.Text);

            #region 给radioButton赋值
            int radiobtn_value = 0;
            if (radiobtn_Number.Checked == true)
            {
                radiobtn_value = 1;
            }
            else if (radiobtn_LowerCaseLetters.Checked == true)
            {
                radiobtn_value = 2;
            }
            else if (radiobtn_UpperCaseLetters.Checked == true)
            {
                radiobtn_value = 3;
            }
            else if (radiobtn_UppercaseAndLowerCaseLetters.Checked == true)
            {
                radiobtn_value = 4;
            }
            else if (radiobtn_NumberAndLowerCaseLetters.Checked == true)
            {
                radiobtn_value = 5;
            }
            else if (radiobtn_NumberAndUpperCaseLetters.Checked == true)
            {
                radiobtn_value = 6;
            }
            else if (radiobtn_NumberAndUppercaseAndLowerCaseLetters.Checked == true)
            {
                radiobtn_value = 7;
            }
            else if (radiobtn_Symbol.Checked == true)
            {
                radiobtn_value = 8;
            }
            else if (radiobtn_ChineseCharacter.Checked == true)
            {
                radiobtn_value = 9;
            }
            else if (radiobtn_Mixed.Checked == true)
            {
                radiobtn_value = 10;
            }
            #endregion

            #region switch case处理
            switch (radiobtn_value)
            {
                case 1://数字
                    richTextBox1.Text = GenerateRandomValue.RandomNumber(GetLength(txtbox_length));
                    break;
                case 2://小写字母
                    richTextBox1.Text = GenerateRandomValue.RandomLowerCaseLetters(GetLength(txtbox_length));
                    break;
                case 3://大写字母
                    richTextBox1.Text = GenerateRandomValue.RandomUpperCaseLetters(GetLength(txtbox_length));
                    break;
                case 4://大小写字母
                    richTextBox1.Text = GenerateRandomValue.RandomUppercaseAndLowerCaseLetters(GetLength(txtbox_length));
                    break;
                case 5://数字+小写字母
                    richTextBox1.Text = GenerateRandomValue.RandomNumberAndLowerCaseLetters(GetLength(txtbox_length));
                    break;
                case 6://数字+大写字母
                    richTextBox1.Text = GenerateRandomValue.RandomNumberAndUpperCaseLetters(GetLength(txtbox_length));
                    break;
                case 7://数字+大小写字母
                    richTextBox1.Text = GenerateRandomValue.RandomNumberAndUppercaseAndLowerCaseLetters(GetLength(txtbox_length));
                    break;
                case 8://符号
                    richTextBox1.Text = GenerateRandomValue.RandomSymbol(GetLength(txtbox_length));
                    break;
                case 9://汉字
                    richTextBox1.Text = GenerateRandomValue.RandomNumber(GetLength(txtbox_length));
                    break;
                case 10://混合
                    richTextBox1.Text = GenerateRandomValue.RandomNumber(GetLength(txtbox_length));
                    break;
                default:
                    break;
            }
            #endregion
        }
        #endregion

        #region 长度文本框单击事件
        private void txtbox_length_MouseClick(object sender, MouseEventArgs e)
        {
            txtbox_length.SelectAll();
        }
        #endregion

        #region 获取长度文本框输入的值，含判断
        private static int GetLength(TextBox txtbox)
        {
            int result = 0;
            if (IsNumber(txtbox.Text.Trim()) == true)
            {
                result = Convert.ToInt32(txtbox.Text.Trim());
            }
            else
            {
                MessageBox.Show("请输入数字！");
            }
            return result;
        }
        #endregion

        #region 字符串转数组
        private static string getready(string str)
        {
            string result = string.Empty;
            for (int i = 0; i < str.Length; i++)
            {
                result += "'" + str.Substring(i, 1) + "',";
            }
            return result;
        }
        #endregion

        #region 富文本框单击事件
        private void richTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            richTextBox1.SelectAll();
            richTextBox1.Focus();
        }
        #endregion

        #region 判断字符串是否为数字
        /// <summary>
        /// 判断字符串是否为数字
        /// </summary>
        /// <param name="str">待验证的字符串</param>
        /// <returns>bool</returns>
        public static bool IsNumber(string str)
        {
            bool result = true;
            foreach (char ar in str)
            {
                if (!char.IsNumber(ar))
                {
                    result = false;
                    break;
                }
            }
            return result;
        }
        #endregion
    }
}