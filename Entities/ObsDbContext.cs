using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Scaffolding.Internal;

namespace OBSC.Entities;

public partial class ObsDbContext : DbContext
{
    public ObsDbContext()
    {
    }

    public ObsDbContext(DbContextOptions<ObsDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdminTb> AdminTbs { get; set; }

    public virtual DbSet<AnnounceTb> AnnounceTbs { get; set; }

    public virtual DbSet<ArrivalTb> ArrivalTbs { get; set; }

    public virtual DbSet<BookTb> BookTbs { get; set; }

    public virtual DbSet<BusStamby> BusStambies { get; set; }

    public virtual DbSet<DepartureTb> DepartureTbs { get; set; }

    public virtual DbSet<LostTb> LostTbs { get; set; }

    public virtual DbSet<MainTb> MainTbs { get; set; }

    public virtual DbSet<ManagementTb> ManagementTbs { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=localhost;database=obs_db;user=root", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.4.28-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<AdminTb>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("admin_tb");

            entity.Property(e => e.Id)
                .HasColumnType("int(50)")
                .HasColumnName("id");
            entity.Property(e => e.Password)
                .HasMaxLength(50)
                .HasColumnName("password");
            entity.Property(e => e.Username)
                .HasMaxLength(50)
                .HasColumnName("username");
        });

        modelBuilder.Entity<AnnounceTb>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("announce_tb");

            entity.Property(e => e.Id)
                .HasColumnType("int(50)")
                .HasColumnName("id");
            entity.Property(e => e.Content)
                .HasMaxLength(1000)
                .HasColumnName("content");
            entity.Property(e => e.Date)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp(6)")
                .HasColumnType("timestamp(6)")
                .HasColumnName("date");
            entity.Property(e => e.Title)
                .HasMaxLength(1000)
                .HasColumnName("title");
        });

        modelBuilder.Entity<ArrivalTb>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("arrival_tb");

            entity.Property(e => e.Id)
                .HasColumnType("int(50)")
                .HasColumnName("id");
            entity.Property(e => e.BusNo)
                .HasColumnType("int(100)")
                .HasColumnName("bus_no");
            entity.Property(e => e.DeparturedTime)
                .HasMaxLength(100)
                .HasColumnName("departured_time");
            entity.Property(e => e.RouteDestination)
                .HasMaxLength(100)
                .HasColumnName("route_destination");
            entity.Property(e => e.Unit)
                .HasMaxLength(100)
                .HasColumnName("unit");
        });

        modelBuilder.Entity<BookTb>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("book_tb");

            entity.Property(e => e.Id)
                .HasColumnType("int(10)")
                .HasColumnName("id");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.RouteDestination)
                .HasMaxLength(50)
                .HasColumnName("route_destination");
            entity.Property(e => e.Unit)
                .HasMaxLength(50)
                .HasColumnName("unit");
        });

        modelBuilder.Entity<BusStamby>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("bus_stamby");

            entity.Property(e => e.Id)
                .HasColumnType("int(100)")
                .HasColumnName("id");
            entity.Property(e => e.BusNo)
                .HasColumnType("int(100)")
                .HasColumnName("bus_no");
            entity.Property(e => e.ConductorsName)
                .HasMaxLength(100)
                .HasColumnName("conductors_name");
            entity.Property(e => e.CorNumber)
                .HasColumnType("int(100)")
                .HasColumnName("cor_number");
            entity.Property(e => e.DepartureTime)
                .HasMaxLength(100)
                .HasColumnName("departure_time");
            entity.Property(e => e.DriversName)
                .HasMaxLength(100)
                .HasColumnName("drivers_name");
            entity.Property(e => e.RouteDestination)
                .HasMaxLength(100)
                .HasColumnName("route_destination");
            entity.Property(e => e.Unit)
                .HasMaxLength(100)
                .HasColumnName("unit");
        });

        modelBuilder.Entity<DepartureTb>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("departure_tb");

            entity.Property(e => e.Id)
                .HasColumnType("int(50)")
                .HasColumnName("id");
            entity.Property(e => e.BusNo)
                .HasColumnType("int(50)")
                .HasColumnName("bus_no");
            entity.Property(e => e.ConductorsName)
                .HasMaxLength(50)
                .HasColumnName("conductors_name");
            entity.Property(e => e.DriversName)
                .HasMaxLength(50)
                .HasColumnName("drivers_name");
            entity.Property(e => e.Passenger)
                .HasColumnType("int(50)")
                .HasColumnName("passenger");
            entity.Property(e => e.RouteDestination)
                .HasMaxLength(50)
                .HasColumnName("route_destination");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.TimeDept)
                .HasMaxLength(50)
                .HasColumnName("time_dept");
            entity.Property(e => e.Unit)
                .HasMaxLength(50)
                .HasColumnName("unit");
        });

        modelBuilder.Entity<LostTb>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("lost_tb");

            entity.Property(e => e.Id)
                .HasColumnType("int(50)")
                .HasColumnName("id");
            entity.Property(e => e.BusNo)
                .HasColumnType("int(50)")
                .HasColumnName("bus_no");
            entity.Property(e => e.ConductorsName)
                .HasMaxLength(100)
                .HasColumnName("conductors_name");
            entity.Property(e => e.Date)
                .ValueGeneratedOnAddOrUpdate()
                .HasDefaultValueSql("current_timestamp(6)")
                .HasColumnType("timestamp(6)")
                .HasColumnName("date");
            entity.Property(e => e.DriversName)
                .HasMaxLength(100)
                .HasColumnName("drivers_name");
            entity.Property(e => e.Item)
                .HasMaxLength(100)
                .HasColumnName("item");
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .HasColumnName("status");
            entity.Property(e => e.TicketNo)
                .HasColumnType("int(50)")
                .HasColumnName("ticket_no");
        });

        modelBuilder.Entity<MainTb>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("main_tb");

            entity.Property(e => e.Id)
                .HasColumnType("int(100)")
                .HasColumnName("id");
            entity.Property(e => e.BaggTicket)
                .HasColumnType("int(100)")
                .HasColumnName("bagg_ticket");
            entity.Property(e => e.BusNo)
                .HasColumnType("int(100)")
                .HasColumnName("bus_no");
            entity.Property(e => e.ConductorsName)
                .HasMaxLength(100)
                .HasColumnName("conductors_name");
            entity.Property(e => e.CorNumber)
                .HasColumnType("int(100)")
                .HasColumnName("cor_number");
            entity.Property(e => e.Date).HasColumnName("date");
            entity.Property(e => e.DriversName)
                .HasMaxLength(100)
                .HasColumnName("drivers_name");
            entity.Property(e => e.PassTicket)
                .HasColumnType("int(100)")
                .HasColumnName("pass_ticket");
            entity.Property(e => e.Passenger)
                .HasColumnType("int(100)")
                .HasColumnName("passenger");
            entity.Property(e => e.RouteDestination)
                .HasMaxLength(100)
                .HasColumnName("route_destination");
            entity.Property(e => e.TimeDept)
                .HasMaxLength(100)
                .HasColumnName("time_dept");
            entity.Property(e => e.Unit)
                .HasMaxLength(100)
                .HasColumnName("unit");
        });

        modelBuilder.Entity<ManagementTb>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("management_tb");

            entity.Property(e => e.Id)
                .HasColumnType("int(50)")
                .HasColumnName("id");
            entity.Property(e => e.BaggTicket)
                .HasColumnType("int(50)")
                .HasColumnName("bagg_ticket");
            entity.Property(e => e.BusNo)
                .HasColumnType("int(50)")
                .HasColumnName("bus_no");
            entity.Property(e => e.ConductorsName)
                .HasMaxLength(50)
                .HasColumnName("conductors_name");
            entity.Property(e => e.CorNumber)
                .HasColumnType("int(50)")
                .HasColumnName("cor_number");
            entity.Property(e => e.DriversName)
                .HasMaxLength(50)
                .HasColumnName("drivers_name");
            entity.Property(e => e.PassTicket)
                .HasColumnType("int(50)")
                .HasColumnName("pass_ticket");
            entity.Property(e => e.Passenger)
                .HasColumnType("int(50)")
                .HasColumnName("passenger");
            entity.Property(e => e.RouteDestination)
                .HasMaxLength(50)
                .HasColumnName("route_destination");
            entity.Property(e => e.TimeDept)
                .HasMaxLength(50)
                .HasColumnName("time_dept");
            entity.Property(e => e.Unit)
                .HasMaxLength(50)
                .HasColumnName("unit");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
