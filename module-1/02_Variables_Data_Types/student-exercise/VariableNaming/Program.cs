using System;

namespace VariableNaming
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            1. 4 birds are sitting on a branch. 1 flies away. How many birds are left on
            the branch?
            */

            // ### EXAMPLE:
            int initialNumberOfBirds = 4;
            int birdsThatFlewAway = 1;
            int remainingNumberOfBirds = initialNumberOfBirds - birdsThatFlewAway;

            /*
            2. There are 6 birds and 3 nests. How many more birds are there than
            nests?
            */

            // ### EXAMPLE:
            int numberOfBirds = 6;
            int numberOfNests = 3;
            int numberOfExtraBirds = numberOfBirds - numberOfNests;



            /*
            3. 3 raccoons are playing in the woods. 2 go home to eat dinner. How
            many raccoons are left in the woods?
            */
            int woodsRaccoons = 3;
            int dinnerRaccoons = 2;
            int raccoonsLeft = woodsRaccoons - dinnerRaccoons;
            Console.WriteLine(raccoonsLeft);
            /*
            4. There are 5 flowers and 3 bees. How many less bees than flowers?
            */
            int flowers = 5;
            int bees = 3;
            int fewerBees = flowers - bees;
            Console.WriteLine(fewerBees);
            /*
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now?
            */
            int lonelyPigeon = 1;
            int anotherPigeon = 1;
            int totalPigeons = lonelyPigeon + anotherPigeon;
            Console.WriteLine(totalPigeons);
            /*
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now?
            */
            int originalOwls = 3;
            int moreOwls = 2;
            int totalOwls = originalOwls + moreOwls;
            Console.WriteLine(totalOwls);
            /*
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home?
            */
            int workBeavers = 2;
            int swimBeavers = 1;
            int stillWorkingBeavers = workBeavers - swimBeavers;
            Console.WriteLine(stillWorkingBeavers);
            /*
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all?
            */
            int origToucans = 2;
            int moreToucans = 1;
            int totalToucans = origToucans + moreToucans;
            Console.WriteLine(totalToucans);

            /*
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts?
            */
            int squirrels = 4;
            int nuts = 2;
            int moreSquirrels = squirrels - nuts;
            Console.WriteLine(moreSquirrels);
            /*
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find?
            */
            decimal quarter = .25M;
            decimal dime = .1M;
            decimal nickels = .05M * 2;
            decimal moneyFound = quarter + dime + nickels;
            Console.WriteLine(moneyFound + "cents");

            /*
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all?
            */
            int brierMuffins = 18;
            int macadamsMuffins = 20;
            int flanneryMuffins = 17;
            int firstGradeMuffins = brierMuffins + macadamsMuffins + flanneryMuffins;
            Console.WriteLine(firstGradeMuffins);
            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */
            decimal yoyo = .24M;
            decimal whistle = .14M;
            decimal toyTotal = yoyo + whistle;
            Console.WriteLine(toyTotal);
            /*
            13. Mrs. Hilt made 5 Rice Krispie Treats. She used 8 large marshmallows
            and 10 mini marshmallows.How many marshmallows did she use
            altogether?
            */
        
            int largeMarsh = 8;
            int miniMarsh = 10;
            int totalMarsh = largeMarsh + miniMarsh;
            Console.WriteLine(totalMarsh);
            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */
            int hiltSnow = 29;
            int schoolSnow = 17;
            int moreSnow = hiltSnow - schoolSnow;
            Console.WriteLine(moreSnow);
            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */
            decimal startMoney = 10M;
            decimal toyTruck = 3M;
            decimal pencilCase = 2M;
            decimal moneyLeft = startMoney - toyTruck - pencilCase;
            Console.WriteLine("$" + moneyLeft);
            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */
            int startMarbles = 16;
            int lostMarbles = 7;
            int leftMarbles = startMarbles - lostMarbles;
            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */
            int startShells = 19;
            int howManyMoreShells = 25 - startShells;
            Console.WriteLine(howManyMoreShells);
            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */
            int totalBalloons = 17;
            int redBalloons = 8;
            int greenBalloons = totalBalloons - redBalloons;
            Console.WriteLine(greenBalloons);
            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */
            int startBooks = 38;
            int moreBooks = 10;
            int totalBooks = startBooks + moreBooks;
            Console.WriteLine(totalBooks);
            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */
            int eachBeeLegs = 6;
            int manyBeesLegs = 8 * eachBeeLegs;
            Console.WriteLine(manyBeesLegs);
            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */
            decimal iceCream = .99M;
            decimal moreIceCream = iceCream * 2;
            Console.WriteLine("$" + moreIceCream);
            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */
            int currentRocks = 64;
            int moreRocks = 125 - currentRocks;
            Console.WriteLine(moreRocks);
            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */
            int startingMarbles = 38;
            int hiltLostMarbles = 15;
            int marblesLeft = startingMarbles - hiltLostMarbles;
            Console.WriteLine(marblesLeft);
            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */
            int concertMiles = 78;
            int drivenSoFar = 32;
            int milesLeft = concertMiles - drivenSoFar;
            Console.WriteLine(milesLeft);
            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time did she spend shoveling snow?
            */
            int mornShovel = 90;
            int afterNoonShovel = 45;
            int totalShovel = mornShovel + afterNoonShovel;
            Console.WriteLine(totalShovel + " minutes");
            /*
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */
            int hiltHotDogs = 6;
            decimal hotDogCost = .5M;
            decimal hotDogTotal = hiltHotDogs * hotDogCost;
            Console.WriteLine(hotDogTotal);
            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */
            int hiltMoney = 50;
            int pencilCost = 7;
            int totalPencils = hiltMoney / pencilCost;
            Console.WriteLine(totalPencils);
            /*
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */
            int butterflyTotal = 33;
            int orangeButterflies = 20;
            int redButterflies = butterflyTotal - orangeButterflies;
            Console.WriteLine(redButterflies);
            /*
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */
            decimal clerkMoney = 1.00M;
            decimal candyCost = .54M;
            decimal kateChange = clerkMoney - candyCost;
            Console.WriteLine(kateChange);

            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */
            int backTrees = 13;
            int moreTrees = 12;
            int totalTrees = backTrees + moreTrees;
            Console.WriteLine(totalTrees);
            /*
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */
            int daysTilGrandma = 2;
            const int hrsInaDay = 24;
            int hrsTilGrandma = hrsInaDay * daysTilGrandma;
            Console.WriteLine(hrsTilGrandma);
            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */
            const int cousins = 4;
            int gumPerCousin = 5;
            int totalGumNeeded = cousins * gumPerCousin;
            Console.WriteLine(totalGumNeeded);
            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */
            decimal dansMoney = 3.00M;
            decimal candyBarCost = 1.00M;
            decimal moneyLeftOver = dansMoney - candyBarCost;
            Console.WriteLine(moneyLeftOver);
            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */
            int boats = 5;
            int peoplePerBoat = 3;
            int totalPeople = boats * peoplePerBoat;
            Console.WriteLine(totalPeople);
            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */
            int totalLegos = 308;
            int lostLegos = 57;
            int leftLegos = totalLegos - lostLegos;
            Console.WriteLine(leftLegos);
            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */
            int bakedMuffins = 35;
            int muffinsNeeded = 83;
            int muffinsLeftToBake = muffinsNeeded - bakedMuffins;
            Console.WriteLine(muffinsLeftToBake);
            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */
            int willyCrayons = 1400;
            int lucyCrayons = 290;
            int moreCrayons = willyCrayons - lucyCrayons;
            Console.WriteLine(moreCrayons);
            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */
            int stickersPerPage = 10;
            int pages = 22;
            int totalStickers = stickersPerPage * pages;
            Console.WriteLine(totalStickers);
            /*
            39. There are 96 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */
            int cupCakes = 96;
            int children = 8;
            int cupcakesEach = cupCakes / children;
            Console.WriteLine(cupcakesEach);
            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies each, how many
            cookies will not be placed in a jar?
            */
            int gingerbreadCookies = 47;
            int cookiesPerJar = 6;
            int remainderCookies = gingerbreadCookies % cookiesPerJar;
            Console.WriteLine(remainderCookies);
            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received and equal number of croissants,
            how many will be left with Marian?
            */
            int croissantTotal = 59;
            int numberOfNeighbors = 8;
            int leftOverCroissants = croissantTotal % numberOfNeighbors;
            Console.WriteLine(leftOverCroissants);
            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */
            int oatmealCookiesNeeded = 276;
            int cookiesOnSheet = 12;
            int numberOfTrays = oatmealCookiesNeeded / cookiesOnSheet;
            Console.WriteLine(numberOfTrays);
            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */
            int pretzelTotal = 480;
            int pretzelServing = 12;
            int servingsPrepared = pretzelTotal / pretzelServing;
            Console.WriteLine(servingsPrepared);
            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */
            int orphanageCupcakes = 53-2;
            int cupcakesPerBox = 3;
            int boxesTotal = orphanageCupcakes / cupcakesPerBox;
            Console.WriteLine(boxesTotal);

            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */
            int carrotSticks = 74;
            int people = 12;
            int carrotSticksLeft = carrotSticks % people;
            Console.WriteLine(carrotSticksLeft);
            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */
            int teddyBears = 98;
            int shelfCapacity = 7;
            int numberOfShelves = teddyBears / shelfCapacity;
            Console.WriteLine(numberOfShelves);
            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */
            int picturesTotal = 480;
            int picturesPerAlbum = 20;
            int albumsNeeded = picturesTotal / picturesPerAlbum;
            Console.WriteLine(albumsNeeded);
            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */
            int tradingCards = 94;
            int cardsPerBox = 8;
            int boxesFilled = tradingCards / cardsPerBox;
            int unfilledBoxCards = tradingCards % cardsPerBox;
            Console.WriteLine(boxesFilled);
            Console.WriteLine(unfilledBoxCards);


            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */
            int booksInReadingRoom = 210;
            int shelves = 10;
            int booksPerShelf = booksInReadingRoom / shelves;
            Console.WriteLine(booksPerShelf);
            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */
            int croissantsChristina = 17;
            int numberOfGuests = 7;
            int howManyCroissantsEach = croissantsChristina / numberOfGuests;
            Console.WriteLine(howManyCroissantsEach);
            /*
                CHALLENGE PROBLEMS
            */

            /*
            Bill and Jill are house painters. Bill can paint a 12 x 14 room in 2.15 hours, while Jill averages
            1.90 hours. How long will it take the two painter working together to paint 5 12 x 14 rooms?
            Hint: Calculate the hourly rate for each painter, combine them, and then divide the total walls in feet by the combined hourly rate of the painters.
            Challenge: How many days will it take the pair to paint 623 rooms assuming they work 8 hours a day?.
            */
            int linearFeetPerRoom=(12+14)*2;
            double averageFeetPerHourBill = linearFeetPerRoom / 2.15;
            double averageFeetPerHourJill = linearFeetPerRoom / 1.90;
            double combinedFeetPerHour = averageFeetPerHourBill + averageFeetPerHourJill;
            int numberOfRooms = 5;
            int totalLinearFeet = numberOfRooms * linearFeetPerRoom;
            double timeToPaintFiveRooms = totalLinearFeet * numberOfRooms;



            /*
            Create and assign variables to hold your first name, last name, and middle initial. Using concatenation,
            build an additional variable to hold your full name in the order of last name, first name, middle initial. The
            last and first names should be separated by a comma followed by a space, and the middle initial must end
            with a period.
            Example: "Hopper, Grace B."
            */

            /*
            The distance between New York and Chicago is 800 miles, and the train has already travelled 537 miles.
            What percentage of the trip has been completed?
            Hint: The percent completed is the miles already travelled divided by the total miles.
            Challenge: Display as an integer value between 0 and 100 using casts.
            */

        }
    }
}
