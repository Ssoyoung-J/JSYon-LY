Imports System.IO
Public Class Form1
    Private txtNoteChange As Boolean
    Private fWord As String
    Private Sub txtNote_TextChanged(sender As Object, e As EventArgs) Handles txtNote.TextChanged
        Me.txtNoteChange = True
    End Sub

    Private Sub 새로만들기ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 새로만들기ToolStripMenuItem1.Click
        If Me.txtNoteChange = True Then
            Dim dlr As DialogResult
            Dim msg As String = Me.Text + "파일의 내용이 변경되었습니다." & _
                Chr(13) & "변경된 내용을 저장하시겠습니까?"
            dlr = MessageBox.Show(msg, "메모장", _
                                  MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
            If dlr = Windows.Forms.DialogResult.Yes Then
                textSave()
                Me.txtNote.ResetText()
                Me.Text = "제목 없음"
            ElseIf dlr = Windows.Forms.DialogResult.No Then
                Me.txtNote.ResetText()
                Me.Text = "제목 없음"
                Me.txtNoteChange = False
            ElseIf dlr = Windows.Forms.DialogResult.Cancel Then
                Return
            End If
        Else
            Me.txtNote.ResetText()
            Me.Text = "제목 없음"
            Me.txtNoteChange = False
        End If
    End Sub

    Private Sub 열기ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 열기ToolStripMenuItem1.Click
        If Me.txtNoteChange = True Then
            Dim dlr As DialogResult
            Dim msg As String = Me.Text + "파일의 내용이 변경되었습니다." & _
                Chr(13) & "변경된 내용을 저장하시겠습니까?"
            dlr = MessageBox.Show(msg, "메모장", _
                                  MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
            If dlr = Windows.Forms.DialogResult.Yes Then
                textSave()
                textOpen()
            ElseIf dlr = Windows.Forms.DialogResult.No Then
                textOpen()
            ElseIf dlr = Windows.Forms.DialogResult.Cancel Then
                Return
            End If
        Else
            textOpen()
        End If
    End Sub
    Private Sub textSave()
        If Me.Text = "제목 없음" Then
            Dim dlr As DialogResult = Me.sfdFile.ShowDialog()
            If dlr <> Windows.Forms.DialogResult.Cancel Then
                Dim str As String = Me.sfdFile.FileName
                Dim sw As StreamWriter = _
                    New StreamWriter(str, False, System.Text.Encoding.Default)
                sw.Write(Me.txtNote.Text)
                sw.Flush()
                sw.Close()
                Dim f As FileInfo = New FileInfo(str)
                Me.Text = f.Name
                Me.txtNoteChange = False
            End If
        Else
            Dim strt As String = Me.Text
            Dim sw As StreamWriter = _
                New StreamWriter(strt, False, System.Text.Encoding.Default)
            sw.Write(Me.txtNote.Text)
            sw.Flush()
            sw.Close()
            Me.Text = strt
            Me.txtNoteChange = False
        End If
    End Sub
    Private Sub textOpen()
        Dim dr As DialogResult = Me.ofdFile.ShowDialog()
        If dr <> Windows.Forms.DialogResult.Cancel Then
            Dim str As String = Me.ofdFile.FileName
            Dim sr As StreamReader = _
                New StreamReader(str, System.Text.Encoding.Default)
            Me.txtNote.Text = sr.ReadToEnd()
            sr.Close()
            Dim f As FileInfo = New FileInfo(str)
            Me.Text = f.Name
            Me.txtNoteChange = False
        End If
    End Sub
    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        e.Cancel = True
        If Me.txtNoteChange = True Then
            Dim dlr As DialogResult
            Dim msg As String = Me.Text + "파일의 내용이 변경되었습니다." & _
                Chr(13) & "변경된 내용을 저장하시겠습니까?"
            dlr = MessageBox.Show(msg, "메모장", _
                                  MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning)
            If dlr = Windows.Forms.DialogResult.Yes Then
                If Me.Text = "제목 없음" Then
                    Dim dr As DialogResult = Me.sfdFile.ShowDialog()
                    If dr <> Windows.Forms.DialogResult.Cancel Then
                        Dim str As String = Me.sfdFile.FileName
                        Dim sw As StreamWriter = _
                            New StreamWriter(str, False, System.Text.Encoding.Default)
                        sw.Write(Me.txtNote.Text)
                        sw.Flush()
                        sw.Close()
                        Me.txtNoteChange = False
                    End If
                Else
                    Dim str As String = Me.Text
                    Dim sw As StreamWriter = New StreamWriter(str, False, System.Text.Encoding.Default)
                    sw.Write(Me.txtNote.Text)
                    sw.Flush()
                    sw.Close()
                    Me.txtNoteChange = False
                End If
                Me.Dispose()
            ElseIf dlr = Windows.Forms.DialogResult.No Then
                Me.Dispose()
            ElseIf dlr = Windows.Forms.DialogResult.Cancel Then
                Return
            End If
        Else
            Me.Dispose()
        End If
    End Sub

    Private Sub 저장ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles 저장ToolStripMenuItem2.Click
        textSave()
    End Sub

    Private Sub 다른이름으로저장ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles 다른이름으로저장ToolStripMenuItem3.Click
        Dim dr As DialogResult = Me.sfdFile.ShowDialog()
        If dr <> Windows.Forms.DialogResult.Cancel Then
            Dim str As String = Me.sfdFile.FileName
            Dim sw As StreamWriter = _
                New StreamWriter(str, False, System.Text.Encoding.Default)
            sw.Write(Me.txtNote.Text)
            sw.Flush()
            sw.Close()
            Dim f As FileInfo = New FileInfo(str)
            Me.Text = f.Name
            Me.txtNoteChange = False
        End If
    End Sub

    Private Sub 찾기ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles 찾기ToolStripMenuItem5.Click
        If Not (Form2 Is Nothing Or Not Form2.Visible) Then
            Form2.Focus()
            Return
        End If
        If Me.txtNote.SelectionLength = 0 Then
            Form2.txtWord.Text = Me.fWord
        Else
            Form2.txtWord.Text = Me.txtNote.SelectedText
        End If
        AddHandler Form2.btnOk.Click, AddressOf Me.btnOk_Click
        Form2.Show()
    End Sub
    Private Sub btnOk_Click(sender As Object, e As EventArgs)
        Dim updown As Integer = -1
        Dim str As String = Me.txtNote.Text
        Dim findWord As String = Form2.txtWord.Text

        If Form2.chb.Checked = False Then
            str = str.ToUpper()
            findWord = findWord.ToUpper
        End If
        If Form2.rdb01.Checked = True Then
            If Me.txtNote.SelectionStart <> 0 Then
                updown = str.LastIndexOf(findWord, Me.txtNote.SelectionStart - 1)
            End If
        Else
            updown = str.IndexOf(findWord, Me.txtNote.SelectionStart + Me.txtNote.SelectionLength)
        End If
        If updown = -1 Then
            MessageBox.Show("더 이상 찾는 문자열이 없습니다.", "메모장", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        Me.txtNote.Select(updown, findWord.Length)
        fWord = Form2.txtWord.Text
        Me.txtNote.Focus()
        Me.txtNote.ScrollToCaret()
    End Sub

    Private Sub 다음찾기ToolStripMenuItem6_Click(sender As Object, e As EventArgs) Handles 다음찾기ToolStripMenuItem6.Click
        If Not (Form2 Is Nothing Or Not Form2.Visible) Then
            Form2.txtWord.Text = Me.fWord
            Me.btnOk_Click(Me, EventArgs.Empty)
        End If
    End Sub

    Private Sub 시간날짜ToolStripMenuItem8_Click(sender As Object, e As EventArgs) Handles 시간날짜ToolStripMenuItem8.Click
        Dim time As String = DateTime.Now.ToShortTimeString()
        Dim Tdate As String = DateTime.Today.ToShortDateString()
        Me.txtNote.AppendText(time + "/" + Tdate)
    End Sub

    Private Sub 끝내기ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles 끝내기ToolStripMenuItem4.Click
        Me.Close()
    End Sub

    Private Sub 실행취소ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 실행취소ToolStripMenuItem1.Click
        Me.txtNote.Undo()
    End Sub

    Private Sub 잘라내기ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 잘라내기ToolStripMenuItem1.Click
        Me.txtNote.Cut()
    End Sub

    Private Sub 복사ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles 복사ToolStripMenuItem2.Click
        Me.txtNote.Copy()
    End Sub

    Private Sub 붙여넣기ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles 붙여넣기ToolStripMenuItem3.Click
        Me.txtNote.Paste()
    End Sub

    Private Sub 삭제ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles 삭제ToolStripMenuItem4.Click
        Me.txtNote.SelectedText = " "
    End Sub

    Private Sub 모두선택ToolStripMenuItem7_Click(sender As Object, e As EventArgs) Handles 모두선택ToolStripMenuItem7.Click
        Me.txtNote.SelectAll()
    End Sub

    Private Sub 자동줄바꿈ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 자동줄바꿈ToolStripMenuItem1.Click
        Me.txtNote.WordWrap = Not (Me.txtNote.WordWrap)
        Me.자동줄바꿈ToolStripMenuItem1.Checked = Not (Me.새로만들기ToolStripMenuItem1.Checked)
    End Sub

    Private Sub 글꼴ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles 글꼴ToolStripMenuItem2.Click
        If Me.fdText.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then
            Me.txtNote.Font = Me.fdText.Font
        End If

    End Sub

    Private Sub 메모장정보ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles 메모장정보ToolStripMenuItem1.Click
        Form3.ShowDialog()
    End Sub

End Class
