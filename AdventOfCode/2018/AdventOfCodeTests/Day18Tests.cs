﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdventOfCode;

namespace AdventOfCodeTests
{
    [TestClass]
    public class Day18Tests
    {
        const string sampleInput = ".#.#...|#.\n.....#|##|\n.|..|...#.\n..|#.....#\n#.#|||#|#|\n...#.||...\n.|....|...\n||...#|.#|\n|.||||..|.\n...#.|..|.";
        const string myInput = "|#..|#...|..|.#..|###|.....#.|.......||#..|....||.\n#||..##.#........||#...##.|..###.|.||...|.#.|.|.#.\n##.#.###....##....|..||#.||##.|.###|........||.##.\n#.|.||#...|..####......|.#|#..#.#|##...||..#..|...\n.....#..#.|.####..#..#...|||...||.|...#......#..|.\n.|..#..#.......|...#.|...|.##....|#|..#|###..#..#.\n.##..#..##..|.#|||.##..|..#.##..|....#..#|.##|.|#.\n|#..|#...|...|.|.......#.#......|...|.#.|||.|||#.#\n|....#...|..#..#.....#.|..#.#..|#|.#|...|..|#..|#|\n.#...##..|#.##......##...#|||..|.....#.|..|...|..#\n#.....|..|...||.|.|.....|....#|..|#...#|...#.....#\n...|...###.||......|..#|..|...|.##|........#|#|..|\n|.|.#.#......||#|||..|#....|#.|...#|..|.|.#|#.|.|.\n###.#.|....|.......##.#|###.|#.#..#.|.#...#...###.\n|###...|.....#.|.##..#...|#.#.|.##.#........#..|..\n|.||.|...##...##|......#..|.##.##|..#..|#..#.##...\n#....|#.....|...|...|............#..#|.....|.#.|.#\n...#..|..|||#.|.......#|...#...##|.......####.|...\n.#..|..#..|....||#.##.....|||...#..|.#..|.#..|..##\n....#...##.........#....|..#.......#...|.....##.#.\n|...|...|....#|####||###..|.|..|.||.#......#.|#...\n.#.#|.|.|....#.....||...||..|...##.#..|.|.#......|\n..|.......|||.|..#.#......|.|..##.||....|###....#.\n##....#.......#.|#.##.........|.|....#...|.#|.|.#|\n|#.##...|||||#.##.#...#.|#...|.||.|...|..#...#..|.\n...#||..#.......||..|.###.#.|#......||..|.#.....#.\n#..|.||#.#...|..........#.....#...#...###||.#.....\n#..#.|###|#|..|##...##.#......#|.#.#|..#.......|#.\n.|.....|.|..#.###|.#|.##.....|.|..|..|..#..|...##.\n.|........#...#..|.|..||#....|....#..|.|........|#\n....#.|...#|||...#......#...##......|#....#.||.#..\n.|.....|....#......#.|#.|.|.|..#.#.|..##.#||.....#\n.....#...|.#|..#..#|#.#|.|..|.#........#|..#|....#\n|.||..##...|#.#||..|..#.|..|..#..|..#.|.#|.#...|#.\n...|#.###...#..|#..##..||....#.||..#.|.|#.#..|..||\n......|#|.#.#|.|....#..##|##|#...|.#.|.#....##|#..\n#..||.....#....#....#.#.....|.....#....|....|...#.\n.#....#.##..........|.||.#.....#|#|||.#..#|......|\n..||..|....#..........#.|...#|.|#.|#..|#||.#...|#|\n..#..#.#|......#|.....||.#..##.|.#..#.||...|.|||..\n.#....|....#.|#...#..||..||.##..#.||....|.#|....|.\n..#|.|.....#....#..|..||..#..##.|.||..||||#.#..|.|\n.|#.|.||........#|.#|#....||..#||#...|..........##\n..#|.|..|||..###..|||.#..#.#||||.#.|##...|#......|\n..|...#|...|.#.#|.#...#.|..||##.#..#.|...#.#.#|#..\n#..#..|##.#|......#...|#|##..#.|...#.#.....#..##..\n..#.|..###|.|#.|........|.....|.....#..|.|.#...|.#\n..#|.|#.#.|#..|....|#...|.....|........|.|##.|#||#\n#.....##.#..#..#...|#||.#.#.#..|....|||.|.|......#\n...#|#....|.#.#..##.|.....#....|.|||..##.|.#.|.##.";

        [TestMethod]
        public void Part1()
        {
            Assert.AreEqual(1147, Day18.Part1(sampleInput));
            Assert.AreEqual(678529, Day18.Part1(myInput));
        }

        [TestMethod]
        public void Part2()
        {
            Assert.AreEqual(0, Day18.Part2(sampleInput));
            Assert.AreEqual(0, Day18.Part2(myInput));
        }
    }
}
