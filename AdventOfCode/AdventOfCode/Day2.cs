﻿using System;

namespace AdventOfCode
{
    // http://adventofcode.com/2016/day/2
    //
    //     --- Day 2: Bathroom Security ---
    //
    // You arrive at Easter Bunny Headquarters under cover of darkness.However, you left in such a rush that you forgot to use the bathroom! Fancy office
    // buildings like this one usually have keypad locks on their bathrooms, so you search the front desk for the code.
    //
    // "In order to improve security," the document you find says, "bathroom codes will no longer be written down. Instead, please memorize and follow the
    // procedure below to access the bathrooms."
    //
    // The document goes on to explain that each button to be pressed can be found by starting on the previous button and moving to adjacent buttons on the
    // keypad: U moves up, D moves down, L moves left, and R moves right. Each line of instructions corresponds to one button, starting at the previous button (or, for the first line, the "5" button); press whatever button you're on at the end of each line. If a move doesn't lead to a button, ignore it.
    //
    // You can't hold it much longer, so you decide to figure out the code as you walk to the bathroom. You picture a keypad like this:
    // 1 2 3
    // 4 5 6
    // 7 8 9
    //
    // Suppose your instructions are:
    // ULL
    // RRDDD
    // LURDL
    // UUUUD
    // You start at "5" and move up (to "2"), left(to "1"), and left(you can't, and stay on "1"), so the first button is 1.
    // Starting from the previous button ("1"), you move right twice(to "3") and then down three times(stopping at "9" after two moves and ignoring the third),
    // ending up with 9.
    // Continuing from "9", you move left, up, right, down, and left, ending with 8.
    // Finally, you move up four times(stopping at "2"), then down once, ending with 5.
    // So, in this example, the bathroom code is 1985.
    //
    // Your puzzle input is the instructions from the document you found at the front desk.What is the bathroom code?
    // DULUDRDDDRLUDURUUULRRRURDRDULRUDDUDRULUDDUDRLDULRRLRDRUDUUULUUDLRURDUDDDDRDLLLLULRDLDRDLRLULRUURDDUULUDLRURRDDRDDRDDLDRDLLUURDRUULRRURURRDLRLLLUDULULULULUDRLLRUDUURLDRLRLRDRRDRLLLDURRDULDURDDRLURRDURLRRRLDLLLDRUUURLRDLDLLLLRDURRLDLULRLDDLDLURLRRDDRUDDUULRURRUDLRDLDUURDDDDRLRURUDULUDLRRLLLLLRDRURLLDLDULUUDLUDDDRLLDRRUDLLURRUUDDRRLLRRLDDDURLDRDRLURRRRDRRRDDUDULULDURRUUURRRDULUUUDDRULDRLLRDLDURLURRLLRUUUULRDURLLDDRLLDLRLRULUUDRURUDLLURUDDRDURLRDRRRDURLDDRDRLRLLURULUUULUDDDULDLRDDDRDLLRRLDRDULLUUUDLDDLDDDLLLLLLLDUDURURDURDRUURRRDDRDUDLULDURDUDURDDDRULDURURURRLURLURLUURLULDLLRUULURDDRLRDDLRDLRRR
    // LUURLRUDRRUDLLDLUDDURULURLUUDUUDDRLUULRDUDDUULDUUDRURDDRRDRLULLRDRDLRLLUURRUULRLDRULUDLDUUDDDRDDLRDLULDRLDUULDLRDLLLDLDLRDUULUDURRULLRLDUDRLLLULUUUULUUDUUURRRDULLUURUDRRLDURRUULDRDULDUDRDUUULUUDDRLUDRLDLDRUUURDLDUDRUDUURLLRRLRLLRRLDULDDULUDUUURULDDUDUDRURRDLULRUDDURDLDLLRRRLDRLULLLRUULDUDLUUDURRLLLRLUDURRDDLDRDDDLURDLDRRUDUDLUDULULRUUUDLUURLLRLDDLURULDURDLRRDDDDURLDDLLDDULLLRLDLDULDUUDDRLDUURDDLDLUUDULRRLRLUURURUURLRLURUURLDRUURLLRDDUUUDULUDDDRDRLDRDRRLRLDULLRRUDLURULULRDRURURLULDUDLRURLRDDRULDDLRD
    // LUDRULUULRRDDDDRRDUURUDDRLDDLDRDURRURULRDLDLDUUDRRDUUDUDLLLRRLDUDDRLDDLRRLRDRLUDLULUDDUUDULDUUULUDLDDURLDURUDLDRUUDRLRRLDLDDULDUUDDLDDLLURDRLRUURDDRUDDUDLDRRLRUDRUULRRRLRULULURDLRRURDRLRULDDDRDUULLURUUUURUDDLRRRRRDURLULDLUULUDRRUDUDRRDDRURDURLRLUDDLDLRRULUDLDDRLDDLDDDLLLLRDLLUULDDLULDLDRDDUDLURUDLDLDDRRUUDDDLRLLLDRRDDDUURDUDURUURRDRLLDUDLDUULLDLDLLUULLRRULDLDRURLDULDRUURDURRURDLRDLLLDRRUDRUUDRURLUDDRURLDURRDLUUDLUUDULLLDDDDRRDLLLDLURULDDRDLUUURRDRRUUDDUL
    // DUUULDUDDDURLLULDDLLUDURLLLURULULURUURDRURLRULLLLDRDDULRRDRRLLLRDDDUULLRRURRULLDDURRRLRDDLULDULLDUDLURRDLDDLURDLRLLDRURLLRLLRRRDRRRURURUUDDLLDDLDDDLRLURUUUULRDLUDDDURLLDDRLDRRLLUDUUULRLLDRRRLRUUDLDUULRLUDRULLLLDUDLLUUDDRUURLURUDRDDDLRURUDRLULLULUUDLDURDULRRDRLDURUULRDRRRDRDRRLRLRDDUULLRDLDURDDDULURRLULDDURDURDDUDURDLLUUULUDULRDDLDRDRUDLLUURDLRDURURULURULLDRLLRRULDLULULDLULRURLRRLUDLLLRLUDLURLULDULDRLLLDLDDDDRDRLRRLRDULUUDULDDLDURDLLLDDDDLLUURRDURLDLUDDLULRUUUDDRRLDLLLRDLLDRRRDDLULLURDDRRRRLDLRLLLRL
    // LULLRRDURRLDUUDRRURLURURRRLRDRUULUULURLLURRDRULRDURDDDDUULLLLDUULDLULURDRLDLULULDRLLDLLRLRULURUDRUUDULRULLLUDRULUDRLLUDLDRRDRUUURURLRDURDRLRDDDURLURRDLRUUUDUURULULDLUULRDLRRRDRDRLLLDLRRDRLLDDULDRUDRRLULLRDLDUDDULRDDLULRURULRLLLULDLLLLRDLDRURUDUURURLDRLUULLDUDULUDDDULUDLRUDDUDLULLUULUUURULURRULRDDURDDLURLRRDRDLDULRLRDRRRULRDDDRLLDDDDRRRRDRDLULUURDURULDLRDULDUDLDURUDLUDLUDDDUDURDURDDURLLRUDUURRRUDRRRRULLLLDDDLUULLUULRRRULDLURDLULRULDRLR
    // Answer: 98575
    //
    //     --- Part Two ---
    //
    // You finally arrive at the bathroom (it's a several minute walk from the lobby so visitors can behold the many fancy conference rooms and water coolers on this
    // floor) and go to punch in the code. Much to your bladder's dismay, the keypad is not at all like you imagined it.Instead, you are confronted with the result
    // of hundreds of man-hours of bathroom-keypad-design meetings:
    //     1
    //   2 3 4
    // 5 6 7 8 9
    //   A B C
    //     D
    // You still start at "5" and stop when you're at an edge, but given the same instructions as above, the outcome is very different:
    //
    // You start at "5" and don't move at all (up and left are both edges), ending at 5.
    // Continuing from "5", you move right twice and down three times (through "6", "7", "B", "D", "D"), ending at D.
    // Then, from "D", you move five more times(through "D", "B", "C", "C", "B"), ending at B.
    // Finally, after five more moves, you end at 3.
    // So, given the actual keypad layout, the code would be 5DB3.
    //
    //Using the same instructions in your puzzle input, what is the correct bathroom code?
    // Answer: CD8D4
    public static class Day2
    {
        public static string FindBathroomCode(string rawInput)
        {
            var xPos = 1;
            var yPos = 1;
            var result = string.Empty;

            foreach (var line in rawInput.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
            {
                foreach (var dir in line.ToCharArray())
                {
                    switch (dir)
                    {
                        case 'U':
                            yPos = Math.Max(0, yPos - 1);
                            break;
                        case 'R':
                            xPos = Math.Min(2, xPos + 1);
                            break;
                        case 'D':
                            yPos = Math.Min(2, yPos + 1);
                            break;
                        case 'L':
                            xPos = Math.Max(0, xPos - 1);
                            break;
                    }
                }

                switch ($"{xPos}_{yPos}")
                {
                    case "0_0":
                        result += "1";
                        break;
                    case "0_1":
                        result += "4";
                        break;
                    case "0_2":
                        result += "7";
                        break;
                    case "1_0":
                        result += "2";
                        break;
                    case "1_1":
                        result += "5";
                        break;
                    case "1_2":
                        result += "8";
                        break;
                    case "2_0":
                        result += "3";
                        break;
                    case "2_1":
                        result += "6";
                        break;
                    case "2_2":
                        result += "9";
                        break;
                }
            }

            return result;
        }

        public static string FindBathroomCodeWithAdvancedKeypad(string rawInput)
        {
            var curPos = '5';
            var result = string.Empty;

            foreach (var line in rawInput.Split("\r\n".ToCharArray(), StringSplitOptions.RemoveEmptyEntries))
            {
                foreach (var dir in line.ToCharArray())
                {
                    switch (curPos)
                    {
                        case '1':
                            curPos = GetNewPos(dir, '1', '1', '3', '1');
                            break;
                        case '2':
                            curPos = GetNewPos(dir, '2', '3', '6', '2');
                            break;
                        case '3':
                            curPos = GetNewPos(dir, '1', '4', '7', '2');
                            break;
                        case '4':
                            curPos = GetNewPos(dir, '4', '4', '8', '3');
                            switch (dir)
                            {
                                case 'U':
                                    curPos = '4';
                                    break;
                                case 'R':
                                    curPos = '4';
                                    break;
                                case 'D':
                                    curPos = '8';
                                    break;
                                case 'L':
                                    curPos = '3';
                                    break;
                            }
                            break;
                        case '5':
                            curPos = GetNewPos(dir, '5', '6', '5', '5');
                            break;
                        case '6':
                            curPos = GetNewPos(dir, '2', '7', 'A', '5');
                            break;
                        case '7':
                            curPos = GetNewPos(dir, '3', '8', 'B', '6');
                            break;
                        case '8':
                            curPos = GetNewPos(dir, '4', '9', 'C', '7');
                            break;
                        case '9':
                            curPos = GetNewPos(dir, '9', '9', '9', '8');
                            break;
                        case 'A':
                            curPos = GetNewPos(dir, '6', 'B', 'A', 'A');
                            break;
                        case 'B':
                            curPos = GetNewPos(dir, '7', 'C', 'D', 'A');
                            break;
                        case 'C':
                            curPos = GetNewPos(dir, '8', 'C', 'C', 'B');
                            break;
                        case 'D':
                            curPos = GetNewPos(dir, 'B', 'D', 'D', 'D');
                            break;
                    }
                }

                result += curPos;
            }

            return result;
        }

        private static char GetNewPos(char dir, char up, char right, char down, char left)
        {
            switch (dir)
            {
                case 'U':
                    return up;
                case 'R':
                    return right;
                case 'D':
                    return down;
                case 'L':
                    return left;
            }
            
            throw new InvalidOperationException("This case shouldn't happen");
        }
    }
}