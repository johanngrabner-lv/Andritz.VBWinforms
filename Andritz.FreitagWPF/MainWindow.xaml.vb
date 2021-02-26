Class MainWindow

    Dim vm As New MainWindowViewModel
    Sub New()
        vm.Init()
        Me.DataContext = vm
    End Sub

    Private Sub MenuItem_Click(sender As Object, e As RoutedEventArgs)
        vm.Save()
    End Sub

    Private Sub lstMaschinen_SelectionChanged(sender As Object, e As SelectionChangedEventArgs)

    End Sub
End Class
