using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AlternatiflerCore
{
    public class GenelNotlar
    {

        // Empty bir uygulama aç
        // uygulamayı deploy etmek için gerekli olan bazı ayarlamalar var bunlar
        // 1- https://docs.microsoft.com/tr-tr/aspnet/core/host-and-deploy/iis/?view=aspnetcore-3.0 adresinden
        // .Net CORE barındıra paketini yükle
        // 2- IIS Server de Ayar Yap normal bir site ekle -> uygulama havuzlarına gel -> siteni bul 
        // sağ tıkla -> temel ayarlar -> açılan pencerede CLR ayarı olarak ->yönetilen kod yok seç işlem tmm
        // startup.cs kısmı önemli çünkü uygulamanın kullanacağı kaynakların star işlemini buradan yapıyoruz
        // eğer gerekli ayarlar olmazsa başlamıyor ya da çalışmıyor 
        // ilk olarak Web Route View-Controller yapısı çalışmak için aşağıdaki koda ihtiyaç duyuyor.
        // public void ConfigureServices(IServiceCollection services)
        // {
        //     services.AddControllersWithViews();
        // }

        // Bir Route yapısı tanımlamak istiyor isen aşağıdaki kodlamaları kullanmalısın
        // app.UseEndpoints(
        //endpoints =>
        //         endpoints.MapControllerRoute(
        //               name: "default",
        //               pattern: "{controller=Default}/{action=Index}/{id?}")
        //     ); 

        // Statick Web Resource ların çalışmasını istiyor isen aşağıdaki kodu kullanmalısınn yoksa ilgili 
        // kaynaları bulamadım diyor. tasarım kayıyor.
        //app.UseStaticFiles();

        // EF Kullanımı da değişmiş, eğer bir ef yüklemek istiyor isen aşağıda verdiğim kodu Package MAnager Console
        // kısmına yazarak db nin gelmesini sağlıyorsun
        // Scaffold-DbContext "Server=.;Database=dbalternatif;Trusted_Connection=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models
        // Kullanım ise ilgili contoroller için yazılan constructor için de i initialize etmelisin

    }
}
