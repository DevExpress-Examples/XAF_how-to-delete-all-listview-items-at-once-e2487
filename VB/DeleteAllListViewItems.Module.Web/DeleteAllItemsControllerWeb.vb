Imports Microsoft.VisualBasic
Imports System
Imports System.ComponentModel
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Text

Imports DevExpress.ExpressApp
Imports DevExpress.ExpressApp.Actions
Imports DevExpress.Persistent.Base
Imports System.Collections
Imports DevExpress.ExpressApp.Web.Editors.ASPx
Imports DevExpress.Data.Filtering

Namespace DeleteAllListViewItems.Module
	Partial Public Class DeleteAllItemsController
		Inherits ViewController
		Public Sub New()
			InitializeComponent()
			RegisterActions(components)
			Me.TargetViewType = ViewType.ListView
		End Sub


		Protected Overrides Sub OnActivated()
			MyBase.OnActivated()
			UpdateActionState()
			AddHandler View.SelectionChanged, AddressOf ObjectChanged
			AddHandler View.CurrentObjectChanged, AddressOf ObjectChanged
		End Sub

		Private Sub ObjectChanged(ByVal sender As Object, ByVal e As EventArgs)
			UpdateActionState()
		End Sub


		Private Sub UpdateActionState()
			Dim type As Type = (CType(View, ListView)).ObjectTypeInfo.Type
			Me.simpleAction1.Enabled.SetItemValue("ItemsCount", View.ObjectSpace.GetObjects(type).Count > 0)
		End Sub


		Private Sub simpleAction1_Execute(ByVal sender As Object, ByVal e As SimpleActionExecuteEventArgs) Handles simpleAction1.Execute
			Dim listEditor As ASPxGridListEditor = TryCast((CType(View, ListView)).Editor, ASPxGridListEditor)
			If listEditor IsNot Nothing Then

				Using objectSpace As IObjectSpace = Application.CreateObjectSpace()
					Dim objectsToDelete As New ArrayList()
					Dim type As Type = (CType(View, ListView)).ObjectTypeInfo.Type
					objectsToDelete.AddRange(objectSpace.GetObjects(type, CriteriaOperator.Parse(listEditor.Grid.FilterExpression)))
					objectSpace.Delete(objectsToDelete)
					objectSpace.CommitChanges()
				End Using
				ObjectSpace.Refresh()
				UpdateActionState()
			End If
		End Sub
	End Class
End Namespace
