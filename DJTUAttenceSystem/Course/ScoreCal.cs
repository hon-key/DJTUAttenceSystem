using DJTUAttenceSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DJTUAttenceSystem.Course {
    class ScoreCal {
        Model.Course course;
        public double SingleWeightedPoints {
            get {
                return calWeightScore();
            }
        }
        private int totalAttandanceCount {
            get {
                return course.allSubAttandances().Count;
            }
        }
        private ScoreCal() {

        }
        public static ScoreCal createForCourse(Model.Course course) {
            if (course == null)
                throw new CalCreateFailedException("课程实例为空");
            ScoreCal cal = new ScoreCal();
            cal.course = course;
            return cal;
        }
        private double calWeightScore() {
            int attWeight = course.getRecord(Record.RType.attendance).weight;
            int totalAttWeight = attWeight * course.allSubAttandances().Count;
            int totalExtraWeight = 0;
            foreach (subExtra subExt in course.allExtras()) {
                totalExtraWeight += subExt.getMaxWeightCheckType().weight;
            }
            int totalWeight = totalAttWeight + totalExtraWeight;
            return 100.0f / totalWeight;
        }
        public int scoreForStudent(Student stu) {
            if (!isContainsStudent(stu))
                throw new CalFailedException("学生不存在该Course中");
            int attWeight = course.getRecord(Record.RType.attendance).weight;
            int totalAttWeight = 0;
            foreach (StuAttandance stuAtt in stu.allStuAttandances()) {
                totalAttWeight += stuAtt.record.weight;
            }
            if (stu.allStuAttandances().Count == 0)
                return 60;
            else
                totalAttWeight += attWeight * (course.allSubAttandances().Count - stu.allStuAttandances().Count);
            int totalExtWeight = 0;
            foreach (StuExtra stuExt in stu.allStuExtras()) {
                totalExtWeight += stuExt.result.weight;
            }
            double score = (SingleWeightedPoints * (totalAttWeight + totalExtWeight));
            double round = Math.Round(score);
            return (int)round;
        }
        public void calStudentScore(Student stu) {
            try {
                stu.score = "" + scoreForStudent(stu);
            } catch (CalCreateFailedException) {
                HKConfirmForm.showConfirmForm("成绩计算模块初始化失败，原因是课程出错，请重试");
            } catch (CalFailedException) {
                HKConfirmForm.showConfirmForm("成绩计算失败，原因是学生不存在");
            }
        }
        public bool isContainsStudent(Student stu) {
            foreach (StuList stulist in course.allStulist()) {
                if (stulist.containsStudent(stu)) {
                    return true;
                }
            }
            return false;
        }

        public class CalCreateFailedException : ApplicationException {
            public CalCreateFailedException(string message):base(message) {

            }
        }
        public class CalFailedException : ApplicationException {
            public CalFailedException(string message) : base(message) {

            }
        }
    }
}
