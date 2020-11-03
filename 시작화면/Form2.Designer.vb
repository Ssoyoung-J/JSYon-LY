<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.lblWord = New System.Windows.Forms.Label()
        Me.txtWord = New System.Windows.Forms.TextBox()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.chb = New System.Windows.Forms.CheckBox()
        Me.groupBox = New System.Windows.Forms.GroupBox()
        Me.rdb01 = New System.Windows.Forms.RadioButton()
        Me.rdb02 = New System.Windows.Forms.RadioButton()
        Me.groupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblWord
        '
        Me.lblWord.AutoSize = True
        Me.lblWord.Location = New System.Drawing.Point(30, 21)
        Me.lblWord.Name = "lblWord"
        Me.lblWord.Size = New System.Drawing.Size(57, 12)
        Me.lblWord.TabIndex = 0
        Me.lblWord.Text = "찾을 내용"
        '
        'txtWord
        '
        Me.txtWord.Location = New System.Drawing.Point(110, 18)
        Me.txtWord.Name = "txtWord"
        Me.txtWord.Size = New System.Drawing.Size(372, 21)
        Me.txtWord.TabIndex = 1
        '
        'btnOk
        '
        Me.btnOk.Location = New System.Drawing.Point(500, 16)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(116, 23)
        Me.btnOk.TabIndex = 2
        Me.btnOk.Text = "다음 찾기"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(500, 71)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(116, 23)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "취소"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'chb
        '
        Me.chb.AutoSize = True
        Me.chb.Location = New System.Drawing.Point(32, 58)
        Me.chb.Name = "chb"
        Me.chb.Size = New System.Drawing.Size(106, 16)
        Me.chb.TabIndex = 4
        Me.chb.Text = "대/소문자 구문"
        Me.chb.UseVisualStyleBackColor = True
        '
        'groupBox
        '
        Me.groupBox.Controls.Add(Me.rdb01)
        Me.groupBox.Controls.Add(Me.rdb02)
        Me.groupBox.Location = New System.Drawing.Point(144, 58)
        Me.groupBox.Name = "groupBox"
        Me.groupBox.Size = New System.Drawing.Size(338, 69)
        Me.groupBox.TabIndex = 5
        Me.groupBox.TabStop = False
        Me.groupBox.Text = "방향"
        '
        'rdb01
        '
        Me.rdb01.AutoSize = True
        Me.rdb01.Location = New System.Drawing.Point(30, 32)
        Me.rdb01.Name = "rdb01"
        Me.rdb01.Size = New System.Drawing.Size(47, 16)
        Me.rdb01.TabIndex = 0
        Me.rdb01.TabStop = True
        Me.rdb01.Text = "위쪽"
        Me.rdb01.UseVisualStyleBackColor = True
        '
        'rdb02
        '
        Me.rdb02.AutoSize = True
        Me.rdb02.Location = New System.Drawing.Point(188, 32)
        Me.rdb02.Name = "rdb02"
        Me.rdb02.Size = New System.Drawing.Size(59, 16)
        Me.rdb02.TabIndex = 1
        Me.rdb02.TabStop = True
        Me.rdb02.Text = "아래쪽"
        Me.rdb02.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 149)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.chb)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.groupBox)
        Me.Controls.Add(Me.txtWord)
        Me.Controls.Add(Me.lblWord)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.Text = "찾 기"
        Me.TopMost = True
        Me.groupBox.ResumeLayout(False)
        Me.groupBox.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblWord As System.Windows.Forms.Label
    Friend WithEvents txtWord As System.Windows.Forms.TextBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents chb As System.Windows.Forms.CheckBox
    Friend WithEvents groupBox As System.Windows.Forms.GroupBox
    Friend WithEvents rdb01 As System.Windows.Forms.RadioButton
    Friend WithEvents rdb02 As System.Windows.Forms.RadioButton
End Class
