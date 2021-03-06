USE [master]
GO
/****** Object:  Database [Db_Language_Course]    Script Date: 14.11.2020 15:03:32 ******/
CREATE DATABASE [Db_Language_Course]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Db_Language_Course', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER01\MSSQL\DATA\Db_Language_Course.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Db_Language_Course_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER01\MSSQL\DATA\Db_Language_Course_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [Db_Language_Course] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Db_Language_Course].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Db_Language_Course] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Db_Language_Course] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Db_Language_Course] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Db_Language_Course] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Db_Language_Course] SET ARITHABORT OFF 
GO
ALTER DATABASE [Db_Language_Course] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Db_Language_Course] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Db_Language_Course] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Db_Language_Course] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Db_Language_Course] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Db_Language_Course] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Db_Language_Course] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Db_Language_Course] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Db_Language_Course] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Db_Language_Course] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Db_Language_Course] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Db_Language_Course] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Db_Language_Course] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Db_Language_Course] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Db_Language_Course] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Db_Language_Course] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Db_Language_Course] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Db_Language_Course] SET RECOVERY FULL 
GO
ALTER DATABASE [Db_Language_Course] SET  MULTI_USER 
GO
ALTER DATABASE [Db_Language_Course] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Db_Language_Course] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Db_Language_Course] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Db_Language_Course] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Db_Language_Course] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Db_Language_Course', N'ON'
GO
ALTER DATABASE [Db_Language_Course] SET QUERY_STORE = OFF
GO
USE [Db_Language_Course]
GO
/****** Object:  Table [dbo].[tbl_articles]    Script Date: 14.11.2020 15:03:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_articles](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[article_title] [nvarchar](500) NULL,
	[article_content] [nvarchar](max) NULL,
	[article_date] [datetime] NULL,
	[status] [bit] NULL,
 CONSTRAINT [PK_tbl_articles] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_exams]    Script Date: 14.11.2020 15:03:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_exams](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[exam_date] [nchar](25) NULL,
	[article_id] [int] NULL,
	[article_title] [nchar](2000) NULL,
	[status] [bit] NULL,
 CONSTRAINT [PK_tbl_exams] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_question]    Script Date: 14.11.2020 15:03:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_question](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[exam_id] [int] NULL,
	[status] [bit] NULL,
	[question1_text] [nvarchar](max) NULL,
	[option1_a] [nvarchar](500) NULL,
	[option1_b] [nvarchar](500) NULL,
	[option1_c] [nvarchar](500) NULL,
	[option1_d] [nvarchar](500) NULL,
	[correct_answer1] [nvarchar](500) NULL,
	[question2_text] [nvarchar](max) NULL,
	[option2_a] [nvarchar](500) NULL,
	[option2_b] [nvarchar](500) NULL,
	[option2_c] [nvarchar](500) NULL,
	[option2_d] [nvarchar](500) NULL,
	[correct_answer2] [nvarchar](500) NULL,
	[question3_text] [nvarchar](max) NULL,
	[option3_a] [nvarchar](500) NULL,
	[option3_b] [nvarchar](500) NULL,
	[option3_c] [nvarchar](500) NULL,
	[option3_d] [nvarchar](500) NULL,
	[correct_answer3] [nvarchar](500) NULL,
	[question4_text] [nvarchar](max) NULL,
	[option4_a] [nvarchar](500) NULL,
	[option4_b] [nvarchar](500) NULL,
	[option4_c] [nvarchar](500) NULL,
	[option4_d] [nvarchar](500) NULL,
	[correct_answer4] [nvarchar](500) NULL,
 CONSTRAINT [PK_Question] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tbl_users]    Script Date: 14.11.2020 15:03:52 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_users](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[user_name] [varchar](100) NULL,
	[password] [varchar](50) NULL,
	[role] [int] NULL,
	[status] [bit] NULL,
 CONSTRAINT [PK_tbl_users] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[tbl_articles] ON 

INSERT [dbo].[tbl_articles] ([id], [article_title], [article_content], [article_date], [status]) VALUES (1, N'Fireball Is Werner Herzog’s Ode to Space Rocks', N'THE RAMGARH CRATER in northern India was formed millions of years ago when a large meteorite crashed into Earth. But it wasn’t until the 19th century that scientists began to believe it was an impact basin. From the ground, it’s difficult to assess that it''s a crater. The thing is just too big to take in all at once. Yet the cluster of temples in the center of Ramgarh suggests ancient cultures recognized there was something special about the place, even if they had no way of knowing it was formed by a rock from outer space. Examining the effects of meteorites is always scientific, but it’s often spiritual, too, and it’s the tension between those two disciplines that drives Fireball. Written and directed by Werner Herzog, the documentary aims to make sense of extraterrestrial geology, to trace all the ways meteorites have made impressions far beyond the edges of any individual crater. Herzog and his codirector, Cambridge University volcanologist Clive Oppenheimer, interview boffins geeking out over meteorites in their lab, of course, but also a jazz musician prowling for micrometeorites on the rooftops of Oslo, an indigenous painter chronicling otherworldly stories in the outback of Australia, and a Jesuit priest keeping vigil over a meteorite collection in a secluded European observatory. “Every stone has its own separate story,” Herzog says.

Oppenheimer traces the genesis of Fireball, which drops Friday on Apple TV+, to a visit to Korean Polar Research Institute, which sponsors an annual Antarctic expedition to collect meteorites. When Oppenheimer saw the vast collection of meteorites stored at the institute, he knew there was a bigger story to tell. “I was struck by the significance these stones have for understanding the earliest period of the solar system and the building blocks of life on Earth,” he says. “I just felt instantly that meteorites are a phenomenon that speak to us on both a scientific and a metaphysical level.” Oppenheimer had previously collaborated with Herzog on Into the Inferno, and when he pitched the German auteur on a movie about meteorites he didn’t have to wait long for a decision. “It was five seconds and it was clear we were going to do it,” Herzog says.

Meteorites are the perfect topic for a filmmaker like Herzog. His best work has always featured subjects that occupy liminal spaces where two worlds collide—East and West, the human and the supernatural, the digital and the analog. Fireball falls squarely in this tradition. Meteorites are both a local phenomenon that have shaped communities and an existential threat faced by the entire planet. They’re messengers from the deep past heralded as portents, and inert pieces of matter that carry the building blocks of life. They’re the source of both scientific and spiritual wonder, and in this respect, meteorites have a lot in common with the humans who study them.

Even though Fireball is ostensibly a science documentary, it doesn’t feel like one. “Documentaries about science are always very predictable, and many of them are too didactic,” Herzog says. “We said we shall never be didactic, we will give insights of a deeper nature than just science.”

While Herzog and Oppenhemier drop plenty of mind-bending facts throughout the doc, they also know when some hand-waving will suffice. (Do you really want to know the mathematical basis of a quasicrystal? I didn’t think so.) Fans of Herzog will also relish his moody and often humorous voice-overs, which transform a Mexican port town into “a beach resort so godforsaken you want to cry” and stray dogs sunning themselves in a crater into beasts too dumb to reckon with the cosmic implications of their tanning bed.

More than 100 tons of space rock falls to earth every day. Most of these meteorites arrive as microscopic particles of cosmic dust, but every so often one comes along that’s big enough to shape the destiny of an individual, a community, or the entire planet. This is what Herzog meant when he said each of these stones has a story. It feels natural to attribute meaning to a natural event caused by random fluctuations in an unfeeling universe. Sometimes the story starts with a meteorite. Other times, it’s how the story ends.', CAST(N'2020-11-12T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[tbl_articles] ([id], [article_title], [article_content], [article_date], [status]) VALUES (2, N'25 Gift Ideas for People Who Hate Being Inside
', N'If you know someone who wants to break out of their stuffy home this winter, give them these escape tools.
FALL AND WINTER are the perfect seasons for outfitting the adventurous person in your life with warm and helpful outdoor gear. Our guide accounts for all the winter conditions any outdoors-loving person could encounter, from snowdrifts in Maine to crisp California temperatures in the 50s. With some of these cold-weather keepers, your loved one can go out and enjoy the breathtaking snowy scenery and gobble up the uncrowded trails. Some of our picks can even be used year-round.

Check out more of our buying guides. We have a growing number of outdoor gear guides, including the Best Action Cameras, Best Fitness Trackers, and Best Electric Bikes.  ', CAST(N'2018-07-08T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[tbl_articles] ([id], [article_title], [article_content], [article_date], [status]) VALUES (3, N'An Engineer Gets 9 Years for Stealing $10M From Microsoft', N'A FORMER MICROSOFT software engineer from Ukraine has been sentenced to nine years in prison for stealing more than $10 million in store credit from Microsoft''s online store. From 2016 to 2018, Volodymyr Kvashuk worked for Microsoft as a tester, placing mock online orders to make sure everything was working smoothly.  The software automatically prevented shipment of physical products to testers like Kvashuk. But in a crucial oversight, it didn''t block the purchase of virtual gift cards. So the 26-year-old Kvashuk discovered that he could use his test account to buy real store credit and then use the credit to buy real products.

At first, Kvashuk bought an Office subscription and a couple of graphics cards. But when no one objected to those small purchases, he grew much bolder. In late 2017 and early 2018, he stole millions of dollars worth of Microsoft store credit and resold it online for bitcoin, which he then cashed out using Coinbase.

US prosecutors say he netted at least $2.8 million, which he used to buy a $160,000 Tesla and a $1.6 million waterfront home (his proceeds were less than the value of the stolen credit because he had to sell at a steep discount).

Kvashuk made little effort to cover his tracks for his earliest purchases. But as his thefts got bigger, he took more precautions. He used test accounts that had been created by colleagues for later thefts. This was easy to do because the testers kept track of test account credentials in a shared online document. He used throwaway email addresses and began using a virtual private networking service.

Before cashing out the bitcoins, he sent them to a mixing service in an attempt to hide their origins. Kvashuk reported the bitcoin windfall to the IRS but claimed the bitcoins had been a gift from his father.

But the government''s complaint included quite a bit of evidence linking Kvashuk to the crime.

He sometimes used the same VPN connection—and hence the same IP address—to access different accounts, allowing investigators to draw connections between his known accounts and those used for later thefts. Device fingerprinting techniques also provided circumstantial evidence linking Kvashuk to the larger heists.

The feds also argued that the timing of Kvashuk''s sudden bitcoin wealth was suspicious. "The value of the bitcoin deposits to Kvashuk''s Coinbase account generally correlated with the value of the purchased and redeemed [Microsoft credit]," the government argued.

A jury found the government''s arguments convincing and convicted Kvashuk on several counts in February.

"Stealing from your employer is bad enough, but stealing and making it appear that your colleagues are to blame widens the damage beyond dollars and cents," US attorney Brian Moran said in a press release. Kvashuk was convicted of "five counts of wire fraud, six counts of money laundering, two counts of aggravated identity theft, two counts of filing false tax returns, and one count each of mail fraud, access device fraud, and access to a protected computer in furtherance of fraud," the government wrote.

Kvashuk has been ordered to pay $8.3 million in restitution, though it seems unlikely he''ll ever be able to do that. The government says he may be deported after serving his time in prison. ', CAST(N'2019-10-10T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[tbl_articles] ([id], [article_title], [article_content], [article_date], [status]) VALUES (4, N'Can Biden Make Climate Progress With a Divided Congress? Actually, Yeah', N'WHEN PRESIDENT-ELECT JOE Biden took the stage in Wilmington, Delaware, Saturday night to deliver his victory speech, he promised to "marshal the forces of science and the forces of hope” to fight the novel coronavirus, revive the economy, achieve racial justice—and protect the climate. The former vice president’s transition website calls for net zero carbon emissions by the year 2050, a lofty goal required to keep greenhouse gas emissions from causing the 2 degrees Celsius warming that scientists say will result in catastrophic climate-related disruptions, droughts, and storms by the end of the century.  Biden says he can save the climate while boosting jobs. He wants the federal government to rebuild roads, bridges, and buildings to make them more environmentally friendly; plug abandoned oil and gas wells to prevent emissions of planet-warming methane and carbon dioxide; build new electric-vehicle charging stations and roll out electric buses in every city with more than 100,000 residents; and launch a Climate Conservation Corps—among other things. It’s a super ambitious plan. But given the gridlock on Capitol Hill during the past six years, and the fact that, despite the push for a Green New Deal by some Democrats last year, no major environmental legislation has passed Congress since 1990, will any of Biden’s green plans even get off the ground?

Environmental groups hope that Biden will at least get the climate bus rolling in the right direction, while acknowledging that federal legislation might be a bridge too far. Even if the two disputed Senate seats in Georgia somehow flip to the Democrats, that would leave a 50-50 tie, with incoming vice president Kamala Harris as the tie breaker. But under current Senate rules, any non-spending bills require 60 votes to clear a filibuster challenge, meaning that climate bills would need to overcome that higher hurdle. The only shortcut is if climate measures are folded into a must-pass spending bill that only requires 51 votes.

Combining climate bills and a coronavirus stimulus package might be the winning ticket, according to Andrew Light, a former climate negotiator in the Obama-era State Department and now a senior fellow at the World Resources Institute, a Washington-based nonpartisan think tank. “That is a place where you could imagine some possibility,” Light says. He notes that more than 10 percent of former president Obama’s $787 billion stimulus package in 2009 went to climate-related spending, including clean energy innovation and renovation of the nation’s electrical grid. If Biden can get Congress to pass his trillion-dollar stimulus plan, earmarking 10 percent of that to fight climate change “can add up and be impactful,” Light says.

Many observers say that Biden will have a better chance at pushing his climate agenda through executive orders that don’t require congressional approval. Obama allowed California to require cleaner automobile tailpipe standards under such an executive order, an order that President Donald Trump promptly canceled and is now being fought in court. Trump also reversed Obama’s Clean Power Plan that would have cut greenhouse emissions produced by electric utilities and halted efforts to reduce climate-warming chemicals from refrigerants known as hydrofluorocarbons.

For his part, Biden says he will reverse Trump’s anti-climate executive orders. On day one, Biden says, he will get the US back into the Paris Climate Agreement, which places voluntary limits on nations’ greenhouse gas emissions. The country officially exited the Paris accord on November 4. He also plans to sign separate orders to ban new oil and gas drilling on federal lands and cancel the Keystone XL pipeline.

Trump’s climate reversals, if left unchecked, will result in an additional 1.8 gigatons of greenhouse gas emissions by the year 2035, about one-third of the US total, according to a recent study from the Rhodium Group, an independent energy research and analysis group. Study author John Larsen, a former policy analyst in the Department of Energy, says that the best climate bang for the buck comes from boosting mileage standards for US automobiles. And the biggest driver of that action might come from states, not Congress.', CAST(N'2017-04-05T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[tbl_articles] ([id], [article_title], [article_content], [article_date], [status]) VALUES (5, N'All Baby Yoda Does Is Coo and Destroy Things', N'BABY YODA IS a force of mass destruction. Yes, as of this week, the Child—the breakout star of the The Mandalorian, the one with a green face so sweet it moved Werner Herzog to tears and inspired zillions of squeeful memes—has progressed far beyond the cute creature fans inexplicably wanted to breastfeed and turned into something far more insidious. Don’t believe me? Look no further than this week’s episode, where (spoilers) the Child ate a woman’s unborn babies. OK, fine, they were unfertilized eggs, but they were the unfertilized eggs of a refugee, named Frog Lady, who was trying to get them to her husband so that together they could prevent their species'' extinction. Not exactly the kind of roe that comes with your sashimi plate. Yet, even as the Mandalorian is trying to help Frog Lady at great personal risk, Baby Yoda is just out of sight, popping her spawn like candy—and Disney expects you to laugh.

Making a heartless bastard out of a character who primarily exists to be cute is jarring, even though the little menace has been giving off some Dark Side vibes for a while. Sure, he healed a guy once, but he also levitated a fuzzy monster rhino just so Mando could kill it, and used the Force to choke someone, a Sithy signature second only to Force lightning. Now, post-spawn-slurp, Baby Yoda is basically just an amoral toddler goblin who causes a second round of chaos in this week’s episode when he almost gets everyone killed for devouring even more ovum, this time belonging to angry ice spiders. Remember when Baby Yoda was primarily famous for sipping soup? Whomst was the nerf herder who thought that this was a good idea?

Some Mandalorian fans are disturbed, enough that Lucasfilm creative executive Phil Szostak stepped in to explain that the egg-eating was bad, but not that bad.

', CAST(N'2015-12-10T00:00:00.000' AS DateTime), 1)
INSERT [dbo].[tbl_articles] ([id], [article_title], [article_content], [article_date], [status]) VALUES (6, N'deneme', N'deneme', CAST(N'2005-03-02T00:00:00.000' AS DateTime), 1)
SET IDENTITY_INSERT [dbo].[tbl_articles] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_exams] ON 

INSERT [dbo].[tbl_exams] ([id], [exam_date], [article_id], [article_title], [status]) VALUES (1, N'13 Kasım 2020 Cuma       ', 1, N'Fireball Is Werner Herzog’s Ode to Space Rocks                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  ', 1)
INSERT [dbo].[tbl_exams] ([id], [exam_date], [article_id], [article_title], [status]) VALUES (7, N'14 Kasım 2020 Cumartesi  ', 2, N'25 Gift Ideas for People Who Hate Being Inside
                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                ', 1)
INSERT [dbo].[tbl_exams] ([id], [exam_date], [article_id], [article_title], [status]) VALUES (8, N'14 Kasım 2020 Cumartesi  ', 4, N'Can Biden Make Climate Progress With a Divided Congress? Actually, Yeah                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                         ', 1)
SET IDENTITY_INSERT [dbo].[tbl_exams] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_question] ON 

INSERT [dbo].[tbl_question] ([Id], [exam_id], [status], [question1_text], [option1_a], [option1_b], [option1_c], [option1_d], [correct_answer1], [question2_text], [option2_a], [option2_b], [option2_c], [option2_d], [correct_answer2], [question3_text], [option3_a], [option3_b], [option3_c], [option3_d], [correct_answer3], [question4_text], [option4_a], [option4_b], [option4_c], [option4_d], [correct_answer4]) VALUES (5, 7, 1, N'deneme1', N'as', N'bb', N'cc', NULL, N'D', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[tbl_question] ([Id], [exam_id], [status], [question1_text], [option1_a], [option1_b], [option1_c], [option1_d], [correct_answer1], [question2_text], [option2_a], [option2_b], [option2_c], [option2_d], [correct_answer2], [question3_text], [option3_a], [option3_b], [option3_c], [option3_d], [correct_answer3], [question4_text], [option4_a], [option4_b], [option4_c], [option4_d], [correct_answer4]) VALUES (6, 8, 1, N'soru1', N'a1', N'b1', N'c1', N'd1', N'D', N'soru2', N'a2', N'b2', N'c2', N'd2', N'C', N'soru3', N'a3', N'b3', N'c3', N'd3', N'B', N'soru4', N'a4', N'b4', N'c4', N'd4', N'A')
SET IDENTITY_INSERT [dbo].[tbl_question] OFF
GO
SET IDENTITY_INSERT [dbo].[tbl_users] ON 

INSERT [dbo].[tbl_users] ([id], [user_name], [password], [role], [status]) VALUES (1, N'konusarakogren', N'123456', 1, NULL)
INSERT [dbo].[tbl_users] ([id], [user_name], [password], [role], [status]) VALUES (2, N'student1', N'123456', 2, NULL)
SET IDENTITY_INSERT [dbo].[tbl_users] OFF
GO
ALTER TABLE [dbo].[tbl_exams]  WITH CHECK ADD  CONSTRAINT [FK_tbl_exams_tbl_articles] FOREIGN KEY([article_id])
REFERENCES [dbo].[tbl_articles] ([id])
GO
ALTER TABLE [dbo].[tbl_exams] CHECK CONSTRAINT [FK_tbl_exams_tbl_articles]
GO
ALTER TABLE [dbo].[tbl_question]  WITH CHECK ADD  CONSTRAINT [FK_Question_tbl_exams] FOREIGN KEY([exam_id])
REFERENCES [dbo].[tbl_exams] ([id])
GO
ALTER TABLE [dbo].[tbl_question] CHECK CONSTRAINT [FK_Question_tbl_exams]
GO
USE [master]
GO
ALTER DATABASE [Db_Language_Course] SET  READ_WRITE 
GO
