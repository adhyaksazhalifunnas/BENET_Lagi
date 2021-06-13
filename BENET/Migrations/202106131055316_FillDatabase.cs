namespace BENET.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FillDatabase : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO dbo.SportModels(SportName,SportType,SportDrill) VALUES ('Running','Outdoor','Run at a moderate pace for 20-30 minutes (or about 5-8 kilometers)')");
            Sql("INSERT INTO dbo.SportModels(SportName,SportType,SportDrill) VALUES ('Push-up (Beginner)','Indoor','3 x 8-10 reps regular push-up, 2 x 6 reps tempo push-up (4-second per phase), 3 x 6-8 reps decline push-up, 4 x 20-25 seconds extended plank. Schedule : Monday, Wednesday, Friday or Tuesday, Thursday, Saturday')");
            Sql("INSERT INTO dbo.SportModels(SportName,SportType,SportDrill) VALUES ('Swimming (Leisure)','Indoor','Swim at your own pace for 20-30 minutes a day, five days a week.')");
            Sql("INSERT INTO dbo.SportModels(SportName,SportType,SportDrill) VALUES ('Walking','Outdoor','Walking for 30 minutes a day or more on most days of the week.')");
            Sql("INSERT INTO dbo.SportModels(SportName,SportType,SportDrill) VALUES ('Fitness','Indoor','2 -3 sessions per week, lasting about 20 to 30 minutes each (Beginner). 3 - 4 sessions each week, lasting about 30 to 40 minutes (experienced ).')");
            Sql("INSERT INTO dbo.SportModels(SportName,SportType,SportDrill) VALUES ('Cycling','Outdoor','30-60 minutes, 3-5 days a week. Start every ride with a warm-up. Pedal at a slow, easy pace for 5-10 minutes.')");
            Sql("INSERT INTO dbo.SportModels(SportName,SportType,SportDrill) VALUES ('Futsal','Indoor','3-5 times (30-45 mins per workout) a week. For great results, you need to think about giving yourself enough recovery time (rest days) in between team trainings/matches')");
            Sql("INSERT INTO dbo.SportModels(SportName,SportType,SportDrill) VALUES ('Yoga','Indoor','3-5 times a week. Workout consists of a variety of exercise sequences that are performed in low repetitions, usually five to ten times, over a session of 45 to 90 minutes.')");
            Sql("INSERT INTO dbo.SportModels(SportName,SportType,SportDrill) VALUES ('Martial arts','Indoor','Practicing 2-3 times a week for at least an hour at a time.')");
            Sql("INSERT INTO dbo.SportModels(SportName,SportType,SportDrill) VALUES ('Tennis','Indoor','2 to 3 times per week, tennis set takes just over 40 minutes on average.')");
            Sql("INSERT INTO dbo.SportModels(SportName,SportType,SportDrill) VALUES ('Dancing','Indoor','Aim for more than 150 minutes of moderate intensity dance or 75 minutes of high-intensity dance each week.')");
            Sql("INSERT INTO dbo.SportModels(SportName,SportType,SportDrill) VALUES ('Rope skipping','Indoor','Aim to jump rope at a moderate intensity for at least half an hour, five days a week.')");
            Sql("INSERT INTO dbo.SportModels(SportName,SportType,SportDrill) VALUES ('Badminton','Indoor','Playing a game of badminton can help you burn around 450 calories an hour. we recommend taking 30 minutes of exercise, five times a week.')");
            Sql("INSERT INTO dbo.SportModels(SportName,SportType,SportDrill) VALUES ('Basketball','Outdoor','2-3 days a week for 60-90 minutes with a minimum of 48 hours rest')");
            Sql("INSERT INTO dbo.SportModels(SportName,SportType,SportDrill) VALUES ('Table Tennis','Indoor','9 hours a week (3 hours/3-4 days a week)')");
            Sql("INSERT INTO dbo.SportModels(SportName,SportType,SportDrill) VALUES ('Climbing','Outdoor','3-days per week. Session should last between 60 to 90 minutes (high-intensity training), 2-hour session (moderate approach)')");
            Sql("INSERT INTO dbo.SportModels(SportName,SportType,SportDrill) VALUES ('Boxing','Indoor','3-4 times a week. Boxing classes are 60 minutes long and are structured in three “rounds” that include an intense cardio warmup, bodyweight exercises, and core work.')");
            Sql("INSERT INTO dbo.SportModels(SportName,SportType,SportDrill) VALUES ('Gymnastic','Indoor','sessions last roughly 20 minutes each, that breaks down to about three hours of exercise a week (90 minutes/ 2 days a week).')");
            Sql("INSERT INTO dbo.SportModels(SportName,SportType,SportDrill) VALUES ('Volleyball','Outdoor','60-90 minutes, 2 - 3days per week with 24-48 hours of recovery')");

        }
        
        public override void Down()
        {
        }
    }
}
