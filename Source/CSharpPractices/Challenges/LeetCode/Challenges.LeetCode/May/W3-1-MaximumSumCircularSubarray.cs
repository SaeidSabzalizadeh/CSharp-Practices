using Helper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Challenges.LeetCode.May
{
    public class MaximumSumCircularSubarray
    {
        /*
         
        Given a circular array C of integers represented by A, find the maximum possible sum of a non-empty subarray of C.
        
        Here, a circular array means the end of the array connects to the beginning of the array.  
        (Formally, C[i] = A[i] when 0 <= i < A.length, and C[i+A.length] = C[i] when i >= 0.)

        Also, a subarray may only include each element of the fixed buffer A at most once.  
        (Formally, for a subarray C[i], C[i+1], ..., C[j], there does not exist i <= k1, k2 <= j with k1 % A.length = k2 % A.length.)

        Note:
            -30000 <= A[i] <= 30000
            1 <= A.length <= 30000


        Input: [1,-2,3,-2]
        Output: 3
        Explanation: Subarray [3] has maximum sum 3


        Input: [5,-3,5]
        Output: 10
        Explanation: Subarray [5,5] has maximum sum 5 + 5 = 10


        Input: [3,-1,2,-1]
        Output: 4
        Explanation: Subarray [2,-1,3] has maximum sum 2 + (-1) + 3 = 4


        Input: [3,-2,2,-3]
        Output: 3
        Explanation: Subarray [3] and [3,-2,2] both have maximum sum 3


        Input: [-2,-3,-1]
        Output: -1
        Explanation: Subarray [-1] has maximum sum -1
                
         */


        public static void Run()
        {
            Base.Start(typeof(MaximumSumCircularSubarray));

            int[] A1 = new int[] { -50, -281, 804, -274, 303, 916, 326, -394, 174, -167, -599, 215, -927, -248, 631, -973, -335, -946, -1000, -83, 108, 292, 773, 895, -674, 183, 471, 863, -363, -235, -271, 575, -199, 178, -170, 805, -443, -327, 659, -734, 132, -63, 161, -880, 110, 55, -969, 981, 780, 153, -363, -552, 20, 110, -850, 845, -434, -621, 724, 553, -251, 435, -964, -915, 983, 280, 284, 191, 850, 999, -951, -893, 145, -971, 186, -382, -960, 917, 586, -120, -422, -881, 900, 459, 215, -279, -186, -870, 460, 277, -703, 369, 3, -575, -941, 659, 400, -537, 365, 632, 84, -351, -993, -707, -297, -484, 59, 28, -961, 66, -509, -21, -230, -858, 302, -162, -803, -585, -389, 749, 231, -738, -959, 931, 735, -797, 935, -761, 201, -469, 251, 692, 324, -857, 408, -380, -349, 691, -258, -824, -570, -216, 998, -712, 600, -344, -30, -338, 602, 601, -131, 529, 505, -362, 436, 499, 649, 498, 103, -935, 499, 997, 74, -612, 240, 45, -765, -658, 654, -994, -608, -852, -287, -170, 756, -897, 803, 242, 419, -856, -711, -18, 666, -31, -48, 919, 552, -230, 16, -196, 507, -359, 549, -346, -341, -67, 228, -114, -936, 806, -4, 261, -325, 521, 592, -543, 37, 529, 993, 956, 114, -703, 218, 484, 248, -564, -340, 42, 537, -941, -863, 137, 451, -441, 206, -158, 225, 751, -817, 861, 536, 677, 470, -899, -636, -41, 820, -64, -272, 897, -271, -218, -475, -919, -667, 294, 219, -577, -357, 149, -220, 232, -566, -653, 733, 766, 138, 435, -296, -820, -664, -328, 895, -230, -103, 736, -542, 247, 632, 628, 818, 108, -898, 725, -509, 364, -753, -172, -392, -682, 964, 245, 910, 288, -435, -562, -338, 217, 946, 67, 677, -823, 885, 494, 854, 719, -415, 588, 398, -164, 606, -413, 976, -241, 703, -486, 856, -546, 791, 770, -434, -790, -246, -469, 913, 660, -55, 94, 371, -475, -2, 841, -595, -852, -989, 284, 383, -338, -146, 80, -260, -959, 700, 852, -620, 349, 430, 550, 773, -280, 863, 896, -897, -713, 718, 731, 61, -934, -116, 542, -877, 616, 798, 508, -731, -471, 575, 156, 362, 560, 85, -291, 379, -675, 67, -298, 764, 53, 518, -188, 887, -64, 690, -147, -974, 638, 839, 236, 935, -814, -650, -137, -433, 59, -65, 868, 599, 167, -546, -674, 110, -62, 539, 773, 161, 76, 919, -244, -749, -698, -349, -933, -663, 927, -23, -92, 283, 512, -678, 147, 759, 953, -848, -150, -3, 736, -650, -523, -832, -156, -997, 154, -120, 699, -294, 176, 140, 492, 276, -723, 463, 480, 149, -420, 471, 412, 485, 784, 265, 433, -446, -188, -23, 210, -389, -955, 435, 431, -605, 301, 42, -661, -827, 351, 994, 144, 740, 728, 450, 87, 529, -752, 397, -849, -236, -292, -484, -386, -220, -972, -953, -709, 149, -789, 341, 451, 864, -329, -130, 786, -875, -110, 532, 698, 707, 806, -417, -248, -834, -464, 271, 344, -658, -755, 16, -971, -605, 715, 943, -732, 744, -721, -315, 900, -506, -200, -228, -768, -339, -261, 50, 804, -69, 327, 683, -44, -124, 265, -822, 21, 13, 852, 689, -9, 375, -291, 316, 589, -492, -897, 328, -430, -898, 920, 971, 979, 677, 3, 10, -411, 439, 694, 439, 257, 577, -892, 299, -146, -873, 875, -326, 339, -672, 406, -274, -618, 759, -696, -912, 812, 84, 700, -55, 669, 658, -183, 920, -820, -373, 935, 84, -816, -515, 706, -854, 423, -298, 41, 918, -726, 965, 30, 729, 751, 811, -441, -926, 941, -1, -896, 317, 538, 48, -448, -575, -657, 468, 449, -929, 937, 518, 660, 129, -135, 102, 25, -681, -770, -577, -643, -103, -489, -143, -43, 432, -207, -194, 513, -961, 922, 19, -608, 803, 149, 553, 912, -215, 23, 500, -31, -250, -463, 39, 242, -853, 779, -125, 744, -447, -330, -18, 551, 539, -142, 119, 587, -619, 680, 819, 598, -670, 441, -829, -892, -617, 345, -199, 288, -142, -550, 319, 460, 120, -854, 611, 517, -899, -476, -381, 684, -503, 39, 885, -389, -64, -841, 727, 335, 416, 859, 462, -585, 289, -29, -481, 371, 71, 424, 297, -450, -82, 817, 472, -83, 550, -826, -283, 608, 997, 147, 901, -912, -545, -116, 16, -184, 680, 498, -892, -568, -946, 260, 365, 566, 185, -598, 774, -219, -543, 319, -294, 117, -564, 617, 152, -512, -439, 412, -679, 880, 336, 24, -758, 458, -982, -338, 260, -841, -110, 326, -948, 942, -356, 32, -190, -172, 819, -308, 654, 611, -805, -501, -587, -653, 89, 416, 380, 195, -475, -43, 707, -33, 988, 452, 154, 723, -299, -608, -388, -932, -634, 198, 588, 578, -169, 551, 513, -189, -940, 650, -108, -764, 685, 636, 239, 634, 176, 222, -80, 665, 525, 516, 218, 97, -117, 480, -311, 309, -617, 799, -795, 404, -4, -516, 321, -933, -190, -699, 536, -455, -878, 581, 530, 947, -734, -153, -209, -38, -916, -661, 9, -889, -633, -163, 173, 774, -365, 526, -793, 106, -424, -103, -764, -442, -212, 837, 418, -738, -677, 477, -406, -415, 241, 339, 777, 923, -682, 478, 326, -304, -970, -970, 96, 706, -655, 66, -943, -645, -464, 115, 270, -511, 127, 14, 207, 828, 978, 6, -504, 629, 720, -289, 272, 641, 295, -607, -766, 245, 982, 278, -697, 780, 492, 525, -587, -942, -580, -528, 515, 181, -659, -21, 37, 658, -230, -946, 343, 386, -680, 736, 866, -380, 887, 264, -744, 644, -443, -707, -377, 729, -743, -100, 662, 931, 640, -143, 870, 786, -947, 497, -454, 213, -658, -964, -653, 224, -354, 701, 398, -573, -227, -803, -967, 920, 376, -379, 256, 550, -313, -179, -545, -277, -953, -381, 620, 859, 331, 252, -107, 481, 652, 689, -675, 970, -488, 848, 584, -490, -974, -500, -708, 568, -580, -739, -542, -262, 780, 13, 45, -268, -235, -113, 661, -970, -589, -970, 744, 393, 501, 952, -693, -408, 840, 305, 547, -662, 397, -715, 371, -404, -791, 639, -868, -912, -156, -730, -378, 273, -850, 564 };
            int[] A2 = new int[] { -744, 843, -599, 711, 370, -483, 672, -827, 380, 555, -756, 949, -768, 151, -608, 478, 993, 146, -288, -596, -440, -333, 301, 42, -428, -182, -652, 954, 705, -330, 626, -706, -405, 334, 657, -532, 528, -877, -736, 101, -751, -789, 23, -122, 995, -602, -938, -57, 521, -731, -432, -432, -11, -376, -190, 535, -549, 889, -570, 25, -588, 477, 442, 668, -575, -869, -550, -9, -239, -858, 705, -382, -309, 447, 716, 652, -782, 300, 803, -287, -351, 806, 308, 908, -640, 555, -715, -356, 860, 310, 167, -708, 756, 266, 39, 297, 534, -871, -522, 785, 798, -4, 767, 291, 135, -385, -315, -288, -806, 765, 96, 179, 562, 511, 344, 537, -10, -650, -241, -689, -769, -758, -704, 775, 752, -901, 797, -838, 236, 953, -198, 563, -382, -558, -851, 397, 138, 954, -185, 0, -221, -964, -861, -312, 425, -925, -603, -202, 418, 965, 0, -186, 266, -922, 801, 935, 351, 461, -861, -467, -850, -684, 466, 709, -931, 395, 56, 873, 443, -342, -79, 783, 191, 806, 549, -388, -780, -898, -493, 194, 297, -364, 143, -162, 831, -468, 608, -921, 703, -262, -36, 715, 233, 718, -398, 957, -221, 777, 189, 220, 687, 840, -301, -433, -776, -459, -763, 290, 197, -151, -137, 120, -50, -914, 570, -902, -96, -551, 739, 165, 579, -720, -113, 952, -619, -374, 244, -38, 6, -301, -890, 891, 194, 451, -770, -791, -690, -941, -207, -792, -483, 406, 508, 145, 898, 873, 142, -83, -380, -494, 904, -907, 630, -486, -687, -720, -919, -123, 364, 315, 668, 841, 29, -54, -957, 841, -465, -364, -406, -407, -827, 301, -37, -40, -550, 94, -469, 496, 990, -927, -999, 169, 965, -637, 361, -718, 11, -995, -404, -834, 803, 27, -867, -514, 576, 923, 703, 33, 277, 396, -923, -532, 544, 85, -821, 895, 366, 600, -324, -282, 392, -208, -118, 785, -285, 94, 37, -63, 750, -86, 310, 432, -261, -349, 244, 887, -370, -549, 328, -153, -173, -78, -28, -887, -845, 49, 254, -821, 342, 586, 215, 108, 721, 346, -400, -504, -250, -847, -165, 731, -528, -452, -742, 318, 909, -665, -896, 189, -383, -955, 518, 79, -46, 200, 391, -380, 895, 891, -144, 689, 626, 842, -707, 369, -163, -68, -522, 75, 602, 838, 154, 30, 5, 418, -267, -581, -874, 568, 266, -234, -7, 149, -878, -238, -696, -585, 205, -739, 573, -423, -420, -380, -628, 628, 30, 621, 165, 900, -723, 17, 680, -749, -400, -985, 990, 598, -629, -176, -735, 195, -902, -356, 168, 284, -407, 847, -433, -700, -195, -894, 841, 888, -737, 638, -119, 497, 47, 649, -206, 178, -62, -121, -874, -903, -653, -21, 62, 23, -116, 676, 947, -75, 663, 599, 406, -266, 40, -613, 397, -510, 847, -145, 798, -545, -723, -657, 531, -943, -196, -782, -776, -886, -902, 748, 501, -585, 448, 190, 252, 237, 453, 102, -813, -846, -715, -484, 391, 637, -341, -451, -468, -983, -916, 608, 511, 296, 394, -701, 589, 786, 619, 888, -64, -639, 329, 548, 477, 682, -445, 757, 61, 857, -358, -133, -264, -511, 871, -159, 606, -729, 41, 999, -549, 201, 120, 680, -86, -644, -383, -982, -878, -110, 237, -140, -697, 512, 151, 961, 119, -444, -560, 748, 991, 361, -438, -544, 657, -182, 353, -877, 245, -362, 140, -958, -348, 633, -921, 731, -241, 333, 909, 241, 308, -207, -371, -615, 831, 78, -313, -92, -745, -328, 272, -493, 244, 49, -717, -961, 676, 776, -618, -513, 390, 270, 338, -596, -276, 117, -116, 207, -817, -407, -721, -81, 851, 741, 580, -771, -415, -199, -760, -363, -403, 733, 814, -483, 412, -287, 339, 251, 435, 216, -177, 398, -948, -930, -691, -95, -796, -790, 764, -959, -82, 168, -574, -21, 152, -642, -154, -804, -511, 567, -964, 260, 21, -206, -142, -400, -196, 606, 894, 211, 820, 484, 34, 77, -671, 664, -653, -807, -646, 850, 276, -447, 343, -716, 802, -717, 408, -150, -926, -56, 140, 37, -528, 694, -392, -373, 266, -338, 34, 142, -467, 65, -407, -856, 526, 805, 579, -440, -971, -975, 5, -757, 568, -486, -475, -113, -491, -394, -474, -549, -360, 72, 680, 554, 508, -412, 906, -987, -428, -655, 274, -543, -790, 263, 739, 244, 62, 702, -772, 878, -769, -991, 912, 309, -658, 961, 397, -638, -75, 90, -551, 262, 887, -940, 707, 766, -955, -270, 908, 267, -923, -660, -541, 352, -849, 343, 648, -619, 141, -389, 122, 95, 373, 588, 273, 598, -85, 550, 684, -543, -531, 869, 413, 412, 247, 981, 773, 673, -657, 663, 423, -735, -439, 467, -368, -419, 308, -725, -553, -588, 431, -420, 218, -677, 649, 696, 969, -769, 558, 548, -486, -28, 550, -647, -282, -35, 395, 711, 189, 296, 488, 273, 540, 854, 780, -754, -931, 833, -719, -862, -88, -487, 591, -165, 584, -640, 502, -308, 219, 390, 713, -732, 228, -759, 488, 675, -300, -153, 105, 269, -240, 462, -825, -638, 299, -65, -576, -222, -929, 481, -404, 687, -574, -81, -365, -844, 530, 298, -681, 676, -304, -528, -4, 431, -35, 311, 669, -392, -998, 983, 466, -350, -62, -457, -807, 7, 821, -835, -291, -433, 171, -510, -309, -509, -981, 422, -820, -753, 342, 803, 79, 886, -233, 551, -595, -272, 289, -159, 470, 36, -882, -773, 916, 446, -79, -500, -240, 199, 703, 391, -316, -273, -659, -781, 836, -409, -688, -287, 230, -254, 575, -529, -431, -985, -451, 244, -503, -321, -196, -116, -340, -460, 433, -428, -977, 127, -256, 485, -940, 876, 574, 646, -596, -315, 976, 249, 108, -983, 277, 388, 269, 6, 504, 734, -267, 86, 143, -979, 504, -569, 827, -935, -499, -63, -67, 117, 472, -31, -904, -361, -122, 700, -889, 978, 620, -954, -396, 248, -885, -588, 1000, 438, 305, -635, 455, 620, -566, 445, -107, 114, -317, 575, -241, 58, 717, -52, 977, 900, -603, -659, -266, 692, -750, -769, 952, -648, -213, -545, 715, 129, -160, 126, 322, -162, 205, 386, 608, 654 };

            PerformanceProfiler.Compare(new Dictionary<string, Action>()
            {
                {nameof(MaxSubarraySumCircular_ForLoop), ()=> { _ = MaxSubarraySumCircular_ForLoop(A1); _ = MaxSubarraySumCircular_ForLoop(A2); } },
                {nameof(MaxSubarraySumCircular_Kadane), ()=> { _ = MaxSubarraySumCircular_Kadane(A1); _ = MaxSubarraySumCircular_Kadane(A2); } },
                {nameof(MaxSubarraySumCircular_LeetCodeBest), ()=> { _ = MaxSubarraySumCircular_LeetCodeBest(A1); _ = MaxSubarraySumCircular_LeetCodeBest(A2); } },

            }, 3);

            Base.End(typeof(MaximumSumCircularSubarray));
        }


        public static int MaxSubarraySumCircular_LeetCodeBest(int[] A)
        {
            if (A.Length == 0)
                return 0;

            // Case 1: No wrapping.
            int globalMax = A[0];
            int localMax = A[0];

            for (int i = 1; i < A.Length; i++)
            {
                localMax = Math.Max(localMax, 0) + A[i];
                globalMax = Math.Max(localMax, globalMax);
            }

            if (A.Length < 3)
                return globalMax;


            // Case 2: Wrapping
            int totalSum = 0;
            for (int i = 0; i < A.Length; i++)
            {
                totalSum += A[i];
                A[i] = -A[i];
            }

            int wrappingMax = A[1];
            int wrappingLocalMax = A[1];

            for (int i = 2; i < A.Length; i++)
            {
                wrappingLocalMax = Math.Max(wrappingLocalMax, 0) + A[i];
                wrappingMax = Math.Max(wrappingMax, wrappingLocalMax);
            }

            int wrappedGlobalMax = totalSum + wrappingMax;

            return Math.Max(globalMax, wrappedGlobalMax);
        }


        public static int MaxSubarraySumCircular_Kadane(int[] A)
        {
            int min = int.MinValue;
            bool positive = false;

            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] >= 0)
                {
                    positive = true;
                    break;
                }
                else
                {
                    if (A[i] > min)
                    {
                        min = A[i];
                    }
                }
            }
            if (!positive)
            {
                return min;
            }
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = -A[i];
            }

            // run Kadane's algorithm on modified array
            int negMaxSum = Kadane(A);

            // restore the array
            for (int i = 0; i < A.Length; i++)
            {
                A[i] = -A[i];
            }

            /*  return maximum of

               1. sum returned by Kadane's algorithm on original array.

               2. sum returned by Kadane's algorithm on modified array +
                  sum of all elements of the array.
               You might be wondering that why we are adding the min sum to total sum. The reason is that the min sum that we have is positive. That's why we are adding it.
            */
            int kadane = Kadane(A);
            int sum = A.Sum() + negMaxSum;

            return kadane > sum ? kadane : sum;
        }

        private static int Kadane(int[] A)
        {
            int sum = 0;
            int maxSum = 0;
            int firstIndex = -1;

            for (int i = 0; i < A.Length; i++)
            {
                sum += A[i];
                if (sum < 0)
                {
                    sum = 0;
                }
                else
                {
                    maxSum = sum > maxSum ? sum : maxSum;
                    if (firstIndex == -1)
                        firstIndex = i;
                }
            }
            // starting again from 0 till firstIndex.
            for (int i = 0; i < firstIndex; i++)
            {
                sum += A[i];
                if (sum < 0)
                {
                    sum = 0;
                }
                else
                {
                    maxSum = sum > maxSum ? sum : maxSum;
                }
            }
            return maxSum;
        }


        public static int MaxSubarraySumCircular_ForLoop(int[] A)
        {
            int maxSum = int.MinValue;
            int currentSum = 0;

            int arrayLength = A.Length;

            for (int startIndex = 0; startIndex < arrayLength; startIndex++)
            {
                for (int endIndex = startIndex; endIndex < (startIndex + arrayLength); endIndex++)
                {
                    currentSum = 0;

                    for (int i = startIndex; i <= endIndex; i++)
                    {
                        currentSum += A[i % arrayLength];
                    }

                    if (currentSum > maxSum)
                        maxSum = currentSum;
                }
            }

            return maxSum;

        }

        //LocalMax(i) is max subarray ending in i
        //ex: LocalMax(3) = MAX(A[3], [A2]+[A3], [A1]+[A2]+[A3])

        //Then LocalMax(i) = MAX(localMax(i-1), A[i]+LocalMax(i-1))

        //LocalMax(0) = A[0]
        //


        //public static int MaxSubArray(int[] A)
        //{
        //    int arrayLength = A.Length;
        //    int localMax = A[0];
        //    int globalMax = A[0];

        //    for (int i = 1; i < arrayLength; i++)
        //    {
        //        localMax = A[i] > (A[i] + localMax) ? A[i] : A[i] + localMax;

        //        if (localMax > globalMax)
        //            globalMax = localMax;
        //    }

        //    return globalMax;

        //}

        //public static int MaxSubArrayCircular(int[] A)
        //{
        //    //"2,-1, 3,-2, 4, 1"
        //    //"-2,1,-3, 2,-4,-1"

        //    int arrayLength = A.Length;
        //    int localMax = A[0];
        //    int n = arrayLength - 1;
        //    int localMaxN = int.MinValue;

        //    for (int i = 1; i < arrayLength; i++)
        //    {
        //        localMax = A[i] > (A[i] + localMax) ? A[i] : A[i] + localMax;

        //        if (i == n)
        //            localMaxN = localMax;
        //    }

        //    localMax = localMaxN;
        //    int globalMax = localMaxN; //7

        //    for (int i = 0; i < arrayLength; i++)
        //    {
        //        localMax = A[i] > (A[i] + localMax) ? A[i] : A[i] + localMax;

        //        if (localMax > globalMax)
        //            globalMax = localMax;
        //    }

        //    return globalMax;
        //}

        //public static int MaxSubArrayINTEGRATE(int[] A)
        //{
        //    int arrayLength = A.Length;
        //    int kadaneSum = MaxSubArray(A);
        //    int arraySum = 0;

        //    for (int i = 0; i < arrayLength; i++)
        //    {
        //        arraySum += A[i];
        //        A[i] = -A[i];
        //    }

        //    int inverseKadaneSum = MaxSubArray(A);
        //    int wrapSum = arraySum + inverseKadaneSum;

        //    return (wrapSum > kadaneSum) ? wrapSum : kadaneSum;
        //}




        //private static int Kadane(int[] A)
        //{
        //    int arrayLength = A.Length;
        //    int maxSum = int.MinValue;
        //    int currentSum = int.MinValue;
        //    bool reset = true;

        //    for (int i = 0; i < arrayLength; i++)
        //    {
        //        if (reset)
        //        {
        //            currentSum = A[i];
        //            reset = false;
        //        }
        //        else
        //        {
        //            if (currentSum + A[i] < currentSum)
        //                reset = true;
        //            else
        //                currentSum += A[i];
        //        }

        //        if (currentSum > maxSum)
        //            maxSum = currentSum;
        //    }

        //    return maxSum;
        //}

        //public static int MaxSubarraySumCircular_Integration(int[] A)
        //{
        //    int arrayLength = A.Length;
        //    int kadane_sum = Kadane(A);

        //    int wrap_sum = 0;

        //    for (int i = 0; i < arrayLength; i++)
        //    {
        //        wrap_sum += A[i];
        //        A[i] = -A[i];
        //    }

        //    wrap_sum += Kadane(A);

        //    return wrap_sum > kadane_sum ? wrap_sum : kadane_sum;
        //}


        //public static int MaxSubarraySumCircular_Kadane(int[] A)
        //{

        //    int arrayLength = A.Length;
        //    int kadaneSum = Kadane(A);
        //    int arraySum = 0;

        //    for (int i = 0; i < arrayLength; i++)
        //    {
        //        arraySum += A[i];
        //        A[i] = -A[i];
        //    }

        //    int inverseKadaneSum = Kadane(A);
        //    int wrapSum = arraySum + inverseKadaneSum;

        //    return (wrapSum > kadaneSum) ? wrapSum : kadaneSum;
        //}


        //1
        //public static int MaxSubarraySumCircular_Kadane(int[] A)
        //{
        //    int n = A.Length;

        //    for (int i = 0; i < n; i++)
        //        A[i] = -A[i];

        //    int negMaxSum = Kadane(A);

        //    for (int i = 0; i < n; i++)
        //        A[i] = -A[i];


        //    int kadane = Kadane(A);
        //    int lol = A.Sum() + negMaxSum;

        //    return lol > kadane ? lol : kadane;
        //}

        //private static int Kadane(int[] A)
        //{
        //    int arrayLength = A.Length;

        //    int max_so_far = 0;
        //    int max_ending_here = 0;

        //    for (int i = 0; i < arrayLength; i++)
        //    {
        //        max_ending_here += A[i];
        //        max_ending_here = max_ending_here < 0 ? 0 : max_ending_here;
        //        max_so_far = max_so_far > max_ending_here ? max_so_far : max_ending_here;
        //    }

        //    return max_so_far;
        //}



        //public static int MaxSubarraySumCircular_Temp(int[] A)
        //{
        //    int maxSum = int.MinValue;
        //    int currentSum = 0;
        //    int arrayLength = A.Length;
        //    int currentAvg = int.MinValue;
        //    int currentCount = 0;
        //    int collapseIndex = -1;
        //    int collapseCount = 0;
        //    int collapseSum = 0;


        //    for (int startIndex = 0; startIndex < arrayLength; startIndex++)
        //    {
        //        if (A[startIndex] > currentAvg)
        //        {
        //            currentSum += A[startIndex];
        //            currentCount++;
        //            currentAvg = currentSum / currentAvg;
        //        }
        //        else
        //        {
        //            collapseCount++;

        //            if (collapseIndex == -1)
        //            {
        //                collapseIndex = startIndex;
        //                collapseSum = currentSum;
        //            }

        //            collapseSum += A[startIndex];
        //        }

        //        if (currentSum > maxSum)
        //            maxSum = currentSum;




        //    }


        //    for (int startIndex = 0; startIndex < arrayLength; startIndex++)
        //    {
        //        for (int endIndex = startIndex; endIndex < (startIndex + arrayLength); endIndex++)
        //        {
        //            currentSum = 0;

        //            for (int i = startIndex; i <= endIndex; i++)
        //            {
        //                currentSum += A[i % arrayLength];
        //            }

        //            if (currentSum > maxSum)
        //                maxSum = currentSum;
        //        }
        //    }

        //    return maxSum;

        //}


    }
}
