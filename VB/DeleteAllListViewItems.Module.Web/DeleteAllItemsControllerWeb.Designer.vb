Imports Microsoft.VisualBasic
Imports System
Namespace DeleteAllListViewItems.Module
	Partial Public Class DeleteAllItemsController
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

		#Region "Component Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.simpleAction1 = New DevExpress.ExpressApp.Actions.SimpleAction(Me.components)
			' 
			' simpleAction1
			' 
			Me.simpleAction1.Caption = "Delete All"
			Me.simpleAction1.ConfirmationMessage = "Are you sure to delete all items?"
			Me.simpleAction1.Id = "c2f592a4-01bb-48bd-9f06-dd7ceb3d399c"
			Me.simpleAction1.ImageName = Nothing
			Me.simpleAction1.Shortcut = Nothing
			Me.simpleAction1.Tag = Nothing
			Me.simpleAction1.TargetObjectsCriteria = Nothing
			Me.simpleAction1.TargetViewId = Nothing
			Me.simpleAction1.TargetViewType = DevExpress.ExpressApp.ViewType.ListView
			Me.simpleAction1.ToolTip = Nothing
			Me.simpleAction1.TypeOfView = GetType(DevExpress.ExpressApp.ListView)
'			Me.simpleAction1.Execute += New DevExpress.ExpressApp.Actions.SimpleActionExecuteEventHandler(Me.simpleAction1_Execute);

		End Sub

		#End Region

		Private WithEvents simpleAction1 As DevExpress.ExpressApp.Actions.SimpleAction
	End Class
End Namespace
