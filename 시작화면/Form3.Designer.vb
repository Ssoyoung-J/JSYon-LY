<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
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
        Me.lblAbout01 = New System.Windows.Forms.Label()
        Me.lblAbout02 = New System.Windows.Forms.Label()
        Me.lblAbout03 = New System.Windows.Forms.Label()
        Me.lblAbout04 = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAbout01
        '
        Me.lblAbout01.AutoSize = True
        Me.lblAbout01.Location = New System.Drawing.Point(12, 32)
        Me.lblAbout01.Name = "lblAbout01"
        Me.lblAbout01.Size = New System.Drawing.Size(90, 12)
        Me.lblAbout01.TabIndex = 0
        Me.lblAbout01.Text = "VB.NET 메모장"
        '
        'lblAbout02
        '
        Me.lblAbout02.AutoSize = True
        Me.lblAbout02.Location = New System.Drawing.Point(12, 69)
        Me.lblAbout02.Name = "lblAbout02"
        Me.lblAbout02.Size = New System.Drawing.Size(189, 12)
        Me.lblAbout02.TabIndex = 1
        Me.lblAbout02.Text = "이 제품은 다음 사용자에게 허가됨"
        '
        'lblAbout03
        '
        Me.lblAbout03.AutoSize = True
        Me.lblAbout03.Location = New System.Drawing.Point(12, 109)
        Me.lblAbout03.Name = "lblAbout03"
        Me.lblAbout03.Size = New System.Drawing.Size(77, 12)
        Me.lblAbout03.TabIndex = 2
        Me.lblAbout03.Text = "사용자 이름 :"
        '
        'lblAbout04
        '
        Me.lblAbout04.AutoSize = True
        Me.lblAbout04.Location = New System.Drawing.Point(12, 154)
        Me.lblAbout04.Name = "lblAbout04"
        Me.lblAbout04.Size = New System.Drawing.Size(77, 12)
        Me.lblAbout04.TabIndex = 3
        Me.lblAbout04.Text = "컴퓨터 이름 :"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(170, 198)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(75, 23)
        Me.btnClose.TabIndex = 4
        Me.btnClose.Text = "확 인"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(257, 233)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.lblAbout04)
        Me.Controls.Add(Me.lblAbout03)
        Me.Controls.Add(Me.lblAbout02)
        Me.Controls.Add(Me.lblAbout01)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Form3"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "메모장 정보"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblAbout01 As System.Windows.Forms.Label
    Friend WithEvents lblAbout02 As System.Windows.Forms.Label
    Friend WithEvents lblAbout03 As System.Windows.Forms.Label
    Friend WithEvents lblAbout04 As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
