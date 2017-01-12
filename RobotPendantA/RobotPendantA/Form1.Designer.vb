<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PortsListBox = New System.Windows.Forms.ListBox()
        Me.ActiveSerialPort = New System.IO.Ports.SerialPort(Me.components)
        Me.ConnectButton = New System.Windows.Forms.Button()
        Me.DisconnectButton = New System.Windows.Forms.Button()
        Me.RefreshButton = New System.Windows.Forms.Button()
        Me.TestConnectionButton = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.OutputListBox = New System.Windows.Forms.ListBox()
        Me.ClawButton = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TestConnectionButton)
        Me.GroupBox1.Controls.Add(Me.RefreshButton)
        Me.GroupBox1.Controls.Add(Me.DisconnectButton)
        Me.GroupBox1.Controls.Add(Me.ConnectButton)
        Me.GroupBox1.Controls.Add(Me.PortsListBox)
        Me.GroupBox1.Location = New System.Drawing.Point(7, 5)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(206, 520)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Serial"
        '
        'PortsListBox
        '
        Me.PortsListBox.FormattingEnabled = True
        Me.PortsListBox.Location = New System.Drawing.Point(6, 19)
        Me.PortsListBox.Name = "PortsListBox"
        Me.PortsListBox.Size = New System.Drawing.Size(194, 108)
        Me.PortsListBox.TabIndex = 0
        '
        'ConnectButton
        '
        Me.ConnectButton.Location = New System.Drawing.Point(9, 171)
        Me.ConnectButton.Name = "ConnectButton"
        Me.ConnectButton.Size = New System.Drawing.Size(191, 42)
        Me.ConnectButton.TabIndex = 1
        Me.ConnectButton.Text = "Connect"
        Me.ConnectButton.UseVisualStyleBackColor = True
        '
        'DisconnectButton
        '
        Me.DisconnectButton.Location = New System.Drawing.Point(9, 264)
        Me.DisconnectButton.Name = "DisconnectButton"
        Me.DisconnectButton.Size = New System.Drawing.Size(191, 22)
        Me.DisconnectButton.TabIndex = 2
        Me.DisconnectButton.Text = "Disconnect"
        Me.DisconnectButton.UseVisualStyleBackColor = True
        '
        'RefreshButton
        '
        Me.RefreshButton.Location = New System.Drawing.Point(9, 133)
        Me.RefreshButton.Name = "RefreshButton"
        Me.RefreshButton.Size = New System.Drawing.Size(191, 22)
        Me.RefreshButton.TabIndex = 3
        Me.RefreshButton.Text = "Refresh"
        Me.RefreshButton.UseVisualStyleBackColor = True
        '
        'TestConnectionButton
        '
        Me.TestConnectionButton.Location = New System.Drawing.Point(9, 219)
        Me.TestConnectionButton.Name = "TestConnectionButton"
        Me.TestConnectionButton.Size = New System.Drawing.Size(191, 22)
        Me.TestConnectionButton.TabIndex = 4
        Me.TestConnectionButton.Text = "Send Test"
        Me.TestConnectionButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.OutputListBox)
        Me.GroupBox2.Location = New System.Drawing.Point(219, 315)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(480, 210)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "EEPROM Output"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button6)
        Me.GroupBox3.Controls.Add(Me.Button7)
        Me.GroupBox3.Controls.Add(Me.Button4)
        Me.GroupBox3.Controls.Add(Me.Button5)
        Me.GroupBox3.Controls.Add(Me.Button2)
        Me.GroupBox3.Controls.Add(Me.Button3)
        Me.GroupBox3.Controls.Add(Me.Button1)
        Me.GroupBox3.Controls.Add(Me.ClawButton)
        Me.GroupBox3.Location = New System.Drawing.Point(219, 5)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(479, 301)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Manual Controls/Teaching"
        '
        'OutputListBox
        '
        Me.OutputListBox.FormattingEnabled = True
        Me.OutputListBox.Location = New System.Drawing.Point(6, 19)
        Me.OutputListBox.MultiColumn = True
        Me.OutputListBox.Name = "OutputListBox"
        Me.OutputListBox.Size = New System.Drawing.Size(463, 173)
        Me.OutputListBox.TabIndex = 0
        '
        'ClawButton
        '
        Me.ClawButton.Location = New System.Drawing.Point(382, 35)
        Me.ClawButton.Name = "ClawButton"
        Me.ClawButton.Size = New System.Drawing.Size(73, 64)
        Me.ClawButton.TabIndex = 5
        Me.ClawButton.Text = "Open/Close Effector"
        Me.ClawButton.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(382, 222)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 64)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Save Current to EEPROM"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(213, 185)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(48, 40)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "<<"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(281, 185)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 40)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = ">>"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(281, 72)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(48, 40)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = ">>"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(213, 72)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(48, 40)
        Me.Button5.TabIndex = 10
        Me.Button5.Text = "<<"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(281, 129)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(48, 40)
        Me.Button6.TabIndex = 13
        Me.Button6.Text = ">>"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(213, 129)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(48, 40)
        Me.Button7.TabIndex = 12
        Me.Button7.Text = "<<"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(716, 537)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Robot Arm A - Serial Teaching Pendant"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TestConnectionButton As Button
    Friend WithEvents RefreshButton As Button
    Friend WithEvents DisconnectButton As Button
    Friend WithEvents ConnectButton As Button
    Friend WithEvents PortsListBox As ListBox
    Friend WithEvents ActiveSerialPort As IO.Ports.SerialPort
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents OutputListBox As ListBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents ClawButton As Button
End Class
