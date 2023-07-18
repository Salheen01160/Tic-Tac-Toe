using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class TicTacToeCode : MonoBehaviour
{
    Boolean Checker;
    int PlusOne;
    public Text btnText1 = null;
    public Text btnText2 = null;
    public Text btnText3 = null;
    public Text btnText4 = null;
    public Text btnText5 = null;
    public Text btnText6 = null;
    public Text btnText7 = null;
    public Text btnText8 = null;
    public Text btnText9 = null;
    public Text btnResetGame = null;
    public Text btnNewGame = null;
    public Text msgFeedBack = null;
    public Text txtPlayer_X ;
    public Text txtPlayer_O ;

    public void btn_text_click1()
    {
        if (Checker == false)
        {
            btnText1.text = "X";
            Checker = true;
        }
        else
        {
            btnText1.text = "O";
            Checker = false;
        }
        score();
    }
    public void btn_text_click2()
    {
        if (Checker == false)
        {
            btnText2.text = "X";
            Checker = true;
        }
        else
        {
            btnText2.text = "O";
            Checker = false;
        }
        score();
    }
    public void btn_text_click3()
    {
        if (Checker == false)
        {
            btnText3.text = "X";
            Checker = true;
        }
        else
        {
            btnText3.text = "O";
            Checker = false;
        }
        score();
    }
    public void btn_text_click4()
    {
        if (Checker == false)
        {
            btnText4.text = "X";
            Checker = true;
        }
        else
        {
            btnText4.text = "O";
            Checker = false;
        }
        score();
    }
    public void btn_text_click5()
    {
        if (Checker == false)
        {
            btnText5.text = "X";
            Checker = true;
        }
        else
        {
            btnText5.text = "O";
            Checker = false;
        }
        score();
    }
    public void btn_text_click6()
    {
        if (Checker == false)
        {
            btnText6.text = "X";
            Checker = true;
        }
        else
        {
            btnText6.text = "O";
            Checker = false;
        }
        score();
    }
    public void btn_text_click7()
    {
        if (Checker == false)
        {
            btnText7.text = "X";
            Checker = true;
        }
        else
        {
            btnText7.text = "O";
            Checker = false;
        }
        score();
    }
    public void btn_text_click8()
    {
        if (Checker == false)
        {
            btnText8.text = "X";
            Checker = true;
        }
        else
        {
            btnText8.text = "O";
            Checker = false;
        }
        score();
    }
    public void btn_text_click9()
    {
        if (Checker == false)
        {
            btnText9.text = "X";
            Checker = true;
        }
        else
        {
            btnText9.text = "O";
            Checker = false;
        }
        score();
    }
    public void btnResetGame_Click()
    {
        btnText1.text = "";
        btnText2.text = "";
        btnText3.text = "";
        btnText4.text = "";
        btnText5.text = "";
        btnText6.text = "";
        btnText7.text = "";
        btnText8.text = "";
        btnText9.text = "";
        btnText1.color = Color.black;
        btnText2.color = Color.black;
        btnText3.color = Color.black;
        btnText4.color = Color.black;
        btnText5.color = Color.black;
        btnText6.color = Color.black;
        btnText7.color = Color.black;
        btnText8.color = Color.black;
        btnText9.color = Color.black;
    }

    public void btnNewGame_Click()
    {
        btnResetGame_Click();
        txtPlayer_X.text = "";
        txtPlayer_O.text = "";
        msgFeedBack.text = "";

    }





    public void score()
    {
        if(btnText1.text=="X" && btnText2.text == "X" && btnText3.text == "X" )
        {
            btnText1.color = Color.red;
            btnText2.color = Color.red;
            btnText3.color = Color.red;
            msgFeedBack.text = "the winner is player X";
            PlusOne = int.Parse(txtPlayer_X.text);
            txtPlayer_X.text = Convert.ToString(PlusOne + 1);

        }
        if (btnText4.text == "X" && btnText5.text == "X" && btnText6.text == "X")
        {
            btnText4.color = Color.blue;
            btnText5.color = Color.blue;
            btnText6.color = Color.blue;
            msgFeedBack.text = "the winner is player X";
            PlusOne = int.Parse(txtPlayer_X.text);
            txtPlayer_X.text = Convert.ToString(PlusOne + 1);
        }
        if (btnText7.text == "X" && btnText8.text == "X" && btnText9.text == "X")
        {
            btnText7.color = Color.red;
            btnText8.color = Color.red;
            btnText9.color = Color.red;
            msgFeedBack.text = "the winner is player X";
            PlusOne = int.Parse(txtPlayer_X.text);
            txtPlayer_X.text = Convert.ToString(PlusOne + 1);
        }
        if (btnText1.text == "X" && btnText4.text == "X" && btnText7.text == "X")
        {
            btnText1.color = Color.blue;
            btnText4.color = Color.blue;
            btnText7.color = Color.blue;
            msgFeedBack.text = "the winner is player X";
            PlusOne = int.Parse(txtPlayer_X.text);
            txtPlayer_X.text = Convert.ToString(PlusOne + 1);
        }
        if (btnText2.text == "X" && btnText5.text == "X" && btnText8.text == "X")
        {
            btnText2.color = Color.red;
            btnText5.color = Color.red;
            btnText8.color = Color.red;
            msgFeedBack.text = "the winner is player X";
            PlusOne = int.Parse(txtPlayer_X.text);
            txtPlayer_X.text = Convert.ToString(PlusOne + 1);
        }
        if (btnText3.text == "X" && btnText6.text == "X" && btnText9.text == "X")
        {
            btnText3.color = Color.blue;
            btnText6.color = Color.blue;
            btnText9.color = Color.blue;
            msgFeedBack.text = "the winner is player X";
            PlusOne = int.Parse(txtPlayer_X.text);
            txtPlayer_X.text = Convert.ToString(PlusOne + 1);
        }
        if (btnText3.text == "X" && btnText5.text == "X" && btnText7.text == "X")
        {
            btnText3.color = Color.red;
            btnText5.color = Color.red;
            btnText7.color = Color.red;
            msgFeedBack.text = "the winner is player X";
            PlusOne = int.Parse(txtPlayer_X.text);
            txtPlayer_X.text = Convert.ToString(PlusOne + 1);
        }
        if (btnText1.text == "X" && btnText5.text == "X" && btnText9.text == "X")
        {
            btnText1.color = Color.blue;
            btnText5.color = Color.blue;
            btnText9.color = Color.blue;
            msgFeedBack.text = "the winner is player X";
            PlusOne = int.Parse(txtPlayer_X.text);
            txtPlayer_X.text = Convert.ToString(PlusOne + 1);
        }
        //=====================================================================
        //for player O
        if (btnText1.text == "O" && btnText2.text == "O" && btnText3.text == "O")
        {
            btnText1.color = Color.red;
            btnText2.color = Color.red;
            btnText3.color = Color.red;
            msgFeedBack.text = "the winner is player O";
            PlusOne = int.Parse(txtPlayer_O.text);
            txtPlayer_O.text = Convert.ToString(PlusOne + 1);
        }
        if (btnText4.text == "O" && btnText5.text == "O" && btnText6.text == "O")
        {
            btnText4.color = Color.blue;
            btnText5.color = Color.blue;
            btnText6.color = Color.blue;
            msgFeedBack.text = "the winner is player O";
            PlusOne = int.Parse(txtPlayer_O.text);
            txtPlayer_O.text = Convert.ToString(PlusOne + 1);
        }
        if (btnText7.text == "O" && btnText8.text == "O" && btnText9.text == "O")
        {
            btnText7.color = Color.red;
            btnText8.color = Color.red;
            btnText9.color = Color.red;
            msgFeedBack.text = "the winner is player O";
            PlusOne = int.Parse(txtPlayer_O.text);
            txtPlayer_O.text = Convert.ToString(PlusOne + 1);
        }
        if (btnText1.text == "O" && btnText4.text == "O" && btnText7.text == "O")
        {
            btnText1.color = Color.blue;
            btnText4.color = Color.blue;
            btnText7.color = Color.blue;
            msgFeedBack.text = "the winner is player O";
            PlusOne = int.Parse(txtPlayer_O.text);
            txtPlayer_O.text = Convert.ToString(PlusOne + 1);
        }
        if (btnText2.text == "O" && btnText5.text == "O" && btnText8.text == "O")
        {
            btnText2.color = Color.red;
            btnText5.color = Color.red;
            btnText8.color = Color.red;
            msgFeedBack.text = "the winner is player O";
            PlusOne = int.Parse(txtPlayer_O.text);
            txtPlayer_O.text = Convert.ToString(PlusOne + 1);
        }
        if (btnText3.text == "O" && btnText6.text == "O" && btnText9.text == "O")
        {
            btnText3.color = Color.blue;
            btnText6.color = Color.blue;
            btnText9.color = Color.blue;
            msgFeedBack.text = "the winner is player O";
            PlusOne = int.Parse(txtPlayer_O.text);
            txtPlayer_O.text = Convert.ToString(PlusOne + 1);
        }
        if (btnText3.text == "O" && btnText5.text == "O" && btnText7.text == "O")
        {
            btnText3.color = Color.red;
            btnText5.color = Color.red;
            btnText7.color = Color.red;
            msgFeedBack.text = "the winner is player O";
            PlusOne = int.Parse(txtPlayer_O.text);
            txtPlayer_O.text = Convert.ToString(PlusOne + 1);
        }
        if (btnText1.text == "O" && btnText5.text == "O" && btnText9.text == "O")
        {
            btnText1.color = Color.blue;
            btnText5.color = Color.blue;
            btnText9.color = Color.blue;
            msgFeedBack.text = "the winner is player O";
            PlusOne = int.Parse(txtPlayer_O.text);
            txtPlayer_O.text = Convert.ToString(PlusOne + 1);
        }


    }
   
}
