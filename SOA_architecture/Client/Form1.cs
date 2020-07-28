using System;
using System.Linq;
using System.Windows.Forms;
using Client.AsmxService;
using Client.WCFService;

namespace Client
{
    public partial class Form1 : Form
    {
        private PhoneServiceSoapClient AsmxService { get; set; }//asmx
        private IService1 WCFService { get; set; } //WCF
        public Form1()
        {
            InitializeComponent();
            AsmxService = new PhoneServiceSoapClient();
            WCFService = new Service1Client();
            LoadPhoneList();
            LoadCatList();
        }

        private void AddPhoneButton_Click(object sender, EventArgs e)
        {
            if (PhoneList.SelectedRows.Count != 0)
            {
                if (PhoneList.SelectedRows != null && PhoneList.SelectedRows[0] != null &&
                    PhoneList.SelectedRows[0].Cells[1].Value != null && PhoneList.SelectedRows[0].Cells[2].Value != null)
                {
                    int phone_number;
                    if (Int32.TryParse(PhoneList.SelectedRows[0].Cells[2].Value.ToString(), out phone_number))
                    {
                        AsmxService.AddPhone(new Phone
                        {
                            Last_name = PhoneList.SelectedRows[0].Cells[1].Value.ToString(),
                            Phone_number = phone_number
                        });
                        LoadPhoneList();
                    }
                    else
                    {
                        MessageBox.Show("В номере телефона доступны только цифры");
                    }
                }
            }
            if (CatList.SelectedRows.Count != 0)
            {
                if (CatList.SelectedRows != null && CatList.SelectedRows[0] != null &&
                    CatList.SelectedRows[0].Cells[1].Value != null && CatList.SelectedRows[0].Cells[2].Value != null)
                {
                    int ifInt;
                    if (!Int32.TryParse(CatList.SelectedRows[0].Cells[2].Value.ToString(), out ifInt))
                    {
                        WCFService.AddCat(new ClassLibrary.Cat
                        {
                            Name = CatList.SelectedRows[0].Cells[1].Value.ToString(),
                            Breed = CatList.SelectedRows[0].Cells[2].Value.ToString()
                        });
                        LoadCatList();
                    }
                    else
                    {
                        MessageBox.Show("Порода кота не может содержать цифры");
                    }
                }
            }
        }

        private void UpdatePhoneButton_Click(object sender, EventArgs e)
        {
            if (PhoneList.SelectedRows.Count != 0)
            {
                if (PhoneList.SelectedRows != null && PhoneList.SelectedRows[0] != null &&
                    PhoneList.SelectedRows[0].Cells[1].Value != null && PhoneList.SelectedRows[0].Cells[2].Value != null &&
                    PhoneList.SelectedRows[0].Cells[0].Value != null)
                {
                    int phone_number;
                    if (Int32.TryParse(PhoneList.SelectedRows[0].Cells[2].Value.ToString(), out phone_number))
                    {
                        AsmxService.UpdPhone(new Phone
                        {
                            Id = int.Parse(PhoneList.SelectedRows[0].Cells[0].Value.ToString()),
                            Last_name = PhoneList.SelectedRows[0].Cells[1].Value.ToString(),
                            Phone_number = phone_number
                        });
                        LoadPhoneList();
                    }
                    else
                    {
                        MessageBox.Show("В номере телефона доступны только цифры");
                    }
                }
            }
            if (CatList.SelectedRows.Count != 0)
            {
                if (CatList.SelectedRows != null && CatList.SelectedRows[0] != null &&
                    CatList.SelectedRows[0].Cells[1].Value != null && CatList.SelectedRows[0].Cells[2].Value != null &&
                    CatList.SelectedRows[0].Cells[0].Value != null)
                {
                    int ifInt;
                    if (!Int32.TryParse(CatList.SelectedRows[0].Cells[2].Value.ToString(), out ifInt))
                    {
                        WCFService.UpdCat(new ClassLibrary.Cat
                        {
                            Id = int.Parse(CatList.SelectedRows[0].Cells[0].Value.ToString()),
                            Name = CatList.SelectedRows[0].Cells[1].Value.ToString(),
                            Breed = CatList.SelectedRows[0].Cells[2].Value.ToString()
                        });
                        LoadCatList();
                    }
                    else
                    {
                        MessageBox.Show("Порода кота не может содержать цифры");
                    }
                }
            }
        }

        private void DeletePhoneButton_Click(object sender, EventArgs e)
        {
            if (PhoneList.SelectedRows.Count != 0)
            {
                if (PhoneList.SelectedRows != null && PhoneList.SelectedRows[0] != null &&
                    PhoneList.SelectedRows[0].Cells[1].Value != null && PhoneList.SelectedRows[0].Cells[2].Value != null &&
                    PhoneList.SelectedRows[0].Cells[0].Value != null)
                {
                    int phone_number;
                    if (Int32.TryParse(PhoneList.SelectedRows[0].Cells[2].Value.ToString(), out phone_number))
                    {
                        AsmxService.DelPhone(new Phone
                        {
                            Id = int.Parse(PhoneList.SelectedRows[0].Cells[0].Value.ToString()),
                            Last_name = PhoneList.SelectedRows[0].Cells[1].Value.ToString(),
                            Phone_number = Int32.Parse(PhoneList.SelectedRows[0].Cells[2].Value.ToString())
                        });
                        LoadPhoneList();
                    }
                    else
                    {
                        MessageBox.Show("В номере телефона доступны только цифры");
                    }
                }
            }
            if (CatList.SelectedRows.Count != 0)
            {
                if (CatList.SelectedRows != null && CatList.SelectedRows[0] != null &&
                    CatList.SelectedRows[0].Cells[1].Value != null && CatList.SelectedRows[0].Cells[2].Value != null &&
                    CatList.SelectedRows[0].Cells[0].Value != null)
                {
                    int ifInt;
                    if (!Int32.TryParse(CatList.SelectedRows[0].Cells[2].Value.ToString(), out ifInt))
                    {
                        WCFService.DelCat(new ClassLibrary.Cat
                        {
                            Id = int.Parse(CatList.SelectedRows[0].Cells[0].Value.ToString()),
                            Name = CatList.SelectedRows[0].Cells[1].Value.ToString(),
                            Breed = CatList.SelectedRows[0].Cells[2].Value.ToString()
                        });
                        LoadCatList();
                    }
                    else
                    {
                        MessageBox.Show("Порода кота не может содержать цифры");
                    }
                }
            }
        }

        private void LoadPhoneList()
        {
            PhoneList.Rows.Clear();
            PhoneList.Columns.Clear();
            PhoneList.Columns.Add("Id", "Id");
            PhoneList.Columns.Add("Name", "Name");
            PhoneList.Columns.Add("Phone_Number", "Phone_Number");
            int rowNumber;
            foreach (var phone in AsmxService.GetPhones().ToList())
            {
                rowNumber = PhoneList.Rows.Add();
                PhoneList.Rows[rowNumber].Cells["Id"].Value = phone.Id;
                PhoneList.Rows[rowNumber].Cells[0].ReadOnly = true;
                PhoneList.Rows[rowNumber].Cells["Name"].Value = phone.Last_name;
                PhoneList.Rows[rowNumber].Cells["Phone_Number"].Value = phone.Phone_number;
            }
        }

        private void LoadCatList()
        {
            CatList.Rows.Clear();
            CatList.Columns.Clear();
            CatList.Columns.Add("Id", "Id");
            CatList.Columns.Add("Name", "Name");
            CatList.Columns.Add("Breed", "Breed");
            int rowCatNumber;
            foreach (var cat in WCFService.GetCats())
            {
                if (cat != null)
                {
                    rowCatNumber = CatList.Rows.Add();
                    CatList.Rows[rowCatNumber].Cells["Id"].Value = cat.Id;
                    CatList.Rows[rowCatNumber].Cells[0].ReadOnly = true;
                    CatList.Rows[rowCatNumber].Cells["Name"].Value = cat.Name;
                    CatList.Rows[rowCatNumber].Cells["Breed"].Value = cat.Breed;
                }
            }
        }

    }
}
