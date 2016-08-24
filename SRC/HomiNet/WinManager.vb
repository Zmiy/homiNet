Option Strict On
Option Explicit On

Imports System.ComponentModel
Imports System.Threading

Imports System.Runtime.InteropServices

Public Class WinManager
    <DllImport("user32.dll", EntryPoint:="FindWindow", SetLastError:=True)>
    Private Shared Function FindWindowByCaption(zeroOnly As IntPtr, lpWindowName As String) As IntPtr
    End Function

    <DllImport("user32.dll")>
    Private Shared Function PostMessage(hWnd As IntPtr, msg As UInt32, wParam As Integer, lParam As Integer) As Integer
    End Function
    <DllImport("user32.dll")>
    Private Shared Function SetWindowPos(hWnd As IntPtr, hWndInsertAfter As IntPtr, x As Integer, y As Integer, cx As Integer, cy As Integer, uFlag As UInteger) As Boolean
    End Function
    <DllImport("user32.dll", SetLastError:=True, CharSet:=CharSet.Auto)> _
    Private Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal msg As UInt32, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function

    Private Const WM_CLOSE As UInt32 = &H10
    Private Const HWND_TOP As Integer = 0
    Private Const HWND_TOPMOST As Integer = -1
    Private Const SWP_SHOWWINDOW As UInt32 = &H40
    Private Const SWP_NOMOVE As UInt32 = &H2
    Private Const SWP_NOSIZE As UInt32 = &H1
    Public Shared Sub CloseMessageBox(caption As String, ByRef work As BackgroundWorker)
        If IsNothing(work) Then
            Exit Sub
        End If
        Dim isSucceed As Integer
        Dim hWnd As IntPtr = FindWindowByCaption(IntPtr.Zero, caption)
        If (hWnd <> IntPtr.Zero) Then
            'isSucceed = PostMessage(hWnd, WM_CLOSE, 0, 0)
            SendMessage(hWnd, WM_CLOSE, IntPtr.Zero, IntPtr.Zero)
        End If
        If (work.IsBusy) Then
            work.WorkerSupportsCancellation = True
            work.CancelAsync()
        End If
    End Sub
    Public Shared Sub CloseMessageBox(caption As String)
        Dim hWnd As IntPtr = FindWindowByCaption(IntPtr.Zero, caption)
        If (hWnd <> IntPtr.Zero) Then
            PostMessage(hWnd, WM_CLOSE, 0, 0)
        End If
    End Sub
    Public Shared Sub CloseMessageBox(caption As String, ByRef work As Thread)
        Dim hWnd As IntPtr = FindWindowByCaption(IntPtr.Zero, caption)
        If (hWnd <> IntPtr.Zero) Then
            PostMessage(hWnd, WM_CLOSE, 0, 0)
        End If
        If (work.IsAlive) Then
            work.Abort()
        End If
    End Sub
    Public Shared Sub MoveWIndow2TopofZOrder(caption As String)
        Dim hWnd As IntPtr = FindWindowByCaption(IntPtr.Zero, caption)
        If hWnd <> IntPtr.Zero Then
            SetWindowPos(hWnd, CType(HWND_TOPMOST, IntPtr), 0, 0, 0, 0, SWP_NOSIZE Or SWP_NOMOVE Or SWP_SHOWWINDOW)
        End If
    End Sub


End Class


