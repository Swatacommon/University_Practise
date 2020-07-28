using ClassLibrary;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class Form1 : Form
    {
        PhoneRepository phoneRepository;
        public Form1()
        {
            phoneRepository = new PhoneRepository();
            InitializeComponent();
            LoadTable();

        }
        private void LoadTable()
        {
            Thread.Sleep(200);
            PhoneList.Rows.Clear();
            PhoneList.Columns.Clear();
            PhoneList.Columns.Add("Id", "Id");
            PhoneList.Columns.Add("Last_name", "Last_name");
            PhoneList.Columns.Add("Phone_Number", "Phone_Number");
            int rowNumber;
            foreach (var phone in phoneRepository.sendGet())
            {
                rowNumber = PhoneList.Rows.Add();
                PhoneList.Rows[rowNumber].Cells["Id"].Value = phone.Id;
                PhoneList.Rows[rowNumber].Cells[0].ReadOnly = true;
                PhoneList.Rows[rowNumber].Cells["Last_name"].Value = phone.Last_name;
                PhoneList.Rows[rowNumber].Cells["Phone_Number"].Value = phone.Phone_number;
            }
        }

        private async void AddPhoneButton_Click(object sender, EventArgs e)
        {
            if (PhoneList.SelectedRows.Count != 0)
            {
                if (PhoneList.SelectedRows != null && PhoneList.SelectedRows[0] != null &&
                    PhoneList.SelectedRows[0].Cells[1].Value != null && PhoneList.SelectedRows[0].Cells[2].Value != null)
                {
                    int phone_number;
                    if (Int32.TryParse(PhoneList.SelectedRows[0].Cells[2].Value.ToString(), out phone_number))
                    {
                        phoneRepository.sendPost(new Phone
                        {
                            Last_name = PhoneList.SelectedRows[0].Cells[1].Value.ToString(),
                            Phone_number = phone_number
                        });
                        await Task.Run(() => LoadTable());
                    }
                    else
                    {
                        MessageBox.Show("В номере телефона доступны только цифры");
                    }
                }
            }
        }

        private async void UpdatePhoneButton_Click(object sender, EventArgs e)
        {
            if (PhoneList.SelectedRows.Count != 0)
            {
                if (PhoneList.SelectedRows != null && PhoneList.SelectedRows[0] != null &&
                    PhoneList.SelectedRows[0].Cells[1].Value != null && PhoneList.SelectedRows[0].Cells[2].Value != null)
                {
                    int phone_number;
                    if (Int32.TryParse(PhoneList.SelectedRows[0].Cells[2].Value.ToString(), out phone_number))
                    {
                        phoneRepository.sendPut(new Phone
                        {
                            Id = int.Parse(PhoneList.SelectedRows[0].Cells[0].Value.ToString()),
                            Last_name = PhoneList.SelectedRows[0].Cells[1].Value.ToString(),
                            Phone_number = phone_number
                        });
                        await Task.Run(() => LoadTable());
                    }
                    else
                    {
                        MessageBox.Show("В номере телефона доступны только цифры");
                    }
                }
            }

        }

        private async void DeletePhoneButton_Click(object sender, EventArgs e)
        {
            if (PhoneList.SelectedRows.Count != 0)
            {
                if (PhoneList.SelectedRows != null && PhoneList.SelectedRows[0] != null &&
                    PhoneList.SelectedRows[0].Cells[1].Value != null && PhoneList.SelectedRows[0].Cells[2].Value != null)
                {
                    int phone_number;
                    if (Int32.TryParse(PhoneList.SelectedRows[0].Cells[2].Value.ToString(), out phone_number))
                    {
                        phoneRepository.sendDelete(new Phone
                        {
                            Id = int.Parse(PhoneList.SelectedRows[0].Cells[0].Value.ToString()),
                            Last_name = PhoneList.SelectedRows[0].Cells[1].Value.ToString(),
                            Phone_number = Int32.Parse(PhoneList.SelectedRows[0].Cells[2].Value.ToString())
                        });
                        await Task.Run(() => LoadTable());
                    }
                    else
                    {
                        MessageBox.Show("В номере телефона доступны только цифры");
                    }
                }
            }

        }
    }
}
