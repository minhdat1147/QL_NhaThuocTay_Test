using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Input;
using System.Windows.Forms;
using System.Drawing;
using Microsoft.VisualStudio.TestTools.UITesting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UITest.Extension;
using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;


namespace TestBanHang
{
    /// <summary>
    /// Summary description for CodedUITest1
    /// </summary>
    [CodedUITest]
    public class CodedUITest1
    {
        public CodedUITest1()
        {
        }
        //lưu ý cô dùng mã NV001 và pass 123 để test ạ
        [TestMethod]
        public void CodedUITestMethod_Them()
        {
            string strCBBLoaiThuoc = "THUỐC SỐT";
            string strCBBTenThuoc = "THUỐC SỐT MỸ";
            int intSL = 3;
            string strThongBao = "Thêm Thành công";
            this.UIMap.RecordedMethod_TCThemParams.UICboTenLoaiComboBoxSelectedItem = strCBBLoaiThuoc.ToString();
            this.UIMap.RecordedMethod_TCThemParams.UITênthuốcComboBoxSelectedItem = strCBBTenThuoc.ToString();
            this.UIMap.RecordedMethod_TCThemParams.UINumericUpDownEditSendKeys = intSL.ToString();
            this.UIMap.AssertMethod1_ThemThanhCongExpectedValues.UIThêmThànhcôngTextControlType = strThongBao.ToString();
            this.UIMap.RecordedMethod_TCThem();
            this.UIMap.AssertMethod1_ThemThanhCong();
        }
        [TestMethod]
        public void CodedUITestMethod_ThemLoi()
        {
            string strCBBLoaiThuoc = "THUỐC SỐT";

            string strCBBTenThuoc = "THUỐC SỐT MỸ";
            int intSL = 0;//Cố tình nhập sai số lượng
            string strThongBao = "Thêm không thành công! Vui lòng kiểm tra lại nhập liệu!";
            this.UIMap.RecordedMethod_TCThemParams.UICboTenLoaiComboBoxSelectedItem = strCBBLoaiThuoc.ToString();
            this.UIMap.RecordedMethod_TCThemParams.UITênthuốcComboBoxSelectedItem = strCBBTenThuoc.ToString();
            this.UIMap.RecordedMethod_TCThemParams.UINumericUpDownEditSendKeys = intSL.ToString();
            this.UIMap.AssertMethod1_ThemLoiExpectedValues.UIThêmkhôngthànhcôngVuTextControlType = strThongBao.ToString();
            this.UIMap.RecordedMethod_TCThem();
            this.UIMap.AssertMethod1_ThemLoi();
        }

        [TestMethod]
        public void CodedUITestMethod_Sua()
        {
            int intSL = 10;
            string strThongBao = "Sửa Thành công";
            this.UIMap.RecordedMethod_SuaParams.UINumericUpDownEditSendKeys = intSL.ToString();
            this.UIMap.AssertMethod1_SuaThanhCongExpectedValues.UISửaThànhcôngTextControlType = strThongBao;
            this.UIMap.RecordedMethod_Sua();
            this.UIMap.AssertMethod1_SuaThanhCong();
        }
        [TestMethod]
        public void CodedUITestMethod_SuaLoi()
        {
            int intSL = 0;
            string strThongBao = "Sửa không thành công! Vui lòng kiểm tra lại nhập liệu!";
            this.UIMap.RecordedMethod_SuaParams.UINumericUpDownEditSendKeys = intSL.ToString();
            this.UIMap.AssertMethod1_SuaKhongThanhCongExpectedValues.UISửakhôngthànhcôngVuiTextControlType = strThongBao;
            this.UIMap.RecordedMethod_Sua();
            this.UIMap.AssertMethod1_SuaKhongThanhCong();

        }
        [TestMethod]
        public void CodedUITestMethod_ThanhToan()
        {
            string strCBBLoaiThuoc = "THUỐC SỐT";
            string strCBBTenThuoc = "THUỐC SỐT MỸ";
            int intSL = 3;
            int intTienKD = 90000;
            this.UIMap.RecordedMethod1_ThanhToanTCParams.UICboTenLoaiComboBoxSelectedItem = strCBBLoaiThuoc.ToString();
            this.UIMap.RecordedMethod1_ThanhToanTCParams.UITênthuốcComboBoxSelectedItem = strCBBTenThuoc.ToString();
            this.UIMap.RecordedMethod1_ThanhToanTCParams.UINumericUpDownEditSendKeys = intSL.ToString();
            this.UIMap.RecordedMethod1_ThanhToanTCParams.UITxtTienKhachDuaEditText = intTienKD.ToString();
            this.UIMap.RecordedMethod1_ThanhToanTC();
        }
        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "|DataDirectory|\\TestBanHang.xml", "TinhTienThuoc", DataAccessMethod.Sequential)]
        public void CodedUITestMethod_ThanhToanAuTo()
        {

            string strCBBLoaiThuoc = this.TestContext.DataRow["LoaiThuoc"].ToString();
            string strCBBTenThuoc = this.TestContext.DataRow["TenThuoc"].ToString();
            int intSL = int.Parse(this.TestContext.DataRow["SoLuong"].ToString());
            int intTienKD = int.Parse(this.TestContext.DataRow["TienKhachDua"].ToString());
            this.UIMap.RecordedMethod1_ThanhToanTCParams.UICboTenLoaiComboBoxSelectedItem = strCBBLoaiThuoc.ToString();
            this.UIMap.RecordedMethod1_ThanhToanTCParams.UITênthuốcComboBoxSelectedItem = strCBBTenThuoc.ToString();
            this.UIMap.RecordedMethod1_ThanhToanTCParams.UINumericUpDownEditSendKeys = intSL.ToString();
            this.UIMap.RecordedMethod1_ThanhToanTCParams.UITxtTienKhachDuaEditText = intTienKD.ToString();
            this.UIMap.RecordedMethod1_ThanhToanTC();
        }

        #region Additional test attributes

        // You can use the following additional attributes as you write your tests:

        ////Use TestInitialize to run code before running each test 
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //    // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
        //}

        ////Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{        
        //    // To generate code for this test, select "Generate Code for Coded UI Test" from the shortcut menu and select one of the menu items.
        //    // For more information on generated code, see http://go.microsoft.com/fwlink/?LinkId=179463
        //}

        #endregion

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }
        private TestContext testContextInstance;

        public UIMap UIMap
        {
            get
            {
                if ((this.map == null))
                {
                    this.map = new UIMap();
                }

                return this.map;
            }
        }

        private UIMap map;
    }
}
