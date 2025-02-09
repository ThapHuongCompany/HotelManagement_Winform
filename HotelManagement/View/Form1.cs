﻿using HotelManagement.BLL.Interface;
using HotelManagement.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HotelManagement
{
    public partial class Form1 : Form
    {
        private IRoomTypeBLL _iRoomTypeBLL;
        private IRoomBLL _iRoomBLL;
        private IUserBLL _iUserBLL;
        public Form1(IRoomTypeBLL iRoomTypeBLL, IRoomBLL iRoomBLL, IUserBLL iUserBLL)
        {
            InitializeComponent();
            _iUserBLL = iUserBLL;
            _iRoomBLL = iRoomBLL;
            _iRoomTypeBLL = iRoomTypeBLL;
            /* getAllRoom();*/
            getAllUSer();
        }

        public void getAllRoomType()
        {
            List<RoomTypeVM> listVM = _iRoomTypeBLL.getAll();
            Console.WriteLine(listVM.Count);
            Console.WriteLine("fefel");

            string json = JsonConvert.SerializeObject(listVM, Formatting.Indented);
            richTextBox1.Text = json;
            Console.WriteLine(json);
        }

        public void getAllRoom()
        {
            List<RoomVM> listVm = _iRoomBLL.getAll(1, 2, "HELO");
            string json = JsonConvert.SerializeObject(listVm, Formatting.Indented);
            richTextBox1.Text = json;
        }

        public void getAllUSer()
        {
            List<UserVM> userVMlist = _iUserBLL.searchUser("","");
            string json = JsonConvert.SerializeObject(userVMlist, Formatting.Indented);
            richTextBox1.Text = json;
        }
    }
}
