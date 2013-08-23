Public Class Dbo_Appointments
    Private m_CollegeId As Integer
    Private m_Fyear As String
    Private m_Category As String
    Private m_SubCat As String
    Private m_Post As String
    Private m_Subject As String
    Private m_Number As String

    Public Property MCollegeId() As Integer
        Get
            Return m_CollegeId
        End Get
        Set (ByVal value As Integer)
            m_CollegeId = value
        End Set
    End Property

    Public Property MFyear() As String
        Get
            Return m_Fyear
        End Get
        Set (ByVal value As String)
            m_Fyear = value
        End Set
    End Property

    Public Property MCategory() As String
        Get
            Return m_Category
        End Get
        Set (ByVal value As String)
            m_Category = value
        End Set
    End Property

    Public Property MSubCat() As String
        Get
            Return m_SubCat
        End Get
        Set (ByVal value As String)
            m_SubCat = value
        End Set
    End Property

    Public Property MPost() As String
        Get
            Return m_Post
        End Get
        Set (ByVal value As String)
            m_Post = value
        End Set
    End Property

    Public Property MSubject() As String
        Get
            Return m_Subject
        End Get
        Set (ByVal value As String)
            m_Subject = value
        End Set
    End Property

    Public Property MNumber() As String
        Get
            Return m_Number
        End Get
        Set (ByVal value As String)
            m_Number = value
        End Set
    End Property
End Class
