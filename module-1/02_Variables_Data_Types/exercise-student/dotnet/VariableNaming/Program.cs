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
            int numberOfRaccoonsPlayingInTheWoods = 3;
            int numberOfRaccoonsEatingDinner = 2;
            int numberOfRaccoonsLeftInTheWoods = numberOfRaccoonsPlayingInTheWoods - numberOfRaccoonsEatingDinner;
            /*
            4. There are 5 flowers and 3 bees. How many less bees than flowers?
            */
            int numberOfFlowers = 5;
            int numberOfBees = 3;
            int differenceOfFlowersAndBees = numberOfFlowers - numberOfBees;
            /*
            5. 1 lonely pigeon was eating breadcrumbs. Another pigeon came to eat
            breadcrumbs, too. How many pigeons are eating breadcrumbs now?
            */
            int numberOfPigeonsOriginallyEating = 1;
            int numberOfPigeonsWhoJoined = 1;
            int totalNumberOfPigeonsEating = numberOfPigeonsOriginallyEating + numberOfPigeonsWhoJoined;
            /*
            6. 3 owls were sitting on the fence. 2 more owls joined them. How many
            owls are on the fence now?
            */
            int numberOfOwlsOriginallySitting = 3;
            int numberOfOwlsWhoJoined = 2;
            int totalNumberOfOwlsSitting = numberOfOwlsWhoJoined + numberOfOwlsOriginallySitting;
            /*
            7. 2 beavers were working on their home. 1 went for a swim. How many
            beavers are still working on their home?
            */
            int numberOfBeaversWorkingOnTheirHome = 2;
            int numberOfBeaversWhoWentForASwim = 1;
            int numberOfBeaversStillWorkingOnTheirHome = numberOfBeaversWorkingOnTheirHome - numberOfBeaversWhoWentForASwim;
            /*
            8. 2 toucans are sitting on a tree limb. 1 more toucan joins them. How
            many toucans in all?
            */
            int numberOfToucansOriginallySitting = 2;
            int numberOfToucansWhoJoined = 1;
            int totalNumberOfToucansSitting = numberOfToucansOriginallySitting + numberOfToucansWhoJoined;
            /*
            9. There are 4 squirrels in a tree with 2 nuts. How many more squirrels
            are there than nuts?
            */
            int numberOfSquirrelsInATree = 4;
            int numberOfNuts = 2;
            int numberOfExtraSquirrelsComparedToNuts = numberOfSquirrelsInATree - numberOfNuts;
            /*
            10. Mrs. Hilt found a quarter, 1 dime, and 2 nickels. How much money did
            she find?
            */
            decimal valueOfQuarters = (decimal)0.25;
            decimal valueOfDimes = (decimal)0.10;
            decimal valueOfNickels = (decimal)0.10;
            decimal valueOfMoneyMrsHiltFound = valueOfQuarters + valueOfDimes + valueOfNickels;
            /*
            11. Mrs. Hilt's favorite first grade classes are baking muffins. Mrs. Brier's
            class bakes 18 muffins, Mrs. MacAdams's class bakes 20 muffins, and
            Mrs. Flannery's class bakes 17 muffins. How many muffins does first
            grade bake in all?
            */
            int numberOfMuffinsFromMrsBriersClass = 18;
            int numberOfMuffinsFromMrsMacAdamsClass = 20;
            int numberOfMuffinsFromMrsFlannerysClass = 17;
            int numberOfMuffinsFirstGradeBaked = numberOfMuffinsFromMrsBriersClass + numberOfMuffinsFromMrsMacAdamsClass + numberOfMuffinsFromMrsFlannerysClass;
            /*
            12. Mrs. Hilt bought a yoyo for 24 cents and a whistle for 14 cents. How
            much did she spend in all for the two toys?
            */
            decimal costOfYoyo = (decimal)0.24;
            decimal costOfWhistle = (decimal)0.14;
            decimal costOfYoyoAndWhistle = costOfYoyo + costOfWhistle;
            /*
            13. Mrs. Hilt made 5 Rice Krispie Treats. She used 8 large marshmallows
            and 10 mini marshmallows. How many marshmallows did she use
            altogether?
            */
            int numberOfLargeMarshmallows = 8;
            int numberOfMiniMarshmallows = 10;
            int numberOfTotalMarshmallowsUsed = numberOfLargeMarshmallows + numberOfMiniMarshmallows;
            /*
            14. At Mrs. Hilt's house, there was 29 inches of snow, and Brecknock
            Elementary School received 17 inches of snow. How much more snow
            did Mrs. Hilt's house have?
            */
            int inchesOfSnowAtMrsHiltsHouse = 29;
            int inchesOfSnowAtBrecknockElementarySchool = 17;
            int amountOfSnowMrsHiltHadComparedtoBrecknockElementarySchool = inchesOfSnowAtMrsHiltsHouse - inchesOfSnowAtBrecknockElementarySchool;
            /*
            15. Mrs. Hilt has $10. She spends $3 on a toy truck and $2 on a pencil
            case. How much money does she have left?
            */
            decimal amountMrsHiltOriginallyHad = (decimal)10.00;
            decimal amountMrsHiltSpentOnAToyTruck = (decimal)3.00;
            decimal amountMrsHiltSpentOnAPencilCase = (decimal)2.00;
            decimal amountMrsHiltHasLeft = amountMrsHiltOriginallyHad - (amountMrsHiltSpentOnAToyTruck + amountMrsHiltSpentOnAPencilCase);
            /*
            16. Josh had 16 marbles in his collection. He lost 7 marbles. How many
            marbles does he have now?
            */
            int amountOfMarblesJoshOriginallyHad = 16;
            int amountOfMarblesJoshLost = 7;
            int amountOfMarblesJoshHasNow = amountOfMarblesJoshOriginallyHad - amountOfMarblesJoshLost;
            /*
            17. Megan has 19 seashells. How many more seashells does she need to
            find to have 25 seashells in her collection?
            */
            int amountOfSeashellsMeganHas = 19;
            int amountOfSeashellsMeganNeedsToHave = 25;
            int amountOfSeashellsMeganHasToFind = amountOfSeashellsMeganNeedsToHave - amountOfSeashellsMeganHas;
            /*
            18. Brad has 17 balloons. 8 balloons are red and the rest are green. How
            many green balloons does Brad have?
            */
            int totalNumberOfBalloons = 17;
            int numberOfRedBallons = 8;
            int numberOfGreenBalloons = totalNumberOfBalloons - numberOfRedBallons;
            /*
            19. There are 38 books on the shelf. Marta put 10 more books on the shelf.
            How many books are on the shelf now?
            */
            int originalNumberOfBooksOnShelf = 38;
            int numberOfBooksMartaAdded = 10;
            int numberOfBooksOnShelfAfterMartaAddedSome = originalNumberOfBooksOnShelf + numberOfBooksMartaAdded;
            /*
            20. A bee has 6 legs. How many legs do 8 bees have?
            */
            int numberOfLegsABeeHas = 6;
            int amountOfBees = 8;
            int amountOfLegsEightBeesHave = numberOfLegsABeeHas * amountOfBees;
            /*
            21. Mrs. Hilt bought an ice cream cone for 99 cents. How much would 2 ice
            cream cones cost?
            */
            decimal costOfIceCreamCone = (decimal)0.99;
            int numberOfIceCreamCones = 2;
            decimal costOfTwoIceCreamCones = (decimal)costOfIceCreamCone * numberOfIceCreamCones;
            /*
            22. Mrs. Hilt wants to make a border around her garden. She needs 125
            rocks to complete the border. She has 64 rocks. How many more rocks
            does she need to complete the border?
            */
            int amountOfRocksMrsHiltOriginallyHas = 64;
            int amountOfRocksMrsHiltNeedsAltogether = 125;
            int amountOfRocksMrsHiltNeeds = amountOfRocksMrsHiltNeedsAltogether - amountOfRocksMrsHiltOriginallyHas;
            /*
            23. Mrs. Hilt had 38 marbles. She lost 15 of them. How many marbles does
            she have left?
            */
            int amountOfMarblesMrsHiltOriginallyHad = 38;
            int amountOfMarblesMrsHiltLost = 15;
            int amountOfMarblesMrsHiltHasLeft = amountOfMarblesMrsHiltOriginallyHad - amountOfMarblesMrsHiltLost;
            /*
            24. Mrs. Hilt and her sister drove to a concert 78 miles away. They drove 32
            miles and then stopped for gas. How many miles did they have left to drive?
            */
            int totalAmountOfMilesTheyHaveToDrive = 78;
            int amountOfMilesTheyHaveDrivenSoFar = 32;
            int amountOfMilesTheyHaveLeftToDrive = totalAmountOfMilesTheyHaveToDrive - amountOfMilesTheyHaveDrivenSoFar;
            /*
            25. Mrs. Hilt spent 1 hour and 30 minutes shoveling snow on Saturday
            morning and 45 minutes shoveling snow on Saturday afternoon. How
            much total time (in minutes) did she spend shoveling snow?
            */
            int minutesSheShoveledInTheMorning = 90;
            int minutesSheShoveledInTheAfternoon = 45;
            int totalAmountOfMinutesSheShoveledSnowFor = minutesSheShoveledInTheMorning + minutesSheShoveledInTheAfternoon;
            /*
            26. Mrs. Hilt bought 6 hot dogs. Each hot dog cost 50 cents. How much
            money did she pay for all of the hot dogs?
            */
            decimal amountOfHotDogsMrsHiltBought = 6.0M;
            decimal costOfOneHotDog = 0.5M;
            decimal costOfSixHotDogs = amountOfHotDogsMrsHiltBought * costOfOneHotDog;

            /*
            27. Mrs. Hilt has 50 cents. A pencil costs 7 cents. How many pencils can
            she buy with the money she has?
            */
            decimal hilt = 0.5M;
            decimal costOfPencil = 0.07M;
            int pencils = (int)(hilt / costOfPencil);
            /*
            28. Mrs. Hilt saw 33 butterflies. Some of the butterflies were red and others
            were orange. If 20 of the butterflies were orange, how many of them
            were red?
            */
            int butterfliesMrsHiltSaw = 33;
            int orangeButterflies = 20;
            int redButterflies = butterfliesMrsHiltSaw - orangeButterflies;
            /*
            29. Kate gave the clerk $1.00. Her candy cost 54 cents. How much change
            should Kate get back?
            */
            decimal moneyKateGave = 1.00M;
            decimal costOfCandy = 0.54M;
            decimal katesChange = moneyKateGave - costOfCandy;
            /*
            30. Mark has 13 trees in his backyard. If he plants 12 more, how many trees
            will he have?
            */
            int treesInMarksBackyard = 13;
            int extraTreesMarkPlants = 12;
            int numberOfTreesAltogether = treesInMarksBackyard + extraTreesMarkPlants;
            /*
            31. Joy will see her grandma in two days. How many hours until she sees
            her?
            */
            int daysTillVisit = 2;
            int hoursInADay = 24;
            int hoursTillVisit = daysTillVisit * hoursInADay;
            /*
            32. Kim has 4 cousins. She wants to give each one 5 pieces of gum. How
            much gum will she need?
            */
            int numberOfCousins = 4;
            int piecesOfGumPerCousin = 5;
            int piecesOfGumKimWillNeed = numberOfCousins * piecesOfGumPerCousin;
            /*
            33. Dan has $3.00. He bought a candy bar for $1.00. How much money is
            left?
            */
            decimal moneyDanStartedWith = 3.00M;
            decimal costOfCandyBar = 1.00M;
            decimal moneyDanHasLeft = moneyDanStartedWith - costOfCandyBar;
            /*
            34. 5 boats are in the lake. Each boat has 3 people. How many people are
            on boats in the lake?
            */
            int boatsInTheLake = 5;
            int peopleInEachBoat = 3;
            int amountOfPeopleOnBoats = boatsInTheLake * peopleInEachBoat;
            /*
            35. Ellen had 380 legos, but she lost 57 of them. How many legos does she
            have now?
            */
            int legosEllenHad = 380;
            int legosEllenLost = 57;
            int legosEllenHasNow = legosEllenHad - legosEllenLost;
            /*
            36. Arthur baked 35 muffins. How many more muffins does Arthur have to
            bake to have 83 muffins?
            */
            int totalAmountOfMuffins = 83;
            int muffinsArthurBaked = 35;
            int numberOfMuffinsArthurStillHasToMake = totalAmountOfMuffins - muffinsArthurBaked;
            /*
            37. Willy has 1400 crayons. Lucy has 290 crayons. How many more
            crayons does Willy have then Lucy?
            */
            int willysCrayons = 1400;
            int lucysCrayons = 290;
            int differenceOfWillysAndLucysCrayons = willysCrayons - lucysCrayons;
            /*
            38. There are 10 stickers on a page. If you have 22 pages of stickers, how
            many stickers do you have?
            */
            int stickers = 10;
            int pages = 22;
            int totalStickers = stickers * pages;
            /*
            39. There are 96 cupcakes for 8 children to share. How much will each
            person get if they share the cupcakes equally?
            */
            double cupcakes = 96;
            int children = 8;
            double numberOfCupcakesEachPersonWillGet = (cupcakes / children);
            /*
            40. She made 47 gingerbread cookies which she will distribute equally in
            tiny glass jars. If each jar is to contain six cookies each, how many
            cookies will not be placed in a jar?
            */
            int cookies = 47;
            int cookiesInEachJar = 6;
            int cookiesNotPlacedInAJar = cookies % cookiesInEachJar;
            /*
            41. She also prepared 59 croissants which she plans to give to her 8
            neighbors. If each neighbor received and equal number of croissants,
            how many will be left with Marian?
            */
            int croissants = 59;
            int neighbors = 8;
            int croissantsLeftWithMarian = croissants % neighbors;
            /*
            42. Marian also baked oatmeal cookies for her classmates. If she can
            place 12 cookies on a tray at a time, how many trays will she need to
            prepare 276 oatmeal cookies at a time?
            */
            int oatmealCookies = 276;
            int cookiesThatCanFitOnOneTray = 12;
            int traysNeeded = oatmealCookies / cookiesThatCanFitOnOneTray;
            /*
            43. Marian’s friends were coming over that afternoon so she made 480
            bite-sized pretzels. If one serving is equal to 12 pretzels, how many
            servings of bite-sized pretzels was Marian able to prepare?
            */
            int pretzels = 480;
            int oneServingOfPretzels = 12;
            int servingsPrepared = pretzels / oneServingOfPretzels;
            /*
            44. Lastly, she baked 53 lemon cupcakes for the children living in the city
            orphanage. If two lemon cupcakes were left at home, how many
            boxes with 3 lemon cupcakes each were given away?
            */
            int lemonCupcakesBaked = 53;
            int cupcakesLeftAtHome = 2;
            int cupcakesPerBox = 3;
            int boxesGivenAway = (lemonCupcakesBaked - cupcakesLeftAtHome) / cupcakesPerBox;
            /*
            45. Susie's mom prepared 74 carrot sticks for breakfast. If the carrots
            were served equally to 12 people, how many carrot sticks were left
            uneaten?
            */
            int carrotSticks = 74;
            int peopleEating = 12;
            int carrotSticksLeftUneaten = carrotSticks % peopleEating;
            /*
            46. Susie and her sister gathered all 98 of their teddy bears and placed
            them on the shelves in their bedroom. If every shelf can carry a
            maximum of 7 teddy bears, how many shelves will be filled?
            */
            int teddyBears = 98;
            int teddyBearsPerShelf = 7;
            int numberOfShelvesFilled = teddyBears / teddyBearsPerShelf;
            /*
            47. Susie’s mother collected all family pictures and wanted to place all of
            them in an album. If an album can contain 20 pictures, how many
            albums will she need if there are 480 pictures?
            */
            int picturesPerAlbum = 20;
            int pictures = 480;
            int albumsNeeded = pictures / picturesPerAlbum;
            /*
            48. Joe, Susie’s brother, collected all 94 trading cards scattered in his
            room and placed them in boxes. If a full box can hold a maximum of 8
            cards, how many boxes were filled and how many cards are there in
            the unfilled box?
            */
            int tradingCards = 94;
            int cardsPerBox = 8;
            int boxesFilled = tradingCards / cardsPerBox;
            int cardsInUnfilledBox = tradingCards % cardsPerBox;
            /*
            49. Susie’s father repaired the bookshelves in the reading room. If he has
            210 books to be distributed equally on the 10 shelves he repaired,
            how many books will each shelf contain?
            */
            int books = 210;
            int shelves = 10;
            int amountOfBooksPerShelf = books / shelves;
            /*
            50. Cristina baked 17 croissants. If she planned to serve this equally to
            her seven guests, how many will each have?
            */
            double christinasCroissants = 17;
            double guests = 7;
            double croissantsPerGuest = (int) christinasCroissants / guests;
            /*
            51. Bill and Jill are house painters. Bill can paint a 12 x 14 room in 2.15 hours, while Jill averages
            1.90 hours. How long will it take the two painters working together to paint 5 12 x 14 rooms?
            Hint: Calculate the hourly rate for each painter, combine them, and then divide the total walls in feet by the combined hourly rate of the painters.
            */
            double billsHourlyRate = (12 * 14) / 2.15;
            double jillsHourlyRate = (12 * 14) / 1.90;
            double combinedRates = billsHourlyRate + jillsHourlyRate;
            double totalWalls = 5 * (12 * 14);
            double answerOne = totalWalls / combinedRates;
            /*
            52. Create and assign variables to hold a first name, last name, and middle initial. Using concatenation,
            build an additional variable to hold the full name in the order of last name, first name, middle initial. The
            last and first names should be separated by a comma followed by a space, and the middle initial must end
            with a period. Use "Grace", "Hopper, and "B" for the first name, last name, and middle initial.
            Example: "John", "Smith, "D" —> "Smith, John D."
            */
            var firstName = "Grace ";
            var middleInitial = "B.";
            var lastName = "Hopper, ";
            string fullName = (lastName + firstName + middleInitial);
            /*
            53. The distance between New York and Chicago is 800 miles, and the train has already travelled 537 miles.
            What percentage of the trip as a whole number (integer) has been completed?
            */
            int totalDistance = 800;
            int distanceTravelled = 537;
            double percentageCompleted = (double)distanceTravelled / totalDistance;
            double hundred = 100.00;
            int answer = (int)(percentageCompleted * hundred);
        }
    }
}
