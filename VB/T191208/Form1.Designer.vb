﻿'INSTANT C# NOTE: Formerly VB project-level imports:
Imports System.Collections.Generic
Imports System.Collections
Imports System.Diagnostics
Imports System.Linq
Imports System.Xml.Linq
Imports System.Data
Imports System.Drawing
Imports System.Windows.Forms
Imports System

Imports DevExpress.XtraBars
Imports DevExpress.XtraBars.Controls
Imports System.ComponentModel
Imports System.Text

Namespace T191208
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
            Me.barManager1 = New T191208.MyBarManager(Me.components)
            Me.bar2 = New DevExpress.XtraBars.Bar()
            Me.barSubItem1 = New DevExpress.XtraBars.BarSubItem()
            Me.barButtonItem2 = New DevExpress.XtraBars.BarButtonItem()
            Me.barButtonItem3 = New DevExpress.XtraBars.BarButtonItem()
            Me.bar3 = New DevExpress.XtraBars.Bar()
            Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
            Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
            Me.barButtonItem1 = New DevExpress.XtraBars.BarButtonItem()
            DirectCast(Me.barManager1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' barManager1
            ' 
            Me.barManager1.Bars.AddRange(New DevExpress.XtraBars.Bar() { Me.bar2, Me.bar3})
            Me.barManager1.Categories.AddRange(New DevExpress.XtraBars.BarManagerCategory() { New DevExpress.XtraBars.BarManagerCategory("File", New System.Guid("2c717a34-0916-4ac5-9246-a26b52948d4a"))})
            Me.barManager1.DockControls.Add(Me.barDockControlTop)
            Me.barManager1.DockControls.Add(Me.barDockControlBottom)
            Me.barManager1.DockControls.Add(Me.barDockControlLeft)
            Me.barManager1.DockControls.Add(Me.barDockControlRight)
            Me.barManager1.Form = Me
            Me.barManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() { Me.barSubItem1, Me.barButtonItem2, Me.barButtonItem3, Me.barButtonItem1})
            Me.barManager1.MainMenu = Me.bar2
            Me.barManager1.MaxItemId = 6
            Me.barManager1.StatusBar = Me.bar3
            ' 
            ' bar2
            ' 
            Me.bar2.BarName = "Main menu"
            Me.bar2.DockCol = 0
            Me.bar2.DockRow = 0
            Me.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top
            Me.bar2.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.barSubItem1), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem1) _
            })
            Me.bar2.OptionsBar.MultiLine = True
            Me.bar2.OptionsBar.UseWholeRow = True
            Me.bar2.Text = "Main menu"
            ' 
            ' barSubItem1
            ' 
            Me.barSubItem1.Caption = "Menu"
            Me.barSubItem1.Id = 1
            Me.barSubItem1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() { _
                New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem2), _
                New DevExpress.XtraBars.LinkPersistInfo(Me.barButtonItem3) _
            })
            Me.barSubItem1.Name = "barSubItem1"
            ' 
            ' barButtonItem2
            ' 
            Me.barButtonItem2.Caption = "barButtonItem2"
            Me.barButtonItem2.Id = 2
            Me.barButtonItem2.Name = "barButtonItem2"
            ' 
            ' barButtonItem3
            ' 
            Me.barButtonItem3.Caption = "barButtonItem3"
            Me.barButtonItem3.Id = 3
            Me.barButtonItem3.Name = "barButtonItem3"
            ' 
            ' bar3
            ' 
            Me.bar3.BarName = "Status bar"
            Me.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom
            Me.bar3.DockCol = 0
            Me.bar3.DockRow = 0
            Me.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom
            Me.bar3.OptionsBar.AllowQuickCustomization = False
            Me.bar3.OptionsBar.DrawDragBorder = False
            Me.bar3.OptionsBar.UseWholeRow = True
            Me.bar3.Text = "Status bar"
            ' 
            ' barDockControlTop
            ' 
            Me.barDockControlTop.CausesValidation = False
            Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
            Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
            Me.barDockControlTop.Size = New System.Drawing.Size(632, 40)
            ' 
            ' barDockControlBottom
            ' 
            Me.barDockControlBottom.CausesValidation = False
            Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.barDockControlBottom.Location = New System.Drawing.Point(0, 255)
            Me.barDockControlBottom.Size = New System.Drawing.Size(632, 23)
            ' 
            ' barDockControlLeft
            ' 
            Me.barDockControlLeft.CausesValidation = False
            Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
            Me.barDockControlLeft.Location = New System.Drawing.Point(0, 40)
            Me.barDockControlLeft.Size = New System.Drawing.Size(0, 215)
            ' 
            ' barDockControlRight
            ' 
            Me.barDockControlRight.CausesValidation = False
            Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
            Me.barDockControlRight.Location = New System.Drawing.Point(632, 40)
            Me.barDockControlRight.Size = New System.Drawing.Size(0, 215)
            ' 
            ' barButtonItem1
            ' 
            Me.barButtonItem1.Caption = "barButtonItem1"
            Me.barButtonItem1.Glyph = (DirectCast(resources.GetObject("barButtonItem1.Glyph"), System.Drawing.Image))
            Me.barButtonItem1.Id = 5
            Me.barButtonItem1.Name = "barButtonItem1"
            ' 
            ' Form1
            ' 
            Me.AllowDrop = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(632, 278)
            Me.Controls.Add(Me.barDockControlLeft)
            Me.Controls.Add(Me.barDockControlRight)
            Me.Controls.Add(Me.barDockControlBottom)
            Me.Controls.Add(Me.barDockControlTop)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.barManager1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

#End Region

        'private DevExpress.XtraBars.BarManager barManager1;
        Private barManager1 As MyBarManager
        Private bar2 As DevExpress.XtraBars.Bar
        Private bar3 As DevExpress.XtraBars.Bar
        Private barDockControlTop As DevExpress.XtraBars.BarDockControl
        Private barDockControlBottom As DevExpress.XtraBars.BarDockControl
        Private barDockControlLeft As DevExpress.XtraBars.BarDockControl
        Private barDockControlRight As DevExpress.XtraBars.BarDockControl
        Private barSubItem1 As DevExpress.XtraBars.BarSubItem
        Private barButtonItem2 As DevExpress.XtraBars.BarButtonItem
        Private barButtonItem3 As DevExpress.XtraBars.BarButtonItem
        Private barButtonItem1 As BarButtonItem

    End Class
End Namespace

