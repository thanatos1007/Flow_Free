Option Explicit On
Option Strict On
Public Class Form1
    'Functies voor een willekeurig vakje"
    Function Randomlocatiex() As Integer
        Dim rooster(4, 4) As Integer
        Dim rnd As System.Random = New Random()
        Dim x As Integer = rnd.Next(0, rooster.GetLength(0) - 1)
        Return x
    End Function

    Function Randomlocatiey() As Integer
        Dim rooster(4, 4) As Integer
        Dim rnd As System.Random = New Random()
        Dim y As Integer = rnd.Next(0, rooster.GetLength(1) - 1)
        Return y
    End Function
    'Einde van de functies voor een willekeurig vakje'

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Reset de timer en laat hem starten'
        Label1.Show()
        Timer1.Start()
        Label1.Text = "0"
        Label3.Text = "100"
        Timer2.Start()







        'Matrix van 5 breed (tot 4) en 5 hoog (tot 4)
        Dim rooster(4, 4) As Label
        Dim Xcoordinaat As Integer = 0
        Dim Ycoordinaat As Integer = 0
        'Initialisatie van het rooster
        For i As Integer = rooster.GetLowerBound(0) To rooster.GetUpperBound(0)
            For j As Integer = rooster.GetLowerBound(1) To rooster.GetUpperBound(1)
                rooster(i, j) = New Label
                rooster(i, j).Size = New Size(66, 66)
                rooster(i, j).Name = "tile_" & i & "_" & j
                rooster(i, j).BorderStyle = BorderStyle.FixedSingle
                'x,y locatie in het venster
                rooster(i, j).Location = New Point(Xcoordinaat, Ycoordinaat)
                'kleur van het vierkantje
                rooster(i, j).BackColor = Color.White
                AddHandler SpelBord.MouseDown, AddressOf SpelBord_MouseDown
                'voeg toe aan GUI
                SpelBord.Controls.Add(rooster(i, j))
                Xcoordinaat += 66
            Next
            Ycoordinaat += 66
            Xcoordinaat = 0
        Next
        ' Random kleur generatie'
        Dim juistrooster As Boolean
        juistrooster = False
        While juistrooster = False

            Dim blue1x As Integer
            Dim blue1y As Integer
            blue1x = Randomlocatiex()
            blue1y = Randomlocatiey()
            While rooster(Randomlocatiex(), Randomlocatiey()).BackColor <> Color.White
                blue1x = Randomlocatiex()
            blue1y = Randomlocatiey()
            End While
            If rooster(Randomlocatiex(), Randomlocatiey()).BackColor = Color.White Then
                rooster(blue1x, blue1y).BackColor = Color.Blue
            End If

            Dim blue2x As Integer
            Dim blue2y As Integer
            blue2x = blue1x + 1
            blue2y = blue1y
            If rooster(blue2x, blue2y).BackColor = Color.White Then
                rooster(blue2x, blue2y).BackColor = Color.Blue
            ElseIf rooster(blue2x, blue2y).BackColor <> Color.White Then
                blue2x = blue1x
            blue2y = blue1y + 1
            If rooster(blue2x, blue2y).BackColor = Color.White Then
                rooster(blue2x, blue2y).BackColor = Color.Blue
            ElseIf rooster(blue2x, blue2y).BackColor <> Color.White Then
                blue2x = blue1x - 1
                blue2y = blue1y
                If rooster(blue2x, blue2y).BackColor = Color.White Then
                    rooster(blue2x, blue2y).BackColor = Color.Blue
                ElseIf rooster(blue2x, blue2y).BackColor <> Color.White Then
                    blue2x = blue1x
                    blue2y = blue1y - 1
                    If rooster(blue2x, blue2y).BackColor = Color.White Then
                        rooster(blue2x, blue2y).BackColor = Color.Blue
                    End If
                End If
            End If
        End If
            Dim kop_blue As Label
            Dim tail_blue As Label
            kop_blue = rooster(blue1x, blue1y)
            tail_blue = rooster(blue2x, blue2y)

            Dim red1x As Integer
            Dim red1y As Integer
            red1x = Randomlocatiex()
            red1y = Randomlocatiey()
            While rooster(Randomlocatiex(), Randomlocatiey()).BackColor <> Color.White
                red1x = Randomlocatiex()
            red1y = Randomlocatiey()
            End While
            If rooster(Randomlocatiex(), Randomlocatiey()).BackColor = Color.White Then
                rooster(red1x, red1y).BackColor = Color.Red
            End If

            Dim red2x As Integer
            Dim red2y As Integer
            red2x = red1x + 1
            red2y = red1y
            If rooster(red2x, red2y).BackColor = Color.White Then
            rooster(red2x, red2y).BackColor = Color.Red
        ElseIf rooster(red2x, red2y).BackColor <> Color.White Then
            red2x = red1x
            red2y = red1y + 1
            If rooster(red2x, red2y).BackColor = Color.White Then
                rooster(red2x, red2y).BackColor = Color.Red
            ElseIf rooster(red2x, red2y).BackColor <> Color.White Then
                red2x = red1x - 1
                red2y = red1y
                If rooster(red2x, red2y).BackColor = Color.White Then
                    rooster(red2x, red2y).BackColor = Color.Red
                ElseIf rooster(red2x, red2y).BackColor <> Color.White Then
                    red2x = red1x
                    red2y = red1y - 1
                    If rooster(red2x, red2y).BackColor = Color.White Then
                        rooster(red2x, red2y).BackColor = Color.Red
                    End If
                End If
            End If
        End If
            Dim kop_red As Label
            Dim tail_red As Label
            kop_red = rooster(red1x, red1y)
            tail_red = rooster(red2x, red2y)

            Dim green1x As Integer
            Dim green1y As Integer
            green1x = Randomlocatiex()
            green1y = Randomlocatiey()
            While rooster(Randomlocatiex(), Randomlocatiey()).BackColor <> Color.White
            green1x = Randomlocatiex()
            green1y = Randomlocatiey()
            End While
            If rooster(Randomlocatiex(), Randomlocatiey()).BackColor = Color.White Then
                rooster(green1x, green1y).BackColor = Color.Green
            End If


            Dim green2x As Integer
            Dim green2y As Integer
            green2x = green1x + 1
            green2y = green1y
            If rooster(green2x, green2y).BackColor = Color.White Then
            rooster(green2x, green2y).BackColor = Color.Green
        ElseIf rooster(green2x, green2y).BackColor <> Color.White Then
            green2x = green1x
            green2y = green1y + 1
            If rooster(green2x, green2y).BackColor = Color.White Then
                rooster(green2x, green2y).BackColor = Color.Green
            ElseIf rooster(green2x, green2y).BackColor <> Color.White Then
                green2x = green1x - 1
                green2y = green1y
                If rooster(green2x, green2y).BackColor = Color.White Then
                    rooster(green2x, green2y).BackColor = Color.Green
                ElseIf rooster(green2x, green2y).BackColor <> Color.White Then
                    green2x = green1x
                    green2y = green1y - 1
                    If rooster(green2x, green2y).BackColor = Color.White Then
                        rooster(green2x, green2y).BackColor = Color.Green
                    End If
                End If
            End If
        End If
            Dim kop_green As Label
            Dim tail_green As Label
            kop_green = rooster(green1x, green1y)
            tail_green = rooster(green2x, green2y)

            Dim orange1x As Integer
            Dim orange1y As Integer
            orange1x = Randomlocatiex()
            orange1y = Randomlocatiey()
            While rooster(Randomlocatiex(), Randomlocatiey()).BackColor <> Color.White
                orange1x = Randomlocatiex()
            orange1y = Randomlocatiey()
            End While
            If rooster(Randomlocatiex(), Randomlocatiey()).BackColor = Color.White Then
                rooster(orange1x, orange1y).BackColor = Color.Orange
            End If

            Dim orange2x As Integer
            Dim orange2y As Integer
            orange2x = orange1x + 1
            orange2y = orange1y
            If rooster(orange2x, orange2y).BackColor = Color.White Then
                rooster(orange2x, orange2y).BackColor = Color.Orange
            ElseIf rooster(orange2x, orange2y).BackColor <> Color.White Then
                orange2x = orange1x
            orange2y = orange1y + 1
            If rooster(orange2x, orange2y).BackColor = Color.White Then
                rooster(orange2x, orange2y).BackColor = Color.Orange
            ElseIf rooster(orange2x, orange2y).BackColor <> Color.White Then
                orange2x = orange1x - 1
                orange2y = orange1y
                If rooster(orange2x, orange2y).BackColor = Color.White Then
                    rooster(orange2x, orange2y).BackColor = Color.Orange
                ElseIf rooster(orange2x, orange2y).BackColor <> Color.White Then
                    orange2x = orange1x
                    orange2y = orange1y - 1
                    If rooster(orange2x, orange2y).BackColor = Color.White Then
                        rooster(orange2x, orange2y).BackColor = Color.Orange
                    End If
                End If
            End If
        End If
            Dim kop_orange As Label
            Dim tail_orange As Label
            kop_orange = rooster(orange1x, orange1y)
            tail_orange = rooster(orange2x, orange2y)

            Dim yellow1x As Integer
            Dim yellow1y As Integer
            yellow1x = Randomlocatiex()
            yellow1y = Randomlocatiey()
            While rooster(Randomlocatiex(), Randomlocatiey()).BackColor <> Color.White
                yellow1x = Randomlocatiex()
            yellow1y = Randomlocatiey()
            End While
            If rooster(Randomlocatiex(), Randomlocatiey()).BackColor = Color.White Then
                rooster(yellow1x, yellow1y).BackColor = Color.Yellow
            End If
            Dim yellow2x As Integer
            Dim yellow2y As Integer
            yellow2x = yellow1x + 1
            yellow2y = yellow1y
            If rooster(yellow2x, yellow2y).BackColor = Color.White Then
                rooster(yellow2x, yellow2y).BackColor = Color.Yellow
            ElseIf rooster(yellow2x, yellow2y).BackColor <> Color.White Then
                yellow2x = yellow1x
            yellow2y = yellow1y + 1
            If rooster(yellow2x, yellow2y).BackColor = Color.White Then
                rooster(yellow2x, yellow2y).BackColor = Color.Yellow
            ElseIf rooster(yellow2x, yellow2y).BackColor <> Color.White Then
                yellow2x = yellow1x - 1
                yellow2y = yellow1y
                If rooster(yellow2x, yellow2y).BackColor = Color.White Then
                    rooster(yellow2x, yellow2y).BackColor = Color.Yellow
                ElseIf rooster(yellow2x, yellow2y).BackColor <> Color.White Then
                    yellow2x = yellow1x
                    yellow2y = yellow1y - 1
                    If rooster(yellow2x, yellow2y).BackColor = Color.White Then
                        rooster(yellow2x, yellow2y).BackColor = Color.Yellow
                    End If
                End If
            End If
        End If
            Dim kop_yellow As Label
            Dim tail_yellow As Label
            kop_yellow = rooster(yellow1x, yellow1y)
            tail_yellow = rooster(yellow2x, yellow2y)
            'Einde van de Random kleur generatie'

            'Begin van kleuren stap 2"
            'Kies een willekerige kleur'
            Dim Willekeurigkleur As Color
            Dim kopwillekeurigekleur As Label
            Dim tailwillekeurigekleur As Label
            Dim Xwp As Integer
            Dim Ywp As Integer
            Dim juistekleur As Boolean
            Dim juistekleurbestaat As Boolean
            juistekleurbestaat = True
            juistekleur = False
            Dim bluekleur As Boolean
            bluekleur = True
            Dim greenkleur As Boolean
            greenkleur = True
            Dim yellowkleur As Boolean
            yellowkleur = True
            Dim redkleur As Boolean
            redkleur = True
            Dim orangekleur As Boolean
            orangekleur = True
            Dim willekeurigpos As Label
            willekeurigpos = rooster(Randomlocatiex(), Randomlocatiey())
            Dim Keuze1 As Label
            Dim Keuze2 As Label
            Dim Keuze3 As Label
            Dim keuze4 As Label
            Dim Keuze5 As Label
            Dim Keuze6 As Label
            Dim Keuze7 As Label
            Dim Keuze8 As Label
            While juistekleur = False And juistekleurbestaat = True
                Xwp = Randomlocatiex()
                Ywp = Randomlocatiey()
                While rooster(Xwp, Ywp).BackColor = Color.White
                    Xwp = Randomlocatiex()
                Ywp = Randomlocatiey()
            End While

                'Bepaal de kleur van de willekeurig locatie
                If rooster(Xwp, Ywp).BackColor = Color.Blue Then
                    Willekeurigkleur = Color.Blue
                ElseIf rooster(Xwp, Ywp).BackColor = Color.Red Then
                    Willekeurigkleur = Color.Red
                ElseIf rooster(Xwp, Ywp).BackColor = Color.Green Then
                    Willekeurigkleur = Color.Green
                ElseIf rooster(Xwp, Ywp).BackColor = Color.Orange Then
                    Willekeurigkleur = Color.Orange
                ElseIf rooster(Xwp, Ywp).BackColor = Color.Yellow Then
                    Willekeurigkleur = Color.Yellow
            End If
                'Algoritme bij de willekeurige kleur'
                If Willekeurigkleur = Color.Blue Then
                    kopwillekeurigekleur = kop_blue
                    tailwillekeurigekleur = tail_blue

                    'Grenzend aan kop"
                    If rooster(blue1x + 1, blue1y).BackColor = Color.White Then
                        juistekleur = True
                        keuze1 = rooster(blue1x + 1, blue1y)
                    ElseIf rooster(blue1x - 1, blue1y).BackColor = Color.White Then
                        juistekleur = True
                        Keuze2 = rooster(blue1x - 1, blue1y)
                    ElseIf rooster(blue1x, blue1y + 1).BackColor = Color.White Then
                        juistekleur = True
                        Keuze3 = rooster(blue1x, blue1y + 1)
                    ElseIf rooster(blue1x, blue1y - 1).BackColor = Color.White Then
                        juistekleur = True
                        keuze4 = rooster(blue1x, blue1y - 1)
                        'Grenzend aan tail'
                    ElseIf rooster(blue2x + 1, blue2y).BackColor = Color.White Then
                        juistekleur = True
                        Keuze5 = rooster(blue2x + 1, blue2y)
                    ElseIf rooster(blue2x - 1, blue2y).BackColor = Color.White Then
                        juistekleur = True
                        Keuze6 = rooster(blue2x - 1, blue2y)
                    ElseIf rooster(blue2x, blue2y + 1).BackColor = Color.White Then
                        juistekleur = True
                        Keuze7 = rooster(blue2x, blue2y + 1)
                    ElseIf rooster(blue2x, blue2y - 1).BackColor = Color.White Then
                        juistekleur = True
                        Keuze8 = rooster(blue2x, blue2y - 1)
                    Else
                        juistekleur = False
                        bluekleur = False
                    End If
                    Dim geengrenzendkopblue As Boolean
                    geengrenzendkopblue = True
                    willekeurigpos = rooster(Randomlocatiex, Randomlocatiey)

                End If

                If Willekeurigkleur = Color.Red Then
                kopwillekeurigekleur = kop_red
                tailwillekeurigekleur = tail_red
                If rooster(red1x + 1, red1y).BackColor = Color.White Then
                    juistekleur = True
                ElseIf rooster(red1x - 1, red1y).BackColor = Color.White Then
                    juistekleur = True
                ElseIf rooster(red1x, red1y + 1).BackColor = Color.White Then
                    juistekleur = True
                ElseIf rooster(red1x, red1y - 1).BackColor = Color.White Then
                    juistekleur = True
                ElseIf rooster(red2x + 1, red2y).BackColor = Color.White Then
                    juistekleur = True
                ElseIf rooster(red2x - 1, red2y).BackColor = Color.White Then
                    juistekleur = True
                ElseIf rooster(red2x, red2y + 1).BackColor = Color.White Then
                    juistekleur = True
                ElseIf rooster(red2x, red2y - 1).BackColor = Color.White Then
                    juistekleur = True
                Else
                    juistekleur = False
                    redkleur = False
                End If
            End If

                If Willekeurigkleur = Color.Orange Then
                    kopwillekeurigekleur = kop_orange
                    tailwillekeurigekleur = tail_orange
                    If rooster(orange1x + 1, orange1y).BackColor = Color.White Then
                        juistekleur = True
                    ElseIf rooster(orange1x - 1, orange1y).BackColor = Color.White Then
                        juistekleur = True
                    ElseIf rooster(orange1x, orange1y + 1).BackColor = Color.White Then
                        juistekleur = True
                    ElseIf rooster(orange1x, orange1y - 1).BackColor = Color.White Then
                        juistekleur = True
                    ElseIf rooster(orange2x + 1, orange2y).BackColor = Color.White Then
                        juistekleur = True
                    ElseIf rooster(orange2x - 1, orange2y).BackColor = Color.White Then
                        juistekleur = True
                    ElseIf rooster(orange2x, orange2y + 1).BackColor = Color.White Then
                        juistekleur = True
                    ElseIf rooster(orange2x, orange2y - 1).BackColor = Color.White Then
                        juistekleur = True
                    Else
                        juistekleur = False
                        orangekleur = False
                    End If
                End If

                If Willekeurigkleur = Color.Green Then
                    kopwillekeurigekleur = kop_green
                    tailwillekeurigekleur = tail_green
                    If rooster(green1x + 1, green1y).BackColor = Color.White Then
                        juistekleur = True
                    ElseIf rooster(green1x - 1, green1y).BackColor = Color.White Then
                        juistekleur = True
                    ElseIf rooster(green1x, green1y + 1).BackColor = Color.White Then
                        juistekleur = True
                    ElseIf rooster(green1x, green1y - 1).BackColor = Color.White Then
                        juistekleur = True
                    ElseIf rooster(green2x + 1, green2y).BackColor = Color.White Then
                        juistekleur = True
                    ElseIf rooster(green2x - 1, green2y).BackColor = Color.White Then
                        juistekleur = True
                    ElseIf rooster(green2x, green2y + 1).BackColor = Color.White Then
                        juistekleur = True
                    ElseIf rooster(green2x, green2y - 1).BackColor = Color.White Then
                        juistekleur = True
                    Else
                        juistekleur = False
                        greenkleur = False
                    End If
                End If

                If Willekeurigkleur = Color.Yellow Then
                kopwillekeurigekleur = kop_yellow
                tailwillekeurigekleur = tail_yellow
                If rooster(yellow1x + 1, yellow1y).BackColor = Color.White Then
                    juistekleur = True
                ElseIf rooster(yellow1x - 1, yellow1y).BackColor = Color.White Then
                    juistekleur = True
                ElseIf rooster(yellow1x, yellow1y + 1).BackColor = Color.White Then
                    juistekleur = True
                ElseIf rooster(yellow1x, yellow1y - 1).BackColor = Color.White Then
                    juistekleur = True
                ElseIf rooster(yellow2x + 1, yellow2y).BackColor = Color.White Then
                    juistekleur = True
                ElseIf rooster(yellow2x - 1, yellow2y).BackColor = Color.White Then
                    juistekleur = True
                ElseIf rooster(yellow2x, yellow2y + 1).BackColor = Color.White Then
                    juistekleur = True
                ElseIf rooster(yellow2x, yellow2y - 1).BackColor = Color.White Then
                    juistekleur = True
                Else
                    juistekleur = False
                    yellowkleur = False

                End If
            End If

                If redkleur = False And bluekleur = False And yellowkleur = False And orangekleur = False And greenkleur = False Then
                    juistrooster = False
                Else
                    juistrooster = True
                End If
            End While
        End While

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Verhoog timer met 1"
        'Bron: https://www.youtube.com/watch?v=7ZrLjJm_QB8'
        Label1.Text = CType(CInt(Label1.Text) + 1, String)



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub



    Private Sub SpelBord_MouseDown(sender As Object, e As MouseEventArgs) Handles SpelBord.MouseDown
        Dim Rooster(4, 4) As Label
        Dim Muisposx As Integer
        Dim Muisposy As Integer
        Dim Kleur As Color
        Muisposx = MousePosition.X
        Muisposy = MousePosition.Y
        Kleur = Rooster(Muisposx, Muisposy).BackColor



    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click


    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        'Vergelijk de timer zijn text met20'
        'Als het kleiner is dan is het honderd"      
  
        Dim Limiet As Integer
        Limiet = 20
        If CInt(Label1.Text) <= 20 Then
            Label3.Text = CType(100, String)
        Else
            Label3.Text = CType(CInt(Label3.Text) - 1, String)
        End If



    End Sub
End Class
