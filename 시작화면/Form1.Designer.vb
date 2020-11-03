<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기를 사용하여 수정하지 마십시오.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtNote = New System.Windows.Forms.TextBox()
        Me.menuBar = New System.Windows.Forms.MenuStrip()
        Me.파일ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.새로만들기ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.열기ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.저장ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.다른이름으로저장ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.끝내기ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.편집ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.실행취소ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.잘라내기ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.복사ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.붙여넣기ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.삭제ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.찾기ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.다음찾기ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.모두선택ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.시간날짜ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.서식ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.자동줄바꿈ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.글꼴ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.도움말ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.메모장정보ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ofdFile = New System.Windows.Forms.OpenFileDialog()
        Me.sfdFile = New System.Windows.Forms.SaveFileDialog()
        Me.fdText = New System.Windows.Forms.FontDialog()
        Me.menuBar.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtNote
        '
        Me.txtNote.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtNote.Location = New System.Drawing.Point(0, 24)
        Me.txtNote.Multiline = True
        Me.txtNote.Name = "txtNote"
        Me.txtNote.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtNote.Size = New System.Drawing.Size(306, 301)
        Me.txtNote.TabIndex = 0
        '
        'menuBar
        '
        Me.menuBar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.파일ToolStripMenuItem1, Me.편집ToolStripMenuItem1, Me.서식ToolStripMenuItem2, Me.도움말ToolStripMenuItem3})
        Me.menuBar.Location = New System.Drawing.Point(0, 0)
        Me.menuBar.Name = "menuBar"
        Me.menuBar.Size = New System.Drawing.Size(306, 24)
        Me.menuBar.TabIndex = 1
        Me.menuBar.Text = "MenuStrip1"
        '
        '파일ToolStripMenuItem1
        '
        Me.파일ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.새로만들기ToolStripMenuItem1, Me.열기ToolStripMenuItem1, Me.저장ToolStripMenuItem2, Me.다른이름으로저장ToolStripMenuItem3, Me.ToolStripSeparator1, Me.끝내기ToolStripMenuItem4})
        Me.파일ToolStripMenuItem1.Name = "파일ToolStripMenuItem1"
        Me.파일ToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F), System.Windows.Forms.Keys)
        Me.파일ToolStripMenuItem1.Size = New System.Drawing.Size(57, 20)
        Me.파일ToolStripMenuItem1.Text = "파일(&F)"
        '
        '새로만들기ToolStripMenuItem1
        '
        Me.새로만들기ToolStripMenuItem1.Name = "새로만들기ToolStripMenuItem1"
        Me.새로만들기ToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.새로만들기ToolStripMenuItem1.Size = New System.Drawing.Size(232, 22)
        Me.새로만들기ToolStripMenuItem1.Text = "새로만들기(&N)"
        '
        '열기ToolStripMenuItem1
        '
        Me.열기ToolStripMenuItem1.Name = "열기ToolStripMenuItem1"
        Me.열기ToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.열기ToolStripMenuItem1.Size = New System.Drawing.Size(232, 22)
        Me.열기ToolStripMenuItem1.Text = "열기(&O)"
        '
        '저장ToolStripMenuItem2
        '
        Me.저장ToolStripMenuItem2.Name = "저장ToolStripMenuItem2"
        Me.저장ToolStripMenuItem2.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.저장ToolStripMenuItem2.Size = New System.Drawing.Size(232, 22)
        Me.저장ToolStripMenuItem2.Text = "저장(&S)"
        '
        '다른이름으로저장ToolStripMenuItem3
        '
        Me.다른이름으로저장ToolStripMenuItem3.Name = "다른이름으로저장ToolStripMenuItem3"
        Me.다른이름으로저장ToolStripMenuItem3.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.A), System.Windows.Forms.Keys)
        Me.다른이름으로저장ToolStripMenuItem3.Size = New System.Drawing.Size(232, 22)
        Me.다른이름으로저장ToolStripMenuItem3.Text = "다른 이름으로 저장(&A)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(229, 6)
        '
        '끝내기ToolStripMenuItem4
        '
        Me.끝내기ToolStripMenuItem4.Name = "끝내기ToolStripMenuItem4"
        Me.끝내기ToolStripMenuItem4.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.끝내기ToolStripMenuItem4.Size = New System.Drawing.Size(232, 22)
        Me.끝내기ToolStripMenuItem4.Text = "끝내기(&X)"
        '
        '편집ToolStripMenuItem1
        '
        Me.편집ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.실행취소ToolStripMenuItem1, Me.ToolStripSeparator2, Me.잘라내기ToolStripMenuItem1, Me.복사ToolStripMenuItem2, Me.붙여넣기ToolStripMenuItem3, Me.삭제ToolStripMenuItem4, Me.ToolStripSeparator3, Me.찾기ToolStripMenuItem5, Me.다음찾기ToolStripMenuItem6, Me.ToolStripSeparator4, Me.모두선택ToolStripMenuItem7, Me.시간날짜ToolStripMenuItem8})
        Me.편집ToolStripMenuItem1.Name = "편집ToolStripMenuItem1"
        Me.편집ToolStripMenuItem1.Size = New System.Drawing.Size(57, 20)
        Me.편집ToolStripMenuItem1.Text = "편집(&E)"
        '
        '실행취소ToolStripMenuItem1
        '
        Me.실행취소ToolStripMenuItem1.Name = "실행취소ToolStripMenuItem1"
        Me.실행취소ToolStripMenuItem1.Size = New System.Drawing.Size(144, 22)
        Me.실행취소ToolStripMenuItem1.Text = "실행 취소(&U)"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(141, 6)
        '
        '잘라내기ToolStripMenuItem1
        '
        Me.잘라내기ToolStripMenuItem1.Name = "잘라내기ToolStripMenuItem1"
        Me.잘라내기ToolStripMenuItem1.Size = New System.Drawing.Size(144, 22)
        Me.잘라내기ToolStripMenuItem1.Text = "잘라내기(&T)"
        '
        '복사ToolStripMenuItem2
        '
        Me.복사ToolStripMenuItem2.Name = "복사ToolStripMenuItem2"
        Me.복사ToolStripMenuItem2.Size = New System.Drawing.Size(144, 22)
        Me.복사ToolStripMenuItem2.Text = "복사(&C)"
        '
        '붙여넣기ToolStripMenuItem3
        '
        Me.붙여넣기ToolStripMenuItem3.Name = "붙여넣기ToolStripMenuItem3"
        Me.붙여넣기ToolStripMenuItem3.Size = New System.Drawing.Size(144, 22)
        Me.붙여넣기ToolStripMenuItem3.Text = "붙여넣기(&P)"
        '
        '삭제ToolStripMenuItem4
        '
        Me.삭제ToolStripMenuItem4.Name = "삭제ToolStripMenuItem4"
        Me.삭제ToolStripMenuItem4.Size = New System.Drawing.Size(144, 22)
        Me.삭제ToolStripMenuItem4.Text = "삭제(&L)"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(141, 6)
        '
        '찾기ToolStripMenuItem5
        '
        Me.찾기ToolStripMenuItem5.Name = "찾기ToolStripMenuItem5"
        Me.찾기ToolStripMenuItem5.Size = New System.Drawing.Size(144, 22)
        Me.찾기ToolStripMenuItem5.Text = "찾기(&F)"
        '
        '다음찾기ToolStripMenuItem6
        '
        Me.다음찾기ToolStripMenuItem6.Name = "다음찾기ToolStripMenuItem6"
        Me.다음찾기ToolStripMenuItem6.Size = New System.Drawing.Size(144, 22)
        Me.다음찾기ToolStripMenuItem6.Text = "다음 찾기(&N)"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(141, 6)
        '
        '모두선택ToolStripMenuItem7
        '
        Me.모두선택ToolStripMenuItem7.Name = "모두선택ToolStripMenuItem7"
        Me.모두선택ToolStripMenuItem7.Size = New System.Drawing.Size(144, 22)
        Me.모두선택ToolStripMenuItem7.Text = "모두 선택(&A)"
        '
        '시간날짜ToolStripMenuItem8
        '
        Me.시간날짜ToolStripMenuItem8.Name = "시간날짜ToolStripMenuItem8"
        Me.시간날짜ToolStripMenuItem8.Size = New System.Drawing.Size(144, 22)
        Me.시간날짜ToolStripMenuItem8.Text = "시간/날짜(&D)"
        '
        '서식ToolStripMenuItem2
        '
        Me.서식ToolStripMenuItem2.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.자동줄바꿈ToolStripMenuItem1, Me.글꼴ToolStripMenuItem2})
        Me.서식ToolStripMenuItem2.Name = "서식ToolStripMenuItem2"
        Me.서식ToolStripMenuItem2.Size = New System.Drawing.Size(60, 20)
        Me.서식ToolStripMenuItem2.Text = "서식(&O)"
        '
        '자동줄바꿈ToolStripMenuItem1
        '
        Me.자동줄바꿈ToolStripMenuItem1.Name = "자동줄바꿈ToolStripMenuItem1"
        Me.자동줄바꿈ToolStripMenuItem1.Size = New System.Drawing.Size(161, 22)
        Me.자동줄바꿈ToolStripMenuItem1.Text = "자동 줄 바꿈(&W)"
        '
        '글꼴ToolStripMenuItem2
        '
        Me.글꼴ToolStripMenuItem2.Name = "글꼴ToolStripMenuItem2"
        Me.글꼴ToolStripMenuItem2.Size = New System.Drawing.Size(161, 22)
        Me.글꼴ToolStripMenuItem2.Text = "글꼴(&F)"
        '
        '도움말ToolStripMenuItem3
        '
        Me.도움말ToolStripMenuItem3.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.메모장정보ToolStripMenuItem1})
        Me.도움말ToolStripMenuItem3.Name = "도움말ToolStripMenuItem3"
        Me.도움말ToolStripMenuItem3.Size = New System.Drawing.Size(72, 20)
        Me.도움말ToolStripMenuItem3.Text = "도움말(&H)"
        '
        '메모장정보ToolStripMenuItem1
        '
        Me.메모장정보ToolStripMenuItem1.Name = "메모장정보ToolStripMenuItem1"
        Me.메모장정보ToolStripMenuItem1.Size = New System.Drawing.Size(154, 22)
        Me.메모장정보ToolStripMenuItem1.Text = "메모장 정보(&A)"
        '
        'ofdFile
        '
        Me.ofdFile.FileName = "OpenFileDialog1"
        Me.ofdFile.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일(*.*)|*.*"
        '
        'sfdFile
        '
        Me.sfdFile.FileName = "텍스트"
        Me.sfdFile.Filter = "텍스트 파일(*.txt)|*.txt|모든 파일(*.*)|*.*"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(306, 325)
        Me.Controls.Add(Me.txtNote)
        Me.Controls.Add(Me.menuBar)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.menuBar
        Me.Name = "Form1"
        Me.Text = "제목 없음"
        Me.menuBar.ResumeLayout(False)
        Me.menuBar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtNote As System.Windows.Forms.TextBox
    Friend WithEvents menuBar As System.Windows.Forms.MenuStrip
    Friend WithEvents 파일ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 새로만들기ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 열기ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 저장ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 다른이름으로저장ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 끝내기ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 편집ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 실행취소ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 잘라내기ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 복사ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 붙여넣기ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 삭제ToolStripMenuItem4 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 찾기ToolStripMenuItem5 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 다음찾기ToolStripMenuItem6 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents 모두선택ToolStripMenuItem7 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 시간날짜ToolStripMenuItem8 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 서식ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 자동줄바꿈ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 글꼴ToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 도움말ToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents 메모장정보ToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ofdFile As System.Windows.Forms.OpenFileDialog
    Friend WithEvents sfdFile As System.Windows.Forms.SaveFileDialog
    Friend WithEvents fdText As System.Windows.Forms.FontDialog

End Class
