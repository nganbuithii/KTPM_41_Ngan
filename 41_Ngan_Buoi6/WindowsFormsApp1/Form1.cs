using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOpenUrl_Click(object sender, EventArgs e)
        {
            string url = txtUrl.Text;
            if (string.IsNullOrEmpty(url))
                url = "https://www.google.com.vn/?hl=vi";

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);

            //driver.Close();

            // tắt màn hình đen
            //ChromeDriverService chrome = ChromeDriverService.CreateDefaultService();
            //chrome.HideCommandPromptWindow = true;

            //// Điều hướng trình duyệt
            //IWebDriver drive = new ChromeDriver(chrome);

            //drive.Quit();

            // lấy url
            String link_hientai = driver.Url;
            Console.WriteLine(link_hientai);

            // lấy title
            String urlTitle = driver.Title;
            Console.WriteLine(urlTitle);

            //G
            // Lấy URL hiện tại và tiêu đề của trang
            string currentUrl = driver.Url;
            string pageTitle = driver.Title;

            // Hiển thị URL và tiêu đề lên các TextBox tương ứng
            txtUrl.Text = currentUrl;
            txtTitle.Text = pageTitle;


            //H
            // LẤY PAGE SOURCE
            String PageSource = driver.PageSource;
            Console.WriteLine(PageSource);

            // back
            //driver.Navigate().Back();
            //Thread.Sleep(1000);
            //driver.Navigate().Refresh();


            // Tự động điền vào ô tìm kiếm
            IWebElement element = driver.FindElement(By.Name("q"));
            element.SendKeys("hello world");



            // Lấy giá trị của phần tử và gán vào TextBox
            string elementValue = element.GetAttribute("value");
            txtInput.Text = elementValue;

            driver.Quit();


        }
    }
}
