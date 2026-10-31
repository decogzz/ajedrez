Public Class tabla
    Public blanco As Integer
    Public negro As Integer
    Public Sub accion(ByVal x As PictureBox, ByVal y1 As PictureBox, ByVal y2 As PictureBox, Optional ByVal y3 As PictureBox = Nothing, Optional ByVal y4 As PictureBox = Nothing, Optional ByVal y5 As PictureBox = Nothing, Optional ByVal y6 As PictureBox = Nothing, Optional ByVal y7 As PictureBox = Nothing, Optional ByVal y8 As PictureBox = Nothing)
        If x.BackColor = Color.Green Then
            For Each ctr As PictureBox In ajedrez.Form2.Tabla1.Controls
                Try
                    ctr.Image.Dispose()
                Catch
                End Try
                ctr.Image = Nothing
                If ctr.BackColor = Color.Green Then
                    If ctr.AccessibleDescription = "negro" Then
                        ctr.BackColor = Color.Black
                    Else
                        ctr.BackColor = Color.White
                    End If
                End If
            Next ctr
            Try
                x.Image = My.Resources.caballo2
                y1.BackColor = Color.Green
                y2.BackColor = Color.Green
                y3.BackColor = Color.Green
                y4.BackColor = Color.Green
                y5.BackColor = Color.Green
                y6.BackColor = Color.Green
                y7.BackColor = Color.Green
                y8.BackColor = Color.Green
            Catch
            End Try
        End If
    End Sub
    Private Sub tabla_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        For Each ctr As PictureBox In ajedrez.Form2.Tabla1.Controls
            If ctr.BackColor = Color.Black Then
                ctr.AccessibleDescription = "negro"
            End If
        Next ctr
        a3.BackColor = Color.Green
        d2.BackColor = Color.Green
        c3.BackColor = Color.Green
    End Sub
    Private Sub b1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b1.Click
        accion(b1, a3, d2, c3)
    End Sub
    Private Sub a1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a1.Click
        accion(a1, b3, c2)
    End Sub
    Private Sub a2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a2.Click
        accion(a2, c1, c3, b4)
    End Sub
    Private Sub b3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b3.Click
        accion(b3, a1, c1, d2, d4, c5, a5)
    End Sub
    Private Sub c1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c1.Click
        accion(c1, a2, b3, d3, e2)
    End Sub
    Private Sub d1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles d1.Click
        accion(d1, b2, c3, e3, f2)
    End Sub
    Private Sub e1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles e1.Click
        accion(e1, c2, d3, f3, g2)
    End Sub
    Private Sub f1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f1.Click
        accion(f1, d2, e3, g3, h2)
    End Sub
    Private Sub g1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles g1.Click
        accion(g1, e2, f3, h3)
    End Sub
    Private Sub h1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles h1.Click
        accion(h1, f2, g3)
    End Sub
    Private Sub b2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b2.Click
        accion(b2, d1, d3, c4, a4)
    End Sub
    Private Sub c2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c2.Click
        accion(c2, a1, a3, e1, e3, d4, b4)
    End Sub
    Private Sub d2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles d2.Click
        accion(d2, b1, b3, f1, f3, e4, c4)
    End Sub
    Private Sub e2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles e2.Click
        accion(e2, c1, c3, g1, g3, f4, d4)
    End Sub
    Private Sub f2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f2.Click
        accion(f2, d1, d3, h1, h3, g4, e4)
    End Sub
    Private Sub h2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles h2.Click
        accion(h2, f1, f3, g4)
    End Sub
    Private Sub g2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles g2.Click
        accion(g2, e1, e3, f4, h4)
    End Sub
    Private Sub g4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles g4.Click
        accion(g4, h2, f2, e3, e5, f6, h6)
    End Sub
    Private Sub c3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c3.Click
        accion(c3, a2, a4, b5, d5, e2, e4, d1, b1)
    End Sub
    Private Sub a4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a4.Click
        accion(a4, b2, c3, c5, b6)
    End Sub
    Private Sub a3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a3.Click
        accion(a3, b1, c2, c4, b5)
    End Sub
    Private Sub c4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c4.Click
        accion(c4, d2, b2, a3, a5, b6, d6, e5, e3)
    End Sub
    Private Sub d3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles d3.Click
        accion(d3, b4, b2, f2, f4, c1, e1, e5, c5)
    End Sub
    Private Sub e3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles e3.Click
        accion(e3, c2, c4, g2, g4, d1, d5, f5, f1)
    End Sub
    Private Sub f3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f3.Click
        accion(f3, e1, g1, e5, g5, h2, h4, d2, d4)
    End Sub
    Private Sub g3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles g3.Click
        accion(g3, e2, e4, f1, f5, f5, f5, h1, h5)
    End Sub
    Private Sub h3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles h3.Click
        accion(h3, g1, f2, f4, g5)
    End Sub
    Private Sub b5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b5.Click
        accion(b5, a3, c3, d4, d6, c7, a7)
    End Sub
    Private Sub d5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles d5.Click
        accion(d5, c3, e3, c7, e7, b6, f6, b4, f4)
    End Sub
    Private Sub e4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles e4.Click
        accion(e4, d2, f2, g3, g5, f6, d6, c5, c3)
    End Sub
    Private Sub h4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles h4.Click
        accion(h4, g2, f3, f5, g6, g6, g6, f5, f3)
    End Sub
    Private Sub f4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f4.Click
        accion(f4, e2, g2, e6, g6, d5, d3, h5, h3)
    End Sub
    Private Sub d4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles d4.Click
        accion(d4, e2, c2, e6, c6, b5, b3, f5, f3)
    End Sub
    Private Sub b4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b4.Click
        accion(b4, a2, c2, a6, c6, d5, d3)
    End Sub
    Private Sub a5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a5.Click
        accion(a5, b3, c4, c6, b7)
    End Sub
    Private Sub c5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c5.Click
        accion(c5, b3, d3, a4, a6, e4, e6, d7, b7)
    End Sub
    Private Sub e5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles e5.Click
        accion(e5, d3, c4, c6, d7, f7, g6, g4, f3)
    End Sub
    Private Sub f5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f5.Click
        accion(f5, g3, e3, d4, d6, e7, g7, h6, h4)
    End Sub
    Private Sub g5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles g5.Click
        accion(g5, h3, f3, e4, e6, f7, h7)
    End Sub
    Private Sub h5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles h5.Click
        accion(h5, f4, f6, g3, g7)
    End Sub
    Private Sub h6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles h6.Click
        accion(h6, f5, f7, g4, g8)
    End Sub
    Private Sub h7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles h7.Click
        accion(h7, f6, f8, g5)
    End Sub
    Private Sub h8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles h8.Click
        accion(h8, f7, f7, g6)
    End Sub
    Private Sub g6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles g6.Click
        accion(g6, h4, f4, e5, e7, h8, f8)
    End Sub
    Private Sub g7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles g7.Click
        accion(g7, h5, f5, e6, e8)
    End Sub
    Private Sub g8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles g8.Click
        accion(g8, h6, f6, e7)
    End Sub
    Private Sub f6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f6.Click
        accion(f6, e4, g4, h5, h7, e8, g8, d5, d7)
    End Sub
    Private Sub f7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f7.Click
        accion(f7, e5, g5, h6, h8, d6, d8)
    End Sub
    Private Sub f8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles f8.Click
        accion(f8, e6, g6, h7, d7)
    End Sub
    Private Sub e8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles e8.Click
        accion(e8, c7, g7, d6, f6)
    End Sub
    Private Sub e7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles e7.Click
        accion(e7, c6, g6, d5, f5, g8, c8)
    End Sub
    Private Sub e6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles e6.Click
        accion(e6, c5, g5, d4, f4, g7, c7, d8, f8)
    End Sub
    Private Sub d6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles d6.Click
        accion(d6, e4, c4, e8, c8, f7, f5, b7, b5)
    End Sub
    Private Sub d7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles d7.Click
        accion(d7, e5, c5, c5, c5, f8, f6, b8, b6)
    End Sub
    Private Sub d8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles d8.Click
        accion(d8, e6, c6, c6, c6, c6, c6, f7, b7)
    End Sub
    Private Sub c6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c6.Click
        accion(c6, b4, d4, b8, d8, a5, a7, e5, e7)
    End Sub
    Private Sub c7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c7.Click
        accion(c7, b5, d5, a6, a8, e6, e8)
    End Sub
    Private Sub c8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles c8.Click
        accion(c8, b6, d6, d6, d6, a7, a7, e7)
    End Sub
    Private Sub b8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b8.Click
        accion(b8, a6, c6, d7)
    End Sub
    Private Sub b7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b7.Click
        accion(b7, a5, c5, d6, d8)
    End Sub
    Private Sub b6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles b6.Click
        accion(b6, a4, c4, d5, d7, c8, a8)
    End Sub
    Private Sub a6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a6.Click
        accion(a6, b4, b8, c5, c7)
    End Sub
    Private Sub a7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a7.Click
        accion(a7, b5, b5, c6, c8)
    End Sub
    Private Sub a8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles a8.Click
        accion(a8, b6, b6, c7)
    End Sub
End Class
