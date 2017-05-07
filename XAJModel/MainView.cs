using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace XAJModel
{
    public partial class MainView : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public MainView()
        {
            InitializeComponent();
            if (!mvvmContext1.IsDesignMode)
                InitializeBindings();
        }
        private void MainView_Load(object sender, EventArgs e){    }

        //模块对象
        private Modules.EvaporRunoff EvaporCal;
        private Modules.RunoffDivision DivisionCal;
        private Modules.SConverge SlopeCal;
        private Modules.RConverge RiverCal;

        void InitializeBindings()
        {
            var fluent = mvvmContext1.OfType<MainViewModel>();
        }

        //蒸散发数据导入
        private void EImport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Misc.DataGridHelper DGH = new Misc.DataGridHelper(dataGrid);
            //DGH.importExcel("蒸散发产流数据.xls");
            EvaporCal = new Modules.EvaporRunoff(dataGrid);
            EvaporCal.importExcel();
        }
        //蒸散发数据导出
        private void EExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Misc.DataGridHelper DGH = new Misc.DataGridHelper(dataGrid);
            //DGH.exportExcel("蒸散发、土壤蓄水量及产流计算结果.xls");
            EvaporCal.exportExcel();
        }
        //蒸散发参数设置
        private void setEParams_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ParamsDlg.ERParamsDlg EPDlg = new ParamsDlg.ERParamsDlg();
            if (EPDlg.ShowDialog() == DialogResult.OK)
            {
                Params.ERunoff EParams = new Params.ERunoff(EPDlg.Kc, EPDlg.C, EPDlg.WM, EPDlg.WUM, EPDlg.WLM, EPDlg.WDM, EPDlg.b,EPDlg.IM);
                EvaporCal.initParams(EParams);
                EPDlg.Close();
            }
        }
        //蒸散发计算
        private void ECalButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EvaporCal.Start();
        }

        //水源划分参数设置
        private void DParamsButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ParamsDlg.DParamsDlg DPDlg = new ParamsDlg.DParamsDlg();
            if (DPDlg.ShowDialog() == DialogResult.OK)
            {
                Params.Division DParams = new Params.Division(DPDlg.SM, DPDlg.EX, DPDlg.KI, DPDlg.KG, DPDlg.IM);
                DivisionCal.initParams(DParams);
                DPDlg.Close();
            }
        }
        private void DParams2Button_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ParamsDlg.D2ParamsDlg D2PDlg = new ParamsDlg.D2ParamsDlg();
            if (D2PDlg.ShowDialog() == DialogResult.OK)
            {
                Params.Division2 D2Params = new Params.Division2(D2PDlg.FC,D2PDlg.DT);
                DivisionCal.initParams(D2Params);
                D2PDlg.Close();
            }
        }
        //水源划分数据导入
        private void DImport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Misc.DataGridHelper DGH = new Misc.DataGridHelper(dataGrid);
            //DGH.importExcel("蒸散发、土壤蓄水量及产流计算结果.xls");
            DivisionCal = new Modules.RunoffDivision(dataGrid);
            DivisionCal.importExcel();
        }
        //水源划分数据导出
        private void DExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            //Misc.DataGridHelper DGH = new Misc.DataGridHelper(dataGrid);
            //DGH.exportExcel("蒸散发、土壤蓄水量及分水源产流计算结果.xls");
            DivisionCal.exportExcel();
        }
        //水源划分计算
        private void DCalButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DivisionCal.Start();
        }

        private void Division2_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Division2.Checked == true)
                Division3.Checked = false;
            else
                Division3.Checked = true;
        }

        private void Division3_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Division3.Checked == true)
                Division2.Checked = false;
            else
                Division2.Checked = true;
        }
        //坡面汇流数据导入
        private void SImport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int DivisionType;
            if (Division2.Checked == true)
                DivisionType = 2;
            else
                DivisionType = 3;
            SlopeCal = new Modules.SConverge(dataGrid, DivisionType);
            SlopeCal.importExcel();
        }
        //坡面汇流数据导出
        private void SExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SlopeCal.exportExcel();
        }
        //坡面汇流参数设置
        private void SParamsButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ParamsDlg.SParamsDlg SPDlg = new ParamsDlg.SParamsDlg();
            if (SPDlg.ShowDialog() == DialogResult.OK)
            {
                Params.SConverge SParams = new Params.SConverge(SPDlg.CS, SPDlg.CI, SPDlg.CG, SPDlg.CR, SPDlg.U);
                SlopeCal.initParams(SParams);
                SPDlg.Close();
            }
        }
        //坡面汇流数据计算
        private void SCalButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            SlopeCal.Start();
        }
        //河网汇流计算
        private void RCalButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RiverCal.Start();
        }
        //河网汇流参数设置
        private void RParamsButton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ParamsDlg.RParamsDlg RPDlg = new ParamsDlg.RParamsDlg();
            if (RPDlg.ShowDialog() == DialogResult.OK)
            {
                Params.RConverge SParams = new Params.RConverge(RPDlg.DT, RPDlg.KE, RPDlg.XE, RPDlg.N);
                RiverCal.initParams(SParams);
                RPDlg.Close();
            }
        }
        //河网汇流数据导出
        private void RExport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RiverCal.exportExcel();
        }
        //河网汇流数据导入
        private void RImport_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RiverCal = new Modules.RConverge(dataGrid);
            RiverCal.importExcel();
        }
    }
}
