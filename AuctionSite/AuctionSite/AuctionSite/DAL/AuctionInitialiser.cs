﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AuctionSite.Models;
using System.Data.Entity;
using System.Data.OleDb;

namespace AuctionSite.DAL
{
    public class AuctionInitialiser : DropCreateDatabaseIfModelChanges<AuctionContext>
    {
        protected override void Seed(AuctionContext context)
        {
            var items = new List<Items>
            {
                new Items { artist = "Marcel Dyf", title = "Bles En Charente", condition = "Perfect", valuation = 15000, startBid = 9000, image1 = "/Content/TEST.jpg" },
                new Items { artist = "Marcel Dyf", title = "Plage Bretonne", condition = "Perfect", valuation = 15000, startBid = 9000},
                new Items { artist = "George Smith", title = "Rural Rustic Idyll", condition = "Good", valuation = 12000, startBid = 4500},
                new Items { artist = "Ronald Ossory Dunlop", title = "Untitled (Townscape)", condition = "Tear in Canvas", valuation = 4000, startBid = 0},
                new Items { artist = "Edward C Williams", title = "A Rustic Idyll", condition = "Slight Staining", valuation = 6000, startBid = 1200},
                new Items { artist = "Attr to Jacob Van Stry", title = "Figures by a Lakeside", condition = "Good", valuation = 10000, startBid = 0},
                new Items { artist = "John F Tennant", title = "An Extensive Landscape", condition = "Good", valuation = 6000, startBid = 1600},
                new Items { artist = "Henry J Yeend-King", title = "Untitled (Landscape w/Stream)", condition = "Good", valuation = 1500, startBid = 650},
                new Items { artist = "Henry J Yeend-King", title = "Untitled (Landscape w/Cottage)", condition = "Restore Frame", valuation = 1500, startBid = 650},
                new Items { artist = "Abraham Hulk Jnr", title = "Untitled (Vase w/Flowers)", condition = "Good", valuation = 600, startBid = 100},
                new Items { artist = "C V Parker", title = "Untitled (Landscape)", condition = "Good", valuation = 400, startBid = 60},
                new Items { artist = "Michael Beddens", title = "Cannock Chase", condition = "Good", valuation = 400, startBid = 60},
                new Items { artist = "Joseph Josiah Dodd", title = "Old London Bridge c.1750", condition = "Scratched Frame", valuation = 1500, startBid = 800},
                new Items { artist = "Unknown", title = "Untitled (Still Life - Flowers)", condition = "Scratch to Surface", valuation = 200, startBid = 40},
                new Items { artist = "Unknown", title = "Untitled (Still Life - Flowers)", condition = "Good", valuation = 200, startBid = 40},
                new Items { artist = "After Van Huysum", title = "Untitled (Still Life - Flowers)", condition = "Good", valuation = 200, startBid = 40},
                new Items { artist = "John Bowles", title = "London Surveyed, 1749", condition = "TBA", valuation = 2500, startBid = 1200},
                new Items { artist = "0", title = "Text for Map", condition = "Good", valuation = 0, startBid = 0},
                new Items { artist = "Victor Pasmore", title = "Points of Contact No 27", condition = "Good", valuation = 1500, startBid = 750},
                new Items { artist = "Victor Pasmore", title = "Green Darkness, 1986", condition = "Good", valuation = 1500, startBid = 750},
                new Items { artist = "Victor Pasmore", title = "Points of Contact No 26", condition = "Cracked Glass", valuation = 1500, startBid = 750},
                new Items { artist = "Franz Karl Opitz", title = "Untitled'72 (Abstract)", condition = "Needs Restretching", valuation = 1000, startBid = 200},
                new Items { artist = "Andre Bourrie", title = "Untitled (Yellow Field)", condition = "Good", valuation = 400, startBid = 180},
                new Items { artist = "Andre Bourrie", title = "Paysage D'Ete", condition = "Chipped Frame", valuation = 400, startBid = 180},
                new Items { artist = "Andre Bourrie", title = "Untitled (Autumn)", condition = "Good", valuation = 400, startBid = 180},
                new Items { artist = "Andre Bourrie", title = "Untitled (Landscape)", condition = "Good", valuation = 400, startBid = 180},
                new Items { artist = "Andre Bourrie", title = "Untitled (House by Lake)", condition = "Good", valuation = 400, startBid = 180},
                new Items { artist = "John Brunsdon", title = "Dorset Coast", condition = "Smashed Glass", valuation = 350, startBid = 60},
                new Items { artist = "Pierre Doutreleau", title = "Untitled - Edn No 29/125", condition = "Good", valuation = 600, startBid = 250},
                new Items { artist = "Pierre Doutreleau", title = "Untitled - Edn No 112/150", condition = "Good", valuation = 600, startBid = 250},
                new Items { artist = "Pierre Doutreleau", title = "Untitled - Edn No 36/150", condition = "Good", valuation = 600, startBid = 250},
                new Items { artist = "Pierre Doutreleau", title = "Untitled - Edn No 54/125", condition = "Good", valuation = 600, startBid = 250},
                new Items { artist = "Derek Hirst", title = "Paradox No V, 1975", condition = "Good", valuation = 450, startBid = 100},
                new Items { artist = "Derek Hirst", title = "Paradox No IV, 1975", condition = "Good", valuation = 450, startBid = 100},
                new Items { artist = "Valerie Thornton", title = "Eton College", condition = "No Glass.", valuation = 400, startBid = 60},
                new Items { artist = "Valerie Thornton", title = "Untitled", condition = "Fair", valuation = 400, startBid = 60},
                new Items { artist = "Victor Vasareley (?)", title = "Untitled", condition = "Cracked Glass", valuation = 200, startBid = 0},
                new Items { artist = "Victor Vasareley (?)", title = "Untitled", condition = "Good", valuation = 200, startBid = 0},
                new Items { artist = "Victor Vasareley (?)", title = "Untitled", condition = "Good", valuation = 200, startBid = 0},
                new Items { artist = "Deneham ?", title = "Untitled (Village Scene)", condition = "Good", valuation = 150, startBid = 25},
                new Items { artist = "Lewis Pinhorn-Wood", title = "Landscape with Reepers", condition = "Chipped Frame", valuation = 1000, startBid = 280},
                new Items { artist = "Unknown", title = "Untitled (Fuji in Blue)", condition = "Good", valuation = 200, startBid = 40},
                new Items { artist = "Unknown", title = "Untitled (Blue Bird & Bamboo)", condition = "Chipped Frame", valuation = 450, startBid = 80},

                new Items { artist = "Unknown", title = "Untitled (Red Flower)", condition = "Good", valuation = 200, startBid = 120},
                new Items { artist = "Unknown", title = "Untitled (Carp)", condition = "Good", valuation = 150, startBid = 10},
                new Items { artist = "Unknown", title = "Untitled (Village Landscape)", condition = "Good", valuation = 150, startBid = 10},
                new Items { artist = "Shindo (?)", title = "Untitled (Mount Fuji)", condition = "Good", valuation = 600, startBid = 320},
                new Items { artist = "Isamu Hirakawa", title = "Untitled (French Street Scene)", condition = "Scratched Frame", valuation = 2000, startBid = 480},
                new Items { artist = "N Sakamoto", title = "Untitled (Notre Dame)", condition = "Good", valuation = 1500, startBid = 320},
                new Items { artist = "Tetsuyaki, 1984", title = "Untitled (Ponte Vecchio)", condition = "Good", valuation = 100, startBid = 5},
                new Items { artist = "Unknown", title = "Untitled  ", condition = "Damaged Frame", valuation = 100, startBid = 5},
                new Items { artist = "Hiroshige", title = "View Of Mt Fuji from M Road", condition = "Damaged Frame", valuation = 300, startBid = 0},
                new Items { artist = "Hiroshi Yoshida", title = "Kinoe, 1930", condition = "Good", valuation = 250, startBid = 0},
                new Items { artist = "Hiroshi Yoshida", title = "Himeji Castle, Evening, 1926", condition = "Slight Foxing", valuation = 250, startBid = 0},
                new Items { artist = "Hiroshi Yoshida", title = "Glittering Sea, 1926", condition = "Good", valuation = 800, startBid = 0},
                new Items { artist = "Hiroshi Yoshida", title = "Bamboo Wood", condition = "Good", valuation = 800, startBid = 0},
                new Items { artist = "Hiroshige", title = "Unknown", condition = "Good", valuation = 600, startBid = 0},
                new Items { artist = "Unknown", title = "Untitled (Tulip)", condition = "Good", valuation = 150, startBid = 20},
                new Items { artist = "Ichirakutei Eisui", title = "Courtesan and Drum", condition = "Good", valuation = 100, startBid = 30},
                new Items { artist = "Unknown", title = "Untitled (Japanese Landscape)", condition = "Good", valuation = 250, startBid = 30},
                new Items { artist = "Fujio Taketani", title = "Untitled", condition = "Good", valuation = 400, startBid = 240},
                new Items { artist = "E Awana (Awata?)", title = "Untitled", condition = "Good", valuation = 250, startBid = 30},
                new Items { artist = "Unknown", title = "Untitled", condition = "Good", valuation = 100, startBid = 10},
                new Items { artist = "Tawaraya Sotatsu", title = "Tale of Ise", condition = "Damaged Frame", valuation = 100, startBid = 10},
                new Items { artist = "Unknown", title = "Untitled", condition = "Good", valuation = 100, startBid = 5},
                new Items { artist = "Charles Penny", title = "Untitled", condition = "Good", valuation = 100, startBid = 10},
                new Items { artist = "Patrick Livingstone", title = "Anemonies", condition = "Good", valuation = 600, startBid = 120},
                new Items { artist = "Buvary (?)", title = "Untitled (Landscape)", condition = "Good", valuation = 300, startBid = 50},
                new Items { artist = "Camelle", title = "Untitled (Lizard)", condition = "Good", valuation = 100, startBid = 10},
                new Items { artist = "Unknown", title = "Untitled", condition = "Good", valuation = 50, startBid = 5},
                new Items { artist = "Richard Davies", title = "Westminster", condition = "Good", valuation = 350, startBid = 20},
                new Items { artist = "Unknown", title = "Untitled", condition = "Good", valuation = 100, startBid = 20},
                new Items { artist = "Unknown", title = "Untitled (Leaves)", condition = "Poor", valuation = 50, startBid = 5},
                new Items { artist = "Laurent", title = "Untitled (Sea)", condition = "Good", valuation = 150, startBid = 10},
                new Items { artist = "Kay Rios (?)", title = "Untitled", condition = "Good", valuation = 0, startBid = 5},
                new Items { artist = "After W A Knell", title = "Steam Frigate Cyclops", condition = "Good", valuation = 180, startBid = 15},
                new Items { artist = "Douglas Adams", title = "War, The Moors", condition = "Scratched Frame", valuation = 220, startBid = 80},
                new Items { artist = "Douglas Adams", title = "Trout Fishing", condition = "Damaged Frame", valuation = 220, startBid = 80},
                new Items { artist = "Douglas Adams", title = "A Tight Line, Connemara", condition = "Scratched Frame", valuation = 220, startBid = 80},
                new Items { artist = "Douglas Adams", title = "Peace, The Moors", condition = "Scratched Frame", valuation = 220, startBid = 80},
                new Items { artist = "Douglas Adams", title = "Rabbit Shooting", condition = "Damaged Frame", valuation = 220, startBid = 80},
                new Items { artist = "James Townshend", title = "Eton College", condition = "Chipped Frame", valuation = 180, startBid = 50},
                new Items { artist = "J H Nixon", title = "Bank of England & Royal Exch", condition = "Good", valuation = 180, startBid = 50},
                new Items { artist = "Robert Gallon", title = "Temple to Waterloo", condition = "Chipped Frame", valuation = 180, startBid = 80},
                new Items { artist = "Unknown", title = "View From Sugar House", condition = "Scratched Frame", valuation = 180, startBid = 50},
                new Items { artist = "Unknown", title = "London Bridge, 1749", condition = "Scratched Frame", valuation = 180, startBid = 50},

                new Items { artist = "Thomas H Shepherd", title = "Regent Street From Piccadilly", condition = "Scratched Frame", valuation = 180, startBid = 50},
                new Items { artist = "Thomas Allom", title = "London Bridge From St Brides", condition = "Slight Foxing", valuation = 180, startBid = 50},
                new Items { artist = "Unknown", title = "View From St Mary's", condition = "Good", valuation = 180, startBid = 50},
                new Items { artist = "Unknown", title = "View Opposite St Bride's", condition = "Scratched Frame", valuation = 180, startBid = 50},
                new Items { artist = "Thomas Abiel Prior", title = "London From Greenwich Park", condition = "Good", valuation = 180, startBid = 50},
                new Items { artist = "Thomas Allom", title = "Hampton Court", condition = "Good", valuation = 180, startBid = 50},
                new Items { artist = "Thomas Allom", title = "The Post Office, St Paul's", condition = "Scratched Frame", valuation = 180, startBid = 50},
                new Items { artist = "Unknown", title = "Untitled (Lambeth Palace)", condition = "Good", valuation = 180, startBid = 50},
                new Items { artist = "J H Nixon", title = "Bank of England", condition = "Good", valuation = 180, startBid = 50},
                new Items { artist = "Thomas Allom", title = "Port of London, 1839", condition = "Foxing", valuation = 180, startBid = 50},
                new Items { artist = "Thomas Allom", title = "London From St Paul's", condition = "Good", valuation = 180, startBid = 50},
                new Items { artist = "George Chambers", title = "City of London", condition = "Good", valuation = 180, startBid = 50},
                new Items { artist = "Thomas Allom", title = "Port of London, 1859", condition = "Foxing", valuation = 180, startBid = 50},
                new Items { artist = "A P Thomas", title = "Royal Exchange", condition = "Fair", valuation = 180, startBid = 50},
                new Items { artist = "Unknown", title = "Isle of Dogs", condition = "Good", valuation = 180, startBid = 50},
                new Items { artist = "G H Andrews", title = "Untitled (View to St Paul's)", condition = "Good", valuation = 180, startBid = 50},
                new Items { artist = "Thomas Allom", title = "New London Bridge", condition = "Good", valuation = 180, startBid = 50},
                new Items { artist = "George Chambers", title = "City of London", condition = "Good", valuation = 180, startBid = 50},
                new Items { artist = "T H Shepherd", title = "The Quadrant, Regent Steet", condition = "Good", valuation = 180, startBid = 50},
                new Items { artist = "After W J Shayer", title = "Drawing Cover", condition = "Stained Paper", valuation = 220, startBid = 80},
                new Items { artist = "After W J Shayer", title = "Full Cry", condition = "Extensive Foxing", valuation = 220, startBid = 80},
                new Items { artist = "After W J Shayer", title = "Gone Away", condition = "Good", valuation = 220, startBid = 80},
                new Items { artist = "After W J Shayer", title = "Dead Beat", condition = "Fair", valuation = 220, startBid = 80},
                new Items { artist = "Harrington Bird", title = "Waiting for the Trainer", condition = "Good", valuation = 200, startBid = 60},
                new Items { artist = "Harrington Bird", title = "The Morning Gallop", condition = "Good", valuation = 200, startBid = 60},
                new Items { artist = "Harrington Bird", title = "Returning Home", condition = "Scratched Frame", valuation = 200, startBid = 60},
                new Items { artist = "Harrington Bird", title = "The Trial", condition = "Good", valuation = 200, startBid = 60},
                new Items { artist = "John Ferneley Snr", title = "Riddlesworth", condition = "Good", valuation = 120, startBid = 10},
                new Items { artist = "George Stubbs", title = "Eclipse", condition = "Good", valuation = 120, startBid = 10},
                new Items { artist = "John Herring Snr", title = "Lottery", condition = "Good", valuation = 120, startBid = 10},
                new Items { artist = "Abraham Cooper", title = "Plenipotentiary", condition = "Good", valuation = 120, startBid = 10},
                new Items { artist = "Anon", title = "South African Deal", condition = "Good", valuation = 0, startBid = 0},
                new Items { artist = "David Langdon", title = "BTMU Cartoon", condition = "Good", valuation = 200, startBid = 0},
                new Items { artist = "Anon", title = "Unknown", condition = "Damaged/Faded", valuation = 0, startBid = 0},
                new Items { artist = "Anon", title = "Certificates", condition = "Good", valuation = 0, startBid = 0},
                new Items { artist = "K Ishibashi", title = "Portrait of a Bank Director", condition = "Needs Restretching", valuation = 0, startBid = 0},
                new Items { artist = "Hohudra, August'20", title = "Untitled", condition = "Poor Frame", valuation = 0, startBid = 0},
                new Items { artist = "0", title = "Kanji Goto", condition = "Good", valuation = 0, startBid = 0},
                new Items { artist = "0", title = "Kunikomo Inaghi", condition = "Good", valuation = 0, startBid = 0},
                new Items { artist = "0", title = "Tomoroni Naruse", condition = "Good", valuation = 0, startBid = 0},
                new Items { artist = "0", title = "Shinichi Yoda", condition = "Good", valuation = 0, startBid = 0},
                new Items { artist = "0", title = "Koei Narusawa", condition = "Good", valuation = 0, startBid = 0},
                new Items { artist = "0", title = "Yasuhiro Okano", condition = "Good", valuation = 0, startBid = 0},
            };
            items.ForEach(a => context.Items.Add(a));
            context.SaveChanges();
            base.Seed(context);            
        }
    }
}