using MongoDB.Bson;
using MediaList.Data.Infrastructure;
using MediaList.Data.Models;

namespace MediaList.Data.SeedData;

public static class Seed
{
    public static async Task DoSeedAsync(MediaListDbContext context)
    {
        var genreCount = await context.Genres.CountDocumentsAsync(new BsonDocument());
        var mediaTypeCount = await context.MediaTypes.CountDocumentsAsync(new BsonDocument());
        var mangaCount = await context.Mangas.CountDocumentsAsync(new BsonDocument());

        if (genreCount == 0)
        {
            Genre[] genres = new Genre[]
{
            new() {Id="1",Name="Action",Description="Action"}, new() {Id="2",Name="Adventure",Description="Adventure"}, new() {Id="3",Name="Comedy",Description="Comedy"}, new() {Id="4",Name="Drama",Description="Drama"}, new() {Id="5",Name="Slice of Life",Description="Slice of Life"}, new() {Id="6",Name="Fantasy",Description="Fantasy"}, new() {Id="7",Name="Magic",Description="Magic"}, new() {Id="8",Name="Supernatural",Description="Supernatural"}, new() {Id="9",Name="Horror",Description="Horror"}, new() {Id="10",Name="Mystery",Description="Mystery"}, new() {Id="11",Name="Psychological",Description="Psychological"}, new() {Id="12",Name="Romance",Description="Romance"}, new() {Id="13",Name="Sci-Fi",Description="Sci-Fi"}, new() {Id="14",Name="Cyberpunk",Description="Cyberpunk"}, new() {Id="15",Name="Game",Description="Game"}, new() {Id="16",Name="Ecchi",Description="Ecchi"}, new() {Id="17",Name="Demons",Description="Demons"}, new() {Id="18",Name="Harem",Description="Harem"}, new() {Id="19",Name="Josei",Description="Josei"}, new() {Id="20",Name="Martial Arts",Description="Martial Arts"}, new() {Id="21",Name="Kids",Description="Kids"}, new() {Id="22",Name="Historical",Description="Historical"}, new() {Id="23",Name="Hentai",Description="Hentai"}, new() {Id="24",Name="Isekai",Description="Isekai"}, new() {Id="25",Name="Military",Description="Military"}, new() {Id="26",Name="Mecha",Description="Mecha"}, new() {Id="27",Name="Music",Description="Music"}, new() {Id="28",Name="Parody",Description="Parody"}, new() {Id="29",Name="Police",Description="Police"}, new() {Id="30",Name="Post-Apocalyptic",Description="Post-Apocalyptic"}, new() {Id="31",Name="Reverse Harem",Description="Reverse Harem"}, new() {Id="32",Name="School",Description="School"}, new() {Id="33",Name="Seinen",Description="Seinen"}, new() {Id="34",Name="Shoujo",Description="Shoujo"}, new() {Id="35",Name="Shoujo-ai",Description="Shoujo-ai"}, new() {Id="36",Name="Shounen",Description="Shounen"}, new() {Id="37",Name="Shounen-ai",Description="Shounen-ai"}, new() {Id="38",Name="Space",Description="Space"}, new() {Id="39",Name="Sports",Description="Sports"}, new() {Id="40",Name="Super Power",Description="Super Power"}, new() {Id="41",Name="Tragedy",Description="Tragedy"}, new() {Id="42",Name="Vampire",Description="Vampire"}, new() {Id="43",Name="Yuri",Description="Yuri"}, new() {Id="44",Name="Yaoi",Description="Yaoi"}
};

            await context.Genres.InsertManyAsync(genres);
        }

        if (mediaTypeCount == 0)
        {
            MediaType[] mediaTypes = new MediaType[]
            {
                new() {Id="1",Name="Anime",Description="Anime"}, new() {Id="2",Name="Commercial Radio",Description="Commercial Radio"}, new() {Id="3",Name="Film",Description="Film"}, new() {Id="4",Name="Magazine",Description="Magazine"}, new() {Id="5",Name="Manga",Description="Manga"}, new() {Id="6",Name="Manhua",Description="Manhua"}, new() {Id="7",Name="Manhwa",Description="Manhwa"}, new() {Id="8",Name="Music",Description="Music"}, new() {Id="9",Name="Newspaper",Description="Newspaper"}, new() {Id="10",Name="Novel",Description="Novel"}, new() {Id="11",Name="Public Broadcasting",Description="Public Broadcasting"}, new() {Id="12",Name="Television",Description="Television"}
            };

            await context.MediaTypes.InsertManyAsync(mediaTypes);
        }

        if (mangaCount == 0)
        {
            var mangasToAdd = new Manga[] {
                new() {Name="tsuki ga michibuki",Description="tsuki ga michibuki",Type="5",Chapters=77,LastChapterRead=77}
                , new() {Name="The Beginning After The End",Description="The Beginning After The End",Type="5",Chapters=159,LastChapterRead=159}
                , new() {Name="taming master",Description="taming master",Type="5",Chapters=52,LastChapterRead=52}
                , new() {Name="The gamer",Description="The gamer",Type="5",Chapters=377,LastChapterRead=377}
                , new() {Name="the unwanted undead adventurer",Description="the unwanted undead adventurer",Type="5",Chapters=34,LastChapterRead=34}
                , new() {Name="Gaikotsu Kishi-sama",Description="Gaikotsu Kishi-sama",Type="5",Chapters=42,LastChapterRead=42}
                , new() {Name="Parallel Paradise",Description="Parallel Paradise",Type="5",Chapters=159,LastChapterRead=159}
                , new() {Name="The Cursed Sword Master’s Harem Life By the Sword, For the Sword, Cursed Sword Master",Description="The Cursed Sword Master’s Harem Life By the Sword, For the Sword, Cursed Sword Master",Type="5",Chapters=14,LastChapterRead=14}
                , new() {Name="Back to Rule Again",Description="Back to Rule Again",Type="5",Chapters=146,LastChapterRead=146}
                , new() {Name="Kubo-san Doesn't Leave Me Be",Description="Kubo-san Doesn't Leave Me Be",Type="5",Chapters=79,LastChapterRead=79}
                , new() {Name="The Eminence in Shadow ",Description="The Eminence in Shadow ",Type="5",Chapters=31,LastChapterRead=31}
                , new() {Name="Sono Mono. Nochi ni... ~Kigatsuitara S-kyuu Saikyou!? Yuusha Wazu no Daibouken~ ",Description="Sono Mono. Nochi ni... ~Kigatsuitara S-kyuu Saikyou!? Yuusha Wazu no Daibouken~ ",Type="5",Chapters=27,LastChapterRead=27}
                , new() {Name="The World's Best Assassin, Reincarnated in a Different World as an Aristocrat",Description="The World's Best Assassin, Reincarnated in a Different World as an Aristocrat",Type="5",Chapters=14,LastChapterRead=14}
             };

            await context.Mangas.InsertManyAsync(mangasToAdd);
        }
    }
}
