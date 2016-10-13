// SRS.cs - Chapter 15 version.

// Copyright 2008 by Jacquie Barker and Grant Palmer - all rights reserved.

// A main driver for the command-line driven version of the SRS, with
// file persistence added.

using System;
using System.Collections;

public class SRS {

  static void Main() {

    //  Create CourseCatalog, ScheduleOfClasses, and Faculty objects.
    //  The order of creation is important because a ScheduleOfClasses
    //  needs a CourseCatalog object to properly initialize and a 
    //  Faculty object needs a ScheduleOfClasses object.

    //  Create a CourseCatalog object and read data from input files. 

    CourseCatalog catalog = new CourseCatalog("CourseCatalog.dat", "Prerequisites.dat");
    catalog.ReadCourseCatalogData();
    catalog.ReadPrerequisitesData();

    //  Create a ScheduleOfClasses object and read data from input file.

    ScheduleOfClasses schedule = new ScheduleOfClasses("SoC_SP2009.dat", "SP2009");
    schedule.ReadScheduleData(catalog);

    //  Create a Faculty object and read data from input files.

    Faculty faculty = new Faculty("Faculty.dat", "TeachingAssignments.dat");
    faculty.ReadFacultyData();
    faculty.ReadAssignmentData(schedule);

    // We'll handle the students differently:  that is,
    // rather than loading them all in at application outset,
    // we'll pull in the data that we need just for one
    // Student when that Student logs on -- see the Student
    // class constructor for the details.

    // Let's temporarily create Students this way as a test,
    // to simulate Students logging on.  Note that only the
    // first Student has "preregistered" for courses based
    // on the content of his/her Student data file (see Student.cs
    // for details). Initial Student data is read from the 
    // Student data files.

    Student s1 = new Student("111-11-1111.dat");
    s1.ReadStudentData(schedule);

    Student s2 = new Student("222-22-2222.dat");
    s2.ReadStudentData(schedule);

    Student s3 = new Student("333-33-3333.dat");
    s3.ReadStudentData(schedule);

    // Let's have one Student try enrolling in something, so
    // that we can simulate his/her logging off and persisting
    // the enrollment data in the ssn.dat file (see Student.cs
    // for details).

    Section sec = schedule.FindSection("ART101 - 1");
    sec.Enroll(s2);
    s2.WriteStudentData();  // Check contents of 222-22-2222.dat!

    // Let's see if everything got initialized properly
    // by calling various display methods!
		
    Console.WriteLine("====================");
    Console.WriteLine("Course Catalog:");
    Console.WriteLine("====================");
    Console.WriteLine("");
    catalog.Display();

    Console.WriteLine("====================");
    Console.WriteLine("Schedule of Classes:");
    Console.WriteLine("====================");
    Console.WriteLine("");
    schedule.Display();

    Console.WriteLine("======================");
    Console.WriteLine("Professor Information:");
    Console.WriteLine("======================");
    Console.WriteLine("");
    faculty.Display();

    Console.WriteLine("====================");
    Console.WriteLine("Student Information:");
    Console.WriteLine("====================");
    Console.WriteLine("");
    s1.Display();
    Console.WriteLine("");
    s2.Display();
    Console.WriteLine("");
    s3.Display();

  }
}
