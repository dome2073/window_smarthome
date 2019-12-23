using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace FirebaseHome
{

    public partial class Form1 : Form
    {
        Data obj;
        int ON = 1;
        int OFF = 0;
        IFirebaseConfig config = new FirebaseConfig
        {
            //내 웹DB연동
            AuthSecret = "sdM7xgFeS8diy4hBjb4fjvAT1ye38N4oNsTQDvkp",
            BasePath = "https://smarthome-50b1d.firebaseio.com/"

        };
        IFirebaseClient client;

        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            DataRead();

        }

        private async void DataRead()
        {
            client = new FireSharp.FirebaseClient(config);

            if (client != null)
            {


                FirebaseResponse response = await client.GetTaskAsync("HomeState/");
                //데이터 받아오기(예외처리필요)
                obj = response.ResultAs<Data>();

                //obj.KEY.Equals .. 하드코딩으로 했습니다.....ㅜ.ㅜ
                if (obj != null)
                {
                    //TV
                    if (obj.tv.Equals("1"))
                    {
                        TV_ON.BackColor = Color.BlueViolet;
                        TV_OFF.BackColor = Color.Gray;
                    }
                    else if (obj.tv.Equals("0"))
                    {
                        TV_ON.BackColor = Color.Gray;
                        TV_OFF.BackColor = Color.BlueViolet;
                    }
                    //Blind
                    if (obj.blind.Equals("1"))
                    {
                        Blind_ON.BackColor = Color.BlueViolet;
                        Blind_OFF.BackColor = Color.Gray;
                    }

                    else if (obj.blind.Equals("0"))
                    {
                        Blind_ON.BackColor = Color.Gray;
                        Blind_OFF.BackColor = Color.BlueViolet;
                    }

                    //AIR
                    if (obj.LED1.Equals("1"))
                    {
                        Air_ON.BackColor = Color.BlueViolet;
                        Air_OFF.BackColor = Color.Gray;
                    }

                    else if (obj.LED1.Equals("0"))
                    {
                        Air_ON.BackColor = Color.Gray;
                        Air_OFF.BackColor = Color.BlueViolet;
                    }

                    //침대전등
                    if (obj.LED2.Equals("1"))
                    {
                        BED_ON.BackColor = Color.BlueViolet;
                        BED_OFF.BackColor = Color.Gray;
                    }
                    else if (obj.LED2.Equals("0"))
                    {
                        BED_ON.BackColor = Color.Gray;
                        BED_OFF.BackColor = Color.BlueViolet;
                    }

                    //TV거실전등
                    if (obj.LED3.Equals("1"))
                    {
                        TV_LED_ON.BackColor = Color.BlueViolet;
                        TV_LED_OFF.BackColor = Color.Gray;
                    }
                    else if (obj.LED3.Equals("0"))
                    {
                        TV_LED_ON.BackColor = Color.Gray;
                        TV_LED_OFF.BackColor = Color.BlueViolet;
                    }
                    Temp.Text = obj.temp;
                    Hum.Text = obj.hum;
                }

            }
        }
        //TV_ON버튼 클릭
        private async void TV_ON_Click(object sender, EventArgs e)
        {
            obj.tv = "1";
            SetResponse resoponse = await client.SetTaskAsync("HomeState/", obj);
            DataRead();
        }
        //tv_OFF버튼 클릭
        private async void TV_OFF_Click(object sender, EventArgs e)
        {
            obj.tv = "0";
            SetResponse resoponse = await client.SetTaskAsync("HomeState/", obj);
            DataRead();
        }

        private async void Blind_ON_Click(object sender, EventArgs e)
        {
            obj.blind = "1";
            SetResponse resoponse = await client.SetTaskAsync("HomeState/", obj);
            DataRead();
        }

        private async void Blind_OFF_Click(object sender, EventArgs e)
        {
            obj.blind = "0";
            SetResponse resoponse = await client.SetTaskAsync("HomeState/", obj);
            DataRead();
        }

        private async void Air_ON_Click(object sender, EventArgs e)
        {
            obj.LED1 = "1";
            SetResponse resoponse = await client.SetTaskAsync("HomeState/", obj);
            DataRead();
        }

        private async void Air_OFF_Click(object sender, EventArgs e)
        {
            obj.LED1 = "0";
            SetResponse resoponse = await client.SetTaskAsync("HomeState/", obj);
            DataRead();
        }

        private async void TV_LED_ON_Click(object sender, EventArgs e)
        {
            obj.LED3 = "1";
            SetResponse resoponse = await client.SetTaskAsync("HomeState/", obj);
            DataRead();
        }

        private async void TV_LED_OFF_Click(object sender, EventArgs e)
        {
            obj.LED3 = "0";
            SetResponse resoponse = await client.SetTaskAsync("HomeState/", obj);
            DataRead();
        }

        private async void BED_ON_Click(object sender, EventArgs e)
        {
            obj.LED2 = "1";
            SetResponse resoponse = await client.SetTaskAsync("HomeState/", obj);
            DataRead();
        }

        private async void BED_OFF_Click(object sender, EventArgs e)
        {
            obj.LED2 = "0";
            SetResponse resoponse = await client.SetTaskAsync("HomeState/", obj);
            DataRead();
        }

    }
}
