using DevExpress.XtraBars;
using DevExpress.XtraBars.Ribbon;
using Sistem.Masaustu.Paneller.Cari;

namespace Sistem.Masaustu.Paneller
{
    public partial class AnaPanel : RibbonForm
    {
        /// <summary>
        /// İşlemin Yapılıp yapıldığını buradan anlaşılır.
        /// </summary>
        private bool IslemlerBittiMi = new bool();

        public AnaPanel()
        {
            InitializeComponent();
        }

        private void BtnYeniCari_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (YeniCari yc = new YeniCari())
            {
                if (yc.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                }

            }
        }

        private void BtnCariHareketleri_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (CariListesi yc = new CariListesi())
            {
                if (yc.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {

                }

            }
        }
    }
}