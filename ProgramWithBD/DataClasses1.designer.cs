﻿#pragma warning disable 1591
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProgramWithBD
{
	using System.Data.Linq;
	using System.Data.Linq.Mapping;
	using System.Data;
	using System.Collections.Generic;
	using System.Reflection;
	using System.Linq;
	using System.Linq.Expressions;
	using System.ComponentModel;
	using System;
	
	
	[global::System.Data.Linq.Mapping.DatabaseAttribute(Name="master")]
	public partial class WorkloadsDataContext : System.Data.Linq.DataContext
	{
		
		private static System.Data.Linq.Mapping.MappingSource mappingSource = new AttributeMappingSource();
		
    #region Определения метода расширяемости
    partial void OnCreated();
    partial void InsertGroups(Groups instance);
    partial void UpdateGroups(Groups instance);
    partial void DeleteGroups(Groups instance);
    partial void InsertWorkloads(Workloads instance);
    partial void UpdateWorkloads(Workloads instance);
    partial void DeleteWorkloads(Workloads instance);
    partial void InsertSubjects(Subjects instance);
    partial void UpdateSubjects(Subjects instance);
    partial void DeleteSubjects(Subjects instance);
    partial void InsertTeachers(Teachers instance);
    partial void UpdateTeachers(Teachers instance);
    partial void DeleteTeachers(Teachers instance);
    partial void InsertTeacherWorkloads(TeacherWorkloads instance);
    partial void UpdateTeacherWorkloads(TeacherWorkloads instance);
    partial void DeleteTeacherWorkloads(TeacherWorkloads instance);
    #endregion
		
		public WorkloadsDataContext() : 
				base(global::ProgramWithBD.Properties.Settings.Default.masterConnectionString, mappingSource)
		{
			OnCreated();
		}
		
		public WorkloadsDataContext(string connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WorkloadsDataContext(System.Data.IDbConnection connection) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WorkloadsDataContext(string connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public WorkloadsDataContext(System.Data.IDbConnection connection, System.Data.Linq.Mapping.MappingSource mappingSource) : 
				base(connection, mappingSource)
		{
			OnCreated();
		}
		
		public System.Data.Linq.Table<Groups> Groups
		{
			get
			{
				return this.GetTable<Groups>();
			}
		}
		
		public System.Data.Linq.Table<Workloads> Workloads
		{
			get
			{
				return this.GetTable<Workloads>();
			}
		}
		
		public System.Data.Linq.Table<Subjects> Subjects
		{
			get
			{
				return this.GetTable<Subjects>();
			}
		}
		
		public System.Data.Linq.Table<Teachers> Teachers
		{
			get
			{
				return this.GetTable<Teachers>();
			}
		}
		
		public System.Data.Linq.Table<TeacherWorkloads> TeacherWorkloads
		{
			get
			{
				return this.GetTable<TeacherWorkloads>();
			}
		}
		
		public System.Data.Linq.Table<TeacherWorkloadsView> TeacherWorkloadsView
		{
			get
			{
				return this.GetTable<TeacherWorkloadsView>();
			}
		}
		
		public System.Data.Linq.Table<WorkloadView> WorkloadView
		{
			get
			{
				return this.GetTable<WorkloadView>();
			}
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetAllWorkloadByYear", IsComposable=true)]
		public IQueryable<GetAllWorkloadByYearResult> GetAllWorkloadByYear([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> year)
		{
			return this.CreateMethodCallQuery<GetAllWorkloadByYearResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), year);
		}
		
		[global::System.Data.Linq.Mapping.FunctionAttribute(Name="dbo.GetTeacherWorkload", IsComposable=true)]
		public IQueryable<GetTeacherWorkloadResult> GetTeacherWorkload([global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> tteacherId, [global::System.Data.Linq.Mapping.ParameterAttribute(DbType="Int")] System.Nullable<int> year)
		{
			return this.CreateMethodCallQuery<GetTeacherWorkloadResult>(this, ((MethodInfo)(MethodInfo.GetCurrentMethod())), tteacherId, year);
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Groups")]
	public partial class Groups : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _GroupName;
		
		private EntitySet<Workloads> _Workloads;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnGroupNameChanging(string value);
    partial void OnGroupNameChanged();
    #endregion
		
		public Groups()
		{
			this._Workloads = new EntitySet<Workloads>(new Action<Workloads>(this.attach_Workloads), new Action<Workloads>(this.detach_Workloads));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GroupName", DbType="NVarChar(15) NOT NULL", CanBeNull=false)]
		public string GroupName
		{
			get
			{
				return this._GroupName;
			}
			set
			{
				if ((this._GroupName != value))
				{
					this.OnGroupNameChanging(value);
					this.SendPropertyChanging();
					this._GroupName = value;
					this.SendPropertyChanged("GroupName");
					this.OnGroupNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Groups_Workloads", Storage="_Workloads", ThisKey="Id", OtherKey="GroupId")]
		public EntitySet<Workloads> Workloads
		{
			get
			{
				return this._Workloads;
			}
			set
			{
				this._Workloads.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Workloads(Workloads entity)
		{
			this.SendPropertyChanging();
			entity.Groups = this;
		}
		
		private void detach_Workloads(Workloads entity)
		{
			this.SendPropertyChanging();
			entity.Groups = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Workloads")]
	public partial class Workloads : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _SubjectId;
		
		private int _HoursLectures;
		
		private int _HoursPractice;
		
		private int _GroupId;
		
		private int _WorkloadYear;
		
		private EntitySet<TeacherWorkloads> _TeacherWorkloads;
		
		private EntityRef<Groups> _Groups;
		
		private EntityRef<Subjects> _Subjects;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnSubjectIdChanging(int value);
    partial void OnSubjectIdChanged();
    partial void OnHoursLecturesChanging(int value);
    partial void OnHoursLecturesChanged();
    partial void OnHoursPracticeChanging(int value);
    partial void OnHoursPracticeChanged();
    partial void OnGroupIdChanging(int value);
    partial void OnGroupIdChanged();
    partial void OnWorkloadYearChanging(int value);
    partial void OnWorkloadYearChanged();
    #endregion
		
		public Workloads()
		{
			this._TeacherWorkloads = new EntitySet<TeacherWorkloads>(new Action<TeacherWorkloads>(this.attach_TeacherWorkloads), new Action<TeacherWorkloads>(this.detach_TeacherWorkloads));
			this._Groups = default(EntityRef<Groups>);
			this._Subjects = default(EntityRef<Subjects>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SubjectId", DbType="Int NOT NULL")]
		public int SubjectId
		{
			get
			{
				return this._SubjectId;
			}
			set
			{
				if ((this._SubjectId != value))
				{
					if (this._Subjects.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnSubjectIdChanging(value);
					this.SendPropertyChanging();
					this._SubjectId = value;
					this.SendPropertyChanged("SubjectId");
					this.OnSubjectIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoursLectures", DbType="Int NOT NULL")]
		public int HoursLectures
		{
			get
			{
				return this._HoursLectures;
			}
			set
			{
				if ((this._HoursLectures != value))
				{
					this.OnHoursLecturesChanging(value);
					this.SendPropertyChanging();
					this._HoursLectures = value;
					this.SendPropertyChanged("HoursLectures");
					this.OnHoursLecturesChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoursPractice", DbType="Int NOT NULL")]
		public int HoursPractice
		{
			get
			{
				return this._HoursPractice;
			}
			set
			{
				if ((this._HoursPractice != value))
				{
					this.OnHoursPracticeChanging(value);
					this.SendPropertyChanging();
					this._HoursPractice = value;
					this.SendPropertyChanged("HoursPractice");
					this.OnHoursPracticeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GroupId", DbType="Int NOT NULL")]
		public int GroupId
		{
			get
			{
				return this._GroupId;
			}
			set
			{
				if ((this._GroupId != value))
				{
					if (this._Groups.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnGroupIdChanging(value);
					this.SendPropertyChanging();
					this._GroupId = value;
					this.SendPropertyChanged("GroupId");
					this.OnGroupIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WorkloadYear", DbType="Int NOT NULL")]
		public int WorkloadYear
		{
			get
			{
				return this._WorkloadYear;
			}
			set
			{
				if ((this._WorkloadYear != value))
				{
					this.OnWorkloadYearChanging(value);
					this.SendPropertyChanging();
					this._WorkloadYear = value;
					this.SendPropertyChanged("WorkloadYear");
					this.OnWorkloadYearChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Workloads_TeacherWorkloads", Storage="_TeacherWorkloads", ThisKey="Id", OtherKey="WorkloadId")]
		public EntitySet<TeacherWorkloads> TeacherWorkloads
		{
			get
			{
				return this._TeacherWorkloads;
			}
			set
			{
				this._TeacherWorkloads.Assign(value);
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Groups_Workloads", Storage="_Groups", ThisKey="GroupId", OtherKey="Id", IsForeignKey=true)]
		public Groups Groups
		{
			get
			{
				return this._Groups.Entity;
			}
			set
			{
				Groups previousValue = this._Groups.Entity;
				if (((previousValue != value) 
							|| (this._Groups.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Groups.Entity = null;
						previousValue.Workloads.Remove(this);
					}
					this._Groups.Entity = value;
					if ((value != null))
					{
						value.Workloads.Add(this);
						this._GroupId = value.Id;
					}
					else
					{
						this._GroupId = default(int);
					}
					this.SendPropertyChanged("Groups");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Subjects_Workloads", Storage="_Subjects", ThisKey="SubjectId", OtherKey="Id", IsForeignKey=true)]
		public Subjects Subjects
		{
			get
			{
				return this._Subjects.Entity;
			}
			set
			{
				Subjects previousValue = this._Subjects.Entity;
				if (((previousValue != value) 
							|| (this._Subjects.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Subjects.Entity = null;
						previousValue.Workloads.Remove(this);
					}
					this._Subjects.Entity = value;
					if ((value != null))
					{
						value.Workloads.Add(this);
						this._SubjectId = value.Id;
					}
					else
					{
						this._SubjectId = default(int);
					}
					this.SendPropertyChanged("Subjects");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_TeacherWorkloads(TeacherWorkloads entity)
		{
			this.SendPropertyChanging();
			entity.Workloads = this;
		}
		
		private void detach_TeacherWorkloads(TeacherWorkloads entity)
		{
			this.SendPropertyChanging();
			entity.Workloads = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Subjects")]
	public partial class Subjects : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _SubjectName;
		
		private EntitySet<Workloads> _Workloads;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnSubjectNameChanging(string value);
    partial void OnSubjectNameChanged();
    #endregion
		
		public Subjects()
		{
			this._Workloads = new EntitySet<Workloads>(new Action<Workloads>(this.attach_Workloads), new Action<Workloads>(this.detach_Workloads));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SubjectName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string SubjectName
		{
			get
			{
				return this._SubjectName;
			}
			set
			{
				if ((this._SubjectName != value))
				{
					this.OnSubjectNameChanging(value);
					this.SendPropertyChanging();
					this._SubjectName = value;
					this.SendPropertyChanged("SubjectName");
					this.OnSubjectNameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Subjects_Workloads", Storage="_Workloads", ThisKey="Id", OtherKey="SubjectId")]
		public EntitySet<Workloads> Workloads
		{
			get
			{
				return this._Workloads;
			}
			set
			{
				this._Workloads.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_Workloads(Workloads entity)
		{
			this.SendPropertyChanging();
			entity.Subjects = this;
		}
		
		private void detach_Workloads(Workloads entity)
		{
			this.SendPropertyChanging();
			entity.Subjects = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.Teachers")]
	public partial class Teachers : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private string _Lastname;
		
		private string _Firstname;
		
		private string _Middlename;
		
		private string _Degree;
		
		private string _Post;
		
		private int _Expirience;
		
		private EntitySet<TeacherWorkloads> _TeacherWorkloads;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnLastnameChanging(string value);
    partial void OnLastnameChanged();
    partial void OnFirstnameChanging(string value);
    partial void OnFirstnameChanged();
    partial void OnMiddlenameChanging(string value);
    partial void OnMiddlenameChanged();
    partial void OnDegreeChanging(string value);
    partial void OnDegreeChanged();
    partial void OnPostChanging(string value);
    partial void OnPostChanged();
    partial void OnExpirienceChanging(int value);
    partial void OnExpirienceChanged();
    #endregion
		
		public Teachers()
		{
			this._TeacherWorkloads = new EntitySet<TeacherWorkloads>(new Action<TeacherWorkloads>(this.attach_TeacherWorkloads), new Action<TeacherWorkloads>(this.detach_TeacherWorkloads));
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Lastname", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Lastname
		{
			get
			{
				return this._Lastname;
			}
			set
			{
				if ((this._Lastname != value))
				{
					this.OnLastnameChanging(value);
					this.SendPropertyChanging();
					this._Lastname = value;
					this.SendPropertyChanged("Lastname");
					this.OnLastnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Firstname", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Firstname
		{
			get
			{
				return this._Firstname;
			}
			set
			{
				if ((this._Firstname != value))
				{
					this.OnFirstnameChanging(value);
					this.SendPropertyChanging();
					this._Firstname = value;
					this.SendPropertyChanged("Firstname");
					this.OnFirstnameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Middlename", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Middlename
		{
			get
			{
				return this._Middlename;
			}
			set
			{
				if ((this._Middlename != value))
				{
					this.OnMiddlenameChanging(value);
					this.SendPropertyChanging();
					this._Middlename = value;
					this.SendPropertyChanged("Middlename");
					this.OnMiddlenameChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Degree", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Degree
		{
			get
			{
				return this._Degree;
			}
			set
			{
				if ((this._Degree != value))
				{
					this.OnDegreeChanging(value);
					this.SendPropertyChanging();
					this._Degree = value;
					this.SendPropertyChanged("Degree");
					this.OnDegreeChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Post", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Post
		{
			get
			{
				return this._Post;
			}
			set
			{
				if ((this._Post != value))
				{
					this.OnPostChanging(value);
					this.SendPropertyChanging();
					this._Post = value;
					this.SendPropertyChanged("Post");
					this.OnPostChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Expirience", DbType="Int NOT NULL")]
		public int Expirience
		{
			get
			{
				return this._Expirience;
			}
			set
			{
				if ((this._Expirience != value))
				{
					this.OnExpirienceChanging(value);
					this.SendPropertyChanging();
					this._Expirience = value;
					this.SendPropertyChanged("Expirience");
					this.OnExpirienceChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Teachers_TeacherWorkloads", Storage="_TeacherWorkloads", ThisKey="Id", OtherKey="TeacherId")]
		public EntitySet<TeacherWorkloads> TeacherWorkloads
		{
			get
			{
				return this._TeacherWorkloads;
			}
			set
			{
				this._TeacherWorkloads.Assign(value);
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
		
		private void attach_TeacherWorkloads(TeacherWorkloads entity)
		{
			this.SendPropertyChanging();
			entity.Teachers = this;
		}
		
		private void detach_TeacherWorkloads(TeacherWorkloads entity)
		{
			this.SendPropertyChanging();
			entity.Teachers = null;
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TeacherWorkloads")]
	public partial class TeacherWorkloads : INotifyPropertyChanging, INotifyPropertyChanged
	{
		
		private static PropertyChangingEventArgs emptyChangingEventArgs = new PropertyChangingEventArgs(String.Empty);
		
		private int _Id;
		
		private int _TeacherId;
		
		private int _WorkloadId;
		
		private EntityRef<Teachers> _Teachers;
		
		private EntityRef<Workloads> _Workloads;
		
    #region Определения метода расширяемости
    partial void OnLoaded();
    partial void OnValidate(System.Data.Linq.ChangeAction action);
    partial void OnCreated();
    partial void OnIdChanging(int value);
    partial void OnIdChanged();
    partial void OnTeacherIdChanging(int value);
    partial void OnTeacherIdChanged();
    partial void OnWorkloadIdChanging(int value);
    partial void OnWorkloadIdChanged();
    #endregion
		
		public TeacherWorkloads()
		{
			this._Teachers = default(EntityRef<Teachers>);
			this._Workloads = default(EntityRef<Workloads>);
			OnCreated();
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", AutoSync=AutoSync.OnInsert, DbType="Int NOT NULL IDENTITY", IsPrimaryKey=true, IsDbGenerated=true)]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this.OnIdChanging(value);
					this.SendPropertyChanging();
					this._Id = value;
					this.SendPropertyChanged("Id");
					this.OnIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TeacherId", DbType="Int NOT NULL")]
		public int TeacherId
		{
			get
			{
				return this._TeacherId;
			}
			set
			{
				if ((this._TeacherId != value))
				{
					if (this._Teachers.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnTeacherIdChanging(value);
					this.SendPropertyChanging();
					this._TeacherId = value;
					this.SendPropertyChanged("TeacherId");
					this.OnTeacherIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WorkloadId", DbType="Int NOT NULL")]
		public int WorkloadId
		{
			get
			{
				return this._WorkloadId;
			}
			set
			{
				if ((this._WorkloadId != value))
				{
					if (this._Workloads.HasLoadedOrAssignedValue)
					{
						throw new System.Data.Linq.ForeignKeyReferenceAlreadyHasValueException();
					}
					this.OnWorkloadIdChanging(value);
					this.SendPropertyChanging();
					this._WorkloadId = value;
					this.SendPropertyChanged("WorkloadId");
					this.OnWorkloadIdChanged();
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Teachers_TeacherWorkloads", Storage="_Teachers", ThisKey="TeacherId", OtherKey="Id", IsForeignKey=true)]
		public Teachers Teachers
		{
			get
			{
				return this._Teachers.Entity;
			}
			set
			{
				Teachers previousValue = this._Teachers.Entity;
				if (((previousValue != value) 
							|| (this._Teachers.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Teachers.Entity = null;
						previousValue.TeacherWorkloads.Remove(this);
					}
					this._Teachers.Entity = value;
					if ((value != null))
					{
						value.TeacherWorkloads.Add(this);
						this._TeacherId = value.Id;
					}
					else
					{
						this._TeacherId = default(int);
					}
					this.SendPropertyChanged("Teachers");
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.AssociationAttribute(Name="Workloads_TeacherWorkloads", Storage="_Workloads", ThisKey="WorkloadId", OtherKey="Id", IsForeignKey=true)]
		public Workloads Workloads
		{
			get
			{
				return this._Workloads.Entity;
			}
			set
			{
				Workloads previousValue = this._Workloads.Entity;
				if (((previousValue != value) 
							|| (this._Workloads.HasLoadedOrAssignedValue == false)))
				{
					this.SendPropertyChanging();
					if ((previousValue != null))
					{
						this._Workloads.Entity = null;
						previousValue.TeacherWorkloads.Remove(this);
					}
					this._Workloads.Entity = value;
					if ((value != null))
					{
						value.TeacherWorkloads.Add(this);
						this._WorkloadId = value.Id;
					}
					else
					{
						this._WorkloadId = default(int);
					}
					this.SendPropertyChanged("Workloads");
				}
			}
		}
		
		public event PropertyChangingEventHandler PropertyChanging;
		
		public event PropertyChangedEventHandler PropertyChanged;
		
		protected virtual void SendPropertyChanging()
		{
			if ((this.PropertyChanging != null))
			{
				this.PropertyChanging(this, emptyChangingEventArgs);
			}
		}
		
		protected virtual void SendPropertyChanged(String propertyName)
		{
			if ((this.PropertyChanged != null))
			{
				this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.TeacherWorkloadsView")]
	public partial class TeacherWorkloadsView
	{
		
		private int _Id;
		
		private string _TeacherLastname;
		
		private string _TeacherFirstname;
		
		private string _TeacherMiddlename;
		
		private string _TracherDegree;
		
		private string _TeacherPost;
		
		private int _TeacherExperience;
		
		private string _SubjectName;
		
		private int _WorkloadHoursLectures;
		
		private int _WorkloadHoursPractice;
		
		private int _WorkloadYear;
		
		private string _GroupName;
		
		public TeacherWorkloadsView()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL")]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TeacherLastname", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TeacherLastname
		{
			get
			{
				return this._TeacherLastname;
			}
			set
			{
				if ((this._TeacherLastname != value))
				{
					this._TeacherLastname = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TeacherFirstname", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TeacherFirstname
		{
			get
			{
				return this._TeacherFirstname;
			}
			set
			{
				if ((this._TeacherFirstname != value))
				{
					this._TeacherFirstname = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TeacherMiddlename", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TeacherMiddlename
		{
			get
			{
				return this._TeacherMiddlename;
			}
			set
			{
				if ((this._TeacherMiddlename != value))
				{
					this._TeacherMiddlename = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TracherDegree", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TracherDegree
		{
			get
			{
				return this._TracherDegree;
			}
			set
			{
				if ((this._TracherDegree != value))
				{
					this._TracherDegree = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TeacherPost", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string TeacherPost
		{
			get
			{
				return this._TeacherPost;
			}
			set
			{
				if ((this._TeacherPost != value))
				{
					this._TeacherPost = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_TeacherExperience", DbType="Int NOT NULL")]
		public int TeacherExperience
		{
			get
			{
				return this._TeacherExperience;
			}
			set
			{
				if ((this._TeacherExperience != value))
				{
					this._TeacherExperience = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SubjectName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string SubjectName
		{
			get
			{
				return this._SubjectName;
			}
			set
			{
				if ((this._SubjectName != value))
				{
					this._SubjectName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WorkloadHoursLectures", DbType="Int NOT NULL")]
		public int WorkloadHoursLectures
		{
			get
			{
				return this._WorkloadHoursLectures;
			}
			set
			{
				if ((this._WorkloadHoursLectures != value))
				{
					this._WorkloadHoursLectures = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WorkloadHoursPractice", DbType="Int NOT NULL")]
		public int WorkloadHoursPractice
		{
			get
			{
				return this._WorkloadHoursPractice;
			}
			set
			{
				if ((this._WorkloadHoursPractice != value))
				{
					this._WorkloadHoursPractice = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WorkloadYear", DbType="Int NOT NULL")]
		public int WorkloadYear
		{
			get
			{
				return this._WorkloadYear;
			}
			set
			{
				if ((this._WorkloadYear != value))
				{
					this._WorkloadYear = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GroupName", DbType="NVarChar(15) NOT NULL", CanBeNull=false)]
		public string GroupName
		{
			get
			{
				return this._GroupName;
			}
			set
			{
				if ((this._GroupName != value))
				{
					this._GroupName = value;
				}
			}
		}
	}
	
	[global::System.Data.Linq.Mapping.TableAttribute(Name="dbo.WorkloadView")]
	public partial class WorkloadView
	{
		
		private string _SubjectName;
		
		private int _HoursLectures;
		
		private int _HoursPractice;
		
		private string _GroupName;
		
		private int _WorkloadYear;
		
		private int _Id;
		
		public WorkloadView()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SubjectName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string SubjectName
		{
			get
			{
				return this._SubjectName;
			}
			set
			{
				if ((this._SubjectName != value))
				{
					this._SubjectName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoursLectures", DbType="Int NOT NULL")]
		public int HoursLectures
		{
			get
			{
				return this._HoursLectures;
			}
			set
			{
				if ((this._HoursLectures != value))
				{
					this._HoursLectures = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoursPractice", DbType="Int NOT NULL")]
		public int HoursPractice
		{
			get
			{
				return this._HoursPractice;
			}
			set
			{
				if ((this._HoursPractice != value))
				{
					this._HoursPractice = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GroupName", DbType="NVarChar(15) NOT NULL", CanBeNull=false)]
		public string GroupName
		{
			get
			{
				return this._GroupName;
			}
			set
			{
				if ((this._GroupName != value))
				{
					this._GroupName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_WorkloadYear", DbType="Int NOT NULL")]
		public int WorkloadYear
		{
			get
			{
				return this._WorkloadYear;
			}
			set
			{
				if ((this._WorkloadYear != value))
				{
					this._WorkloadYear = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Id", DbType="Int NOT NULL")]
		public int Id
		{
			get
			{
				return this._Id;
			}
			set
			{
				if ((this._Id != value))
				{
					this._Id = value;
				}
			}
		}
	}
	
	public partial class GetAllWorkloadByYearResult
	{
		
		private string _Lastname;
		
		private string _Firstname;
		
		private string _Middlename;
		
		private string _Post;
		
		private int _Expirience;
		
		private System.Nullable<int> _HoursLections_HoursPractice;
		
		public GetAllWorkloadByYearResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Lastname", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Lastname
		{
			get
			{
				return this._Lastname;
			}
			set
			{
				if ((this._Lastname != value))
				{
					this._Lastname = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Firstname", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Firstname
		{
			get
			{
				return this._Firstname;
			}
			set
			{
				if ((this._Firstname != value))
				{
					this._Firstname = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Middlename", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Middlename
		{
			get
			{
				return this._Middlename;
			}
			set
			{
				if ((this._Middlename != value))
				{
					this._Middlename = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Post", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string Post
		{
			get
			{
				return this._Post;
			}
			set
			{
				if ((this._Post != value))
				{
					this._Post = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Expirience", DbType="Int NOT NULL")]
		public int Expirience
		{
			get
			{
				return this._Expirience;
			}
			set
			{
				if ((this._Expirience != value))
				{
					this._Expirience = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Name="[HoursLections+HoursPractice]", Storage="_HoursLections_HoursPractice", DbType="Int")]
		public System.Nullable<int> HoursLections_HoursPractice
		{
			get
			{
				return this._HoursLections_HoursPractice;
			}
			set
			{
				if ((this._HoursLections_HoursPractice != value))
				{
					this._HoursLections_HoursPractice = value;
				}
			}
		}
	}
	
	public partial class GetTeacherWorkloadResult
	{
		
		private string _SubjectName;
		
		private string _GroupName;
		
		private int _HoursLectures;
		
		private int _HoursPractice;
		
		private System.Nullable<int> _Sum;
		
		public GetTeacherWorkloadResult()
		{
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_SubjectName", DbType="NVarChar(50) NOT NULL", CanBeNull=false)]
		public string SubjectName
		{
			get
			{
				return this._SubjectName;
			}
			set
			{
				if ((this._SubjectName != value))
				{
					this._SubjectName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_GroupName", DbType="NVarChar(15) NOT NULL", CanBeNull=false)]
		public string GroupName
		{
			get
			{
				return this._GroupName;
			}
			set
			{
				if ((this._GroupName != value))
				{
					this._GroupName = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoursLectures", DbType="Int NOT NULL")]
		public int HoursLectures
		{
			get
			{
				return this._HoursLectures;
			}
			set
			{
				if ((this._HoursLectures != value))
				{
					this._HoursLectures = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_HoursPractice", DbType="Int NOT NULL")]
		public int HoursPractice
		{
			get
			{
				return this._HoursPractice;
			}
			set
			{
				if ((this._HoursPractice != value))
				{
					this._HoursPractice = value;
				}
			}
		}
		
		[global::System.Data.Linq.Mapping.ColumnAttribute(Storage="_Sum", DbType="Int")]
		public System.Nullable<int> Sum
		{
			get
			{
				return this._Sum;
			}
			set
			{
				if ((this._Sum != value))
				{
					this._Sum = value;
				}
			}
		}
	}
}
#pragma warning restore 1591