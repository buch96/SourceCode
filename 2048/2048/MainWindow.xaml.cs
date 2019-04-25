using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _2048
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            A1.Text = ""; A2.Text = ""; A3.Text = ""; A4.Text = "";
            B1.Text = ""; B2.Text = ""; B3.Text = ""; B4.Text = "";
            C1.Text = ""; C2.Text = ""; C3.Text = ""; C4.Text = "";
            D1.Text = ""; D2.Text = ""; D3.Text = ""; D4.Text = "";
            FillSquare();
            FillSquare();
        }

        public void PressLeft()
        {
            if (A1.Text == A2.Text && A1.Text != "") { int number = (Convert.ToInt32(A1.Text)); A1.Text = (number * 2).ToString(); A2.Text = ""; }
            if (A2.Text == A3.Text && A2.Text != "") { int number = (Convert.ToInt32(A2.Text)); A2.Text = (number * 2).ToString(); A3.Text = ""; }
            if (A3.Text == A4.Text && A3.Text != "") { int number = (Convert.ToInt32(A3.Text)); A3.Text = (number * 2).ToString(); A4.Text = ""; }
            if (B1.Text == B2.Text && B1.Text != "") { int number = (Convert.ToInt32(B1.Text)); B1.Text = (number * 2).ToString(); B2.Text = ""; }
            if (B2.Text == B3.Text && B2.Text != "") { int number = (Convert.ToInt32(B2.Text)); B2.Text = (number * 2).ToString(); B3.Text = ""; }
            if (B3.Text == B4.Text && B3.Text != "") { int number = (Convert.ToInt32(B3.Text)); B3.Text = (number * 2).ToString(); B4.Text = ""; }
            if (C1.Text == C2.Text && C1.Text != "") { int number = (Convert.ToInt32(C1.Text)); C1.Text = (number * 2).ToString(); C2.Text = ""; }
            if (C2.Text == C3.Text && C2.Text != "") { int number = (Convert.ToInt32(C2.Text)); C2.Text = (number * 2).ToString(); C3.Text = ""; }
            if (C3.Text == C4.Text && C3.Text != "") { int number = (Convert.ToInt32(C3.Text)); C3.Text = (number * 2).ToString(); C4.Text = ""; }
            if (D1.Text == D2.Text && D1.Text != "") { int number = (Convert.ToInt32(D1.Text)); D1.Text = (number * 2).ToString(); D2.Text = ""; }
            if (D2.Text == D3.Text && D2.Text != "") { int number = (Convert.ToInt32(D2.Text)); D2.Text = (number * 2).ToString(); D3.Text = ""; }
            if (D3.Text == D4.Text && D3.Text != "") { int number = (Convert.ToInt32(D3.Text)); D3.Text = (number * 2).ToString(); D4.Text = ""; }
            if (A1.Text == "" && A2.Text != "") { A1.Text = A2.Text; A2.Text = ""; }
            if (A2.Text == "" && A3.Text != "") { A2.Text = A3.Text; A3.Text = ""; }
            if (A3.Text == "" && A4.Text != "") { A3.Text = A4.Text; A4.Text = ""; }
            if (A2.Text == "" && A3.Text != "") { A2.Text = A3.Text; A3.Text = ""; }
            if (A1.Text == "" && A2.Text != "") { A1.Text = A2.Text; A2.Text = ""; }
            if (B1.Text == "" && B2.Text != "") { B1.Text = B2.Text; B2.Text = ""; }
            if (B2.Text == "" && B3.Text != "") { B2.Text = B3.Text; B3.Text = ""; }
            if (B3.Text == "" && B4.Text != "") { B3.Text = B4.Text; B4.Text = ""; }
            if (B2.Text == "" && B3.Text != "") { B2.Text = B3.Text; B3.Text = ""; }
            if (B1.Text == "" && B2.Text != "") { B1.Text = B2.Text; B2.Text = ""; }
            if (C1.Text == "" && C2.Text != "") { C1.Text = C2.Text; C2.Text = ""; }
            if (C2.Text == "" && C3.Text != "") { C2.Text = C3.Text; C3.Text = ""; }
            if (C3.Text == "" && C4.Text != "") { C3.Text = C4.Text; C4.Text = ""; }
            if (C2.Text == "" && C3.Text != "") { C2.Text = C3.Text; C3.Text = ""; }
            if (C1.Text == "" && C2.Text != "") { C1.Text = C2.Text; C2.Text = ""; }
            if (D1.Text == "" && D2.Text != "") { D1.Text = D2.Text; D2.Text = ""; }
            if (D2.Text == "" && D3.Text != "") { D2.Text = D3.Text; D3.Text = ""; }
            if (D3.Text == "" && D4.Text != "") { D3.Text = D4.Text; D4.Text = ""; }
            if (D2.Text == "" && D3.Text != "") { D2.Text = D3.Text; D3.Text = ""; }
            if (D1.Text == "" && D2.Text != "") { D1.Text = D2.Text; D2.Text = ""; }
            }

        public void PressRight()
        {
            if (A4.Text == A3.Text && A4.Text != "") { int number = (Convert.ToInt32(A4.Text)); A4.Text = (number * 2).ToString(); A3.Text = ""; }
            if (A3.Text == A2.Text && A3.Text != "") { int number = (Convert.ToInt32(A3.Text)); A3.Text = (number * 2).ToString(); A2.Text = ""; }
            if (A2.Text == A1.Text && A2.Text != "") { int number = (Convert.ToInt32(A2.Text)); A2.Text = (number * 2).ToString(); A1.Text = ""; }
            if (B4.Text == B3.Text && B4.Text != "") { int number = (Convert.ToInt32(B4.Text)); B4.Text = (number * 2).ToString(); B3.Text = ""; }
            if (B3.Text == B2.Text && B3.Text != "") { int number = (Convert.ToInt32(B3.Text)); B3.Text = (number * 2).ToString(); B2.Text = ""; }
            if (B2.Text == B1.Text && B2.Text != "") { int number = (Convert.ToInt32(B2.Text)); B2.Text = (number * 2).ToString(); B1.Text = ""; }
            if (C4.Text == C3.Text && C4.Text != "") { int number = (Convert.ToInt32(C4.Text)); C4.Text = (number * 2).ToString(); C3.Text = ""; }
            if (C3.Text == C2.Text && C3.Text != "") { int number = (Convert.ToInt32(C3.Text)); C3.Text = (number * 2).ToString(); C2.Text = ""; }
            if (C2.Text == C1.Text && C2.Text != "") { int number = (Convert.ToInt32(C2.Text)); C2.Text = (number * 2).ToString(); C1.Text = ""; }
            if (D4.Text == D3.Text && D4.Text != "") { int number = (Convert.ToInt32(D4.Text)); D4.Text = (number * 2).ToString(); D3.Text = ""; }
            if (D3.Text == D2.Text && D3.Text != "") { int number = (Convert.ToInt32(D3.Text)); D3.Text = (number * 2).ToString(); D2.Text = ""; }
            if (D2.Text == D1.Text && D2.Text != "") { int number = (Convert.ToInt32(D2.Text)); D2.Text = (number * 2).ToString(); D1.Text = ""; }
            if (A4.Text == "" && A3.Text != "") { A4.Text = A3.Text; A3.Text = ""; }
            if (A3.Text == "" && A2.Text != "") { A3.Text = A2.Text; A2.Text = ""; }
            if (A2.Text == "" && A1.Text != "") { A2.Text = A1.Text; A1.Text = ""; }
            if (A3.Text == "" && A2.Text != "") { A3.Text = A2.Text; A2.Text = ""; }
            if (A4.Text == "" && A3.Text != "") { A4.Text = A3.Text; A3.Text = ""; }
            if (B4.Text == "" && B3.Text != "") { B4.Text = B3.Text; B3.Text = ""; }
            if (B3.Text == "" && B2.Text != "") { B3.Text = B2.Text; B2.Text = ""; }
            if (B2.Text == "" && B1.Text != "") { B2.Text = B1.Text; B1.Text = ""; }
            if (B3.Text == "" && B2.Text != "") { B3.Text = B2.Text; B2.Text = ""; }
            if (B4.Text == "" && B3.Text != "") { B4.Text = B3.Text; B3.Text = ""; }
            if (C4.Text == "" && C3.Text != "") { C4.Text = C3.Text; C3.Text = ""; }
            if (C3.Text == "" && C2.Text != "") { C3.Text = C2.Text; C2.Text = ""; }
            if (C2.Text == "" && C1.Text != "") { C2.Text = C1.Text; C1.Text = ""; }
            if (C3.Text == "" && C2.Text != "") { C3.Text = C2.Text; C2.Text = ""; }
            if (C4.Text == "" && C3.Text != "") { C4.Text = C3.Text; C3.Text = ""; }
            if (D4.Text == "" && D3.Text != "") { D4.Text = D3.Text; D3.Text = ""; }
            if (D3.Text == "" && D2.Text != "") { D3.Text = D2.Text; D2.Text = ""; }
            if (D2.Text == "" && D1.Text != "") { D2.Text = D1.Text; D1.Text = ""; }
            if (D3.Text == "" && D2.Text != "") { D3.Text = D2.Text; D2.Text = ""; }
            if (D4.Text == "" && D3.Text != "") { D4.Text = D3.Text; D3.Text = ""; }
        }

        public void PressUp()
        {
            if (A1.Text == B1.Text && A1.Text != "") { int number = (Convert.ToInt32(A1.Text)); A1.Text = (number * 2).ToString(); B1.Text = ""; }
            if (B1.Text == C1.Text && B1.Text != "") { int number = (Convert.ToInt32(B1.Text)); B1.Text = (number * 2).ToString(); C1.Text = ""; }
            if (C1.Text == D1.Text && C1.Text != "") { int number = (Convert.ToInt32(C1.Text)); C1.Text = (number * 2).ToString(); D1.Text = ""; }
            if (A2.Text == B2.Text && A2.Text != "") { int number = (Convert.ToInt32(A2.Text)); A2.Text = (number * 2).ToString(); B2.Text = ""; }
            if (B2.Text == C2.Text && B2.Text != "") { int number = (Convert.ToInt32(B2.Text)); B2.Text = (number * 2).ToString(); C2.Text = ""; }
            if (C2.Text == D2.Text && C2.Text != "") { int number = (Convert.ToInt32(C2.Text)); C2.Text = (number * 2).ToString(); D2.Text = ""; }
            if (A3.Text == B3.Text && A3.Text != "") { int number = (Convert.ToInt32(A3.Text)); A3.Text = (number * 2).ToString(); B3.Text = ""; }
            if (B3.Text == C3.Text && B3.Text != "") { int number = (Convert.ToInt32(B3.Text)); B3.Text = (number * 2).ToString(); C3.Text = ""; }
            if (C3.Text == D3.Text && C3.Text != "") { int number = (Convert.ToInt32(C3.Text)); C3.Text = (number * 2).ToString(); D3.Text = ""; }
            if (A4.Text == B4.Text && A4.Text != "") { int number = (Convert.ToInt32(A4.Text)); A4.Text = (number * 2).ToString(); B4.Text = ""; }
            if (B4.Text == C4.Text && B4.Text != "") { int number = (Convert.ToInt32(B4.Text)); B4.Text = (number * 2).ToString(); C4.Text = ""; }
            if (C4.Text == D4.Text && C4.Text != "") { int number = (Convert.ToInt32(C4.Text)); C4.Text = (number * 2).ToString(); D4.Text = ""; }
            if (A1.Text == "" && B1.Text != "") { A1.Text = B1.Text; B1.Text = ""; }
            if (B1.Text == "" && C1.Text != "") { B1.Text = C1.Text; C1.Text = ""; }
            if (C1.Text == "" && D1.Text != "") { C1.Text = D1.Text; D1.Text = ""; }
            if (B1.Text == "" && C1.Text != "") { B1.Text = C1.Text; C1.Text = ""; }
            if (A1.Text == "" && B1.Text != "") { A1.Text = B1.Text; B1.Text = ""; }
            if (A2.Text == "" && B2.Text != "") { A2.Text = B2.Text; B2.Text = ""; }
            if (B2.Text == "" && C2.Text != "") { B2.Text = C2.Text; C2.Text = ""; }
            if (C2.Text == "" && D2.Text != "") { C2.Text = D2.Text; D2.Text = ""; }
            if (B2.Text == "" && C2.Text != "") { B2.Text = C2.Text; C2.Text = ""; }
            if (A2.Text == "" && B2.Text != "") { A2.Text = B2.Text; B2.Text = ""; }
            if (A3.Text == "" && B3.Text != "") { A3.Text = B3.Text; B3.Text = ""; }
            if (B3.Text == "" && C3.Text != "") { B3.Text = C3.Text; C3.Text = ""; }
            if (C3.Text == "" && D3.Text != "") { C3.Text = D3.Text; D3.Text = ""; }
            if (B3.Text == "" && C3.Text != "") { B3.Text = C3.Text; C3.Text = ""; }
            if (A3.Text == "" && B3.Text != "") { A3.Text = B3.Text; B3.Text = ""; }
            if (A4.Text == "" && B4.Text != "") { A4.Text = B4.Text; B4.Text = ""; }
            if (B4.Text == "" && C4.Text != "") { B4.Text = C4.Text; C4.Text = ""; }
            if (C4.Text == "" && D4.Text != "") { C4.Text = D4.Text; D4.Text = ""; }
            if (B4.Text == "" && C4.Text != "") { B4.Text = C4.Text; C4.Text = ""; }
            if (A4.Text == "" && B4.Text != "") { A4.Text = B4.Text; B4.Text = ""; }

        }

        public void PressDown()
        {
            if (D1.Text == C1.Text && D1.Text != "") { int number = (Convert.ToInt32(D1.Text)); D1.Text = (number * 2).ToString(); C1.Text = ""; }
            if (C1.Text == B1.Text && C1.Text != "") { int number = (Convert.ToInt32(C1.Text)); C1.Text = (number * 2).ToString(); B1.Text = ""; }
            if (B1.Text == A1.Text && B1.Text != "") { int number = (Convert.ToInt32(B1.Text)); B1.Text = (number * 2).ToString(); A1.Text = ""; }
            if (D2.Text == C2.Text && D2.Text != "") { int number = (Convert.ToInt32(D2.Text)); D2.Text = (number * 2).ToString(); C2.Text = ""; }
            if (C2.Text == B2.Text && C2.Text != "") { int number = (Convert.ToInt32(C2.Text)); C2.Text = (number * 2).ToString(); B2.Text = ""; }
            if (B2.Text == A2.Text && B2.Text != "") { int number = (Convert.ToInt32(B2.Text)); B2.Text = (number * 2).ToString(); A2.Text = ""; }
            if (D3.Text == C3.Text && D3.Text != "") { int number = (Convert.ToInt32(D3.Text)); D3.Text = (number * 2).ToString(); C3.Text = ""; }
            if (C3.Text == B3.Text && C3.Text != "") { int number = (Convert.ToInt32(C3.Text)); C3.Text = (number * 2).ToString(); B3.Text = ""; }
            if (B3.Text == A3.Text && B3.Text != "") { int number = (Convert.ToInt32(B3.Text)); B3.Text = (number * 2).ToString(); A3.Text = ""; }
            if (D4.Text == C4.Text && D4.Text != "") { int number = (Convert.ToInt32(D4.Text)); D4.Text = (number * 2).ToString(); C4.Text = ""; }
            if (C4.Text == B4.Text && C4.Text != "") { int number = (Convert.ToInt32(C4.Text)); C4.Text = (number * 2).ToString(); B4.Text = ""; }
            if (B4.Text == A4.Text && B4.Text != "") { int number = (Convert.ToInt32(B4.Text)); B4.Text = (number * 2).ToString(); A4.Text = ""; }
            if (D1.Text == "" && C1.Text != "") { D1.Text = C1.Text; C1.Text = ""; }
            if (C1.Text == "" && B1.Text != "") { C1.Text = B1.Text; B1.Text = ""; }
            if (B1.Text == "" && A1.Text != "") { B1.Text = A1.Text; A1.Text = ""; }
            if (C1.Text == "" && B1.Text != "") { C1.Text = B1.Text; B1.Text = ""; }
            if (D1.Text == "" && C1.Text != "") { D1.Text = C1.Text; C1.Text = ""; }
            if (D2.Text == "" && C2.Text != "") { D2.Text = C2.Text; C2.Text = ""; }
            if (C2.Text == "" && B2.Text != "") { C2.Text = B2.Text; B2.Text = ""; }
            if (B2.Text == "" && A2.Text != "") { B2.Text = A2.Text; A2.Text = ""; }
            if (C2.Text == "" && B2.Text != "") { C2.Text = B2.Text; B2.Text = ""; }
            if (D2.Text == "" && C2.Text != "") { D2.Text = C2.Text; C2.Text = ""; }
            if (D3.Text == "" && C3.Text != "") { D3.Text = C3.Text; C3.Text = ""; }
            if (C3.Text == "" && B3.Text != "") { C3.Text = B3.Text; B3.Text = ""; }
            if (B3.Text == "" && A3.Text != "") { B3.Text = A3.Text; A3.Text = ""; }
            if (C3.Text == "" && B3.Text != "") { C3.Text = B3.Text; B3.Text = ""; }
            if (D3.Text == "" && C3.Text != "") { D3.Text = C3.Text; C3.Text = ""; }
            if (D4.Text == "" && C4.Text != "") { D4.Text = C4.Text; C4.Text = ""; }
            if (C4.Text == "" && B4.Text != "") { C4.Text = B4.Text; B4.Text = ""; }
            if (B4.Text == "" && A4.Text != "") { B4.Text = A4.Text; A4.Text = ""; }
            if (C4.Text == "" && B4.Text != "") { C4.Text = B4.Text; B4.Text = ""; }
            if (D4.Text == "" && C4.Text != "") { D4.Text = C4.Text; C4.Text = ""; }
        }

        public void FillSquare()
        {
            int winnable = 0;
            if (A1.Text != "" && A2.Text != "" && A3.Text != "" && A4.Text != "" && B1.Text != "" && B2.Text != "" && B3.Text != "" && B4.Text != ""
                && C1.Text != "" && C2.Text != "" && C3.Text != "" && C4.Text != "" && D1.Text != "" && D2.Text != "" && D3.Text != "" && D4.Text != "")
            {
                if (A1.Text != B1.Text && A1.Text != A2.Text) { winnable = winnable + 1; }
                if (A2.Text != B2.Text && A2.Text != A1.Text && A2.Text != A3.Text) { winnable = winnable + 1; }
                if (A3.Text != B3.Text && A3.Text != A2.Text && A3.Text != A4.Text) { winnable = winnable + 1; }
                if (A4.Text != B4.Text && A4.Text != A3.Text) { winnable = winnable + 1; }
                if (B1.Text != A1.Text && B1.Text != C1.Text && B1.Text != B2.Text) { winnable = winnable + 1; }
                if (B2.Text != A2.Text && B2.Text != C2.Text && B2.Text != B1.Text && B2.Text != B3.Text) { winnable = winnable + 1; }
                if (B3.Text != A3.Text && B3.Text != C3.Text && B3.Text != B2.Text && B3.Text != B4.Text) { winnable = winnable + 1; }
                if (B4.Text != A4.Text && B4.Text != C4.Text && B4.Text != B3.Text) { winnable = winnable + 1; }
                if (C1.Text != B1.Text && C1.Text != D1.Text && C1.Text != C2.Text) { winnable = winnable + 1; }
                if (C2.Text != B2.Text && C2.Text != D2.Text && C2.Text != C1.Text && C2.Text != C3.Text) { winnable = winnable + 1; }
                if (C3.Text != B3.Text && C3.Text != D3.Text && C3.Text != C2.Text && C3.Text != C4.Text) { winnable = winnable + 1; }
                if (C4.Text != B4.Text && C4.Text != D4.Text && C4.Text != C3.Text) { winnable = winnable + 1; }
                if (D1.Text != C1.Text && D1.Text != D2.Text) { winnable = winnable + 1; }
                if (D2.Text != C2.Text && D2.Text != D3.Text && D2.Text != D1.Text) { winnable = winnable + 1; }
                if (D3.Text != C3.Text && D3.Text != D4.Text && D3.Text != A2.Text) { winnable = winnable + 1; }
                if (D4.Text != C4.Text && D4.Text != D3.Text) { winnable = winnable + 1; }
                if (winnable == 16) { MessageBox.Show("You lose!"); }
            }
            else
            {
                bool works = false;
                while (works == false)
                {
                    int randomnum = new Random().Next(1, 17);
                    if (randomnum == 1) { if (A1.Text == "") { A1.Text = "2"; works = true; } }
                    if (randomnum == 2) { if (A2.Text == "") { A2.Text = "2"; works = true; } }
                    if (randomnum == 3) { if (A3.Text == "") { A3.Text = "2"; works = true; } }
                    if (randomnum == 4) { if (A4.Text == "") { A4.Text = "2"; works = true; } }
                    if (randomnum == 5) { if (B1.Text == "") { B1.Text = "2"; works = true; } }
                    if (randomnum == 6) { if (B2.Text == "") { B2.Text = "2"; works = true; } }
                    if (randomnum == 7) { if (B3.Text == "") { B3.Text = "2"; works = true; } }
                    if (randomnum == 8) { if (B4.Text == "") { B4.Text = "2"; works = true; } }
                    if (randomnum == 9) { if (C1.Text == "") { C1.Text = "2"; works = true; } }
                    if (randomnum == 10) { if (C2.Text == "") { C2.Text = "2"; works = true; } }
                    if (randomnum == 11) { if (C3.Text == "") { C3.Text = "2"; works = true; } }
                    if (randomnum == 12) { if (C4.Text == "") { C4.Text = "2"; works = true; } }
                    if (randomnum == 13) { if (D1.Text == "") { D1.Text = "2"; works = true; } }
                    if (randomnum == 14) { if (D2.Text == "") { D2.Text = "2"; works = true; } }
                    if (randomnum == 15) { if (D3.Text == "") { D3.Text = "2"; works = true; } }
                    if (randomnum == 16) { if (D4.Text == "") { D4.Text = "2"; works = true; } }
                }
            }
            string score;
            int highscore = Convert.ToInt32(HighScore.Content);
            if (A1.Text != "") { score = A1.Text; if (Convert.ToInt32(score) > highscore) { HighScore.Content = A1.Text; } }
            if (A2.Text != "") { score = A2.Text; if (Convert.ToInt32(score) > highscore) { HighScore.Content = A2.Text; } }
            if (A3.Text != "") { score = A3.Text; if (Convert.ToInt32(score) > highscore) { HighScore.Content = A3.Text; } }
            if (A4.Text != "") { score = A4.Text; if (Convert.ToInt32(score) > highscore) { HighScore.Content = A4.Text; } }
            if (B1.Text != "") { score = B1.Text; if (Convert.ToInt32(score) > highscore) { HighScore.Content = B1.Text; } }
            if (B2.Text != "") { score = B2.Text; if (Convert.ToInt32(score) > highscore) { HighScore.Content = B2.Text; } }
            if (B3.Text != "") { score = B3.Text; if (Convert.ToInt32(score) > highscore) { HighScore.Content = B3.Text; } }
            if (B4.Text != "") { score = B4.Text; if (Convert.ToInt32(score) > highscore) { HighScore.Content = B4.Text; } }
            if (C1.Text != "") { score = C1.Text; if (Convert.ToInt32(score) > highscore) { HighScore.Content = C1.Text; } }
            if (C2.Text != "") { score = C2.Text; if (Convert.ToInt32(score) > highscore) { HighScore.Content = C2.Text; } }
            if (C3.Text != "") { score = C3.Text; if (Convert.ToInt32(score) > highscore) { HighScore.Content = C3.Text; } }
            if (C4.Text != "") { score = C4.Text; if (Convert.ToInt32(score) > highscore) { HighScore.Content = C4.Text; } }
            if (D1.Text != "") { score = D1.Text; if (Convert.ToInt32(score) > highscore) { HighScore.Content = D1.Text; } }
            if (D2.Text != "") { score = D2.Text; if (Convert.ToInt32(score) > highscore) { HighScore.Content = D2.Text; } }
            if (D3.Text != "") { score = D3.Text; if (Convert.ToInt32(score) > highscore) { HighScore.Content = D3.Text; } }
            if (D4.Text != "") { score = D4.Text; if (Convert.ToInt32(score) > highscore) { HighScore.Content = D4.Text; } }
        }

        private void LeftButton_Click(object sender, RoutedEventArgs e)
        {
            PressLeft();
            FillSquare();
        }

        private void RightButton_Click(object sender, RoutedEventArgs e)
        {
            PressRight();
            FillSquare();
        }

        private void UpButton_Click(object sender, RoutedEventArgs e)
        {
            PressUp();
            FillSquare();
        }

        private void DownButton_Click(object sender, RoutedEventArgs e)
        {
            PressDown();
            FillSquare();
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            A1.Text = ""; A2.Text = ""; A3.Text = ""; A4.Text = "";
            B1.Text = ""; B2.Text = ""; B3.Text = ""; B4.Text = "";
            C1.Text = ""; C2.Text = ""; C3.Text = ""; C4.Text = "";
            D1.Text = ""; D2.Text = ""; D3.Text = ""; D4.Text = "";
            FillSquare();
            FillSquare();
        }
    }
}
