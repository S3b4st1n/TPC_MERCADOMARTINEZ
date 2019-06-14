namespace ClassLibrary1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ScripController : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Actividad",
                c => new
                    {
                        ActividadId = c.Int(nullable: false, identity: true),
                        Fecha = c.String(nullable: false, maxLength: 25),
                        Usuarioid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ActividadId)
                .ForeignKey("dbo.Usuario", t => t.Usuarioid, cascadeDelete: true)
                .Index(t => t.Usuarioid);
            
            CreateTable(
                "dbo.Usuario",
                c => new
                    {
                        Usuarioid = c.Int(nullable: false, identity: true),
                        clave = c.String(nullable: false, maxLength: 50),
                        tipo = c.String(nullable: false, maxLength: 50),
                        nombre = c.String(nullable: false, maxLength: 100),
                        Apellido = c.String(nullable: false, maxLength: 100),
                        Descripcion = c.String(nullable: false, maxLength: 100),
                        tipoDocumento = c.Int(nullable: false),
                        Documento = c.String(nullable: false, maxLength: 100),
                        Direccionid = c.Int(nullable: false),
                        TelefonoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Usuarioid)
                .ForeignKey("dbo.Direccion", t => t.Direccionid, cascadeDelete: true)
                .Index(t => t.Direccionid);
            
            CreateTable(
                "dbo.Direccion",
                c => new
                    {
                        Direccionid = c.Int(nullable: false, identity: true),
                        Provinciaid = c.Int(nullable: false),
                        Localidadid = c.Int(nullable: false),
                        Calle = c.String(nullable: false, maxLength: 50),
                        Altura = c.String(nullable: false, maxLength: 50),
                        Piso = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Direccionid)
                .ForeignKey("dbo.Localidad", t => t.Localidadid, cascadeDelete: true)
                .ForeignKey("dbo.Provincia", t => t.Provinciaid, cascadeDelete: true)
                .Index(t => t.Provinciaid)
                .Index(t => t.Localidadid);
            
            CreateTable(
                "dbo.Localidad",
                c => new
                    {
                        Localidadid = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 100),
                        ProvinciaId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Localidadid);
            
            CreateTable(
                "dbo.Provincia",
                c => new
                    {
                        Provinciaid = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Provinciaid);
            
            CreateTable(
                "dbo.Telefono",
                c => new
                    {
                        Telefonoid = c.Int(nullable: false, identity: true),
                        numeroCasa = c.String(nullable: false, maxLength: 50),
                        numeroCelular = c.String(nullable: false, maxLength: 50),
                        Usuario_Usuarioid = c.Int(),
                        Proveedores_Proveedoresid = c.Int(),
                        Clientes_Clienteid = c.Int(),
                    })
                .PrimaryKey(t => t.Telefonoid)
                .ForeignKey("dbo.Usuario", t => t.Usuario_Usuarioid)
                .ForeignKey("dbo.Proveedores", t => t.Proveedores_Proveedoresid)
                .ForeignKey("dbo.Clientes", t => t.Clientes_Clienteid)
                .Index(t => t.Usuario_Usuarioid)
                .Index(t => t.Proveedores_Proveedoresid)
                .Index(t => t.Clientes_Clienteid);
            
            CreateTable(
                "dbo.Articulos",
                c => new
                    {
                        Articulosid = c.Int(nullable: false, identity: true),
                        Descripcion = c.String(nullable: false, maxLength: 100),
                        precioBruto = c.String(nullable: false, maxLength: 25),
                        precioNeto = c.String(nullable: false, maxLength: 25),
                        porcentajeGanancia = c.Long(nullable: false),
                        MarcaId = c.Int(nullable: false),
                        DepartamentoId = c.Int(nullable: false),
                        ProveedoresId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Articulosid)
                .ForeignKey("dbo.Departamento", t => t.DepartamentoId, cascadeDelete: true)
                .ForeignKey("dbo.Marca", t => t.MarcaId, cascadeDelete: true)
                .ForeignKey("dbo.Proveedores", t => t.ProveedoresId, cascadeDelete: true)
                .Index(t => t.MarcaId)
                .Index(t => t.DepartamentoId)
                .Index(t => t.ProveedoresId);
            
            CreateTable(
                "dbo.Departamento",
                c => new
                    {
                        Departamentoid = c.Int(nullable: false, identity: true),
                        descripcion = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Departamentoid);
            
            CreateTable(
                "dbo.Marca",
                c => new
                    {
                        Marcaid = c.Int(nullable: false, identity: true),
                        descripcion = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.Marcaid);
            
            CreateTable(
                "dbo.Proveedores",
                c => new
                    {
                        Proveedoresid = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false, maxLength: 100),
                        Apellido = c.String(nullable: false, maxLength: 100),
                        Descripcion = c.String(nullable: false, maxLength: 100),
                        tipoDocumento = c.Int(nullable: false),
                        Documento = c.String(nullable: false, maxLength: 100),
                        Direccionid = c.Int(nullable: false),
                        TelefonoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Proveedoresid)
                .ForeignKey("dbo.Direccion", t => t.Direccionid, cascadeDelete: true)
                .Index(t => t.Direccionid);
            
            CreateTable(
                "dbo.Clientes",
                c => new
                    {
                        Clienteid = c.Int(nullable: false, identity: true),
                        nombre = c.String(nullable: false, maxLength: 100),
                        Apellido = c.String(nullable: false, maxLength: 100),
                        Descripcion = c.String(nullable: false, maxLength: 100),
                        tipoDocumento = c.Int(nullable: false),
                        Documento = c.String(nullable: false, maxLength: 100),
                        Direccionid = c.Int(nullable: false),
                        TelefonoId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Clienteid)
                .ForeignKey("dbo.Direccion", t => t.Direccionid, cascadeDelete: true)
                .Index(t => t.Direccionid);
            
            CreateTable(
                "dbo.Stock",
                c => new
                    {
                        StockId = c.Int(nullable: false, identity: true),
                        stockMinimo = c.Int(nullable: false),
                        stock = c.Int(nullable: false),
                        ArticulosId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.StockId)
                .ForeignKey("dbo.Articulos", t => t.ArticulosId, cascadeDelete: true)
                .Index(t => t.ArticulosId);
            
            CreateTable(
                "dbo.ArticulosCompras",
                c => new
                    {
                        Articulos_Articulosid = c.Int(nullable: false),
                        Compras_ActividadId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Articulos_Articulosid, t.Compras_ActividadId })
                .ForeignKey("dbo.Articulos", t => t.Articulos_Articulosid, cascadeDelete: true)
                .ForeignKey("dbo.Compras", t => t.Compras_ActividadId, cascadeDelete: true)
                .Index(t => t.Articulos_Articulosid)
                .Index(t => t.Compras_ActividadId);
            
            CreateTable(
                "dbo.VentasArticulos",
                c => new
                    {
                        Ventas_ActividadId = c.Int(nullable: false),
                        Articulos_Articulosid = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Ventas_ActividadId, t.Articulos_Articulosid })
                .ForeignKey("dbo.Ventas", t => t.Ventas_ActividadId, cascadeDelete: true)
                .ForeignKey("dbo.Articulos", t => t.Articulos_Articulosid, cascadeDelete: true)
                .Index(t => t.Ventas_ActividadId)
                .Index(t => t.Articulos_Articulosid);
            
            CreateTable(
                "dbo.Compras",
                c => new
                    {
                        ActividadId = c.Int(nullable: false),
                        CompraId = c.Int(nullable: false),
                        ArticulosId = c.Int(nullable: false),
                        ProveedoresId = c.Int(nullable: false),
                        estado = c.Int(nullable: false),
                        MontoTotal = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ActividadId)
                .ForeignKey("dbo.Actividad", t => t.ActividadId)
                .ForeignKey("dbo.Proveedores", t => t.ProveedoresId, cascadeDelete: false)
                .Index(t => t.ActividadId)
                .Index(t => t.ProveedoresId);
            
            CreateTable(
                "dbo.Ventas",
                c => new
                    {
                        ActividadId = c.Int(nullable: false),
                        Clientes_Clienteid = c.Int(),
                        Ventasid = c.Int(nullable: false),
                        ArticulosId = c.Int(nullable: false),
                        Clientesid = c.Int(nullable: false),
                        MontoTotal = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ActividadId)
                .ForeignKey("dbo.Actividad", t => t.ActividadId)
                .ForeignKey("dbo.Clientes", t => t.Clientes_Clienteid)
                .Index(t => t.ActividadId)
                .Index(t => t.Clientes_Clienteid);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Ventas", "Clientes_Clienteid", "dbo.Clientes");
            DropForeignKey("dbo.Ventas", "ActividadId", "dbo.Actividad");
            DropForeignKey("dbo.Compras", "ProveedoresId", "dbo.Proveedores");
            DropForeignKey("dbo.Compras", "ActividadId", "dbo.Actividad");
            DropForeignKey("dbo.Stock", "ArticulosId", "dbo.Articulos");
            DropForeignKey("dbo.Telefono", "Clientes_Clienteid", "dbo.Clientes");
            DropForeignKey("dbo.Clientes", "Direccionid", "dbo.Direccion");
            DropForeignKey("dbo.VentasArticulos", "Articulos_Articulosid", "dbo.Articulos");
            DropForeignKey("dbo.VentasArticulos", "Ventas_ActividadId", "dbo.Ventas");
            DropForeignKey("dbo.Articulos", "ProveedoresId", "dbo.Proveedores");
            DropForeignKey("dbo.Telefono", "Proveedores_Proveedoresid", "dbo.Proveedores");
            DropForeignKey("dbo.Proveedores", "Direccionid", "dbo.Direccion");
            DropForeignKey("dbo.Articulos", "MarcaId", "dbo.Marca");
            DropForeignKey("dbo.Articulos", "DepartamentoId", "dbo.Departamento");
            DropForeignKey("dbo.ArticulosCompras", "Compras_ActividadId", "dbo.Compras");
            DropForeignKey("dbo.ArticulosCompras", "Articulos_Articulosid", "dbo.Articulos");
            DropForeignKey("dbo.Actividad", "Usuarioid", "dbo.Usuario");
            DropForeignKey("dbo.Telefono", "Usuario_Usuarioid", "dbo.Usuario");
            DropForeignKey("dbo.Usuario", "Direccionid", "dbo.Direccion");
            DropForeignKey("dbo.Direccion", "Provinciaid", "dbo.Provincia");
            DropForeignKey("dbo.Direccion", "Localidadid", "dbo.Localidad");
            DropIndex("dbo.Ventas", new[] { "Clientes_Clienteid" });
            DropIndex("dbo.Ventas", new[] { "ActividadId" });
            DropIndex("dbo.Compras", new[] { "ProveedoresId" });
            DropIndex("dbo.Compras", new[] { "ActividadId" });
            DropIndex("dbo.VentasArticulos", new[] { "Articulos_Articulosid" });
            DropIndex("dbo.VentasArticulos", new[] { "Ventas_ActividadId" });
            DropIndex("dbo.ArticulosCompras", new[] { "Compras_ActividadId" });
            DropIndex("dbo.ArticulosCompras", new[] { "Articulos_Articulosid" });
            DropIndex("dbo.Stock", new[] { "ArticulosId" });
            DropIndex("dbo.Clientes", new[] { "Direccionid" });
            DropIndex("dbo.Proveedores", new[] { "Direccionid" });
            DropIndex("dbo.Articulos", new[] { "ProveedoresId" });
            DropIndex("dbo.Articulos", new[] { "DepartamentoId" });
            DropIndex("dbo.Articulos", new[] { "MarcaId" });
            DropIndex("dbo.Telefono", new[] { "Clientes_Clienteid" });
            DropIndex("dbo.Telefono", new[] { "Proveedores_Proveedoresid" });
            DropIndex("dbo.Telefono", new[] { "Usuario_Usuarioid" });
            DropIndex("dbo.Direccion", new[] { "Localidadid" });
            DropIndex("dbo.Direccion", new[] { "Provinciaid" });
            DropIndex("dbo.Usuario", new[] { "Direccionid" });
            DropIndex("dbo.Actividad", new[] { "Usuarioid" });
            DropTable("dbo.Ventas");
            DropTable("dbo.Compras");
            DropTable("dbo.VentasArticulos");
            DropTable("dbo.ArticulosCompras");
            DropTable("dbo.Stock");
            DropTable("dbo.Clientes");
            DropTable("dbo.Proveedores");
            DropTable("dbo.Marca");
            DropTable("dbo.Departamento");
            DropTable("dbo.Articulos");
            DropTable("dbo.Telefono");
            DropTable("dbo.Provincia");
            DropTable("dbo.Localidad");
            DropTable("dbo.Direccion");
            DropTable("dbo.Usuario");
            DropTable("dbo.Actividad");
        }
    }
}
