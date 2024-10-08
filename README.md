Code First Yaklaşımı ile Veri Tabanı Oluşturma
Entity Framework Core kullanarak Code First yaklaşımıyla bir veri tabanı oluşturdum. Bu veri tabanında, aşağıdaki iki bağımsız veri tablosu bulunuyor.

Movie Tablosu:

Id: int, birincil anahtar ve otomatik artan.

Title: string, filmin başlığı.

Genre: string, filmin türü (örneğin: "Action", "Comedy", "Drama").

ReleaseYear: int, filmin çıkış yılı.

Game Tablosu:

Id: int, birincil anahtar ve otomatik artan.

Name: string, oyunun adı.

Platform: string, oyunun oynandığı platform (örneğin: "PC", "PlayStation", "Xbox").

Rating: decimal, oyunun puanı (0 ile 10 arasında).
