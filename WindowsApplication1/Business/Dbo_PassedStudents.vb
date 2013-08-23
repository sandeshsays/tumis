Public Class Dbo_PassedStudents

    Private m_year As String
    Private m_level As String
    Private m_part As Integer
    Private m_male As Integer
    Private m_female As Integer
    Private m_total As Integer

    Public Property MYear() As String
        Get
            Return m_year
        End Get
        Set (ByVal value As String)
            m_year = value
        End Set
    End Property

    Public Property MLevel() As String
        Get
            Return m_level
        End Get
        Set (ByVal value As String)
            m_level = value
        End Set
    End Property

    Public Property MPart() As Integer
        Get
            Return m_part
        End Get
        Set (ByVal value As Integer)
            m_part = value
        End Set
    End Property

    Public Property MMale() As Integer
        Get
            Return m_male
        End Get
        Set (ByVal value As Integer)
            m_male = value
        End Set
    End Property

    Public Property MFemale() As Integer
        Get
            Return m_female
        End Get
        Set (ByVal value As Integer)
            m_female = value
        End Set
    End Property

    Public Property MTotal() As Integer
        Get
            Return m_total
        End Get
        Set (ByVal value As Integer)
            m_total = value
        End Set
    End Property
End Class
