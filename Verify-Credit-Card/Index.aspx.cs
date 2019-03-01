using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions; //Regex için

namespace Verify_Credit_Card
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            img_card.Visible = false;
            lbl_check.Visible = false;
            lbl_warning.Text = "You should both enter your credit card type and your card number CORRECT!";
            img0.ImageUrl = "https://iconicprintingframing.com.au/wp-content/uploads/visa.png";
            img1.ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/7/72/MasterCard_early_1990s_logo.png";
            img2.ImageUrl = "https://about.americanexpress.com/sites/americanexpress.newshq.businesswire.com/files/logo/image/AXP_BlueBoxLogo_EXTRALARGEscale_RGB_DIGITAL_1600x1600.png";
            img3.ImageUrl = "https://pngimage.net/wp-content/uploads/2018/05/diners-club-png-3.png";
            img4.ImageUrl = "https://pngimage.net/wp-content/uploads/2018/05/discover-png-8.png";
            img5.ImageUrl = "https://vignette.wikia.nocookie.net/logopedia/images/f/fa/Maestro.png/revision/latest?cb=20120906072040";
        }

        protected void btn_check_Click(object sender, EventArgs e)
        {
            /*Her kart için Regular Expression*/
            string isVisa = "^4[0-9]{12}(?:[0-9]{3})?$";
            string isMasterCard = "^(5[1-5][0-9]{14}|2(22[1-9][0-9]{12}|2[3-9][0-9]{13}|[3-6][0-9]{14}|7[0-1][0-9]{13}|720[0-9]{12}))$";
            string isAmericanExp = "^3[47][0-9]{13}$";
            string isDiscover = "^65[4-9][0-9]{13}|64[4-9][0-9]{13}|6011[0-9]{12}|(622(?:12[6-9]|1[3-9][0-9]|[2-8][0-9][0-9]|9[01][0-9]|92[0-5])[0-9]{10})$";
            string isDiners = "^3(?:0[0-5]|[68][0-9])[0-9]{11}$";
            string isMaestro = "^(5018|5020|5038|6304|6759|6761|6763)[0-9]{8,15}$";

            /*Kullanıcının textbox'a girdiği kart numarası aralarındaki boşluklar silindikten sonra kontrol gerçekleştirilir.*/
            string ccnumber = txt_cardnumber.Text;
            ccnumber = ccnumber.Replace(" ", String.Empty);


            int parsedValue;

            if (System.Text.RegularExpressions.Regex.IsMatch(ccnumber, isVisa) && ddl_creditcard.SelectedValue == "VISA")
            {
                img_card.ImageUrl = "https://iconicprintingframing.com.au/wp-content/uploads/visa.png";
                img_card.Visible = true;
                lbl_check.BackColor = System.Drawing.Color.Green;
                lbl_check.Text = "SUCCESS!" + "<br/>" + "Your Credit Card is Verified!";
                lbl_check.Height = 56;
                lbl_check.Visible = true;

            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(ccnumber, isMasterCard) && ddl_creditcard.SelectedValue == "MasterCard")
            {
                img_card.ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/7/72/MasterCard_early_1990s_logo.png";
                img_card.Visible = true;
                lbl_check.BackColor = System.Drawing.Color.Green;
                lbl_check.Text = "SUCCESS!" + "<br/>" + "Your Credit Card is Verified!";
                lbl_check.Height = 56;
                lbl_check.Visible = true;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(ccnumber, isAmericanExp) && ddl_creditcard.SelectedValue == "American Express")
            {
                img_card.ImageUrl = "https://about.americanexpress.com/sites/americanexpress.newshq.businesswire.com/files/logo/image/AXP_BlueBoxLogo_EXTRALARGEscale_RGB_DIGITAL_1600x1600.png";
                img_card.Visible = true;
                lbl_check.BackColor = System.Drawing.Color.Green;
                lbl_check.Text = "SUCCESS!" + "<br/>" + "Your Credit Card is Verified!";
                lbl_check.Height = 56;
                lbl_check.Visible = true;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(ccnumber, isDiners) && ddl_creditcard.SelectedValue == "Diners Club")
            {
                img_card.ImageUrl = "https://pngimage.net/wp-content/uploads/2018/05/diners-club-png-3.png";
                img_card.Visible = true;
                lbl_check.BackColor = System.Drawing.Color.Green;
                lbl_check.Text = "SUCCESS!" + "<br/>" + "Your Credit Card is Verified!";
                lbl_check.Height = 55;
                lbl_check.Visible = true;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(ccnumber, isDiscover) && ddl_creditcard.SelectedValue == "Discover")
            {
                img_card.ImageUrl = "https://pngimage.net/wp-content/uploads/2018/05/discover-png-8.png";
                img_card.Visible = true;
                lbl_check.BackColor = System.Drawing.Color.Green;
                lbl_check.Text = "SUCCESS!" + "<br/>" + "Your Credit Card is Verified!";
                lbl_check.Height = 55;
                lbl_check.Visible = true;
            }
            else if (System.Text.RegularExpressions.Regex.IsMatch(ccnumber, isMaestro) && ddl_creditcard.SelectedValue == "Maestro")
            {
                img_card.ImageUrl = "https://vignette.wikia.nocookie.net/logopedia/images/f/fa/Maestro.png/revision/latest?cb=20120906072040";
                img_card.Visible = true;
                lbl_check.BackColor = System.Drawing.Color.Green;
                lbl_check.Text = "SUCCESS!" + "<br/>" + "Your Credit Card is Verified!";
                lbl_check.Height = 55;
                lbl_check.Visible = true;
            }
            /*Kart Numarası girilmediğinde TeztBox'ın kontrolünü gerçekleştirir.*/
            else if (txt_cardnumber.Text.Trim() == string.Empty)
            {
                lbl_check.Text = "WARNING!" + "<br />" + "No Card Number Provided!";
                lbl_check.BackColor = System.Drawing.Color.Yellow;
                lbl_check.Height = 55;
                lbl_check.Visible = true;
            }
            /*Kart Numarasına rakamlardan başka bir şey olup olmadığının kontrolünü gerçekleştirir.*/
            else if (!int.TryParse(txt_cardnumber.Text, out parsedValue))
            {
                lbl_check.Text = "ERROR!" + "<br />" + "Credit card number has an inappropriate number of digits or Credit card number is in invalid format! PLEASE, Check your credit card type and card number!";
                lbl_check.BackColor = System.Drawing.Color.Red;
                lbl_check.Height = 90;
                lbl_check.Visible = true;
            }
            else
            {
                lbl_check.Text = "WARNING!" + "<br />" + "Unknown card type!";
                lbl_check.BackColor = System.Drawing.Color.Red;
                lbl_check.Height = 56;
                lbl_check.Visible = true;

            }
        }

        protected void txt_cardnumber_TextChanged(object sender, EventArgs e)
        {
            img_card.Visible = false;
            lbl_check.Visible = false;

            /*Her 4 digitten sonra boşluk koyar.*/
            string text = Regex.Replace(txt_cardnumber.Text, @"\D", "");
            text = Regex.Replace(text, @"\d\d\d\d(?!$)", "$0 ");
            txt_cardnumber.Text = text;
        }
    }
}