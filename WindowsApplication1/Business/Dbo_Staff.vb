Public Class Dbo_Staff

    Private m_name As String
    Private m_address As String
    Private m_gender As String
    Private m_dob As Date
    Private m_dobnep As String
    Private m_post As String
    Private m_emptype As String
    Private m_sertype As String
    Private m_appdate As Date
    Private m_appdatenep As String
    Private m_serduration As Int16
    Private m_retdate As Date
    Private m_retdatenep As String
    Private m_leavetype As String
    Private m_department As String
    Private m_training As String
    Private m_status As Boolean
    Private m_collegeid As Int32
    Private m_promotion As String
    Private m_qualification As String

    Public Property MCollegeid() As Integer
        Get
            Return m_collegeid
        End Get
        Set (ByVal value As Integer)
            m_collegeid = value
        End Set
    End Property

    Public Property MName() As String
        Get
            Return m_name
        End Get
        Set (ByVal value As String)
            m_name = value
        End Set
    End Property

    Public Property MAddress() As String
        Get
            Return m_address
        End Get
        Set (ByVal value As String)
            m_address = value
        End Set
    End Property

    Public Property MGender() As String
        Get
            Return m_gender
        End Get
        Set (ByVal value As String)
            m_gender = value
        End Set
    End Property

    Public Property MDob() As Date
        Get
            Return m_dob
        End Get
        Set (ByVal value As Date)
            m_dob = value
        End Set
    End Property

    Public Property MDobnep() As String
        Get
            Return m_dobnep
        End Get
        Set (ByVal value As String)
            m_dobnep = value
        End Set
    End Property

    Public Property MPost() As String
        Get
            Return m_post
        End Get
        Set (ByVal value As String)
            m_post = value
        End Set
    End Property

    Public Property MEmptype() As String
        Get
            Return m_emptype
        End Get
        Set (ByVal value As String)
            m_emptype = value
        End Set
    End Property

    Public Property MSertype() As String
        Get
            Return m_sertype
        End Get
        Set (ByVal value As String)
            m_sertype = value
        End Set
    End Property

    Public Property MAppdate() As Date
        Get
            Return m_appdate
        End Get
        Set (ByVal value As Date)
            m_appdate = value
        End Set
    End Property

    Public Property MAppdatenep() As String
        Get
            Return m_appdatenep
        End Get
        Set (ByVal value As String)
            m_appdatenep = value
        End Set
    End Property

    Public Property MSerduration() As Short
        Get
            Return m_serduration
        End Get
        Set (ByVal value As Short)
            m_serduration = value
        End Set
    End Property

    Public Property MRetdate() As Date
        Get
            Return m_retdate
        End Get
        Set (ByVal value As Date)
            m_retdate = value
        End Set
    End Property

    Public Property MRetdatenep() As String
        Get
            Return m_retdatenep
        End Get
        Set (ByVal value As String)
            m_retdatenep = value
        End Set
    End Property

    Public Property MLeavetype() As String
        Get
            Return m_leavetype
        End Get
        Set (ByVal value As String)
            m_leavetype = value
        End Set
    End Property

    Public Property MDepartment() As String
        Get
            Return m_department
        End Get
        Set (ByVal value As String)
            m_department = value
        End Set
    End Property

    Public Property MTraining() As String
        Get
            Return m_training
        End Get
        Set (ByVal value As String)
            m_training = value
        End Set
    End Property

    Public Property MStatus() As Boolean
        Get
            Return m_status
        End Get
        Set (ByVal value As Boolean)
            m_status = value
        End Set
    End Property

    Public Property MPromotion() As String
        Get
            Return m_promotion
        End Get
        Set(ByVal value As String)
            m_promotion = value
        End Set
    End Property

    Public Property MQualification() As String
        Get
            Return m_qualification
        End Get
        Set(ByVal value As String)
            m_qualification = value
        End Set
    End Property
End Class
