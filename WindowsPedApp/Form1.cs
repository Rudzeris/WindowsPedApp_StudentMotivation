﻿using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace WindowsPedApp
{

    public partial class Form1 : Form
    {
        string MainMenuHelperText = "Здравствуйте! " + //Ввёл полностью текст в кавычках "text" и выбирал места и нажимал Enter
            "Это приложение разработано специально для преподавателей. " +
            "Оно поможет грамотно и интересно составить нетрадиционные занятия для студентов. " +
            "Это уникальное приложение поможет повысить мотивацию обучающихся, " +
            "а также облегчить нелёгкий труд по подготовке к занятиям.";
        string InstructionHelperText = "Здесь указан основной функционал приложения и как им пользоваться.";
        string MenuHelperText = "Это меню педагога.";
        string CreateLessonText1 = "Выберите урок в зависимости от дидактической цели. Здесь только одна кнопка - кнопка по центру.";
        string CreateLessonText2 = "Переменная: CreateLessonText2";
        string CreateLessonText3 = "Переменная: CreateLessonText3";
        string OtherText = "Здесь вы можете проверить себя и узнать дополнительную информацию.";
        string MethodicalText = "Переменная: MethodicalText";
        string TeacherTestText = "Переменная: TeacherTestText";
        //ClassTechnicalMaps CTM = new ClassTechnicalMaps();
        Color defaultButtonColor = SystemColors.ControlLight;
        Color selectButtonColor = Color.Teal;
        bool MethodicalSelect = false;


        struct MethodicalReceptionsStructure
        {
            string op;
            bool point;
            string text;
            public bool GetPoint()
            {
                return point;
            }
            public string GetOp()
            {
                return op;
            }
            public string GetText()
            {
                return text;
            }
            public void On()
            {
                point = true;
            }
            public void Off()
            {
                point = false;
            }
            public void Add(string t, string s)
            {
                point = false; text = s; op = t;
            }
        };

        MethodicalReceptionsStructure[] MethodicalReceptions = new MethodicalReceptionsStructure[9];

        byte LessonNumber;
        byte LessonPoint1X;
        byte LessonPoint2X;
        byte LessonPoint3X;

        public Form1()
        {
            InitializeComponent();
            Size = new Size(560, 700);

            //MinimizeBox= false;
            MaximizeBox = false;

            LiteraturesRichTextBox.Text = "Гин А. А";

            LessonPoint11.SelectionAlignment = HorizontalAlignment.Center;
            LessonPoint12.SelectionAlignment = HorizontalAlignment.Center;
            LessonPoint13.SelectionAlignment = HorizontalAlignment.Center;
            LessonPoint14.SelectionAlignment = HorizontalAlignment.Center;
            LessonPoint15.SelectionAlignment = HorizontalAlignment.Center;
            LessonPoint16.SelectionAlignment = HorizontalAlignment.Center;
            //LessonPoint21.SelectionAlignment = HorizontalAlignment.Center;
            //LessonPoint22.SelectionAlignment = HorizontalAlignment.Center;
            //LessonPoint23.SelectionAlignment = HorizontalAlignment.Center;
            //LessonPoint24.SelectionAlignment = HorizontalAlignment.Center;
            //LessonPoint25.SelectionAlignment = HorizontalAlignment.Center;
            //LessonPoint26.SelectionAlignment = HorizontalAlignment.Center;

            OpenMainMenu();
            MethodicalAddText();
        }
        Point sizeDefault = new Point(520, 637);
        Point locationDefault = new Point(12, 12);

        private void HelperNewLocation(int x, int y)
        {
            HelperLabel.Location = new Point(HelperLabel.Location.X + x, HelperLabel.Location.Y + y);
            HelperButtonClose.Location = new Point(HelperButtonClose.Location.X + x, HelperButtonClose.Location.Y + y);
            HelperPictureBox.Location = new Point(HelperPictureBox.Location.X + x, HelperPictureBox.Location.Y + y);
        }

        private void OpenHelper(string str, int x = 0, int y = 0, int x2 = 0, int y2 = 0)
        {
            HelperPictureBox.Visible = true;
            HelperLabel.Visible = true;
            HelperButtonClose.Visible = true;
            HelperLabel.Location = new Point(226 - x - x2, 230 - y - y2);
            HelperLabel.Size = new Size(270 + x, 120 + y);
            HelperButtonClose.Location = new Point(226 - x - x2, 230 - y - y2);
            HelperPictureBox.Location = new Point(389, 344);
            HelperLabel.Text = str;

            switch (Text)
            {
                case "Main Menu":
                    HelperPictureBox.BackColor = MainMenu.BackColor;
                    HelperLabel.BackColor = MainMenu.BackColor;
                    HelperButtonClose.BackColor = MainMenu.BackColor;
                    break;
                case "Menu":
                    HelperPictureBox.BackColor = Menu.BackColor;
                    HelperLabel.BackColor = Menu.BackColor;
                    HelperButtonClose.BackColor = Menu.BackColor;
                    break;
                case "Instruction":
                    HelperPictureBox.BackColor = Instruction.BackColor;
                    HelperLabel.BackColor = Instruction.BackColor;
                    HelperButtonClose.BackColor = Instruction.BackColor;
                    break;
                case "Literatures":
                    HelperPictureBox.BackColor = Literatures.BackColor;
                    HelperLabel.BackColor = Literatures.BackColor;
                    HelperButtonClose.BackColor = Literatures.BackColor;
                    break;
                case "Create Lesson":
                    HelperPictureBox.BackColor = CreateLesson.BackColor;
                    HelperLabel.BackColor = CreateLesson.BackColor;
                    HelperButtonClose.BackColor = CreateLesson.BackColor;
                    break;
                case "Technological map":
                    HelperPictureBox.BackColor = TechnologicalMap.BackColor;
                    HelperLabel.BackColor = TechnologicalMap.BackColor;
                    HelperButtonClose.BackColor = TechnologicalMap.BackColor;
                    break;
                case "Other":
                    HelperPictureBox.BackColor = Other.BackColor;
                    HelperLabel.BackColor = Other.BackColor;
                    HelperButtonClose.BackColor = Other.BackColor;
                    break;
            };
        }

        private void CloseAll()
        {
            object a = new object();
            EventArgs b = new EventArgs();
            MainMenuCloseHelper(a, b);
            Instruction.Visible = false;
            MainMenu.Visible = false;
            Literatures.Visible = false;
            Menu.Visible = false;
            TechnologicalMap.Visible = false;
            CreateLesson.Visible = false;
            Other.Visible = false;
            //LessonPanel2.Visible = false;
            LessonCompletePanel.Visible = false;
            TestPanel.Visible = false;
            MethodicalPanel.Visible = false;
            MethodicalTextPanel.Visible = false;
            OtherTextPanel.Visible = false;
            MotivationPanel.Visible = false;
            OpenTestPanel.Visible = false;
        }

        private void OpenMainMenu()
        {
            Text = "Main Menu";
            CloseAll();
            OpenHelper(MainMenuHelperText, 60, 50);
            HelperNewLocation(-50, -30);
            MainMenu.Visible = true;
            MainMenu.Size = new Size(sizeDefault);
            MainMenu.Location = locationDefault;
        }

        private void LessonPointDefault()
        {
            LessonPoint11.BackColor = CreateLesson.BackColor;
            LessonPoint12.BackColor = CreateLesson.BackColor;
            LessonPoint13.BackColor = CreateLesson.BackColor;
            LessonPoint14.BackColor = CreateLesson.BackColor;
            LessonPoint15.BackColor = CreateLesson.BackColor;
            LessonPoint16.BackColor = CreateLesson.BackColor;
            LessonPoint11.Visible = true;
            LessonPoint12.Visible = true;
            LessonPoint13.Visible = true;
            LessonPoint14.Visible = true;
            LessonPoint15.Visible = true;
            //LessonPoint16.Visible=true;
            LessonButton1.BackColor = Color.Red;
            LessonButton1.Text = "";
        }

        private void ButtonMainBack(object sender, EventArgs e)
        {
            if (Text == "Instruction" || Text == "Literatures" || Text == "Menu")
            {
                OpenMainMenu();
            }
            else
            if (Text == "Main Menu" || Text == "Create Lesson" || Text == "Technological map" || Text == "Other" || Text == "Lesson Complete")
            {
                if (Text == "Create Lesson")
                {
                    switch (LessonNumber)
                    {
                        case 1:
                            OpenMenu(sender, e);
                            break;
                        case 2:
                            OpenLessonPoint1X();
                            break;
                        case 3:
                            OpenLessonPoint2X();
                            break;
                    }
                }
                else
                    OpenMenu(sender, e);
            }
            else
                if (Text == "Test")
            {

                if (TestButtonResult.BackColor != Color.Blue)
                {
                    OpenOther(sender, e);
                }
                else
                {
                    OpenTest(sender, e);
                }
            }
            else if (Text == "Methodical receptions")
            {
                OpenMenu(sender, e);
            }
            else if (Text == "Methodical reception")
            {
                OpenMethodical(sender, e);
            }
            else if (Text == "Presentation" || Text == "Diagnostic Motivation Student")
            {
                OpenOther(sender, e);
            }
            else if (Text == "Motivation")
            {
                OpenMenu(sender, e);
            }
        }
        private void OpenInstruction(object sender, EventArgs e)
        {
            CloseAll();
            Text = "Instruction";
            OpenHelper(InstructionHelperText);
            Instruction.Visible = true;
            Instruction.Size = new Size(sizeDefault);
            Instruction.Location = locationDefault;
            InstructionRichText.Size = new Size(190, 590);


            HelperLabel.Location = new Point(260, 230);
            HelperButtonClose.Location = new Point(260, 230);
            HelperPictureBox.Location = new Point(360, 344);

        }
        private void OpenLiteratures(object sender, EventArgs e)
        {
            Text = "Literatures";
            CloseAll();
            Literatures.Visible = true;
            Literatures.Size = new Size(sizeDefault);
            Literatures.Location = locationDefault;
            MainMenuCloseHelper(sender, e);
        }
        private void MainMenuButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void OpenMenu(object sender, EventArgs e)
        {
            MethodicalSelect = false;
            CloseAll();
            Text = "Menu";
            OpenHelper(MenuHelperText);
            HelperNewLocation(-50, -130);
            Menu.Visible = true;
            Menu.Size = new Size(sizeDefault);
            Menu.Location = locationDefault;
        }
        private void MainMenuCloseHelper(object sender, EventArgs e)
        {
            HelperPictureBox.Visible = false;
            HelperLabel.Visible = false;
            HelperButtonClose.Visible = false;
            InstructionRichText.Size = new Size(420, 590);

            HelperLabel.Location = new Point(226, 230);
            HelperButtonClose.Location = new Point(226, 204);
            HelperPictureBox.Location = new Point(389, 344);

        }
        private void OpenCreateLesson(object sender, EventArgs e)
        {
            MethodicalSelect = true;
            CloseAll();
            LessonNumber = 0;
            LessonPoint1X = 0;
            Text = "Create Lesson";
            CreateLesson.Visible = true;
            CreateLesson.Location = locationDefault;
            CreateLesson.Size = new Size(sizeDefault);

            OpenLessonPoint1X();
        }
        private void OpenTechnologicalMap(object sender, EventArgs e)
        {
            CloseAll();
            Text = "Technological map";
            TechnologicalMap.Visible = true;
            TechnologicalMap.Location = locationDefault;
            TechnologicalMap.Size = new Size(sizeDefault);
        }
        private void OpenOther(object sender, EventArgs e)
        {
            CloseAll();
            Text = "Other";
            Other.Visible = true;
            Other.Location = locationDefault;
            Other.Size = new Size(sizeDefault);
            OpenHelper(OtherText);
            HelperNewLocation(-50, -50);
        }

        private void OpenLessonComplete(object sender, EventArgs e)
        {
            CloseAll();
            Text = "Lesson Complete";
            LessonCompletePanel.Visible = true;
            LessonCompletePanel.Location = locationDefault;
            LessonCompletePanel.Size = new Size(sizeDefault);
            LessonCompleteRichBox.Visible = false;
            LessonCompletePictureBox.Visible = true;

            CreateLessonRichTextBox();

        }

        private void OpenLessonPoint1X()
        {
            LessonPoint2X = 0;
            LessonPoint3X = 0;
            OpenHelper(CreateLessonText1, 54, -20, 80, -80);
            HelperNewLocation(-30, 56);

            LessonPointDefault();
            LessonNumber = 1;
            LessonPoint11.Text = "Урок усвоения новых знаний ";
            LessonPoint12.Text = "Урок комплексного применения знаний (урок закрепления изученного материала) ";
            LessonPoint13.Text = "Урок рефлексии по ФГОС (систематизации и обобщения полученных знаний) ";
            LessonPoint14.Text = "Урок развивающего контроля ";
            LessonPoint15.Text = "Урок коррекции знаний (работа над ошибками) ";
            LessonPoint16.Visible = false;
            if (LessonPoint1X != 0)
            {
                switch (LessonPoint1X)
                {
                    case 1:
                        LessonPoint11.BackColor = selectButtonColor;
                        break;
                    case 2:
                        LessonPoint12.BackColor = selectButtonColor;
                        break;
                    case 3:
                        LessonPoint13.BackColor = selectButtonColor;
                        break;
                    case 4:
                        LessonPoint14.BackColor = selectButtonColor;
                        break;
                    case 5:
                        LessonPoint15.BackColor = selectButtonColor;
                        break;
                    case 6:
                        LessonPoint16.BackColor = selectButtonColor;
                        break;
                }
                LessonButton1.BackColor = Color.Green;
                LessonButton1.Text = "Далее";
            }
        }

        private void OpenLessonPoint2X()
        {
            MethodicalPanel.Visible = false;
            CreateLesson.Visible = true;
            LessonPointDefault();
            OpenHelper("Текст для 2-го задания", 54, -20, 80, -80);
            HelperNewLocation(-30, 56);
            LessonNumber = 2;
            switch (LessonPoint1X)
            {
                case 1:
                    LessonPoint11.Text = "Урок экскурсия";
                    LessonPoint12.Text = "Инсценировка";
                    LessonPoint13.Text = "Лекция";
                    LessonPoint14.Text = "Беседа";
                    LessonPoint15.Text = "Встреча";
                    LessonPoint16.Visible = false;
                    break;
                case 2:
                    LessonPoint11.Text = "Урок-суд";
                    LessonPoint12.Text = "Экскурсия";
                    LessonPoint13.Text = "Конференция";
                    LessonPoint14.Text = "Деловая игра";
                    LessonPoint15.Visible = false;
                    LessonPoint16.Visible = false;
                    break;
                case 3:
                    LessonPoint11.Text = "Комбинированный урок";
                    LessonPoint12.Text = "Деловая игра";
                    LessonPoint13.Text = "Практикум";
                    LessonPoint14.Text = "Конкурс";
                    LessonPoint15.Text = "Диспут";
                    LessonPoint16.BackColor = CreateLesson.BackColor;
                    LessonPoint16.Font = LessonPoint15.Font;
                    LessonPoint16.Visible = true;
                    LessonPoint16.Text = "Викторина";
                    break;
                case 4:
                    LessonPoint11.Text = "Тест";
                    LessonPoint12.Text = "Устный опрос";
                    LessonPoint13.Text = "Викторина";
                    LessonPoint14.Text = "Коллоквиум";
                    LessonPoint15.Text = "Конкурс";
                    LessonPoint16.Visible = false;
                    break;
                case 5:
                    LessonPoint11.Text = "Зачетное занятие";
                    LessonPoint12.Text = "Экзамен";
                    LessonPoint13.Text = "Семинар";
                    LessonPoint14.Text = "Аукцион знаний";
                    LessonPoint15.Text = "Урок-конкурс";
                    LessonPoint16.Visible = false;
                    break;
            }
            if (LessonPoint2X != 0)
            {
                switch (LessonPoint2X)
                {
                    case 1:
                        LessonPoint11.BackColor = selectButtonColor;
                        break;
                    case 2:
                        LessonPoint12.BackColor = selectButtonColor;
                        break;
                    case 3:
                        LessonPoint13.BackColor = selectButtonColor;
                        break;
                    case 4:
                        LessonPoint14.BackColor = selectButtonColor;
                        break;
                    case 5:
                        LessonPoint15.BackColor = selectButtonColor;
                        break;
                    case 6:
                        LessonPoint16.BackColor = selectButtonColor;
                        break;
                }
                LessonButton1.BackColor = Color.Green;
                LessonButton1.Text = "Далее";
            }
        }

        private void OpenLessonPoint3X()
        {
            LessonButton2.BackColor = Color.Green;
            LessonButton2.Text = "Далее";
            Text = "Create Lesson";
            LessonNumber = 3;
        }
        private void CreateLessonRichTextBox()
        {
            LessonCompleteRichBox.Text = "      Ваша рекомендация по созданию урока"; // Начальная инфа
            string text1 = "\n\n"; // 2 отступа вниз после каждого выбора

            // Информация под конец.
            string OsnInf = "";

            switch (LessonPoint1X)
            {
                case 1:
                    LessonCompleteRichBox.Text = "   Это урок, на котором педагог объясняет новый материал. Он строится в соответствии с требованиями ФГОС несколько иначе, нежели прежде. \n•    В начале следует провести этап мотивации, который, впрочем, немногим отличается от прежнего оргмомента. \n•    Затем следует этап актуализации изученного (повторения) с попыткой решить проблемную задачу, опираясь лишь на уже известную информацию. \n•    Вывод о необходимости еще какого-то знания и получение его тем или иным способом (например, в процессе наблюдения или эксперимента). Это так называемое первичное усвоение материала. \n   А далее: \n•    Этап самостоятельного осмысления; в его ходе школьники выполняют работу самостоятельно. \n•    Проверка. Обсуждение вопроса, какое место занимает новое знание в общей системе знаний, каковы возможности его практического применения. \n•    Инструктаж по домашнему заданию; рефлексия. Разумеется, это приблизительный план хода урока. При этом решаются различные задачи: образовательные (научить, познакомить, проанализировать и т.д.), воспитательные (формировать познавательную и творческую активность, любовь к Родине, к природе, к литературе, воспитывать упорство, любознательность и проч.) и развивающие (формировать умение анализировать, сопоставлять, читать схемы, пользоваться справочной литературой и т.п.).\n   ";
                    LessonCompleteRichBox.Text += text1;
                    switch (LessonPoint2X)
                    {
                        case 1:
                            LessonCompleteRichBox.Text += "   Для достижения поставленных целей в современных условиях актуально проведение занятий с использованием экскурсий.\n    Производственные или учебные экскурсии (ПЭ) - это одна из многочисленных форм профориентационной работы с учащимися. Они имеют большое образовательное, политехническое и воспитательное значение.\n   ПЭ служит формой наглядного ознакомления учащихся с техникой и технологией, организацией производства, содержанием труда, условиями труда и пр.\n   В основном ПЭ рассматриваются как средство формирования и развития у студентов интереса к различным профессиям. Однако ПЭ - это не только одна из форм внеурочной деятельности педагога по оказанию помощи студентам в их профессиональном самоопределении. ПЭ предусматриваются и учебными программами.\n   Основная цель ПЭ - расширение политехнического образования студентов . Экскурсия на какое-либо предприятие, проводимая в органичной связи с содержанием учебных дисциплин, показывает неразрывную связь теории и практики в производственной деятельности людей.\n   \n   Экскурсия (от лат. excursio — прогулка, поездка) — коллективное посещение музея, достопримечательного места, выставки, предприятия и т.п.; поездка, прогулка с образовательной, научной, спортивной или увеселительной целью.\n   Учебная экскурсия — это проведение учебного занятия в условиях производства, природы, музея с целью наблюдения и изучения студентами различных объектов и явлений действительности.\n    Являясь самостоятельной формой обучения, экскурсия входит важной составной частью в систему учебно-воспитательной работы и вносит свой весомый вклад в формирование всесторонне развитой личности.\n   Перед экскурсиями ставятся такие задачи: обогащать знания студентов  (на основе непосредственного восприятия, накопления наглядных представлений и фактов); устанавливать связи теорий с практикой, с жизненными явлениями и процессами; развивать творческие способности студентов (учащихся), их самостоятельность, организованность в учебном труде, чувства коллективизма и взаимопомощи; обогащать эстетические чувства; развивать наблюдательность, память, мышление, эмоции; активизировать познавательную и практическую деятельность; воспитывать положительное отношение к учению. Экскурсия дает широкие возможности для более полного, комплексного использования методов обучения (и в первую очередь проблемных).\n   Важнейшее назначение учебных экскурсий заключается в выявлении жизненности и актуальности учебного материала, в закреплении и конкретизации знаний, полученных на уроках, в применении знаний и умений на практике. Наглядность — существеннейший признак учебной экскурсии: удельный вес зрительной и слуховой наглядности в получении информации на экскурсии составляет более 70 процентов. Благодаря наглядности студенты (учащиеся) быстрее усваивают знания, которые затем на учебных занятиях становятся опорным фактическим материалом при восприятии новой темы, при обобщении и формировании соответствующих выводов. Экскурсионные наблюдения используются также для проверки, исправления, уточнения уже имеющихся у студентов (учащихся) знаний и представлений, для обогащения их новыми конкретными данными. Так, на экскурсии на промышленное или сельскохозяйственное предприятие происходит наглядное знакомство с практической деятельностью людей, с непосредственным использованием научных знаний, основы которых изучаются на занятии, формируются представления о производственных процессах, организации производства, отношениях в коллективе.\n   Наблюдая и познавая явления общественной жизни, студенты (учащиеся) сами готовятся к активному участию в различных сферах общественно полезной деятельности.\n   Студенты (учащиеся) должны быть осведомлены о развитии и достижениях современной науки и техники.  К сожалению не урок, не факультатив, не просмотр научно- популярного фильма или специальной телепередачи не оказывает на студентов (учащихся) такого влияния, как полное впечатлений непосредственное соприкосновение с технологическим процессом производства. Во время экскурсии студенты (учащиеся) переносят знания в новую ситуацию, открывают для себя новые способы решения познавательных задач.( см. приложение).\n    В зависимости от типа, содержания и метода проведения экскурсии, возраста студентов (учащихся), местных условий и вида передвижения в состав экскурсионной группы может входить от десяти до сорока студентов.\n   Длительность учебной экскурсии  определяется в зависимости от учебных задач, конкретных условий проведения.\n   Каждая экскурсия связана с учебным материалом разных дисциплин\n   по профессиям.\n   Этапы подготовки экскурсии\n       \n1.   Определение цели и задачи экскурсии.   \n2.   Выбор темы.   \n3.   Отбор и изучение экскурсионных объектов.   \n4.   Составление маршрута экскурсии.   \n5.   Разработка заданий для учащихся.   \n6.   Составление методической разработки.\n    Цель экскурсии: наглядное ознакомление студентов (учащихся) с техникой и технологией , организации с/х  производства.\n   Задачи экскурсии:   \n1.   обогащать знания студентов (учащихся) на основе непосредственного восприятия, накопления наглядных представлений и фактов;   \n2.   устанавливать связи теорий с практикой, с жизненными явлениями и процессами   \n3.   развивать творческие способности студентов (учащихся),   \n4.   развивать самостоятельность, организованность в учебном труде, чувства коллективизма и взаимопомощи;   \n5.   развивать наблюдательность, память, мышление, эмоции;   \n6.   активизировать познавательную и практическую деятельность; воспитывать положительное отношение к учению. \n    В процессе подготовки экскурсии при отборе объектов проводится их оценка по следующим показателям (критериям):   \n1.   познавательная ценность;   \n2.   известность (популярность);   \n3.   месторасположение.\n   По мере сбора сведений об объекте студентам (учащимся) рекомендуется составить портфолио, в которое вносятся следующие сведения:   \n1.   наименование объекта;   \n2.   завод-изготовитель;   \n3.   техническая характеристика.   \n4.   назначение и место в технологическом процессе;   \n5.   особенности конструкции\n   \n   Проведение экскурсии.\n   Разбивка на группы( по 4-5 человек);\n   Выдача заданий по объектам;\n   Инструктаж;\n   Сбор информации согласно выданным заданиям.\n   Обработка собранного материала.\n   Подготовка к конференции:  презентация, фильм, репортаж, фотообозрение, доклад, плакаты и т. д\n   ";
                            break;
                        case 2:
                            LessonCompleteRichBox.Text += "   Имитационные методы активизации учебно-познавательной деятельности подразделяются - на игровые и не игровые.\nК игровым, относятся разыгрывание ролей и деловые игры различных модификаций. Они заполняют тот пробел в учебном процессе, которую не могут компенсировать другие методы (например, словесные методы, практические занятия и др.), но не заменяют их.     Игровой характер учебно-познавательной деятельности дает возможность ознакомиться со спецификой и особенностями определенной профессиональной деятельности, а также способствует ощущению своей роли в ней. Кроме того, они существенно помогают закреплению и углублению знаний, полученных во время бесед, лекций, рассказов, семинаров, практических занятий, совершенствованию практических навыков и умений, их применению, творческому использованию в решении профессиональных проблем, созданию условий для активного обмена опытом. \n    Основная функция этих занятий заключается в обучении путем действий (чем ближе игровая деятельность учащихся к реальной ситуации, тем выше ее учебно-познавательная эффективность).\n    Основными разновидностями игровых методов активизации учебно-познавательной деятельности является метод инсценировки и деловые игры.\n    Метод инсценировки имеет много общего с театром, который вызывает сильные чувства и, соответственно, влияет на эмоционально-волевую сферу личности. Один из древнейших методов обучения, он наиболее эффективен и на сегодня, потому что обеспечивает условия максимального приближения Дидактического процесса к действительности. \n    Характерными особенностями этого метода являются, во-первых, ознакомление участников занятия с конкретной Дидактической ситуацией, которая наиболее полно соответствует профессиональной деятельности и требует разрешения; во-вторых, предоставление им ролей конкретных должностных лиц, которые существуют в реальной ситуации; в-третьих, распределение этих ролей между студентами. \n    Метод инсценировки обеспечивает обучающимся такие условия для занятий, которые не в состоянии создать другие методы обучения – испытать на себе результаты своих решений и действий.\n    Можно использовать две формы инсценировки занятий: первая – это заранее подготовленное инсценирование; вторая – импровизированное инсценирование, которое по сравнению с первым возникает как бы невзначай, случайно и неожиданно во время обсуждения определенных учебных проблем. \n    В первом случае педагог заранее готовит такие ситуации и выдвигает их для обсуждения во время рассмотрения общей учебной проблемы. Во втором – ситуацию предлагают сами студенты во время дискуссии по определенной проблеме, а педагог должен умело инсценировать эту учебную проблему для коллективного разыгрывания.\nИнсценировка занятия может осуществиться так: \n– роли распределяются между отдельными студентами, а другие выполняют роль активного зрителя или функции «арбитра»; \n– обучающиеся разделяются на небольшие группы. Каждая группа выполняет роль определенного должностного лица, участника ситуации и др. Сначала они активно дискутируют в этих группах над решением дидактической проблемы, после чего представители групп предлагают всем студентам для дискуссионного обсуждения свой вариант.\n    Безусловно, этот метод требует от педагога всесторонней подготовки, умение методически правильно обрабатывать ситуации, которые должны быть разыгранными, и обладание необходимыми навыками и умениями для их воплощения.\n    Существенным мотивом проведения таких занятий есть соответствующая подготовленность учащихся к активному участию в них. Учитывая вышесказанное, можно дать некоторые методические рекомендации. \n    Занятия методом инсценировки рекомендуется проводить в основном при рассмотрении ситуаций, в основе которых лежат проблемы при изучении тем, касающихся совершенствования стиля и методов работы должностных лиц. Педагог должен умело подойти к выбору конкретной ситуации: во-первых, ее необходимо брать из практики; во-вторых, она должна входить в круг будущих обязанностей студента; в-третьих, быть интересной по содержанию и нестандартной по характеру решения. За то педагог должен вдумчиво проработать конкретную дидактическую ситуацию. Она должна включать общий фон ситуации, конкретную дидактическую проблему, четкое распределение ролей в соответствии с «функциональными обязанностями» и определение характера деятельности обучающихся.     Дидактическую проблему, подлежащую инсценировке, нужно подробно описать с четкими общими и индивидуальными инструкциями. Эти описания должны быть объективными, без какого-либо критического анализа и оценочных фактов, но со всеми необходимыми элементами, которые помогут учащимся выяснить сущность дидактической проблемы. \n    Определению этих аспектов и недопущению определенных организационных и методических ошибок способствует подробный план инсценировки, где педагог предполагает свои действия и действия участников занятия, расписывает эти действия во времени. \n    Описание ситуации и конкретные общие и индивидуальные инструкции по выполнению определенных ролей раздаются участникам или накануне занятия, или во время занятия в зависимости от его дидактического и методического замысла. Но в любом случае должно быть достаточно времени для обдумывания дидактической проблемы и осознание роли каждого в ее решении, составление плана и его реализации. \n    Следовательно, описание должно содержать информацию для учебной группы, с которой знакомятся все участники занятия, и конкретных лиц в соответствии с их ролей. Характер общей информации или инструкции должен помогать участникам занятия понять дидактическую проблему, формировать эмоционально положительное отношение к ней и содействовать активному участию всех студентов в инсценировке. Индивидуальные инструкции доводятся до сведения конкретных исполнителей соответствующих ролей. Если только некоторые студенти получили роли, а остальные – активные зрители или «арбитры», до последних также доводят содержание индивидуальных инструкций. В связи с этим они являются наиболее информированными в этом занятии, потому что, знают как общую, так и индивидуальные инструкции. Поэтому им остается только оценить характер рассуждений каждого исполнителя и их решение. При этом с дидактической целью им можно разъяснить, на что следует обращать особое внимание и Что необходимо оценить. \nХод таких занятий во многом зависит от умелого управления. Подготовительными работами руководит, безусловно, педагог, а ходом занятия – как педагог, так и определенный студент в соответствии с конкретной педагогической ситуации и дидактического замысла. Но всегда педагог четко определяет порядок проведения занятия и разъясняет правила дискуссии, ведь успеху всего занятия, прежде всего, способствуют атмосфера эмоциональной приподнятости,«театральности» и отсутствие скованности. \n    После этого начинается обсуждение дидактической проблемы между участниками инсценировки, им необходимо дать время на «вживание» в роли, а также возможность обращаться к педагогу за определенными уточнениями и дополнительной информацией. Во время инсценировки другие участники-зрители не должны мешать исполнителям советами. \n    Такие занятия заканчиваются общей дискуссией: оценивается динамика их хода, игра как отдельных обучающихся, так и всей учебной группы. В зависимости от дидактического и методического замысла занятия содержание дискуссии может быть разным, но в любом случае педагог должен требовать от участников четкой аргументации и научного обоснования личных взглядов.     Обсуждение можно начинать с вопроса к исполнителям: как они сами оценивают исполнение ролей, и какими были бы их действия в реальной ситуации или во время повторной инсценировке? Исполнители в такой способ получают возможность критически оценить свои действия. Это стимулирует начало содержательной дискуссии.\n    Участники-зрители сначала оценивают положительные, а затем отрицательные аспекты в действиях исполнителей конкретных ролей. Все оценки систематизируются, анализируются и обобщаются педагогом. Чтобы выяснить отношение исполнителей ролей к критике, необходимо предоставить им возможность ответить на нее, обосновав свою позицию. После этого снова организуется дискуссия по вопросу наиболее обоснованного варианта решения дидактической проблемы. Итоги дискуссии подводит педагог. \n    Дидактически-воспитательная действенность метода инсценировки, как свидетельствует педагогическая практика, является очень высокой, потому что с его помощью можно реализовать такую дидактическую цель, которой нельзя достичь традиционными методами обучения.\n    Основные положительные аспекты инсценировки: этот метод облегчает учения; способствует наблюдению за собственными действиями и других; помогает критически их оценить; учит чувствовать мотивы действий товарищей и, соответственно, принимать более обоснованное решение; дает возможность всесторонне проанализировать дидактическую проблему с учетом, как личного мнения, так и мыслей других\n";
                            break;
                        case 3:
                            LessonCompleteRichBox.Text += "   1. Методика подготовки лекции\nПри анализе методики подготовки лекции особое внимание следует обращать на решение следующих организационно-методических вопросов:\n1. Определение основной цели лекции, ее главной идеи. Она (цель) задается требованиями учебной программы, местом лекции в изучаемой учебной дисциплине и самим названием. Целесообразно начинать подготовку лекции с постановки перед собой вопроса о том, для какой категории слушателей необходима данная лекция и какой конкретно материал необходимо вложить в ее текст. Ответив на поставленные вопросы, преподаватель конкретизирует содержание лекции.\n2. Уточнение объема материала, входящего в содержание лекции.\nПрактика показывает, что у преподавателя, готовящегося к написанию текста лекции, как правило, материала бывает значительно больше, чем его можно изложить за отведенное время. Следовательно, надо отобрать самое важное  для достижения поставленной цели. В этом случае следует экономить время для раскрытия главного – таково правило наиболее опытных преподавателей. Нехватка времени из-за чрезмерного объема материала – частый недостаток многих  начинающих преподавателей, которые еще не научились рассчитывать время, необходимое для изложения того или иного вопроса. Здесь им поможет простой методический прием: нужно прочитать вслух подготовленный текст, заметив время, а затем увеличить это время примерно на 20-30%.Как показывает практика, столько времени будет затрачено при чтении лекции в аудитории. Безусловно, при определении объема содержания лекции необходимо ориентироваться на требования учебной программы.\n3. Детальная проработка структуры лекции способствует уточнению содержания, его лучшему подчинению главной цели и выполнению основных требований. Практика показывает, что опытные преподаватели не ограничивают  проработку структуры определением основных вопросов, а продумывают их структуру. Каждый вопрос они разбивают на подвопросы и формулируют название последних. Это обеспечивает более строгое подчинение материала теме и цели лекции, позволяет лучше отобрать материал и логичнее его расположить.\n4. Написание текста лекции. По любой теме целесообразно иметь полный текст лекции. При ее написании преподаватель должен работать над тем, как повысить научность и практическую значимость лекции, реализовать все ее функции, как лучше скомпоновать материал. После того как написан первый вариант текста лекции, в него вносятся коррективы, продолжается работа над точностью и яркостью фраз и выражений. Придание тексту наглядности облегчает пользование им, однако нельзя превращать лекцию в чтение текста. Текст лекции должен вести, направлять изложение материала.\n5. Специальная подготовка средств наглядности и решение других организационно-методических вопросов – важный элемент в подготовке лекции. Тот факт, что использование в лекции средств наглядности является обязательным, не вызывает сомнений. Практика показывает, что 5-7 обращений преподавателя к использованию средств изобразительной наглядности бывает вполне достаточно.\n2. Методика чтения лекции\nВсегда следует помнить, что лекция имеет четкую структуру, включающую в себя: введение, основную часть и заключение. В каждом из ее элементов преподавателю следует соблюдать определенные действия и правила поведения, суть которых и определяет методику чтения лекции.\nВо введении к числу основных действий преподавателя можно отнести:\n1. Объявление темы и плана лекции, указание основной и дополнительной литературы.\n2. Разъяснение целей занятия и способов их достижения.\n3. Обозначение места лекции в программе и ее связь с другими дисциплинами.\n4. Создание рабочей обстановки в аудитории, вызвать у слушателей интерес к изучаемой теме.\nВ основной части лекции преподавателю можно рекомендовать следующие методические приемы:\n1. Установление контакта с аудиторией.\n2. Убежденное и эмоциональное изложение материала.\n3. Установление четких временных рамок на изложение материала по намеченному плану.\n4. Использование материала лекции как опорного для лучшего усвоения изучаемой дисциплины.\n5. Контроль за грамотностью своей речи (слогообразование, ударение и т.д.) и поведением.\n6. Наблюдение за аудиторией и поддержание с ней контакта на протяжении всего занятия.\nВ заключительной части лекции преподавателю рекомендуется:\n1. Подвести итоги сказанного в основной части и сделать выводы по теме.\n2. Ответить на вопросы обучающихся.\n3. Напомнить обучающимся о методических указаниях по организации самостоятельной работы.\n4. Объявить в аудитории очередную тему занятий и порекомендовать присутствующим ознакомиться с ее основным содержанием.\n3.  Правила оформления методической разработки лекции\n  Правила оформления титульного листа:\nЛицевая  сторона титульного  листа    оформляется  в  соответствии  с приложением 1.  \nУказывается:\n- название образовательной организации;\n- тема: название  темы  должно  соответствовать  ее  названию  в  учебной программе;\n- учебная дисциплина или междисциплинарный курс: название дисциплины или МДК указывается в соответствии с учебной программой;\n- курс, специальность\n- количество часов\n- разработчик\n- место рассмотрения (одобрения)\n Мотивация изучения темы:\nраскрывается значимость темы с учетом профильности  по  специальности,  формулируется  актуальность  для современной науки и здравоохранения.\nЦели занятия:\nУчебные:  ведущая  дидактическая  цель  лекции  определяется содержанием учебного материала, предусмотренного учебной программой, и предполагает усвоение определенного объема знаний. Знания, получаемые обучающимися, должны представлять собой систему, т.е. все они должны быть направлены на достижение конкретных целей обучения, являющихся частью  общей  системы  целей  по  специальности. Цели  формулируются  с  учетом компетентностного подхода.\nВоспитательные:  Воспитывающая  функция  опирается  на  принцип воспитывающего  обучения. Процессы  обучения  и  воспитания  находятся  в органичном  единстве. Их  объединяют  общие  цели – сформировать специалиста, понимающего  сущность  и  социальную  значимость  будущей профессии, обладающего чувством профессиональной ответственности за результаты  своего  труда;  воспитание  гражданина, способного  на  основе имеющихся  гуманитарных  и  социально-экономических  знаний  оценивать социально значимые факты и явления, проявляющего готовность соблюдать усвоенные  правовые  и  этические  нормы, определяющие  отношение  к человеку, обществу, окружающей среде и т.д.\nРазвивающие:  Суть  развивающей  функции  состоит, прежде  всего, в  том, чтобы  в  процессе  обучения  обеспечить  максимальное  развитие интеллектуальной, эмоциональной и волевой сфер личности, формирование и развитие  познавательных  интересов  и  способностей,  творческой активности.\n Формируемые общие и профессиональные компетенции:\nперечисляются те общие и профессиональные компетенции, формированию которых будет способствовать материал лекции.\nИнтеграционные  связи  (внутри-  и  межмодульные, внутри дисциплинарные, связь с другими учебными дисциплинами):  \n Оснащение: необходимо  перечислить  все  виды средств  обучения, используемые  на  лекции. (К  средствам  обучения относятся  учебно-наглядные  пособия, вербальные  средства, технические средства и специальное оборудование).\n Этапы занятия (с указанием хронометража)\nСписок литературы\n";
                            break;
                        case 4:
                            LessonCompleteRichBox.Text += "   В форме беседы полезно проводить и опрос и объяснение нового, материала на первой ступени обучения. Характерная особенность этой формы урока состоит в том, что учащиеся принимают в нем активное участие — отвечают на вопросы, делают самостоятельные выводы из демонстрационных опытов, объясняют явления. Все это, конечно, корректирует педагог, он руководит такой беседой, уточняет и окончательно формулирует ответы.\nВ начале урока целесообразно в форме беседы провести повторение с целью проверить знания учащихся и восстановить картину пройденного материала, чтобы перейти к последующим вопросам.\nЗатем полезно выявить примеры из жизненного опыта обучающихся, связанные с изучаемым вопросом (например, перед введением понятия об архимедовой силе — явления, замеченные ими при плавании), попросить обучающихся попытаться объяснить эти явления, тем самым показать им необходимость получения новых знаний (проблемная ситуация).\nПотом следует перейти к демонстрационным или самостоятельным опытам, объяснение которых сначала предложить дать обучающимся. При этом лучше вызвать учащихся для ответа поименно, в противном случае активно будут работать лишь несколько студентов. Сначала педагог задает вопрос, дает время для обдумывания и затем называет фамилию обучающегося. (Полезно иметь специальную тетрадь со списком класса и фиксировать в ней все ответы, за таких 2—3 ответа нужно ставить оценку в журнал. Можно оценить и вопрос обучающегося, если он выявляет знания.) В первую очередь рекомендуется вызвать слабого студента (но не слишком затягивать беседу). Если он ответит неверно, то попросить его внимательно слушать другие ответы, предупредить, что после выяснения правильного ответа он должен будет повторить его. После того как ответ будет найден и окончательно откорректирован учителем, такое повторение следует провести.\nДля успешного проведения урока-беседы важно, чтобы педагог установил хороший контакт с классом, наблюдал за ним и добивался полного понимания изучаемого на уроке вопроса.\nУрок-беседа — одна из наиболее трудных форм урока. Она требует от педагога хорошей профессиональной подготовки. Нужно тщательно подбирать вопросы и предвидеть возможные варианты ответов на них. Беседа должна проходить живо и непринужденно, только тогда она захватит всех обучающихся класса и даст нужный эффект.\nИ на первой ступени обучения часть урока может занимать длительный связный рассказ педагога. Он неизбежен в том случае, когда учащееся не располагают данными для самостоятельных выводов или описаний явления, например, при изложении основных положений молекулярно-кинетической или электронной теории; он необходим при изложении исторических сведений и технических приложений физики.\n";
                            break;
                        case 5:
                            LessonCompleteRichBox.Text += "   Подготовка  встречи. В первую очередь необходимо определиться с темой. Она должна быть актуальной и интересной. При этом ставятся цели встречи — чему должны научиться студенты, какие сделать выводы.\nВ соответствии с темой на встречу приглашаются люди, которые смогут отвечать на вопросы в качестве экспертов. Необходимо заранее договориться о посещении, а за день желательно еще раз обзвонить приглашенных людей. Время и место проведения обговариваются вместе с гостями. Продолжительность такого общения не должна быть более 1 часа.\nЗа неделю до встречи необходимо раздать пресс-релизы, в которых указываются тема, план, информация о приглашенных гостях и основные направ¬ления беседы. Студенты должны подготовить вопросы, которые педагог затем отдает приглашенным экспертам, чтобы те могли подготовить ответы.\nВ помощь преподавателю\nВо время проведения встреч, бесед, брифингов могут возникнуть некоторые трудности. Как справляться в сложных ситуациях, направляя общение в нужное русло?\nНекоторые студенты все время говорят, не давая высказаться другим. В этом случае можно периодически задавать вопрос:«А что думают по этому поводу другие?» Во внеурочное время преподаватель может поговорить со слишком активными студентами наедине и объяснить им важность того, чтобы в беседе участвовали не только они, но и другие их одногруппники.\nВ беседе студенты уклонились от темы. Можно сказать, примерно следующее:«Все, что вы сказали, очень интересно, но мне кажется, мы уклонились от темы. Давайте рассмотрим этот вопрос позже в свободное время, а сейчас вернемся к нашей теме». Еще одним способом является стимулирующий вопрос, который возобновит у ребят интерес к изначальной теме.\nНекоторые студенты мешают проведению дискуссии. В этой ситуации не следует срываться на проблемных обучающихся. Необходимо учитывать, что могут быть при¬чины подобного поведения. Надо постараться выяснить, что это за причины. Для этого необходимо понаблюдать за студентом и попробовать выяснить, что стало причиной возникшей с ним проблемы, как можно ее решить и как следует поступить в первую очередь. Можно посоветоваться с другими педагогами по этому поводу.\nДискуссия стала непредсказуемой. Такая проблема вполне может возникнуть, поскольку ответы не всегда можно предугадать. Они могут легко увлечься не тем аспектом освещаемой темы и начать развивать свои мысли в этом направлении. В такой ситуации необходимо уметь вовремя менять акцент беседы.\nЕсли вопрос, предложенный для обсуждения, не увлек студентов, необходимо иметь в запасе несколько других вопросов, удовлетворяющих основным целям дискуссии.\n";
                            break;
                        case 6:
                            LessonCompleteRichBox.Text += "";
                            break;
                    }
                    break;
                case 2:
                    LessonCompleteRichBox.Text = "•    Первый этап. Организационный этап\n   Организационный этап, очень кратковременный, определяет весь психологический настрой урока. Психологический настрой проводится для создания благоприятной рабочей обстановки, чтобы обучающиеся поняли, что им рады, их ждали.\n•    Второй этап. Проверка домашнего задания, воспроизведение и коррекция опорных знаний\n   Выявить пробелы в знаниях и способах деятельности обучающихся.\n•    Третий этап. Постановка цели и задач урока. Мотивация учебной деятельности \n   Это обязательный этап по ФГОС. На данном этапе педагогу необходимо создать проблемную ситуацию так, чтобы студенты сами назвали цель урока, а также саму тему. Результативность учебно-воспитательного процесса, состояние познавательной активности зависят от осознанности обучающегося цели деятельности.\n   Практические приемы: опорные схемы, диалог, мозговой штурм, мозговая атака, постановка проблемных вопросов, игровые моменты, раскрытие практической значимости темы, использование музыки и других эстетических средств.\n•    Четвёртый этап. Первичное закрепление в знакомой ситуации\n•    Пятый этап. Творческое применение и добывание знаний в новой ситуации (проблемные задания)\n•    Шестой этап. Информация о домашнем задании, инструктаж по его выполнению\n   Цель этапа: расширить и углубить знания, умения, полученные на уроке.\n   Задачи этапа:\n   — разъяснить методику выполнения домашнего задания;\n   — обобщить и систематизировать знания;\n   — способствовать применению знаний, умений, навыков в разных условиях;\n   — применить дифференцированный подход.\n   Домашние задания могут быть: устными или письменными; обычными или программированными; долгосрочными или краткосрочными; требовать от студентов различных усилий мысли (репродуктивные, конструктивные, творческие).\n•    Седьмой этап. Рефлексия (подведение итогов занятия)\n   Рефлексия — самоанализ и самооценка своей деятельности. Если говорить о рефлексии как этапе урока, то это оценивание своего состояния, эмоций, результатов своей деятельности на занятии.\n   ";
                    LessonCompleteRichBox.Text += text1;
                    switch (LessonPoint2X)
                    {
                        case 1:
                            LessonCompleteRichBox.Text += "   Виды урока-суда\nСуществует два варианта использования данной ролевой игры: полная и частичная. Полное судебное заседание подразумевает один судебный процесс, занимающий все урочное время. Частичный предполагает сразу несколько упрощенных судебных разбирательств в рамках одного урока.\n\"Мини-суд\" на уроке\nДля проведения урока выбираются сразу несколько микро-тем, которые предстоит обсудить.\nДля каждого судебного дела отбираются по три участника: судья, прокурор и адвокат. Каждое судебное заседание длится не более 5-8 минут.\nТакой вид урока удобен, когда ребятам нужно решить несколько вопросов по одной теме. Например, изучается тема \"Семейное право\". Студентам можно предложить сразу несколько ситуаций, требующих судебного вмешательства: развод, исполнение брачного договора, истребование алиментов на ребенка и т.д. Небольшие импровизированные \"суды\" помогут не только показать разнообразие возможных конфликтов, но и более прочно закрепить знание семейного кодекса.\nТеперь рассмотрим, как провести урок-суд в полном масштабе.\nУрок-суд: подготовка и реализация\nВесь процесс удобнее разделить на два этапа: этап подготовки и этап реализации.\nI. Подготовка к уроку\nПодготовительный этап к такому уроку занимает достаточно много времени, так как необходимо не только распределить роли, но и подготовить \"следственный материал\".\n •    Постановка проблемы и цели урока.\nРоль игровых судов в том, чтобы прийти к общему мнению по поставленной проблеме. Здесь не так важен вердикт с точки зрения \"виновен — не виновен\", сколько важно найти ответы на поставленные вопросы и достичь главной цели урока.\nТак, для литературного суда целью чаще всего выбирают \"характеристику героя\". Например, почему Печорина стоит причислить к \"лишним людям\"?\nМожно выбрать другую цель: \"Главная проблема произведения\". Например, для урока-суда по тексту Н. Лескова \"Леди Макбет Мценского уезда\" взять за гипотезу: \"Можно ли оправдать преступление, совершенное во имя любви?\"\nНа уроках истории роль главных героев урока-суда чаще всего отводят выдающимся политикам, государственным деятелям. Цели таких уроков могут быть разнообразными:\n •    выявить положительные и отрицательные стороны деятельности / политики;\n •    проанализировать поступки / политику того или иного деятеля с точки зрения современности;\n •    проанализировать деятельность героя с точки зрения сложившейся исторической обстановки и т.д.\nВ роли \"обвиняемого\" иногда выступает не личность, а явление, или группа людей. Например, можно проводить уроки \"Суд над наркоманией\", \"Суд над рабством\", \"Суд над декабристами\" и т.д. В этом случае в качестве цели урока можно выбрать следующие: \"оценка явления с точки зрения современности\", \"анализ пагубности / пользы явления\" и т.д.\nНе стоит думать, что урок-суд удобно проводить лишь в рамках гуманитарных предметов. Для точных наук тоже можно найти немало вариантов. Например, \"Суд над обыкновенными дробями\" (цель: доказать значение дробей в математической науке), \"Суд над логарифмами\" (цель: дать обзорное представление о логарифмах числа и логарифмической линейке). По химии: \"Суд над кислородом\" (или любым другим химическим элементом), в ходе которого в игровой форме постигаются свойства этого элемента и его роль в таблице Менделеева, его значение для человеческой деятельности, сферы его применения. По географии \"Суд над природой\" (цель: изучить виды стихийных действий и причины их возникновения), \"Суд над человечеством\" (цель: обсудить важнейшие проблемы экологии и пути их искоренения).  \nТаким образом, выбор \"обвиняемого\" зависит от фантазии педагога. Важнее другое — четко сформулировать проблему и цель урока-суда.\n •    Распределение ролей.\nВажно, чтобы в процессе были задействованы все обучающиеся. Поэтому, желательно подбирать такую тему, чтобы ситуация охватывала как можно больше студентов.\nВозможные роли:\n •    Обвиняемый;\n •    Потерпевший;\n •    Судья;\n •    Присяжные заседатели;\n •    Секретарь суда;\n •    Обвинитель (прокурор);\n •    Помощники прокурора;\n •    Защитник (адвокат);\n •    Помощники адвоката;\n •    Свидетели обвинения;\n •    Свидетели защиты;\n •    Независимые эксперты.\n\nРоли обучающиеся выбирают, по возможности, самостоятельно, ориентируясь на свои убеждения, желания и отношение к поставленной проблеме.\n •    Работа с классом.\nЕсли урок-суд проводится впервые, то педагог должен объяснить, как проходит судебный процесс, растолковать, в чем заключается роль каждого из участников. Желательно предоставить схему планируемого урока, чтобы ребята могли сориентироваться и по времени, и по ходу действия.\nПример схемы урока:\nВступительное слово судьи: представление героев \"суда\", представление обвиняемого и подзащитного, объявление главной проблемы (цели урока).\n •    Обвинительная речь прокурора.\n •    Выступление независимых экспертов.\n •    Выступление свидетелей обвинения.\n •    Речь защитника.\n •    Выступления свидетелей защиты.\n •    \"Последнее слово\" обвиняемого.\n •    Совещание судей.\n •    Приговор.\n •    Подведение итогов (рефлексия).\n\nРабота в группах.\nНа этом этапе удобнее объединить участников будущего процесса в три группы: обвинение, защита, независимые эксперты. Здесь начинается самая интересная и самая объемная часть работы — поиск улик и доказательств. Если это литературный суд, то обязательно цитирование текста произведения. Можно привлечь альтернативные источники — критические статьи, рецензии и дневники автора. Если суд исторический, то подробно изучаются научные статьи и гипотезы, мнения авторитетных ученых.\nЗатем участники групп обсуждают те моменты, которые кажутся им наиболее убедительными, подчеркивающими и доказывающими их правоту. Здесь учителю важно направить работу каждой группы, по возможности объяснить, как должна строиться защита или обвинение.\nИндивидуальная работа.\nКаждый участник будущего процесса составляет план своего выступления, готовит вопросы для оппонентов.\nРоль педагога на данном этапе сводится к консультированию. Можно подсказать студентам дополнительные источники информации, скорректировать их поиск, помочь с составлением плана выступления. Но важно, чтобы работа проводилась по большей части самостоятельно.\nОсобенно важная роль отводится судье. В ходе процесса судья должен не просто выслушивать мнения героев, но и обязательно задавать вопросы. Причем вопросы не обязательно должны быть уточняющими — по поводу каких-то деталей или несущественных мелочей. Хорошо, если получится задавать вопросы провокационные, заставляющие задуматься: \"А правильно ли я выбрал роль в процессе?\" Такие вопросы должны заставлять искать ответ не в тексте, а в жизненной позиции каждого участника, то есть учить детей анализировать материал, вырабатывать и отстаивать свою точку зрения.\n• Этап реализации\nДля урока желательно расставить мебель в комнате таким образом, чтобы воссоздать обстановку судебного зала: отдельные места для защиты и обвинения, скамья подсудимого, верховное место судьи.\nВажно!\nСледует четко следовать намеченному плану проведения судебного заседания. То есть, если для речи прокурора, например, отведено 3 минуты, то важно придерживаться этого времени и не давать студенту растекаться мыслью по древу.\nУрок-суд не предполагает обмена мнениями. Цель уроков — другая: в ходе дискуссии прийти к единому мнению по поставленной проблеме.\nДля воссоздания \"полной картины\" желательно придерживаться форм обращения, принятых в суде (Ваша честь, господин прокурор / адвокат, \"Встать! Суд идет!\", \"Слово предоставляется…\" и т.д.). Можно ввести и моменты приведения свидетелей к присяге. Но, если такие мелочи занимают много времени, их лучше пропустить, оставив лишь общую фабулу процесса.\nНе стоит забывать и о техническом оснащении. Например, можно рекомендовать студентам использовать в своих выступлениях наглядные материалы, презентации, схемы, графики и т.д.\nЗавершающий этап урока является одним из основных. После того, как вынесен приговор, необходимо проанализировать итоги урока, то есть провести рефлексию.\nПри этом важно учесть следующие моменты:\n •    степень активности обучающихся и степень их подготовленности;\n •    использование дополнительной информации, продуктивность самостоятельной работы;\n •    оценка обучающимися итогов урока: согласны или нет с вердиктом?\n •    оценка обучающимися степени \"интересности\" и познавательности такой формы урока.\n";
                            break;
                        case 2:
                            LessonCompleteRichBox.Text += "   Для достижения поставленных целей в современных условиях актуально проведение занятий с использованием экскурсий.\n Производственные или учебные экскурсии (ПЭ) - это одна из многочисленных форм профориентационной работы с учащимися. Они имеют большое образовательное, политехническое и воспитательное значение.\nПЭ служит формой наглядного ознакомления учащихся с техникой и технологией, организацией производства, содержанием труда, условиями труда и пр.\nВ основном ПЭ рассматриваются как средство формирования и развития у студентов интереса к различным профессиям. Однако ПЭ - это не только одна из форм внеурочной деятельности педагога по оказанию помощи студентам в их профессиональном самоопределении. ПЭ предусматриваются и учебными программами.\nОсновная цель ПЭ - расширение политехнического образования студентов . Экскурсия на какое-либо предприятие, проводимая в органичной связи с содержанием учебных дисциплин, показывает неразрывную связь теории и практики в производственной деятельности людей.\n\nЭкскурсия (от лат. excursio — прогулка, поездка) — коллективное посещение музея, достопримечательного места, выставки, предприятия и т.п.; поездка, прогулка с образовательной, научной, спортивной или увеселительной целью.\nУчебная экскурсия — это проведение учебного занятия в условиях производства, природы, музея с целью наблюдения и изучения студентами различных объектов и явлений действительности.\n Являясь самостоятельной формой обучения, экскурсия входит важной составной частью в систему учебно-воспитательной работы и вносит свой весомый вклад в формирование всесторонне развитой личности.\nПеред экскурсиями ставятся такие задачи: обогащать знания студентов  (на основе непосредственного восприятия, накопления наглядных представлений и фактов); устанавливать связи теорий с практикой, с жизненными явлениями и процессами; развивать творческие способности студентов (учащихся), их самостоятельность, организованность в учебном труде, чувства коллективизма и взаимопомощи; обогащать эстетические чувства; развивать наблюдательность, память, мышление, эмоции; активизировать познавательную и практическую деятельность; воспитывать положительное отношение к учению. Экскурсия дает широкие возможности для более полного, комплексного использования методов обучения (и в первую очередь проблемных).\nВажнейшее назначение учебных экскурсий заключается в выявлении жизненности и актуальности учебного материала, в закреплении и конкретизации знаний, полученных на уроках, в применении знаний и умений на практике. Наглядность — существеннейший признак учебной экскурсии: удельный вес зрительной и слуховой наглядности в получении информации на экскурсии составляет более 70 процентов. Благодаря наглядности студенты (учащиеся) быстрее усваивают знания, которые затем на учебных занятиях становятся опорным фактическим материалом при восприятии новой темы, при обобщении и формировании соответствующих выводов. Экскурсионные наблюдения используются также для проверки, исправления, уточнения уже имеющихся у студентов (учащихся) знаний и представлений, для обогащения их новыми конкретными данными. Так, на экскурсии на промышленное или сельскохозяйственное предприятие происходит наглядное знакомство с практической деятельностью людей, с непосредственным использованием научных знаний, основы которых изучаются на занятии, формируются представления о производственных процессах, организации производства, отношениях в коллективе.\nНаблюдая и познавая явления общественной жизни, студенты (учащиеся) сами готовятся к активному участию в различных сферах общественно полезной деятельности.\nСтуденты (учащиеся) должны быть осведомлены о развитии и достижениях современной науки и техники.  К сожалению не урок, не факультатив, не просмотр научно- популярного фильма или специальной телепередачи не оказывает на студентов (учащихся) такого влияния, как полное впечатлений непосредственное соприкосновение с технологическим процессом производства. Во время экскурсии студенты (учащиеся) переносят знания в новую ситуацию, открывают для себя новые способы решения познавательных задач.( см. приложение).\n В зависимости от типа, содержания и метода проведения экскурсии, возраста студентов (учащихся), местных условий и вида передвижения в состав экскурсионной группы может входить от десяти до сорока студентов.\nДлительность учебной экскурсии  определяется в зависимости от учебных задач, конкретных условий проведения.\nКаждая экскурсия связана с учебным материалом разных дисциплин\nпо профессиям.\n• Этапы подготовки экскурсии\n \n1.   Определение цели и задачи экскурсии.\n2.   Выбор темы.\n3.   Отбор и изучение экскурсионных объектов.\n4.   Составление маршрута экскурсии.\n5.   Разработка заданий для учащихся.\n6.   Составление методической разработки.\n Цель экскурсии: наглядное ознакомление студентов (учащихся) с техникой и технологией , организации с/х  производства.\nЗадачи экскурсии:\n1. обогащать знания студентов (учащихся) на основе непосредственного восприятия, накопления наглядных представлений и фактов;\n2. устанавливать связи теорий с практикой, с жизненными явлениями и процессами\n3. развивать творческие способности студентов (учащихся),\n4. развивать самостоятельность, организованность в учебном труде, чувства коллективизма и взаимопомощи;\n5. развивать наблюдательность, память, мышление, эмоции;\n6.активизировать познавательную и практическую деятельность; воспитывать положительное отношение к учению. \n В процессе подготовки экскурсии при отборе объектов проводится их оценка по следующим показателям (критериям):\n1.   познавательная ценность;\n2.   известность (популярность);\n3.   месторасположение.\nПо мере сбора сведений об объекте студентам (учащимся) рекомендуется составить портфолио, в которое вносятся следующие сведения:\n1.   наименование объекта;\n2.   завод-изготовитель;\n3.   техническая характеристика.\n4.   назначение и место в технологическом процессе;\n5.   особенности конструкции\n\nПроведение экскурсии.\nРазбивка на группы( по 4-5 человек);\nВыдача заданий по объектам;\nИнструктаж;\nСбор информации согласно выданным заданиям.\nОбработка собранного материала.\nПодготовка к конференции:  презентация, фильм, репортаж, фотообозрение, доклад, плакаты и т. д\n";
                            break;
                        case 3:
                            LessonCompleteRichBox.Text += "   Как подготовить урок-конференцию?\nПодготовка к такому уроку проходит в несколько этапов, чаще всего в четыре.\n• Этап 1\nНа первом этапе педагог выбирает тему урока-конференции и рассматривает целесообразность рассмотрения того или иного материала студентам. Эти выступления — своего рода мини-проекты, работа над которыми занимает обычно одну - две недели.\nИтак, на первом этапе педагог выбирает общую тему и размышляет над тем, какие мини-темы он может предложить студентам. Это могут быть биографии известных лиц, история открытий, варианты применения физического закона и тому подобное.\n• Этап 2\nНа втором этапе педагог подбирает необходимые материалы — те, которые он порекомендует студентам. По каждой теме он, по возможности, стремится порекомендовать несколько источников, среди них книги, периодические издания и интернет-ресурсы.\n• Этап 3\nНа третьем этапе педагог предлагает школьникам темы. Чаще всего педагог сам делит студентов на группы, которые будут готовить свои выступления. Каждая группа получает свое задание и рекомендации по его выполнению. Можно поручить группам самим выбрать тему из большого списка; можно предложить вытянуть жребий; наконец, педагог сам может предложить тему каждой конкретной группе. Этот вопрос нужно решать в зависимости от возможностей класса и особенностей психологии, а также с учётом специфики темы.\nЖелательно сразу оговорить форму подачи информации от каждой группы и регламент.\nОбсуждая форму, следует обратить внимание студентов на то, что скучно слушать сухие факты, что чтение с листа неинтересно, и сразу предложить подготовить рассказ, а не чтение реферата.\nЕсть смысл также оговорить, что необходим какой-нибудь интерактивный элемент: мини-тест, небольшая викторина, игра на одну-две минуты, какое-то творческое задание для слушателей. Надо также решить, будут ли докладчики выступать с компьютерными презентациями или оформлять стенды, плакаты, стенгазеты.\n• Этап 4\nНа четвертом этапе педагог консультирует конкретные группы ребят.\nВажно! Следует обратить внимание на то, что в конце урока обязательно должны подводиться итоги.\nОднако эти итоги могут быть не окончательными. Если класс достаточно большой доклады едва ли могут быть слишком короткими. Семь, а то и десять минут — это, наверное, минимум по какой-либо серьёзной теме, а значит, все присутствующие на конференции выступить не смогут.\nЧтобы остальные студенты, которые в этот раз не участвуют в конференции, не скучали, им следует подготовить опросные листы для голосования. На основании этих опросных листов участникам конференции могут добавляться дополнительные баллы или может выдаваться приз зрительских симпатий.\nЗалог успеха\nЧтобы подготовить успешный урок-конференцию, необходимо несколько составляющих.\n •    Во-первых, это тщательная проработка темы и всех ее особенностей педагогом. Он должен удачно разработать систему, четко поставить перед студентами задачу, составить разумный план.\n •    Во-вторых, студенты должны быть достаточной степени мотивированы на тщательную подработку своей темы; если мотивация обучающихся низкая, то интересного и продуктивного урока ожидать не приходится.\n •    Наконец, важно четкое следование регламенту, объективная оценка выступлений, конкретные требования, которые должны неукоснительно выполняться; это касается и длительности выступлений, и оформления их, и выставления оценок, и использования опросника.\nЕще одним секретом успеха является соответствующее оформление кабинета для проведения такого урока. У выступающих должны быть бейджики, листы в папке. У членов жюри (если они есть) и у студентов, которые не участвуют в выступлении, а заполняют опросники, должны быть опознавательные знаки (хотя бы те же бейджики с надписью«Эксперт»).\nЕсли урок-конференция проводится в форме деловой игры и участники изображают представителей других стран (или других цивилизаций, например), то также желательно использование соответствующих атрибутов. Неплохо, если на уроке снимается видео: это придаст мероприятию солидности и потренирует студентов не бояться камеры. Создать соответствующий настрой, который поможет студентам воспринять урок не как рутинное мероприятие, а как нечто необычное, — это немалая часть успеха.\n";
                            break;
                        case 4:
                            LessonCompleteRichBox.Text += "«Деловая игра» - эффективна в том случае, если педагоги имеют достаточные знания по проблеме, которая отражается в игре. Она предполагает большую предварительную работу, в которой педагоги получают необходимые знания через различные формы, методы и средства:\n •    наглядную агитацию,\n •    тематические выставки,\n •    консультации,\n •    беседы,\n •    обсуждения.\nДеловая (ролевая) игра – эффективный метод взаимодействия педагогов. Она является формой моделирования тех систем отношений, которые существуют в реальной действительности или в том или ином виде деятельности, в них приобретаются новые методические навыки и приемы.\nДеловая игра – это форма совершенствования развития, восприятие лучшего опыта, утверждения себя как педагога во многих педагогических ситуациях. Необходимое условие эффективности деловой игры – добровольное и заинтересованное участие всех педагогов, открытость, искренность ответов, их полнота.\nЗаранее готовятся карточки с вопросами или 2-3 педагогическими ситуациями по проблеме.\nСтолы необходимо расставить так, чтобы выделилось 2 или 3 команды (на усмотрение руководителя МО) по 4-5 человек участников деловой игры. Педагоги по желанию рассаживаются за столы, и тем самым сразу определяются команды участников. Одна из команд – эксперты судьи – это наиболее компетентные педагоги по предлагаемой проблеме.\nКаждой команде вручается карточка, выбирается капитан, который будет оглашать общий вывод команды, работая над заданием. Командам дается время для подготовки решения, затем заслушиваются ответы. Порядок ответов определяется жребием капитанов. Каждой группой вносится не менее 3-х дополнений отвечающей группе, ставится поощрительный балл, который входит в общий счет очков. В конце игры определяется команда – победитель за лучший (обстоятельный, полный, доказательный) ответ.\nДеловые игры бывают следующих видов:\n •    имитационные, где осуществляется копирование с последующим анализом.\n •    управленческие, в которых осуществляется воспроизведение конкретных управленческих функций);\n •    исследовательские, связанные с научно-исследовательской работой, где через игровую форму изучаются методики по конкретным направлениям;\n •    организационно-деятельные. Участники этих игр моделируют раннее неизвестное содержание деятельности по определенной теме.\n •    игры-тренинги. Это упражнения, закрепляющие те или иные навыки;\n •    игры проективные, в которых составляется собственный проект, алгоритм каких-либо действий, план деятельности и осуществляется защита предложенного проекта.\n\nПримером проективных игр может быть тема:«Как провести итоговый педсовет?» (или родительское собрание, или практический семинар и другое).\nПри организации и проведении деловой игры роль руководителя игры различна – до игры он инструктор, в процессе ее проведения – консультант, на последнем этапе – руководитель дискуссии.\nОсновная цель игры – живое моделирование образовательно-воспитательного процесса, формирование конкретных практических умений педагогов, более быстрая адаптация к обновлению содержания, формирование у них интереса и культуры саморазвития; отработка определенных профессиональных навыков, педагогических технологий.\nМетодика организации и проведения:\nПроцесс организации и проведения игры можно разделить на 4 этапа:\nКонструирование игры:\nчетко сформировать общую цель игры и частные цели для участников;\nразработать общие правила игры.\n •    Организационная подготовка конкретной игры с реализацией определенной дидактической цели:\n •    руководитель разъясняет участникам смысл игры, знакомит с общей программой и правилами, распределяет роли и ставит перед их исполнителями конкретные задачи, которые должны быть ими решены;\n •    назначаются эксперты, которые наблюдают ход игры, анализируют моделируемые ситуации, дают оценку;\n •    определяют время, условия и длительность игры.\n •    Ход игры.\n •    Подведение итогов, подробный анализ игры:\n •    общая оценка игры, подробный анализ, реализация целей и задач, удачные и слабые стороны, их причины;\n •    самооценка участниками исполнения полученных заданий, степень личной удовлетворенности;\n •    характеристика профессиональных знаний и умений, выявленных в процессе игры;\n •    анализ и оценка игры экспертами.\nКритерием для такой оценки может служить количество и содержательность выдвинутых идей (предложений), степень самостоятельности суждений, их практическая значимость.\nВ заключении руководитель подводит итог игры.\n";
                            break;
                        case 5:
                            LessonCompleteRichBox.Text += "";
                            break;
                        case 6:
                            LessonCompleteRichBox.Text += "";
                            break;
                    }
                    break;
                case 3:
                    LessonCompleteRichBox.Text = "   Такому уроку в свете нового ФГОС придается особое значение, поскольку он помогает обучающимся«разложить все по полочкам».  \n•    На первом этапе (мотивационном) стоит обсудить, зачем необходима систематизация знаний. Уместны будут такие образы, как кладовая, книгохранилище и т.п. По какому принципу мы разложим там наши знания? На какую полочку попадет то, что мы изучили? Какая часть информации будет востребована особенно часто? \n•    Затем проводится повторение на другом качественном уровне: обучающимся предлагаются вопросы в нестандартной формулировке или с необычным условием. \n•    Контроль (в соответствии с ФГОС – лучше самоконтроль) проводится тоже с акцентом на обобщение (если ты неправильно решишь эту часть задачи, это отразится – на чем?). Цель работы – не только обобщить, но вписать полученную информацию в контекст общих знаний студента о мире. \n•    Особенно важно на таком уроке тщательно проработать этап рефлексии и проговорить на нем как принципы классификации, так и значение материала, его место в системе знаний.\n";
                    LessonCompleteRichBox.Text += text1;
                    switch (LessonPoint2X)
                    {
                        case 1:
                            LessonCompleteRichBox.Text += "   Цель — освоение какой-либо небольшой темы в течение только одного академического часа. Другое дело, что компоненты урока могут идти в разной последовательности в зависимости от темы и особенностей класса.\nПример плана комбинированного урока можно представить себе так:\n1.   Загадка, намекающая на тему урока.\n2.   Постановка проблемы, формулировка темы и задачи урока.\n3.   Проверка домашнего задания.\n4.   Повторение изученного на прошлых уроках.\n5.   Усвоение нового материала.\n6.   Отработка.\n7.   Контроль.\n8.   Объяснение домашнего задания.\n9.   Рефлексия.\nРазумеется, возможны различные варианты, план комбинированного урока позволяет части его переставлять в соответствии с дидактической задачей, вместо загадки, можно предложить детям задачу или проблему, какую-нибудь игру и т.п.\n•  Варианты начала урока:\n •    сообщение о какой-то памятной дате, имеющей (или даже нет) отношение к предмету (день рождения писателя, композитора, политического деятеля; годовщина исторического события, открытия, выхода в свет книги);\n •    загадка или необычный факт в форме новости;\n •    отрывок из литературного произведения или афоризм;\n •    общий комплимент классу и т.п.\n •    \nМетодика проведения комбинированного урока по ФГОС требует от педагога, по возможности, не сообщать тему урока, а предлагать догадаться самим. Причем одновременно ценность новых знаний необходимо обосновать.\nВ связи с этим обычно рекомендуется начинать объяснение проблемной задачей. Суть приема в том, что студентам предлагается решить задачу, или предсказать результат опыта, или предположить, как пишется какое-то слово и т.п. Подбирается материал таким образом, чтобы для правильного ответа требовались именно те знания, которые планируется изучать на текущем уроке.\nПланируя комбинированный урок, крайне важно оставить достаточно времени на этап выработки навыка применения полученных знаний на практике. Причем желательно придумывать такие задания, которые будут стимулировать творческую активность школьников. Хорошо также дать задания, позволяющие использовать полученные знания в нестандартных условиях, взглянуть на материал под другим углом.\nОднако, предлагая учащимся практическую работу, необходимо сначала удостовериться, что весь теоретический материал ими усвоен. Поэтому хорошо, если практике предшествует небольшой устный опрос, позволяющий«начерно» оценить степень осознания материала. Но при этом не надо забывать, что без практики теоретический материал мертв и все равно не может быть до конца осознан.\nНа этом этапе хорошим решением станет выполнение образцового задания на доске и последующая самостоятельная работа учащихся с разноуровневыми карточками, причем слабым студентам предлагаются задания, максимально совпадающие с образцовым, а более сильным — в большей или меньшей степени отличающиеся от него, чтобы простимулировать творческий подход к работе. Желательно также создать ситуацию успеха, поэтому не следует предлагать слишком сложные задания. Да и времени на их обдумывание на комбинированном уроке слишком мало.\nМожно провести закрепление в виде какой-либо игры, индивидуальной или командной. Неплохо зарекомендовали себя приемы, требующие логики и творческого подхода:\n •    Общее – уникальное.\n •    Цепочка соответствий.\n •    Шесть шляп.\n •    Кейсы\n •    И т.д.\nМожно дать небольшую проверочную работу, например, с использованием перфокарт.\nПри анализе комбинированного урока следует обратить внимание на то же, что и при разборе любого другого урока. Указав вид урока — комбинированный — отдельно анализируются его этапы. Характеристика комбинированного урока включает в себя разбор как отдельных приемов, так и урока в целом.\nКомбинированный тип урока — хорошо зарекомендовавшая себя на протяжении долгого времени форма урока, поистине бессмертная, благодаря своей универсальности и удобству для любого класса и предмета. Не стоит отказываться от него, несмотря на обилие новых форм и технологий — гибкость и поливариантность такого урока предлагает широкие возможности для использования новых приемов в его структуре.\n";
                            break;
                        case 2:
                            LessonCompleteRichBox.Text += "«Деловая игра» - эффективна в том случае, если педагоги имеют достаточные знания по проблеме, которая отражается в игре. Она предполагает большую предварительную работу, в которой педагоги получают необходимые знания через различные формы, методы и средства:\n •    наглядную агитацию,\n •    тематические выставки,\n •    консультации,\n •    беседы,\n •    обсуждения.\nДеловая (ролевая) игра – эффективный метод взаимодействия педагогов. Она является формой моделирования тех систем отношений, которые существуют в реальной действительности или в том или ином виде деятельности, в них приобретаются новые методические навыки и приемы.\nДеловая игра – это форма совершенствования развития, восприятие лучшего опыта, утверждения себя как педагога во многих педагогических ситуациях. Необходимое условие эффективности деловой игры – добровольное и заинтересованное участие всех педагогов, открытость, искренность ответов, их полнота.\nЗаранее готовятся карточки с вопросами или 2-3 педагогическими ситуациями по проблеме.\nСтолы необходимо расставить так, чтобы выделилось 2 или 3 команды (на усмотрение руководителя МО) по 4-5 человек участников деловой игры. Педагоги по желанию рассаживаются за столы, и тем самым сразу определяются команды участников. Одна из команд – эксперты судьи – это наиболее компетентные педагоги по предлагаемой проблеме.\nКаждой команде вручается карточка, выбирается капитан, который будет оглашать общий вывод команды, работая над заданием. Командам дается время для подготовки решения, затем заслушиваются ответы. Порядок ответов определяется жребием капитанов. Каждой группой вносится не менее 3-х дополнений отвечающей группе, ставится поощрительный балл, который входит в общий счет очков. В конце игры определяется команда – победитель за лучший (обстоятельный, полный, доказательный) ответ.\nДеловые игры бывают следующих видов:\n •    имитационные, где осуществляется копирование с последующим анализом.\n •    управленческие, в которых осуществляется воспроизведение конкретных управленческих функций);\n •    исследовательские, связанные с научно-исследовательской работой, где через игровую форму изучаются методики по конкретным направлениям;\n •    организационно-деятельные. Участники этих игр моделируют раннее неизвестное содержание деятельности по определенной теме.\n •    игры-тренинги. Это упражнения, закрепляющие те или иные навыки;\n •    игры проективные, в которых составляется собственный проект, алгоритм каких-либо действий, план деятельности и осуществляется защита предложенного проекта.\n\nПримером проективных игр может быть тема:«Как провести итоговый педсовет?» (или родительское собрание, или практический семинар и другое).\nПри организации и проведении деловой игры роль руководителя игры различна – до игры он инструктор, в процессе ее проведения – консультант, на последнем этапе – руководитель дискуссии.\nОсновная цель игры – живое моделирование образовательно-воспитательного процесса, формирование конкретных практических умений педагогов, более быстрая адаптация к обновлению содержания, формирование у них интереса и культуры саморазвития; отработка определенных профессиональных навыков, педагогических технологий.\nМетодика организации и проведения:\nПроцесс организации и проведения игры можно разделить на 4 этапа:\nКонструирование игры:\nчетко сформировать общую цель игры и частные цели для участников;\nразработать общие правила игры.\n •    Организационная подготовка конкретной игры с реализацией определенной дидактической цели:\n •    руководитель разъясняет участникам смысл игры, знакомит с общей программой и правилами, распределяет роли и ставит перед их исполнителями конкретные задачи, которые должны быть ими решены;\n •    назначаются эксперты, которые наблюдают ход игры, анализируют моделируемые ситуации, дают оценку;\n •    определяют время, условия и длительность игры.\n •    Ход игры.\n •    Подведение итогов, подробный анализ игры:\n •    общая оценка игры, подробный анализ, реализация целей и задач, удачные и слабые стороны, их причины;\n •    самооценка участниками исполнения полученных заданий, степень личной удовлетворенности;\n •    характеристика профессиональных знаний и умений, выявленных в процессе игры;\n •    анализ и оценка игры экспертами.\nКритерием для такой оценки может служить количество и содержательность выдвинутых идей (предложений), степень самостоятельности суждений, их практическая значимость.\nВ заключении руководитель подводит итог игры\n";
                            break;
                        case 3:
                            LessonCompleteRichBox.Text += "   Целью урока-практикума является закрепление материала посредством заданий разной сложности. К его задачам относится:\n1.   Проверка уровня освоенности темы.\n2.   Формирование:\n •    навыка коллективной деятельности;\n •    навыка само- и взаимопроверки;\n •    навыка объективной само- и взаимооценки.\n1.   Развитие:\n •    умения объяснять – связывать несколько мыслей в одну с применением принципов логики;\n •    умения выделять главное в большом объеме информации.\n1.   Воспитание:\n •    коммуникативности;\n •    ответственности, любви к труду;\n •    уважительного отношения к другим людям, вне зависимости от того, что они говорят.\n1.   Повышение интереса к предмету.\n2.   Проявление творческих способностей.\nВиды урока-практикума\nЕсть несколько видов урока-практикума:\n •    установочные;\n •    иллюстративные;\n •    тренировочные;\n •    исследовательские;\n •    творческие;\n •    обобщающие.\nФормы урока-практикума\nИмеют место две формы урока-практикума:\n •    практическая работа;\n •    лабораторная работа.\nУрок-практикум в форме практической работы вырабатывает конструктивные умения, а урок-практикум в форме лабораторной работы – экспериментальные.\nПо поводу лабораторной работы, т.е. учебного эксперимента, следует отметить один важный момент. У него, в отличие от научного эксперимента, уже есть итог, правда, о нем не знают обучающиеся.\nТипы урока-практикума\nТипы урока-практикума:\n •    урок-практикум углубления теории;\n •    урок-практикум групповой обработки информации;\n •    урок-практикум индивидуальной обработки информации;\n •    урок-практикум контроля;\n •    урок-практикум зачет;\n •    урок-практикум комбинированного типа, сочетающий в себе несколько типов, например, урок-практикум группой обработки информации и урок-практикум зачет.\nПлан урока-практикума\nПлан урока-практикума включает в себя:\n1.   Сообщение темы, цели и задач урока-практикума.\n2.   Мотивация к уроку-практикуму.\n3.   Ознакомление с планом и инструкциями урока-практикума.\n4.   Подготовка учебной литературы и оборудования к уроку-практикуму.\n5.   Непосредственное проведение урока-практикума.\n6.   Выводу по уроку-практикуму.\nОрганизация урока-практикума\nПервое, что необходимо сделать для организации урока-практикума – конечно же, определиться с темой, целями и задачами. Далее:\n1.   Немного ускориться в прохождении курса. Это необходимо для того, чтобы освободить как минимум два учебных часа на урок-практикум.\n2.   Написать план (для учителя) и инструкции (для студентов). Требования должны соответствовать уровню подготовки обучающихся: сильным следует давать сложные задания, а слабым более«лояльные».\n3.   Подготовить учебную литературу и оборудование. Нехватку или отсутствие оборудования можно компенсировать творческим заданием или контрольной работой в письменном виде.\nИндивидуальный подход в организации урока-практикума\nНесмотря на то, что на рассматриваемом нами уроке используется групповой подход, это не отменяет другого – индивидуального подхода в виде:\n •    выполнении работы по образцу из учебника или с листа от педагога;\n •    выполнении работы с таблицами и схемами;\n •    выполнении работы с учебной литературой, в частности, словарями и справочниками.\nНа то, как пройдет урок-практикум, влияет, во-первых, уровень освоенности темы студентом и, во-вторых, опыт педагога. На таком уроке знания усваиваются намного лучше, так как складывается неформальная обстановка.\n";
                            break;
                        case 4:
                            LessonCompleteRichBox.Text += "•       Конкурсный урок – это творческое учебное занятие по индивидуальному сценарию, режиссуре и содержанию, опирающееся на современные классические принципы обучения и воспитания учащихся\n •    Конкурсный урок — это не просто современный урок, это особый урок, ибо он естественная часть предъявляемого взыскательной аудитории педагогического опыта.\n •    Важно, чтобы урок был профессиональным! Проблемным! Важно, чтобы он был уроком взаимодействия, диалога!\n •    Конкурсный урок должен быть иллюстрацией системы работы педагога, научных позиций, технологий, педагогических позиций, предъявленных в разных формах (эссе, обобщение опыта, статьи в журнал).\n •    Важно, чтобы после урока у конкурсанта осталось ощущение праздника творческого единения с детьми, соавторами, соисполнителями задуманного.\n •    Безусловно, конкурсный урок своеобразен по содержанию, ориентированному на незнакомых детей.\n •    Залог его успешности в умении поставить цель, определить задачи и педагогически грамотно подобрать нужные для их решения средства.\n •    Учителю-конкурсанту необходимы и такие качества, как способность импровизировать, умение слушать и слышать незнакомых детей, чутко реагировать в диалоге на их вопросы и ответы.\n •    Заметим, что не менее важны раскованность и сдержанность, спокойствие, умение ориентироваться в реальной, порой непред-сказуемой ситуации, управлять своим творческим самочувствием.\n\nПри всем различии предметов и образовательных областей для оценки каждого конкурсанта к ним предъявляются обязательные требования, которые ежегодно входят в критерии оценки:\n •    Глубокое знание своего предмета.\n •    Некорректное оперирование научными понятиями, небрежность, неточности, оговорки, речевая безграмотность недопустимы.\n •    Грамотное, в соответствии с целями и задачами урока использование новых, современных, а иногда и традиционных, но работающих на результат, способов передачи знаний.\n •    Допускается интерпретация описанных в педагогической литературе авторских методик (технологий), а еще лучше - предъявление собственной апробированной методики (технологии).\n •    Коммуникативные способности, актерское и ораторское мастерство. К сожалению, педагогической техникой конкурсанты владеют явно недостаточно.\n •    Умение достигать результата образовательной деятельности при любом уровне подготовленности класса. Ссылка на слабый уровень подготовки детей неуместна.\nОчевидно, что каждый предмет имеет свое образовательно-информационное поле и требует использования специфических методов, приемов и форм организации учебного занятия.\nОшибки при самоанализе урока, мероприятия\n •    Редко бывает объективным со стороны участника;\n •    Цениться объективный анализ, когда педагог констатирует, что получилось не так, как планировал, в каком месте отошёл от запланированного, т.к. урок пошёл не«по сценарию». Это говорит о мобильности педагога, его умении выйти достойно из непредвиденной ситуации;\n •    Редко педагог аргументирует отбор содержания урока (занятия) – не просто, что по программе, а почему взят именно этот материал;\n •    От педагога больше ждут импровизации, а не только домашней заготовки, от которой преподаватель не может отойти.\n";
                            break;
                        case 5:
                            LessonCompleteRichBox.Text += "   Подготовка к диспуту\n1. Выбор темы, ее утверждение. Можно провести анкети¬рование на темы:«Какие вопросы тебя особенно волнуют, и ты\nне находишь на них ответа?»,«О чем бы ты хотел поспорить, поговорить откровенно с товарищами?» и др.\n2. Формулирование вопросов по выбранной теме. Реко¬мендуется сформулировать три-четыре вопроса, но чтобы они звучали проблематично. Например, существуют ли критерии современного человека? Быть современным — значит быть мод¬ным. Согласны ли вы с таким утверждением? и т.п.\n3. Собственно подготовительный период, главной задачей которого является изучение мнения коллектива по выдвинутым во¬просам, включает в себя следующие моменты: а) анкетирование по вопросам диспута; б) составление анкетных карточек, противопо¬ложных по мнению (с них-то можно и начать диспут: зачитать одну, потом — другую, попросить каждого доказать свое мнение по поводу выделенных точек зрения); в) изучение учащимися рекомендован¬ной литературы; г) инсценирование (или «модель») будущего дис¬пута: за несколько дней до диспута рекомендуется собрать несколь¬ко самых активных учащихся класса для выяснения их мнения по вопросам диспута. Это могут быть члены временной инициативной группы. Не навязывая своего мнения, педагог просит этих школьни¬ков подготовить более тщательно свои выступления для того, чтобы на диспуте они дали «толчок» для начала общего спора\nФормулировка темы должна быть острой, проблематичной, будить мысль учащихся, заключать в себе нравственную или эстетическую проблему, которая в жизни, в литературе решается по-разному, вызывает противоречивые суждения. Таким образом, педагогически ценной является такая тема диспута, которая взволнует учащихся,«заденет их за живое», привлечет внимание своей необычностью, новизной.\n-Прежде чем спорить, подумай, о чем будешь спорить.\n-Спорь честно и искренне, не искажай мыслей и слов своих товарищей.\n-Помни, что доказательством и лучшим способом опровержения являются точные и бесспорные факты.\n-Доказывая и опровергая, говори ясно, просто, отчетливо, точно.\n-Старайся говорить своими словами.\n-Если доказали ошибочность твоего мнения, имей мужество признать правоту своего«противника».\n— Заканчивай выступление, подведи итоги, сформулируй выводы.\nВ ходе обсуждения основной темы диспута обычно возникает немало вопросов, имеющих косвенное к ней отношение. В заключительном слове, давая обстоятельный и убедительный ответ на все вопросы, ведущий, ссылаясь на мнение выступающих, выделяет новые мировоззренческие и нравственные проблемы, ценные для воспитания учащихся. Таким образом, на диспуте учащиеся не только учатся спорить, думать, отстаивать свои убеждения, но и получают ответы на интересующие их вопросы, растут духовно.\nЗаключительное слово, желательно, чтобы было кратким, ярким и убедительным, так как оно произносится искренне и задушевно, страстно и доказательно, выслушивается с исключительным вниманием, запоминается надолго.\nТехнология диспута\nРазновидностью учебной встречи является диспут. Организация диспута, основанного на столкновении разных мнений, — сложное и ответственное дело. Успех диспута во многом определяется темой, заключающей в себе, как минимум, две разноречивые позиции. Педагог тщательно продумывает задачи диспута, его предполагаемое течение, возможные варианты и, главное, выводы, к которым учащиеся должны прийти в результате обсуждения. В ходе дискуссии необходимо следить за соблюдением правил ведения дискуссии.\nПравила проведения дискуссии\n1.   Дискуссия — это спор во имя истины; здесь важен обмен мнениями, основанными на конкретных фактах, аргументах, доказательствах, результатах исследований.\n2.   Дискуссия успешна, если все участники хорошо знают предмет обсуждения, не отвлекаются на другие проблемы.\n3.   Сопоставление своей и чужой точек зрения, опровержение неправильной должно быть этичным.\n4.   Не обидь, не оскорби, не унизь человека — девиз всякой дискуссии.\n5.   Человека уважают в споре уже за то, что он искренен, хотя и ошибается.\n6.   Дискуссия — это школа, вырабатывающая демократическое восприятие плюрализма мнений, отношений к поступку, действию.\nДиалог завершается принятием решения, при котором каждый из студентов берет на себя какую-то работу, дело, конкретное обязательство. Преподаватель — оказать профессиональную помощь типа консультации, собеседования; родители — создать максимально благоприятные для ребенка условия, подросток воспитать в себе волевые качества, предъявить к себе требования последовательно и постоянно заботиться о здоровье и вести здоровый образ жизни.\nОчень велика роль ведущего на диспуте. Он обязан предоставлять слово желающим, следить за соблюдением регламента, регулировать очередность выступлений и заботиться о том, чтобы накал встречи не спадал до конца.\nКак руководить дискуссией в группе\n1.   Приглашать к участию стеснительных детей.\n2.   Направлять комментарии и вопросы одного студента к другому.\n3.   Если вы не уверены, что поняли то, что сказал студент, значит и другие студенти тоже не смогли это понять.\n4.   Вытягивать больше информации.\n5.   Не отвлекаться от предмета дискуссии.\n6.   Давать время подумать над ответом: некоторые студенты легче высказываются, если предварительно записывают свои мысли.\n7.   Когда студент заканчивает ответ, оглядеть класс, оценить реакцию других.\n";
                            break;
                        case 6:
                            LessonCompleteRichBox.Text += "   По содержанию можно выделить такие виды викторины:\n1) тематические\n2) развлекательно - развивающие\n3) лингвистические\n4) межтематические\nТематические викторины  используются наиболее часто. С помощью тематических викторин можно сообщить дополнительные сведения по какой-либо теме или обобщить ее изучение, проверить степень информированности студентов, их умение самостоятельно пользоваться рекомендованной преподавателем литературой, давать доказательные и точные ответы.\nРазвлекательно-развивающие викто¬рины способствуют развитию сообрази¬тельности, находчивости, гибкости мыш¬ления, логики. Часто используются кроссворды и различные вопросы.\nЛингвистические викторины способствуют самостоятельной работе обучающихся над языковым материалом, учат некоторым приёмам самостоятельной работы со словом, более внимательному отношению к различным языковым явлениям.\nМежтематические викторины выяв¬ляют разносторонние знания обучающихся; учат их обращаться друг к другу; внимательно относиться к тому, что каждый из них знает, умеет; способствуют взаимообо¬гащению в процессе обучения.\nВ числе основных требований к проведению викторин следующие:\n1)    четкая учебно-воспитательная направленность, ориентация обучающихся на информацию, представляющую общеобразовательную и практическую значимость;\n2)    актуальность и связь с жизнью;\n3)    доступность источников информации;\n4)    занимательность и новизна\n\nСтруктура викторины:\n1) вводная часть\n2) ра¬бота в группах\n3) заключительную часть\nВводная часть. Перед обучающимися ставится задача, они получают раздаточ¬ный материал, их информируют о после¬довательности видов деятельности в про¬цессе работы. Виды деятельности таковы: а) все команды получают одинаковую задачу и материал для выполнения в от-веденное время; б) материал у команд может быть разным (например, при проведении викторины о Германии можно предложить  командам разную тематику: одной команде —«Природа и климат страны», другой —«Население», третьей —«Экономика»); в) команды мо¬гут работать одновременно в отведенное время или же меняться для выполнения различных заданий; г) на викторине мо¬гут быть предусмотрены и индивидуаль¬ные конкурсы капитанов, консультантов; выбор представителя может быть сделан по решению команды.\nРабота в группах. На этом этапе обучающиеся знакомятся с материалом викторины, планируют работу и время, распределяют вопросы между членами команды, совместно обсуждают получен¬ный результат, дорабатывают и коррек¬тируют ответы.\nЗаключительная часть. Подводятся итоги работы, анализируется выполне¬ние заданий, дается оценка групповой и индивидуальной работы, проводится разбор типичных ошибок, акцентирует¬ся внимание на вопросах, вызвавших особые трудности. Этот этап позволяет преподавателю проконтролировать свою рабо¬ту, скорректировать планирование, наметить план по ликвидации пробелов.\n";
                            break;
                    }
                    break;
                case 4:
                    LessonCompleteRichBox.Text = "   Желательно обеспечить наличие разно уровневых заданий, а также возможность выбора задания для студента (например, тест с заданиями разной бальной системы; оценка выставляется в зависимости от количества полученных баллов). На таком уроке, кроме образовательных задач (контроль знаний по теме или разделу), решаются также воспитательные (создание условий для формирования правильной самооценки; упорство в достижении цели) и развивающие (умение анализировать, сравнивать, классифицировать; если работа групповая, то и коммуникативные навыки).";
                    LessonCompleteRichBox.Text += text1;
                    switch (LessonPoint2X)
                    {
                        case 1:
                            LessonCompleteRichBox.Text += "   Планирование деятельности по составлению тестов.\n1. Определить, с какой целью составляется тест.\n2. Просмотреть и изучить материал по теме в различных источниках (сеть Internet, энциклопедии, практические пособия, учебная литература).\n3. Просмотреть и выбрать форму теста.\n4. Определить количество вопросов в тесте.\n5. Составить вопросы и подобрать варианты ответов.\n6. Продумать критерии оценивания.\n7. Написать инструкцию к выполнению теста.\n8. Проверить орфографию текста, соответствие нумерации.\n9. Проанализировать составленный тест согласно критериям оценивания.\n10. Оформить готовый тест.\n11. Оформить бланк ответов к тесту.\nФормы тестовых заданий\n1. - задания закрытой формы, в которых выбирают правильный ответ из данного набора ответов к тексту задания;\n2. - задания открытой формы, требующие при выполнении самостоятельного формулирования ответа;\n3. - задание на соответствие, выполнение которых связано с установлением соответствия между элементами двух множеств;\n4. - задания па установление правильной последовательности, в которых требуется указать порядок действий или процессов, перечисленных в задании.\n \nОбщие рекомендации к составлению тестов\n· не следует прибегать к формулированию задания на воспроизведение, если вместо него может быть предложена каче¬ственная или количественная задача;\n· не следует стремиться к только словесному формирова¬нию вопросов. При использовании рисунков, схем, графиков и др. значительно сокращается текст вопроса и в то же время по¬вышается выразительность задачи;\n· предпочитайте в формулировках не констатацию фак¬тов, а выявление причинно-следственных связей;\n· прибегайте к формулировкам, побуждающим к система¬тизации и классификации явлений;\n· изыскивайте возможность формулировки задания, на¬правленного на установление общности и различия в явлениях;\n· избегайте однообразных формулировок;\n· чаще ставьте проблемы, помогающие решать задачи, с которыми приходиться сталкиваться в каждодневной работе.\nТребования при составлении теста:\n1) Строгое соответствие источникам информации, которы¬ми пользуются учащиеся (соответствие содержанию и объему полученной ими информации).\n2) Простота (задание должно требовать от испытуемого решения только одного вопроса).\n3) Однозначность задания (формулировка вопроса должна исчерпывающим образом разъяснять поставленную перед испы¬туемым задачу, причем язык и термины, способы и индексация обозначений, графические изображения и иллюстрации задания и ответов к нему должны быть безусловно и однозначно понятны всеми учащимися).\n4) Предпочтительнее подробный вопрос (задание) и лако¬ничные ответы.\n5)Идентичность всех ответов по форме, содержанию, объ¬ему, количеству представленных позиций.\n6) Оптимальное количество вариантов ответа — четыре-пять.\n7) Грамматическое и логическое соответствие ответов во¬просу (заданию).\n8) Совер¬шенно неприемлемы абсурдные, очевидно неправильные ответы.\n9) Обучающая функция теста возрастает, если необходимо отметить неправильный или негативный ответ, а также в случае, когда все ответы правильные, но один предпочтительнее по тем или иным критериям.\n \nСтруктура теста\nОбъем работы: 6-8 листов; нумерация страниц - снизу, справа;\n1 лист – титульный ;\n2 - 7 лист – содержание теста;\n8 лист – список используемой литературы\nОтметка: зачет / незачет\nКритерии оценивания: ²зачет² выставляется, если:\n- содержание теста соответствует заданной теме, выдержаны все требования к его оформлению;\n- основные требования к оформлению теста соблюдены, но при этом допущены недочеты, например: неточно и некорректно составлены вопросы (задания), имеются упущения в оформлении;\nзачет не выставляется, если:\n- вопросы или задания теста не соответствуют заданной теме, обнаруживается существенное непонимание проблемы;\n- тест обучающимся не представлен.\nКраткая характеристика программ для создания тестов:\nHotPotatoes – программа, предоставляющая преподавателям возможность самостоятельно создавать интерактивные задания и тесты для контроля и самоконтроля учащихся. С помощью программы можно создать 10 типов упражнений и тестов по различным дисциплинам с использованием текстовой, графической, аудио- и видеоинформации. В этой программе удобно составлять кроссворды, которые можно использовать в интерактивном и печатном варианте.\nhttp://hotpot.uvic.ca/\nADTester. С помощью ADTester возможна организация проведения тестирования в любых образовательных учреждениях. Тестирование может проводиться как с целью выявления знаний учащихся в той или иной области, так и для обучающих целей.\nhttp://www.adtester.org/\n\n\t«MyTest». Пакет программ для создания и проведения компьютерного тестирования, сбора и анализа результатов, выставления оценки по указанной в тесте шкале. С помощью программы MyTest возможна организация и проведение тестирования в любых образовательных учреждениях как с целью выявить уровень знаний по любым учебным дисциплинам, так и с обучающими целями.\nhttp://mytest.klyaksa.net/htm/download/index.htm\nKnowing. Программа позволяет создавать тесты и автоматически оценивать результаты тестирования. Эта программа проста в использовании. Но функции ограничены, например, можно составлять задания только с одним выбором ответа.\nhttp://www.globalpage.ru/download/\n";
                            break;
                        case 2:
                            LessonCompleteRichBox.Text += "   Базовые правила при построении вопросов:\n •    – респондент всегда прав;\n •    – каков вопрос – таков и ответ.\nТребования к формулировке вопросов:\n •    – ясность (понятность для респондента; нельзя включать сложную, непонятную для респондентов терминологию, понятия, которые способны затруднить восприятие респондентами);\n •    – конкретность (не допускать двоякого толкования понятий или вопроса в целом);\n •    – проблемность (прямая или косвенная направленность вопроса на интересующую корреспондента проблему, но формулировка не должна наводить на ответ);\n •    – последовательность (значимо выстроить порядок вопросов так, чтобы они не шокировали респондента, а позволяли постепенно конкретизировать и подробно раскрывать ответы).\nИнтервью и беседа применяются как основной метод в структурированных исследованиях, при экспертном опросе, а также в этнологических экспедициях по заранее составленным опросникам. Беседа – основная форма повседневного взаимодействия людей друг с другом. Однако простое обыденное общение и беседа как метод исследования существенно отличны друг от друга по целеполаганию, процедуре проведения, форме фиксации.\nИнтервью – очный вид опроса. Интервью – встреча лицом к лицу. Буквальный перевод слова \"интервью\" – \"взгляд между\", т.е. взаимный обмен взглядами между двумя людьми, обсуждающими определенную тему, интересующую обоих. Отсюда специфика интервью – разговор, где присутствует определенная динамика и существует возможность обратной связи и уточнения непонятного (в отличие от анкеты). Ведущий принцип – вопросы исходят практически только от корреспондента, а ответы – от респондента.\nИнтервью требует специальной предварительной подготовки. Важна не только правильность формулировки вопроса, но и интонирование, последовательность вопросов, внешний вид корреспондента и многое другое. Но при интервью или беседе в отличие от анкеты можно наблюдать за реакциями на вопросы и невербальными компонентами общения, дающими зачастую очень много информации.\nВиды интервью:\n •    1) стандартизованное (формализованное) – предполагаемые вопросы беседы формулируются заранее, и отход от них не допускается;\n •    2) нестандартизованное (неформализованное, свободное) – обозначается только тема и ключевые вопросы интервью, вопросы формулируются и уточняются по ходу интервью;\n •    3) фокусированное (направленное) – по поводу одного события, документа, явления и т.п.;\n •    4) ненаправленное – неформализованное интервью на общие темы или по поводу разнохарактерных вопросов.\nТребования к интервью:\n •    – не допускается подсказка (это влечет к увеличению субъективизма);\n •    – нельзя проявлять чрезмерную настойчивость в опросе;\n •    – важно учитывать культурный уровень интервьюера;\n •    – важна организация единого социально-психологического пространства между корреспондентом и респондентом;\n •    – а главное – корреспондент больше молчит, а респондент больше говорит, но не наоборот; важно не только уметь задать вопрос, но и уметь выслушать на него ответ.\nХарактер интервью также может различаться по типу вопросов:\n •    – с точной и с неточной формулировкой вопроса;\n •    – подготовленные заранее вопросы и вопросы, задаваемые по ходу интервью;\n •    – общие и частные вопросы;\n •    – наводящие и нейтральные вопросы.\nКроме того, выделяют следующие виды вопросов: вводные, отслеживающие, проясняющие, конкретизирующие, прямые, косвенные, структурированные, вопросы-интерпретации, а также смысловое молчание (паузы).\nСуществуют различные стили проведения интервью. Например, выделяют жесткий и мягкий стили ведения интервью. Интервью может вестись:\n •    – с позиции респондента (мягко, соучаствующее);\n •    – с позиции, противоположной позиции респондента (жестко, недоверчиво);\n •    – с собственной позиции интервьюера (может быть как \"мягким\", так и \"жестким\").\nБеседа – в отличие от интервью в ней две участвующие стороны (задающий вопросы и отвечающий на них) находятся примерно в равном положении. Под беседой чаще всего понимается диалоговый метод исследования, идущий еще от Сократа. Важно умение вести диалог, т.е. не только интересоваться собеседником и корректно ставить ему вопросы, но уметь слышать вопросы другого и содержательно на них отвечать.\nОпрос экспертов. Методика в целом такая же, как при обычном опросе или анкетировании. Специфика – отбор экспертов, т.е. определение выборки опрашиваемых. Правильность метода зависит от правильности выбора эксперта. Этот метод чаще применяется при пилотажном исследовании.\nПри выборе эксперта значимо учитывать компетентность эксперта в нужной теме. Выбор по параметрам: известность, профессионализм, принадлежность к области выбора, определение отношения к виду деятельности, включенность в событие и пр.\nНарративное интервью – направляемый исследователем свободный рассказ респондента о своей жизни или каких-то ситуациях. Различают биографическое интервью (повествование мемуарного характера, о жизненном пути) и интервью о событиях и фактах жизни (рассказ о конкретных жизненно значимых происшествиях, переживаниях, встречах с людьми). Основной акцент в вопросах делается на индивидуальных событиях жизни респондента, его переживаниях и оценках. Нарративное интервью используется наравне с письменными методами сбора нарративных текстов. Одно из перспективных направлений психологических исследований, дающее материал о жизненном пути человека во взаимосвязи с социокультурной ситуацией развития.\nДискуссия (от лат. discussio – рассмотрение, исследование) – публичное обсуждение какого-либо спорного вопроса, проблемы; спор. Посредством обсуждения некоторых спорных для участников дискуссии вопросов происходит выявление и исследование как проблемы, так и точек зрения по ее поводу. В дискуссии каждая сторона, оппонируя мнению собеседника, аргументирует свою позицию и претендует на достижение своей цели. Благодаря этому дискуссия может выступать активным методом получения информации по тем или иным вопросам. Хотя в ситуации противопоставления зачастую срабатывает механизм противоборства, уводящий исследователя от выявления истинных мнений участников дискуссии. Дискуссия в исследовательских целях – тонкий и глубокий метод изучения индивидуальных и социальных мнений. Основные квалификационные требования к исследователю – умение организовать и корректно провести дискуссию. В ряде случаев в форме свободной дискуссии могут разговориться самые молчаливые респонденты.\n• Этапы исследования с помощью методов устного опроса:\n •    1. Выбор темы – формулировка цели исследования, отвечающая на вопросы \"почему?\" и \"что?\", будет изучаться.\n •    2. Планирование – определение логики исследования (какие, в какой последовательности, в каком стиле, при какой ситуации, кому именно будут задаваться вопросы; определение места и времени выборки).\n •    3. Опрос – проведение беседы, интервью или дискуссии по запланированной схеме.\n •    4. Расшифровка – перевод аудиозаписи в письменный текст.\n •    5. Анализ – опираясь на цель и тему опроса, а также с учетом природы полученного материала, выбирается и применяется тот или иной метод анализа (качественный, количественный, качественно-количественный; обобщенный или детальный и т.д.).\n •    6. Верификация (проверка) – выясняется, насколько полученные тексты надежны (тексты опросов однородны) и валидны (тексты опроса реализуют именно ту цель, которая была поставлена исследователем).\n •    7. Написание отчета – изложение результатов исследования в заданной форме с соблюдением этических правил и методических норм.\nМожно выделить следующие критерии качества интервью или беседы:\n •    – объем спонтанных, подробных, конкретных и соответствующих теме ответов, полученных в ходе опроса;\n •    – соотношение по объему вопросов корреспондента и ответов респондента (чем короче вопросы и длиннее ответы, тем лучше);\n •    – глубина прослеживания и прояснения смысла исследователем различных аспектов ответов респондента;\n •    – наличие интерпретаций ответов по ходу опроса, а также их верификация;\n •    – \"интервью говорит само за себя\" – текст опроса как самодостаточный рассказ, который не нуждается в большом количестве лишних описаний и объяснений.\n";
                            break;
                        case 3:
                            LessonCompleteRichBox.Text += "   По содержанию можно выделить такие виды викторины:\n1) тематические\n2) развлекательно - развивающие\n3) лингвистические\n4) межтематические\nТематические викторины  используются наиболее часто. С помощью тематических викторин можно сообщить дополнительные сведения по какой-либо теме или обобщить ее изучение, проверить степень информированности студентов, их умение самостоятельно пользоваться рекомендованной преподавателем литературой, давать доказательные и точные ответы.\nРазвлекательно-развивающие викто¬рины способствуют развитию сообрази¬тельности, находчивости, гибкости мыш¬ления, логики. Часто используются кроссворды и различные вопросы.\nЛингвистические викторины способствуют самостоятельной работе обучающихся над языковым материалом, учат некоторым приёмам самостоятельной работы со словом, более внимательному отношению к различным языковым явлениям.\nМежтематические викторины выяв¬ляют разносторонние знания обучающихся; учат их обращаться друг к другу; внимательно относиться к тому, что каждый из них знает, умеет; способствуют взаимообо¬гащению в процессе обучения.\nВ числе основных требований к проведению викторин следующие:\n1)    четкая учебно-воспитательная направленность, ориентация обучающихся на информацию, представляющую общеобразовательную и практическую значимость;\n2)    актуальность и связь с жизнью;\n3)    доступность источников информации;\n4)    занимательность и новизна\n\nСтруктура викторины:\n1) вводная часть\n2) ра¬бота в группах\n3) заключительную часть\nВводная часть. Перед обучающимися ставится задача, они получают раздаточ¬ный материал, их информируют о после¬довательности видов деятельности в про¬цессе работы. Виды деятельности таковы: а) все команды получают одинаковую задачу и материал для выполнения в от-веденное время; б) материал у команд может быть разным (например, при проведении викторины о Германии можно предложить  командам разную тематику: одной команде —«Природа и климат страны», другой —«Население», третьей —«Экономика»); в) команды мо¬гут работать одновременно в отведенное время или же меняться для выполнения различных заданий; г) на викторине мо¬гут быть предусмотрены и индивидуаль¬ные конкурсы капитанов, консультантов; выбор представителя может быть сделан по решению команды.\nРабота в группах. На этом этапе обучающиеся знакомятся с материалом викторины, планируют работу и время, распределяют вопросы между членами команды, совместно обсуждают получен¬ный результат, дорабатывают и коррек¬тируют ответы.\nЗаключительная часть. Подводятся итоги работы, анализируется выполне¬ние заданий, дается оценка групповой и индивидуальной работы, проводится разбор типичных ошибок, акцентирует¬ся внимание на вопросах, вызвавших особые трудности. Этот этап позволяет преподавателю проконтролировать свою рабо¬ту, скорректировать планирование, наметить план по ликвидации пробелов.\n";
                            break;
                        case 4:
                            LessonCompleteRichBox.Text += "   Требования к подготовке и проведению коллоквиума: \n1. Минимальное количество часов, отводимое на коллоквиум, не может быть менее 2 часов на одну группу. Как правило, коллоквиум проводится в рамках 2 - 4 часов аудиторного времени. Исходя из опыта крупнейших вузов страны время, отводимое на самостоятельную подготовку обучающегося к коллоквиуму, составляет 9 часов в счёт трудоёмкости освоения данной учебной дисциплины по учебному плану.\n2. Материал программы учебной дисциплины (часть, раздел, темы), отнесенный к коллоквиуму, должен по трудоемкости освоения 10 студентом составлять 25-30% от всего объема трудозатрат по данной дисциплине и в дальнейшем не выносится на экзамен. \n3. При подготовке к коллоквиуму преподаватель обязан: \n•    определить задачи, круг обсуждаемых вопросов, практических заданий, время проведения; \n•    подобрать литературу для студентов; \n•    консультировать обучающихся по ходу подготовки коллоквиума и проверять их готовность; \n•    заранее объявить дату, тему и план коллоквиума. \n\n4. Методическое обеспечение коллоквиума должно содержать следующие обязательные компоненты: \n•    формулировки темы и вопросов, заданий по освоению её содержания; \n•    требования к заданиям и умениям, которые должен продемонстрировать обучающийся при освоении содержания данной темы; \n•    списки обязательной и дополнительной литературы, перечень интернет-ресурсов; \n•    терминологический минимум, который должен освоить обучающийся при самостоятельном изучении темы; \n•    методические указания по освоению содержания представленной темы; \n•    разработанный и утвержденный уровень компетенций; \n•    критерии оценки ответов на коллоквиуме. \n Форма проведения коллоквиумов \n1. Коллоквиум проводится, как правило, во внеаудиторное время. В порядке исключения с учетом наличия ресурсов обеспечения учебного процесса и по рекомендации Методического совета Университета решением 11 проректора по учебной работе коллоквиум может быть проведён в аудиторное время, выделенное на изучение данной учебной дисциплины. \n2. В случае неудовлетворительного результата сдачи коллоквиума студенту разрешается его пересдать в оставшийся до экзаменационной сессии период с оформлением индивидуального зачетного листа, выдаваемого в деканате. При не сданном коллоквиуме студент не допускается до экзамена по этой дисциплине. \n3. Итоговая оценка по учебной дисциплине, по которой предусматривается сдача коллоквиума, выставляется по результатам сдачи экзамена в установленном порядке. \n4. Если коллоквиум проводится в письменной форме, то результаты деятельности студентов представляют собой: \n•    развёрнутые ответы на контрольные вопросы; \n•    решения контрольных заданий. \n\n5. Объем одного блока вопросов должен соответствовать общей трудоемкости дисциплины и содержать 20-30 вопросов. Вопросы не должны предполагать односложный (однословный) ответ. \n6. Основанием для принятия (зачёта) коллоквиума является ведомость, выдаваемая деканатом в установленном порядке. По результатам сдачи студентами коллоквиума выносятся следующие оценки:«зачтено» - правильных ответов равно или более 50%,«незачтено» - правильных ответов менее 50% от их общего числа. Определение количества правильных ответов производится преподавателем по опросным картам или по результатам письменных ответов и решению задач. Для повышения объективности оценки преподаватель может провести собеседование со студентом по его письменным ответам на вопросы и результатам решения задач. \n7. Продолжительность сдачи студентами коллоквиума устанавливается преподавателем по согласованию с заведующим кафедрой исходя из формы его проведения и содержания контрольных заданий.  \n8. Результаты коллоквиума преподаватель фиксирует в ведомости, выданной ему деканатом для проведения коллоквиума. Указанная ведомость заполняется и сдается в деканат в день проведения коллоквиума. \n9. Материалы сдачи студентами коллоквиума (опросные карты, письменные ответы на контрольные вопросы, решение задач и другие) должны храниться на кафедре с соблюдением мер конфиденциальности. \n10. Составление и ежегодное обновление вопросов и задач должно быть предусмотрено индивидуальным планом преподавателя, ведущим данную дисциплину. \nОсобенности проведение устного коллоквиум по теме или разделу дисциплины: \nСобеседование ведется с каждым студентом индивидуально в присутствии малой группы (5-6 человек). В случае затруднения студента при ответе на поставленный вопрос, последний может быть переадресован другим. При этом студенты могут дополнять друг друга, дискутировать, задавать вопросы, всесторонне обсуждая проблему. Таким образом, коллоквиум представляет собой групповую форму беседы преподавателя со студентами с целью выяснения их знаний. При этом каждому выставляется дифференцированная оценка. На коллоквиуме студенты могут пользоваться своими записями изученных материалов. Не следует сводить коллоквиум к семинару. Если семинар сегодня не рекомендуется проводить лишь вопросно-ответным методом, то на коллоквиуме такой метод является основным. На коллоквиуме студент должен продемонстрировать, что он: \n•    знает содержание и структуру работы, отдельных её глав и параграфов (если на коллоквиум выносится отдельный труд); \n•    уяснил логику изложения материала; \n•    умеет выделить узловые идеи и положения; \n•    умеет обобщать материал с помощью схем, таблиц, вопросов и делать записи прочитанного (сделать выписки, составить план, тезисы, аннотацию, резюме, конспект); \n•    видит связь изучаемой теории с практикой; \n•    имеет собственное мнение о прочитанном.\n";
                            break;
                        case 5:
                            LessonCompleteRichBox.Text += "•       Конкурсный урок – это творческое учебное занятие по индивидуальному сценарию, режиссуре и содержанию, опирающееся на современные классические принципы обучения и воспитания учащихся\n •    Конкурсный урок — это не просто современный урок, это особый урок, ибо он естественная часть предъявляемого взыскательной аудитории педагогического опыта.\n •    Важно, чтобы урок был профессиональным! Проблемным! Важно, чтобы он был уроком взаимодействия, диалога!\n •    Конкурсный урок должен быть иллюстрацией системы работы педагога, научных позиций, технологий, педагогических позиций, предъявленных в разных формах (эссе, обобщение опыта, статьи в журнал).\n •    Важно, чтобы после урока у конкурсанта осталось ощущение праздника творческого единения с детьми, соавторами, соисполнителями задуманного.\n •    Безусловно, конкурсный урок своеобразен по содержанию, ориентированному на незнакомых детей.\n •    Залог его успешности в умении поставить цель, определить задачи и педагогически грамотно подобрать нужные для их решения средства.\n •    Учителю-конкурсанту необходимы и такие качества, как способность импровизировать, умение слушать и слышать незнакомых детей, чутко реагировать в диалоге на их вопросы и ответы.\n •    Заметим, что не менее важны раскованность и сдержанность, спокойствие, умение ориентироваться в реальной, порой непред-сказуемой ситуации, управлять своим творческим самочувствием.\n\nПри всем различии предметов и образовательных областей для оценки каждого конкурсанта к ним предъявляются обязательные требования, которые ежегодно входят в критерии оценки:\n •    Глубокое знание своего предмета.\n •    Некорректное оперирование научными понятиями, небрежность, неточности, оговорки, речевая безграмотность недопустимы.\n •    Грамотное, в соответствии с целями и задачами урока использование новых, современных, а иногда и традиционных, но работающих на результат, способов передачи знаний.\n •    Допускается интерпретация описанных в педагогической литературе авторских методик (технологий), а еще лучше - предъявление собственной апробированной методики (технологии).\n •    Коммуникативные способности, актерское и ораторское мастерство. К сожалению, педагогической техникой конкурсанты владеют явно недостаточно.\n •    Умение достигать результата образовательной деятельности при любом уровне подготовленности класса. Ссылка на слабый уровень подготовки детей неуместна.\nОчевидно, что каждый предмет имеет свое образовательно-информационное поле и требует использования специфических методов, приемов и форм организации учебного занятия.\nОшибки при самоанализе урока, мероприятия\n •    Редко бывает объективным со стороны участника;\n •    Цениться объективный анализ, когда педагог констатирует, что получилось не так, как планировал, в каком месте отошёл от запланированного, т.к. урок пошёл не«по сценарию». Это говорит о мобильности педагога, его умении выйти достойно из непредвиденной ситуации;\n •    Редко педагог аргументирует отбор содержания урока (занятия) – не просто, что по программе, а почему взят именно этот материал;\n •    От педагога больше ждут импровизации, а не только домашней заготовки, от которой преподаватель не может отойти.\n";
                            break;
                        case 6:
                            LessonCompleteRichBox.Text += "";
                            break;
                    }
                    break;
                case 5:
                    LessonCompleteRichBox.Text = "   Урок коррекции знаний. Он по-прежнему важен, потому что помогает школьнику осознать причину ошибок, скорректировать знания, наметить план работы на будущее. Более низкая, чем хотелось бы, оценка должна стать стимулом для дальнейшей работы, указателем, в каком направлении следует двигаться. Если урок коррекции не выполнит эту задачу, оценка так и останется обидной цифрой в журнале, что нежелательно во всех отношениях. Поэтому к планированию урока коррекции надо подготовиться особенно тщательно и особенное внимание уделить мотивационной части. \nСтруктура урока \n•    Мотивационная часть. \n•    В начале урока проводится работа над наиболее часто встречающимися ошибками, но педагог не комментирует суть ошибки, а предлагает студентам определить, в чем ее причина и как ее можно было избежать. Обычно это коллективный этап работы. \n•    Если позволяет время, затем можно провести групповой этап, разделив студентов на набольшие группы в соответствии с их ошибками. Тем, кто выполнил работу безошибочно, на данном этапе можно предложить задания повышенной сложности. \n•    Следует провести этап индивидуальной работы, в ходе которого предложить каждому студенту наметить для себя план коррекции (повторить какую-либо тему) и определиться, что он может сделать сам, а в чем ему нужна помощь. \n•    Рефлексия на таком уроке особенно важна (собственно, предыдущий этап как раз и есть подготовка к качественной рефлексии).\n";
                    LessonCompleteRichBox.Text += text1;
                    switch (LessonPoint2X)
                    {
                        case 1:
                            LessonCompleteRichBox.Text += "    Этапы подготовки и проведения урока-зачёта.\n1.    Предварительная подготовка к уроку-зачёту.\n2.   Проведение урока-зачёта.\n3.   Подведение итогов и внесение корректив.\n1этап.   Предварительная подготовка.\nПодготовительная работа начинается на первом вводном уроке по теме. Преподаватель анализирует требования программы по теме, определяет основные задания, учитывая три уровня усвоения:\n1.   Понимание, запоминание, воспроизведение материала.\n2.   Применение знаний и  умений в знакомой ситуации.\n3.   Применение знаний и умений в новой ситуации.\nПреподаватель сообщает тему и дату проведения урока-зачёта, его место и значение в изучении новой темы, знакомит с требованиями, которые будут предъявлены к учащимся, предлагает индивидуальные задания по тем вопросам, в которых некоторые студенти ранее не разбирались.\nНа стенде.\n1.   Перечень знаний, умений и навыков.\n2.   Вопросы и задания.\n3.   Советы по организации различных видов учебной деятельности: памятки, алгоритмы ,планы и образцы решений   наиболее сложных задач по теме.\n4.   Примерная контрольная работа.\n5.    Литература по теме.\n2 этап.  Проведение зачёта.\nНа зачётном уроке опрашивать можно не всех учащихся. Учащиеся, успешно усвоившие учебный материал могут получить зачёт по обязательному материалу автоматически.  Они могут помочь учителю принимать зачёт у остальных учащихся, либо им предлагаются дифференцированные задания повышенной сложности.\nЗачёт может быть письменным или устным. Можно проводить и комбинированные зачёты.\n3 этап.  Подведение итогов работы.\nОценка труда учащихся.\nЕсли зачёт устный, то оцениваются ответы учащихся на этом же уроке. Если письменный или комбинированный, то на следующем уроке, после проверки работ учителем.\nВиды зачётов.\n        1).Открытый тематический зачёт.\n        2). Закрытый тематический зачёт.\n        3). Открытый текущий зачёт.\n        4). Закрытый текущий зачёт.\nВ открытом тематическом зачёте учащиеся предварительно знакомятся со списком задач обязательного уровня. В закрытом тематическом зачёте список задач в явном виде учащимся не предъявляется. Но это не означает, что учащимся совсем неизвестно, какие виды задач относятся к обязательным. В ходе изучения материала преподаватель акцентирует внимание учащихся на задачах обязательного уровня, подчёркивая, что подобные задачи нужно будет решать на зачёте.\nМетодические рекомендации по  проведения закрытого зачётного урока.\nЦель: проверка достижения учащимися уровня обязательной подготовки; овладение важнейшими умениями и навыками.\nЗадача: установить уровень овладения знаниями по конкретной теме.\nПодготовка: в процессе изучения темы отводится специальное время на формирование и отработку умений решать задачи обязательного уровня.\nВремя проведения: за один - два урока запланированного окончания изученной темы.\nФормы: устная (опрос по билетам); письменная (контрольная работа); смешанная (часть учащихся класса опрашивается устно, а остальные задания письменно и сдают учителю на проверку).\nПлан проведения: разминка, самостоятельная работа, решение (обязательная) устных задач (часть), устный (дополнительная) мини-экзамен (часть), тест.\nПодведение итогов: проводится на следующем уроке (объявляется количество набранных баллов и оценка).\nКорректировка: разбираются задачи, вызвавшие у учащихся наибольшие трудности. Время на пересдачу зачетов отводится на уроке. Предлагается индивидуальная карточка - задание или задача из зачета в качестве дополнительного задания.\nМетодические рекомендации по проведению открытого зачётного урока.\nЦель: учет и контроль знаний, умений и навыков.\nЗадача: установить уровень овладения знаниями по конкретной теме.\nПодготовка: в начале изучения темы вывешивается в классе или раздается учащимся список задач, отвечающим уровню обязательной подготовки по данной теме, и сообщает, что после ее изучения будет зачет.\nВремя проведения: на специально выделенном уроке.\nФорма: проверочная работа.\nПлан проведения: разминка, самостоятельная работа, обязательная часть, дополнительная часть.\nПодведение итогов: проводится на следующем уроке (объявляется количество набранных баллов и оценка).\nКорректировка: разбираются задачи, вызвавшие у учащихся наибольшие трудности. Время на пересдачу зачетов отводится на следующем уроке. Предлагается индивидуальное задание.\nТекущие зачеты\nпроводятся несколько раз в ходе изучения темы. От тематических они отличаются тем, что охватывают меньший по объему материал; поэтому, как правило, на их проведение не требуется отводить весь урок. Это могут быть небольшие работы, рассчитанные на 10-15 минут и направленные на проверку одного - двух умений, формируемых в течение нескольких уроков.\n";
                            break;
                        case 2:
                            LessonCompleteRichBox.Text += "   Экзамен проводится в объеме программы учебной дисциплины. Форма и порядок проведения экзамена определяются кафедрой. Для проведения экзамена на кафедре разрабатываются:\n- экзаменационные билеты, количество которых должно быть больше числа экзаменующихся курсантов (слушателей и студентов) учебной группы;\n- практические задания, решаемые на экзамене;\n- перечень средств материального обеспечения экзамена (стенды, плакаты, справочная и нормативная литература и т.п.)\nМатериалы для проведения экзамена обсуждаются на заседании кафедры и утверждаются заместителем начальника университета по учебной работе не позднее 10 дней до начала экзаменационной сессии.\nВ экзаменационный билет включаются два теоретических вопроса.\nПредварительное ознакомление обучающихся с экзаменационными билетами не разрешается\nЭкзамен принимается заведующим кафедрой, заместителем начальника кафедры, профессорами и доцентами. В отдельных случаях с разрешения заведующего кафедрой в помощь основному экзаменатору могут привлекаться преподаватели, ведущие семинарские и практические занятия.\nНа экзамене, кроме экзаменатора и экзаменуемых, имеют право присутствовать начальник и заместитель начальника университета, начальники и заместители начальника УМЦ, факультета и кафедры. Другие лица только с разрешения начальника университета. В аудитории (учебном кабинете), где проводится экзамен, должны быть: программы учебной дисциплины, экзаменационная ведомость, комплект экзаменационных билетов, перечень вопросов экзаменационных билетов с указанием номеров билетов.\nВ аудитории могут одновременно находиться не более пяти экзаменующихся.\nДля подготовки к ответу курсантам (слушателям и студентам) отводится не более 20 минут. Норма времени на прием экзамена – 15 минут на одного обучающегося.\nПо окончании ответа на вопросы билета экзаменатор может задавать дополнительные и уточняющие вопросы в пределах учебного материала, вынесенного на экзамен.\nПрерывать экзаменующегося при ответе не рекомендуется.\nОценка по результатам экзамена объявляется курсанту (слушателю и студенту), заноситься в экзаменационную ведомость и зачетную книжку. Неудовлетворительные оценки проставляются только в экзаменационной ведомости (в зачетные книжки не заносятся).\nЕсли неявка была по неуважительной причине, то начальником центра организации и координации учебно-методической работы в ведомости проставляется неудовлетворительная оценка. Другие записи или прочерки в экзаменационной ведомости не допускаются.\n";
                            break;
                        case 3:
                            LessonCompleteRichBox.Text += "   Структура семинарского занятия обычно включает в себя следующие этапы: \n1. Организационный момент \n2. Вступительное слово преподавателя направлено на психологическую установку студентов к предстоящей работе и на актуальность рассматриваемой проблемы. Он объявляет тему, цели и задачи семинарского занятия, определяет его место в изучаемом курсе. Также определяет порядок выступлений и их регламент. \n3. Основная часть семинара. Заслушивание ответов на вопросы, докладов, рефератов. Последовательное обсуждение ответов, рефератов, докладов. Выработка мнений и суждений, формирование в результате дискуссии правильных суждений и др. Обсуждение темы зависит от методики работы преподавателя, которую он реализует на конкретном семинарском занятии. \n4. Заключительное слово преподавателя (подведение итогов занятия). Анализ качества выступлений студентов, оценка их деятельности, степень подготовленности учебной группы, уровень культуры мышления участников. Преподаватель также поясняет используемую им систему поощрения и снижения оценки, определяет степень достижения цели семинара. Для обеспечения обратной связи преподавателю необходимо организовать рефлексию семинара. Здесь для студентов используются вопросы«Что я получил на сегодняшнем занятии?»,«Удалось ли мне доказать свою точку зрения?»,«Кто из участников помогал/мешал мне в работе?» и т.д., а также экспресс-опросы, анкеты. \n5. Домашнее задание. \nПодготовка преподавателя к проведению семинара \nРезультативность и эффективность семинара в значительной степени зависит от преподавателя. В отличии от обучаемых, преподаватель должен изучить более широкий перечень литературы по теме. Особенность работы преподавателя с литературой состоит в том, что он ее изучает не только с целью познания, но и для того, чтобы определить, как можно полезнее использовать важную и наиболее ценную информацию в интересах полного и глубокого осознания и прочного усвоения обучаемыми, выносимых на обсуждение вопросов и проблем, обеспечить реализацию поставленных перед занятием учебных целей. При этом преподаватель всегда выделяет важные детали вопросов, которые могут быть не замечены обучаемыми, но имеющие важное значение для углубления их знаний и для практической деятельности. Преподаватель должен продумать и наметить дополнительные (наводящие) вопросы, стимулируя этим активность обучаемых и глубокое всестороннее изучение вопросов. Следует предусмотреть вероятность альтернативных ответов и подготовиться к их анализу и сравнению, выявлению положительных сторон и недостатков. Затем следует продумать методику проведения семинара, каждый обучаемый должен принять активное участие в семинаре. Сначала продумать вступительное слово, затем методику обсуждения каждого вопроса. Необходимо продумать также структуру ожидаемого ответа. К подведению итогов семинара преподаватель готовится в процессе занятия. Необходимо определить систему критериев и показателей, пользуясь которыми преподаватель мог бы более или менее объективно проанализировать и оценить ответ каждого обучаемого, сравнить ответы студентов между собой, оценить их качество по форме и содержанию и подвести обоснованные итоги подготовки обучаемых и степень достижения целей.\n";
                            break;
                        case 4:
                            LessonCompleteRichBox.Text += "   Подготовительный этап: обсуждаем условия и правила игры\nУсловия аукциона необходимо заранее обсудить с обучающимися. Чем старше студенти, тем более сложную систему торгов и оценивания можно предложить.\n•  Вариант 1. Например, простая форма аукциона: каждый студент получает по 15 монет (у.е.). Каждый лот оценивается в 2 монеты. Право отвечать получает тот, кто предложит наибольшую цену. Задача студентов: потратить все монеты.\n•  Вариант 2: Все лоты раскладываются на игровом поле (как на \"Поле чудес\"). Студенти (или группа студентов) крутит барабан и получает выпавший лот. Их задача: правильно решить предложенную задачу (ответить на вопрос). Каждый правильный, подробный и развернутый ответ оценивается в 2 монеты. За дополнения выдается из банка по 1 монете. Выигрывает та команда (группа), которая получила наиболее количество монет.\n•  Вариант 3: Каждый студент изначально имеет определенную сумму у.е. (например, по 1000). В ходе торгов он (или группа учащихся) могут выкупить лот, назвав максимальную цену. Если ответ на вопрос в лоте будет правильным, подробным, исчерпывающим, то команда или студент могут получить поощрение из банка в размере 100 у.е. За неполные ответы или неправильные возможны штрафные санкции (до 300 у.е.).\n•  Вариант 4: Без денег. Это самый простой вид аукциона. Класс делится на команды. В продажу поступают лоты, но в качестве выкупа будут правильные ответы.\nНапример, для урока русского языка в 3-ем классе. Тема: Части речи. Лот №1 Имя существительное.\nИтак, на продажу выставлен лот № 1. После объявления темы команды дают поочередно характеристики имени существительного: самостоятельная часть речи, отвечает на вопросы \"Кто? Что?\", склоняется по падежам, изменяется по числам, имеет род, имеет склонение и т.д. За каждый правильный ответ команда получает по 2 балла. Лот уходит к той команде, которая наберет самое большое количество очков. Если количество баллов получается одинаковым, можно предложить дополнительное задание. С проигравшей команды можно взимать \"комиссионные\" в виде частушек, песни, стихотворения и т.д.\nКак видите, вариантов воплощения самой идеи аукциона много. Важно только сначала все подробно обсудить с студентами, чтобы в ходе урока не возникало недопонимания и трений среди участников. Очень удобно, когда учет растраченных и заработанных средств ведется в реальном режиме. Для этого можно использовать, к примеру, доску, где в заранее подготовленную таблицу будут вноситься все изменения.\nПодготовка учащихся к уроку-аукциону\nУроки-аукционы ценны тем, что учащиеся должны повторить, обобщить целый пласт знаний по теме до урока. А для более успешного выступления приветствуется подбор новых, интересных фактов по теме.\nКак правило, о проведении аукциона целесообразно объявить заранее — за 1-2 недели. Желательно дать студентам список тем, которые будут обсуждаться на уроке, список литературы и возможных ресурсов, где можно найти информацию по данной тематике, приблизительный перечень заданий.\nСамые активные классы могут сами придумывать задания к лотам. Либо вопросы друг другу можно выставить как один из лотов. В этом случае на аукционе можно ввести систему поощрительных баллов: \"За самое необычное задание\", \"За самый интересный вопрос\" и т.д.\n•  Варианты лотов\n •    Задания \"Кто быстрее?\" Кто быстрее решит примеры, кто быстрее составит анаграмму, кто быстрее отгадает задку и т.д.\n •    Викторины. Такие лоты хороши для разминки, а потому их целесообразнее выставлять первыми.\n •    Тесты.\n •    Кроссворды, чайнворды.\n •    Исторические сведения (уместны для любого предмета).\n •    Цифровые диктанты или диктанты \"да-нет\". Можно проводить как устно, так и письменно.\n •    Игровые задания. Лоты строятся по примеру любых дидактических игр, которые ваши студенти уже знают и умеют в них играть.\n •    Видео или аудио вопросы.\n •    \"Черный ящик\". В ящике лежит предмет, который студенти должны связать с темой урока.\n •    Практические задания (на них стоит сделать основной упор, так как именно практическое применение правил лучше всего показывает степень усвоения темы).\n •    Творческие задания (составить задачу, нарисовать сюжетную картинку, собрать паззл, придумать стихотворение и т.д.).\n •    Задания повышенной сложности. За них и \"цена\" назначается выше.\nОформление урока-аукциона\nУрок-аукцион позволяет использовать максимально возможное количество наглядных изобразительных и звуковых средств. Очень помогает в проведении аукциона интерактивная доска, на которой удобно представлять отдельные задания и вести общий подсчет баллов.\nДополнительно класс можно оформить как зал проведения торгов: за кафедрой, где будет находиться аукционист, установить металлический гонг или специальный молоточек. Хорошо, если будет вывешен плакат с правилами проведения аукциона. Кроме того, каждому студенту можно вручить специальное приглашение на аукцион (такие же можно раздать коллегам, если вы решите их пригласить на свой урок).\nНе забывайте о поощрениях. Конечно, главное поощрение — положительная оценка за урок. Но и награды в виде медалей, дипломов или грамот также приветствуются.\nТипичные ошибки в организации урока-аукциона и как их избежать\n •    Чрезмерное увлечение \"продажами\". Нельзя позволять студентам \"переигрывать\", отводя значительную часть времени на \"торги\". Особенно, если вы решите продавать лоты за у.е. Желательно сразу установить регламент: например, окончательной становится цена, названная третьей или установите максимальную ставку, выше которой поднимать цены нельзя, то есть блиц-цену. Можно установить и размер аукционного шага.\n •    Не регламентировано время. Желательно регламентировать и время ответов на задания одного лота. А чтобы обстановка как можно больше походила на атмосферу настоящего аукциона, можно установить гонг, удары которого будут сигнализировать об окончании торгов.\n •    Слишком много лотов. Лучше всего выбирать микротемы, а не материал целого курса.\n •    Однообразие лотов. Будет скучно и малоэффективно, если все ваши задания будут строиться одинаково: например, только вопросы-ответы. Желательно разнообразить работу, включив в состав лотов разные задачи как из теории, так и  из практики. Ведь ваша задача — привлечь всех студентов. Поэтому необходимо предусмотреть задания и творческого плана, и на эрудицию и общее развитие.\n •    Незнание правил аукциона. Выше уже отмечалось, что если учащиеся не поняли принципа проведения аукциона, то хаоса и обид не избежать. Поэтому рекомендуется предварительно обсудить все правила. А еще лучше, если вы будете иногда включать систему аукциона в качестве одного из этапов урока еще на предварительном этапе подготовки. Например, проводить в форме аукциона проверку домашнего задания или проверку практического задания, данного как закрепление к теме. \nДля тех, кто никак не решится на аукцион\n •    Не стоит сразу отвергать даже кажущиеся невероятными формы нестандартных уроков. Чем меньше будет шаблонов в вашем преподавании, тем больше шансов на успех.\n •    Больше творчества! Но творчества не ради развлечения, а направленного на реализацию идеи познания в самой легкой и интересной форме. \n";
                            break;
                        case 5:
                            LessonCompleteRichBox.Text += " •    Конкурсный урок – это творческое учебное занятие по индивидуальному сценарию, режиссуре и содержанию, опирающееся на современные классические принципы обучения и воспитания учащихся\n •    Конкурсный урок — это не просто современный урок, это особый урок, ибо он естественная часть предъявляемого взыскательной аудитории педагогического опыта.\n •    Важно, чтобы урок был профессиональным! Проблемным! Важно, чтобы он был уроком взаимодействия, диалога!\n •    Конкурсный урок должен быть иллюстрацией системы работы педагога, научных позиций, технологий, педагогических позиций, предъявленных в разных формах (эссе, обобщение опыта, статьи в журнал).\n •    Важно, чтобы после урока у конкурсанта осталось ощущение праздника творческого единения с детьми, соавторами, соисполнителями задуманного.\n •    Безусловно, конкурсный урок своеобразен по содержанию, ориентированному на незнакомых детей.\n •    Залог его успешности в умении поставить цель, определить задачи и педагогически грамотно подобрать нужные для их решения средства.\n •    Учителю-конкурсанту необходимы и такие качества, как способность импровизировать, умение слушать и слышать незнакомых детей, чутко реагировать в диалоге на их вопросы и ответы.\n •    Заметим, что не менее важны раскованность и сдержанность, спокойствие, умение ориентироваться в реальной, порой непред-сказуемой ситуации, управлять своим творческим самочувствием.\n\nПри всем различии предметов и образовательных областей для оценки каждого конкурсанта к ним предъявляются обязательные требования, которые ежегодно входят в критерии оценки:\n •    Глубокое знание своего предмета.\n •    Некорректное оперирование научными понятиями, небрежность, неточности, оговорки, речевая безграмотность недопустимы.\n •    Грамотное, в соответствии с целями и задачами урока использование новых, современных, а иногда и традиционных, но работающих на результат, способов передачи знаний.\n •    Допускается интерпретация описанных в педагогической литературе авторских методик (технологий), а еще лучше - предъявление собственной апробированной методики (технологии).\n •    Коммуникативные способности, актерское и ораторское мастерство. К сожалению, педагогической техникой конкурсанты владеют явно недостаточно.\n •    Умение достигать результата образовательной деятельности при любом уровне подготовленности класса. Ссылка на слабый уровень подготовки детей неуместна.\nОчевидно, что каждый предмет имеет свое образовательно-информационное поле и требует использования специфических методов, приемов и форм организации учебного занятия.\nОшибки при самоанализе урока, мероприятия\n •    Редко бывает объективным со стороны участника;\n •    Цениться объективный анализ, когда педагог констатирует, что получилось не так, как планировал, в каком месте отошёл от запланированного, т.к. урок пошёл не«по сценарию». Это говорит о мобильности педагога, его умении выйти достойно из непредвиденной ситуации;\n •    Редко педагог аргументирует отбор содержания урока (занятия) – не просто, что по программе, а почему взят именно этот материал;\n •    От педагога больше ждут импровизации, а не только домашней заготовки, от которой преподаватель не может отойти.\n";
                            break;
                        case 6:
                            LessonCompleteRichBox.Text += "";
                            break;
                    }
                    break;
            }
            foreach (var item in MethodicalReceptions)
            {
                if (item.GetPoint())
                {
                    LessonCompleteRichBox.Text += text1;
                    LessonCompleteRichBox.Text += "\n   " + item.GetOp() + "\n";
                    LessonCompleteRichBox.Text += item.GetText();
                }
            }
            LessonCompleteRichBox.Text += text1;
            LessonCompleteRichBox.Text += OsnInf;
        }

        private void LessonPointEnabled(bool temp)
        {
            LessonPoint11.Enabled = temp;
            LessonPoint12.Enabled = temp;
            LessonPoint13.Enabled = temp;
            LessonPoint14.Enabled = temp;
            LessonPoint15.Enabled = temp;
            LessonPoint16.Enabled = temp;
        }
        private void LessonPoint11_Click(object sender, EventArgs e)
        {
            LessonPointDefault();
            LessonPoint11.BackColor = selectButtonColor;
            byte lpx = 1;
            if (LessonNumber == 1)
                LessonPoint1X = lpx;
            else if (LessonNumber == 2)
                LessonPoint2X = lpx;
            else
                LessonPoint3X = lpx;
            LessonButton1.BackColor = Color.Green;
            LessonButton1.Text = "Далее";
        }

        private void LessonPoint12_Click(object sender, EventArgs e)
        {
            LessonPointDefault();
            LessonPoint12.BackColor = selectButtonColor;
            byte lpx = 2;
            if (LessonNumber == 1)
                LessonPoint1X = lpx;
            else if (LessonNumber == 2)
                LessonPoint2X = lpx;
            else
                LessonPoint3X = lpx;
            LessonButton1.BackColor = Color.Green;
            LessonButton1.Text = "Далее";
        }

        private void LessonPoint13_Click(object sender, EventArgs e)
        {
            LessonPointDefault();
            LessonPoint13.BackColor = selectButtonColor;
            byte lpx = 3;
            if (LessonNumber == 1)
                LessonPoint1X = lpx;
            else if (LessonNumber == 2)
                LessonPoint2X = lpx;
            else
                LessonPoint3X = lpx;
            LessonButton1.BackColor = Color.Green;
            LessonButton1.Text = "Далее";
        }

        private void LessonPoint14_Click(object sender, EventArgs e)
        {
            LessonPointDefault();
            LessonPoint14.BackColor = selectButtonColor;
            byte lpx = 4;
            if (LessonNumber == 1)
                LessonPoint1X = lpx;
            else if (LessonNumber == 2)
                LessonPoint2X = lpx;
            else
                LessonPoint3X = lpx;
            LessonButton1.BackColor = Color.Green;
            LessonButton1.Text = "Далее";
        }

        private void LessonPoint15_Click(object sender, EventArgs e)
        {
            LessonPointDefault();
            LessonPoint15.BackColor = selectButtonColor;
            byte lpx = 5;
            if (LessonNumber == 1)
                LessonPoint1X = lpx;
            else if (LessonNumber == 2)
                LessonPoint2X = lpx;
            else
                LessonPoint3X = lpx;
            LessonButton1.BackColor = Color.Green;
            LessonButton1.Text = "Далее";
        }

        private void LessonPoint16_Click(object sender, EventArgs e)
        {
            LessonPointDefault();
            LessonPoint16.BackColor = selectButtonColor;
            byte lpx = 6;
            if (LessonNumber == 1)
                LessonPoint1X = lpx;
            else if (LessonNumber == 2)
                LessonPoint2X = lpx;
            else
                LessonPoint3X = lpx;
            LessonButton1.BackColor = Color.Green;
            LessonButton1.Text = "Далее";
        }

        private void LessonButton1_Click(object sender, EventArgs e)
        {
            switch (LessonNumber)
            {
                case 1:
                    if (LessonPoint1X != 0)
                        OpenLessonPoint2X();
                    break;
                case 2:
                    if (LessonPoint2X != 0)
                    {
                        OpenMethodical(sender, e);
                        MainMenuCloseHelper(sender, e);
                    }
                    break;
                case 3:
                    OpenLessonComplete(sender, e);
                    break;
            }

        }

        private void LessonStructureButton_Click(object sender, EventArgs e)
        {
            if (LessonCompletePictureBox.Visible == false)
            {
                LessonCompleteRichBox.Visible = false;
                LessonCompletePictureBox.Visible = true;
                LessonStructureButton.Text = "СКРЫТЬ СТРУКТУРУ";
            }
            else
            {
                LessonCompletePictureBox.Visible = false;
                LessonCompleteRichBox.Visible = true;
                LessonStructureButton.Text = "ПОКАЗАТЬ СТРУКТУРУ";
            }
        }

        private void TestRadioDefault()
        {
            RadioTB11.Checked = false;
            RadioTB12.Checked = false;
            RadioTB21.Checked = false;
            RadioTB22.Checked = false;
            RadioTB31.Checked = false;
            RadioTB32.Checked = false;
            RadioTB41.Checked = false;
            RadioTB42.Checked = false;
            RadioTB51.Checked = false;
            RadioTB52.Checked = false;
            RadioTB61.Checked = false;
            RadioTB62.Checked = false;
            RadioTB71.Checked = false;
            RadioTB72.Checked = false;
            RadioTB81.Checked = false;
            RadioTB82.Checked = false;
            RadioTB91.Checked = false;
            RadioTB92.Checked = false;
            RadioTB101.Checked = false;
            RadioTB102.Checked = false;
        }

        private void OpenPrevTest(object sender, EventArgs e)
        {
            CloseAll();
            Text = "Test";
            OpenHelper(TeacherTestText);
            HelperNewLocation(-50, -50);
            OpenTestPanel.Visible = true;
            OpenTestPanel.Location = locationDefault;
            OpenTestPanel.Size = new Size(sizeDefault);
        }

        private void OpenTest(object sender, EventArgs e)
        {
            CloseAll();
            Text = "Test";
            TestPanel.Visible = true;
            TestPanel.Location = locationDefault;
            TestPanel.Size = new Size(sizeDefault);
            TestRadioDefault();
            RadioTBChecked();
        }

        private void MethodicalButtonDefault()
        {
            MethodicalButton1.BackColor = defaultButtonColor;
            MethodicalButton2.BackColor = defaultButtonColor;
            MethodicalButton3.BackColor = defaultButtonColor;
            MethodicalButton4.BackColor = defaultButtonColor;
            MethodicalButton5.BackColor = defaultButtonColor;
            MethodicalButton6.BackColor = defaultButtonColor;
            MethodicalButton7.BackColor = defaultButtonColor;
            MethodicalButton8.BackColor = defaultButtonColor;
            MethodicalButton9.BackColor = defaultButtonColor;
            foreach (var i in MethodicalReceptions)
            {
                i.Off();
            }
        }

        private void OpenMethodical(object sender, EventArgs e)
        {
            CloseAll();
            LessonButton2.Visible = false;
            MethodicalButtonDefault();

            if (MethodicalSelect)
            {
                OpenLessonPoint3X();
                LessonButton2.Visible = true;
            }
            else
                Text = "Methodical receptions";
            MethodicalPanel.Visible = true;
            MethodicalPanel.Location = locationDefault;
            MethodicalPanel.Size = new Size(sizeDefault);
            OpenHelper(MethodicalText);
            if (MethodicalSelect)
                HelperNewLocation(-20, 150);
            else
                HelperNewLocation(-20, 150);
            Point HLT = new Point(HelperLabel.Location.X - 168, HelperLabel.Location.Y + 100);
            HelperLabel.Location = HLT;
            HelperButtonClose.Location = HLT;
        }

        private void OpenPresent(object sender, EventArgs e)
        {
            CloseAll();
            Text = "Presentation";
            OtherPanelTextBox.Text = "ПРЕЗЕНТАЦИОННОЕ СОПРОВОЖДЕНИЕ УРОКА – НОВОЕ КАЧЕСТВО ЗАНЯТИЙ.\nМультимедийный урок предполагает применение:\n1. ППС – программно-прикладных средств;\n2. видео- и аудиоматериалов;\n3. презентационного сопровождения урока.\nМультимедийные презентации используются для того, чтобы выступающий смог на большом экране или мониторе наглядно продемонстрировать дополнительные материалы к своему сообщению.\n Презентации - это способ подачи информации, в котором присутствуют рисунки, фотографии, анимация и звук. Кроме того, презентация имеет сюжет, сценарий и структуру, организованную для удобного восприятия информации.\n  Отличительной особенностью презентации является её интерактивность, то есть создаваемая для пользователя возможность взаимодействия через элементы управления. А в широком смысле этого слова, презентация — это комплексное представление всей полноты теоретического, фактического и визуального материала в виде логически сменяющей друг друга последовательности наглядного материала (слайдов).\n Формирование знаний, умений, навыков обучающихся с использованием презентации способствует наиболее оптимальному изучению, систематизации и оптимизации как уже изученного, так и нового материала. Она развивает навыки работы с персональным компьютером, обобщения материала и умения правильно и структурировано предоставить его для окружающих людей.\n Презентация также косвенно развивает навыки публичных выступлений. Именно благодаря использованию презентации, у обучающихся появляется возможность выделить наиболее актуальные вопросы и наиболее значимые проблемы изучаемой темы.\n Презентационное сопровождение урока – новое качество урока. Использование презентации на уроках способствует:\nповышению темпа и производительности урока;\nучету индивидуальных особенностей учащихся;\nактивизации познавательной деятельности учащихся;\nэстетическому оформлению урока, эмоциональному воздействию на учащихся.\nОбязательное условие - сочетание презентаций с другими видами работы.\nНЕКОТОРЫЕ ПРАВИЛА ОФОРМЛЕНИЯ ПРЕЗЕНТАЦИЙ\n1. В ходе подготовки, внимательно следить и корректировать используемые цветовые схемы. Нельзя использовать слишком яркие цвета, — они способствуют быстрому утомлению и отрицательно сказываются на эмоциональном состоянии учащихся; одновременно с этим, не рекомендуется использовать и слишком тусклые цвета и оттенки, — они также плохо влияют на психологическое состояние учащихся, способствуют рассеиванию внимания и систематической отвлеченности учащегося от работы на уроке. Выбор цветовой гаммы должен проводиться в зависимости от аудитории. Достаточно использовать около 3 подходящих цветов. Главное, чтобы цветовое разнообразие не отвлекало от темы презентации.\n2. Рекомендуется цветом или жирным шрифтом выделять ключевые фрагменты, на которых Вы останавливаетесь при обсуждении.\n3. Слайды должны быть аккуратным. Неряшливо сделанные слайды (разнобой в шрифтах и отступах, опечатки и т.д.) не допускаются.\n4. Необходима титульная страница, на которой указывается тема, автор, организация, дата.\n5. Оптимальное число строк на слайде — от 6 до 11. Перегруженность и мелкий шрифт тяжелы для восприятия. Недогруженность оставляет впечатление, что вы что-то не дописали, не объяснили.\n6. Размещайте на слайде только минимально необходимое количество текста. Избыток информации на слайде помешает сфокусироваться на главных аспектах вашей презентации.\nПАМЯТКА ДЛЯ СОСТАВЛЕНИЯ ПРЕЗЕНТАЦИИ\n1. Анализ состава, цели, характера и состояния аудитории (для кого создается презентация).\n2. Продумать место презентации в структуре урока, цель презентации.\nВыбор, разработка вариантов использования презентации определяется в соответствии с типом урока и дидактическими целями урока.\nПрезентация может целиком соответствовать структуре урока.\nПрезентация может быть одним из элементов урока (например, использоваться при опросе, закреплении или объяснении материала).\nВ форме презентации может быть представлен методический аппарат урока (схемы, таблицы, познавательные задания, вопросы, текстовый материал и т.д.)\nВ форме презентации-игры может быть урок или один из элементов урока.\nС точки зрения организации можно выделить\nнепрерывно выполняющиеся презентации (видеоряд к лекции)\nинтерактивные презентации (презентация-игра, презентация-тест, таблицы и т.д.)\nпрезентация со сценарием (презентации в соответствии с типом и целью урока)\nНа сегодняшний день именно презентация со сценарием все шире используется в учебной и внеурочной работе.\n3. Отбор материала для презентации.\nДля визуального отражения необходимо отбирать наиболее важные, значимые факты,     процессы, явления изучаемой темы.\nПродумать, как идея каждого слайда раскрывает основную идею, цель  всей презентации?\nПродумать какими наглядными средствами (карты, схемы, графики, таблицы фото, иллюстрации, тексты и т.д.) будут наиболее эффективно отражены  основные идеи урока.\nНеобходимо оптимально сочетать визуальный и фактический материал. Продумать: что будет на слайде? что будет говориться? как будет сделан переход к следующему слайду?\n4. Размещение визуального и фактического материала на слайде.\nПрезентация не должна быть перегружена спецэффектами и текстом. Наиболее важные слова, идеи, фрагменты можно выделять цветом или жирным шрифтом  на слайде, чтобы они сразу бросались в глаза.\n5. Подбор текста к слайду.\nПодготовка к речи: написание текста, плана (соответствующего слайдам презентации).  Распространённая ошибка — читать слайд дословно. Лучше всего, если на слайде будет написано определение, а словами будет рассказываться его содержательный смысл. Информация на слайде может быть более формальной и строго изложенной, чем в речи. Речь и слайды не должны совпадать, тогда презентация станет«объёмной». Речь должна быть более популярна и образна.\n6. Рассчитать время презентации в рамках урока.\n7. Важное правило: сочетание презентации с другими видами работы на уроке.\n8. Презентация включает в себя следующие элементы:\nнаглядность   (иллюстрации, карты)\nчеткая структура темы и урока в целом (план урока, логические схемы)\nметодический аппарат (вопросы и задания в течение урока)\nзакрепление пройденного (задания, в том числе и в тестовой форме)\nигровые элементы (анимация)\nработа с источниками\nматериалы исторических сайтов (гиперссылки – документы , Интернет)\n";
            OtherTextPanel.Visible = true;
            OtherTextPanel.Location = locationDefault;
            OtherTextPanel.Size = new Size(sizeDefault);
            OtherPanelTextBox.SelectionStart = 0;
            OtherPanelTextBox.ScrollToCaret();
        }
        private void OpenDiagnosticMotivationStudent(object sender, EventArgs e)
        {
            CloseAll();
            Text = "Diagnostic Motivation Student";
            OtherPanelTextBox.Text = "Для диагностики учебной мотивации студентов мы рекомендуем Вам провести тестирование среди своих обучающихся. Ниже приведены несколько вариантов тестирования. Они помогут Вам выявить мотивы студентов и повысить среди них мотивацию к обучению на уроках по дисциплинам профессионального цикла.\nДиагностика учебной мотивации студентов.\nОписание теста:  Это коммуникативные, профессиональные, учебно-познавательные, широкие социальные мотивы, а также мотивы творческой самореализации, избегания неудачи и престижа.\nИнструкция к тесту : Оцените по 5-балльной системе приведенные мотивы учебной деятельности по значимости для Вас: 1 балл соответствует минимальной значимости мотива, 5 баллов – максимальной.\nТест\n1. Учусь, потому что мне нравится избранная профессия.\n 2. Чтобы обеспечить успешность будущей профессиональной деятельности.\n 3. Хочу стать специалистом.\n 4. Чтобы дать ответы на актуальные вопросы, относящиеся к сфере будущей профессиональной деятельности.\n 5. Хочу в полной мере использовать имеющиеся у меня задатки, способности и склонности к выбранной профессии.\n 6. Чтобы не отставать от друзей.\n 7. Чтобы работать с людьми, надо иметь глубокие и всесторонние знания.\n 8. Потому что хочу быть в числе лучших студентов.\n 9. Потому что хочу, чтобы наша учебная группа стала лучшей в институте.\n 10. Чтобы заводить знакомства и общаться с интересными людьми.\n 11. Потому что полученные знания позволят мне добиться всего необходимого.\n 12. Необходимо окончить институт, чтобы у знакомых не изменилось мнение обо мне, как способном, перспективном человеке.\n 13. Чтобы избежать осуждения и наказания за плохую учебу.\n 14. Хочу быть уважаемым человеком учебного коллектива.\n 15. Не хочу отставать от сокурсников, не желаю оказаться среди отстающих.\n 16. Потому что от успехов в учебе зависит уровень моей материальной обеспеченности в будущем.\n 17. Успешно учиться, сдавать экзамены на «4» и «5».\n 18. Просто нравится учиться.\n 19. Попав в институт, вынужден учиться, чтобы окончить его.\n 20. Быть постоянно готовым к очередным занятиям.\n 21. Успешно продолжить обучение на последующих курсах, чтобы дать ответы на конкретные учебные вопросы.\n 22. Чтобы приобрести глубокие и прочные знания.\n 23. Потому что в будущем думаю заняться научной деятельностью по специальности.\n 24. Любые знания пригодятся в будущей профессии.\n 25. Потому что хочу принести больше пользы обществу.\n 26. Стать высококвалифицированным специалистом.\n 27. Чтобы узнавать новое, заниматься творческой деятельностью.\n 28. Чтобы дать ответы на проблемы развития общества, жизнедеятельности людей.\n 29. Быть на хорошем счету у преподавателей.\n 30. Добиться одобрения родителей и окружающих.\n 31. Учусь ради исполнения долга перед родителями, школой.\n 32. Потому что знания придают мне уверенность в себе.\n 33. Потому что от успехов в учебе зависит мое будущее служебное положение.\n 34. Хочу получить диплом с хорошими оценками, чтобы иметь преимущество перед другими.\nОбработка и интерпретация результатов теста\n•    Шкала 1. Коммуникативные мотивы: 7, 10, 14, 32.\n•    Шкала 2. Мотивы избегания: 6, 12, 13, 15, 19.\n•    Шкала 3. Мотивы престижа: 8, 9, 29, 30, 34.\n•    Шкала 4. Профессиональные мотивы: 1, 2, 3, 4, 5, 26.\n•    Шкала 5. Мотивы творческой самореализации: 27, 28.\n•    Шкала 6. Учебно-познавательные мотивы: 17, 18, 20, 21, 22, 23, 24.\n•    Шкала 7. Социальные мотивы: 11, 16, 25, 31, 33.\nПри обработке результатов тестирования необходимо подсчитать средний показатель по каждой шкале опросника.\n \n\n\n \nМетодика С.С. Гриншпун«Мотивы выбора профессии»\nИнструкция: Вы выбрали профессию. Каковы причины, определяющие Ваш выбор? Из перечисленных ниже выберите наиболее значимые для Вас. В бланке ответов напротив соответствующего номера отметьте выраженную в баллах степень значимости для Вас того или иного мотива:\n4 балла - очень значим;\n3 балла - имеет значение;\n2 балла - скорее значим, чем незначим;\n1 балл - скорее незначим, чем значим;\n0 балла - не имеет значения.\n\n\t«Причинами выбора мною профессии являются…»\n1.    Убеждение, что данная профессия имеет высокий престиж в обществе.\n2.    Влияние семейных традиций.\n3.    Желание руководить людьми.\n4.    Стремление получить диплом о высшем образовании независимо от специальности.\n5.    Возможность получить профессию без длительного обучения.\n6.    желание работать в престижном месте.\n7.    Желание иметь модную профессию.\n8.    возможность быть в центре внимания, путешествовать, носить специальную форму одежды и т.п.\n9.    Желание приобрести материальную независимость от родителей.\n10. Возможность индивидуальной трудовой деятельности.\n11. Возможность удовлетворить свои материальные потребности.\n12. Возможность предпринимательской деятельности.\n13. Необходимость материально обеспечить семью.\n14. Желание приобрести экономические знания.\n15. Стремление найти удачный способ зарабатывать.\n16. Интерес к материальной стороне профессии или должности.\n17. Интерес к содержанию профессии, желание узнать, в чем заключаются обязанности специалиста в избираемой профессии.\n18. Стремление к самосовершенствованию, развитию навыков и умений в избираемой сфере трудовой деятельности.\n19. Хорошая успеваемость в школе по предметам, соответствующим избираемой сфере трудовой деятельности.\n20. Мечта заниматься любимой работой.\n21. Уверенность, что избранная профессия соответствует моим способностям.\n22. Стремление сделать свою жизнь насыщенной, интересной, увлекательной.\n23. Возможность проявить самостоятельность в работе.\n24. Желание приносить пользу людям.\n25. Желание попробовать различные варианты решения профессиональной задачи.\n26. Возможность привлечь свои разнообразные знания, напрямую с профессией не вязанные.\n27. Стремление узнать новое о давно известном и возможность усвоить трудное.\n28. Возможность выдвигать свои идеи, предлагать новые проблемы для решения, реализовывать их независимо от работающих рядом.\n29. Желание заниматься несколькими делами одновременно или переключаться с одного дела на другое.\n30. Стремление решать профессиональные задачи самому, а не следовать указаниям других.\n31. Возможность самовыражения, проявления своих способностей.\n\n\n\n\nМетодика В.К. Гербачевского«Определение уровня притязаний»\nИнструкция: прочтите каждое из приведенных в опроснике высказываний и отметьте, в какой степени Вы согласны или не согласны с ним. Обведите кружком соответствующую цифру в бланке ответов. Все высказывания относятся к тому, о чем Вы думаете, что чувствуете или хотите от Вашей учебной деятельности.\n \n1.   Учеба мне уже порядком надоела\n2.   Я учусь на пределе своих сил\n3.   Я хочу показать все, на что способен\n4.   Я чувствую, что меня вынуждают стремиться к высокому результату\n5.   Мне интересно, что получится\n6.   Учеба – довольно сложное занятие\n7.   То, что я делаю, никому не нужно\n8.   Меня интересует, лучше или хуже мои результаты, чем у других\n9.   Мне бы хотелось поскорее заняться своими делами\n10.   Думаю, что мои результаты в учебе будут высокими\n11.   Учеба может причинить мне неприятности\n12.   Чем лучше показываешь результат, тем больше хочется его превзойти\n13.   Я проявляю достаточно старания\n14.   Я считаю, что мой результат не случаен\n15.   Учеба не вызывает у меня большого интереса\n16.   Я сам ставлю перед собой задачи\n17.   Я беспокоюсь по поводу своих результатов\n18.   Я ощущаю прилив сил\n19.   Лучших результатов мне не добиться\n20.   Учеба имеет для меня определенное значение\n21.   Я хочу ставить всё более и более трудные цели\n22.   К своим результатам я отношусь равнодушно\n23.   Чем дольше учишься, тем становится интереснее\n24.   Я не собираюсь«выкладываться» в учебе\n25.   Скорее всего, мои результаты будут низкими\n26.   Как ни старайся, результат от этого не измениться\n27.   Я бы занялся сейчас чем угодно, только не учебой\n28.   Учеба – довольно простое занятие\n29.   Я способен на лучший результат\n30.   Чем труднее цель, тем больше желание её достичь\n31.   Я чувствую, что могу преодолеть все трудности на пути к цели\n32.   Мне безразлично, какими будут мои результаты по сравнению с другими\n33.   Я увлекся учебой\n34.   Я хочу избежать низкого результата в учебе\n35.   Я чувствую себя независимым\n36.   Мне кажется, что я зря трачу время\n37.   Я учусь вполсилы\n38.   Меня интересуют границы моих возможностей\n39.   Я хочу, чтобы мой результат в учебе оказался одним из лучших\n40.   Я сделаю все, что в моих силах для достижения цели\n41.   Я чувствую, что у меня ничего не выйдет\n42.   Испытание – это лотерея\n \n\n\n \nМетодика исследования уровня субъективного контроля\n \nИнструкция: внимательно прочитайте каждое высказывание, напишите в бланке ответов только те высказывания, с которыми вы полностью согласны.\n \n1.   Продвижение по службе больше зависит от удачного стечения обстоятельств, чем от личных способностей и усилий.\n2.   Большинство разводов происходит оттого, что люди не захотели приспособиться друг к другу.\n3.   Болезнь - дело случая; если уж суждено заболеть, то ничего не поделаешь.\n4.   Люди оказываются одинокими из-за того, что сами не проявляют интереса и дружелюбия к окружающим.\n5.   Осуществление моих желаний часто зависит от везения.\n6.   Бесполезно предпринимать усилия для того, чтобы завоевать симпатию других людей.\n7.   Внешние обстоятельства, родители и благосостояние влияют на семейное счастье не меньше чем отношения супругов.\n8.   Я часто чувствую, что мало влияю на то, что происходит со мной.\n9.   Как правило, руководство оказывается более эффективным, когда полностью контролирует действия подчиненных, а не полагается на их самостоятельность.\n10.   Мои отметки в школе часто зависели от случайных обстоятельств (например, от настроения учителя), чем от моих собственных усилий.\n11.   Когда я строю планы, то, в общем, верю, что смогу осуществить их.\n12.   То, что многим людям кажется удачей или везением, на самом деле является результатом долгих целенаправленных усилий.\n13.   Думаю, что правильный образ жизни может больше помочь здоровью, чем врачи и лекарства.\n14.   Если люди не подходят друг другу то, как бы они ни старались, наладить семейную жизнь они все равно не смогут.\n15.   То хорошее, что я делаю, обычно бывает по достоинству оценено другими.\n16.   Дети вырастают такими, какими их воспитывают родители.\n17.   Думаю, что случай или судьба не играют важной роли в моей жизни.\n18.   Я стараюсь не планировать далеко вперед, потому что многое зависит от того, как сложатся обстоятельства.\n19.   Мои отметки в школе больше всего зависели от моих усилий и степени подготовленности.\n20.   В семейных конфликтах я чаще чувствую вину за собой, чем за противоположной стороной.\n21.   Жизнь людей зависит от стечения обстоятельств.\n22.   Я предпочитаю такое руководство, при котором можно самостоятельно определять, что и как делать.\n23.   Думаю, что мой образ жизни ни в коей мере не является причиной моих болезней.\n24.   Как правило, именно неудачное стечение обстоятельств мешает людям добиться успеха в своем деле.\n25.   В конце концов, за плохое управление организацией ответственны сами люди, которые в ней работают\n26.   Я часто чувствую, что ничего не могу изменить в сложившихся отношениях в семье.\n27.   Если очень захочу я смогу расположить к себе любого.\n28.   На подрастающее поколение влияет так много разных обстоятельств, что усилия родителей по их воспитанию часто оказываются бесполезными.\n29.   То, что со мной случается,  дело моих рук.\n30.   Трудно бывает понять, почему руководители поступают так, а не иначе.\n31.   Человек, который не смог добиться успеха в своей работе, скорее всего, не проявил достаточно усилий.\n32.   Чаще всего я могу добиться от членов моей семьи того, что я хочу.\n33.   В неприятностях и неудачах, происходивших в моей жизни, чаще были виноваты другие люди, чем я сам.\n34.   Ребенка всегда можно уберечь от простуды, если за ним следить и правильно его одевать.\n35.   В сложных обстоятельствах я предпочитаю подождать, пока проблемы разрешатся сами собой.\n36.   Успех является результатом упорной работы и мало зависит от случая или везения.\n37.   Я чувствую, что от меня больше, чем от кого бы то ни было, зависит счастье моей семьи.\n38.   Мне всегда было трудно понять, почему я нравлюсь одним людям и не нравлюсь другим.\n39.   Я всегда предпочитаю принять решение и действовать самостоятельно, а не надеяться на помощь других людей или на судьбу.\n40.   К сожалению, заслуги человека часто остаются непризнанными, несмотря на все его старания.\n41.   В семейной жизни бывают такие ситуации, которые не возможно разрешить даже при самом сильном желании.\n42.   Способные люди, не сумевшие реализовать свои возможности, должны винить в этом только самих себя.\n43.   Многие мои успехи были возможны только благодаря помощи других людей.\n44.   Большинство неудач в моей жизни произошло от незнания или лени и мало зависело от везения или невезения.\n \n \n\n\n \nМетодика исследования степени развития рефлексивных способностей личности\n1.Стремитесь ли вы записать по возможности полнее все или большинство лекционных курсов?\nа)да;\nб)нет.\n2.При подготовке к экзаменам полагаетесь ли вы целиком на свою память или работаете с карандашом в руке?\nа)да, целиком полагаюсь на свою память;\nб)нет, работаю с карандашом.\n3.Свойственно ли вам в процессе подготовки к экзамену контролировать, проверять себя, чтобы выяснить, насколько хорошо усвоен материал?\nа)да;\nб)нет.\n4.Готовясь к экзаменам, доверяетесь ли вы целиком своей памяти или стремитесь записать основные положения, схемы, закономерности, факты?\nа)да, целиком доверяюсь своей памяти;\nб)нет, стремлюсь записать основное.\n5.Если вы не успели подготовить материал, идете ли вы сдавать экзамен со своей группой или откладываете (при возможности) на 2-3 дня?\nа)да, иду на риск;\nб)нет, откладываю.\n6.Стремитесь ли вы по каждой вынесенной на экзамен теме подготовить основные положения, тезисы для ответа?\nа)да;\nб)нет.\n7.Напишите ваше мнение, полезны ли экзамены?\nа) да, я люблю экзамены, они помогают заново осмыслить материал;\nб) нет, для меня они тяжелы.\n8.Обычно вы идете на экзамен подготовленными по всем вопросам?\nа)да;\nб)нет.\n9.Если вы беретесь за выполнение неинтересного для вас поручения, то обычно:\nа)стараетесь его выполнить как можно быстрее, не вдаваясь в подробности, лишь бы от вас отвязались;\nб)для вас результат собственных усилий слишком значим, чтобы что-то делать кое-как.\n10.При выполнении значимого и интересного дела для вас главное:\nа)оценка окружающими того, что вы делаете;\nб)ваше собственное мнение.\n11.Приступая к важному для вас делу, вы:\nа)стараетесь все заранее спланировать, составляете развернутый план предстоящих действий;\nб)скорее действуете по обстоятельствам.\n12.Вы думаете, что:\nа)не все надо делать одинаково тщательно;\nб)затрудняетесь сказать;\nв)любую работу следует выполнять тщательно, если за нее взялся.\n13.Вы настолько осторожны и практичны, что с вами случается меньше неприятных неожиданностей, чем с другими людьми?\nа)да;\nб)трудно сказать;\nв)нет.\n14.В большинстве дел вы:\nа)предпочитаете рискнуть; б)не знаете, как поступить; в)предпочитаете действовать наверняка.\n\n\n\nМетодика «Коммуникативные и организаторские способности»\nИнструкция: Вам необходимо ответить на все вопросы, которые будут предложены. Свободно выражайте свое мнение и отвечайте на них так: если ваш ответ на вопрос положителен, то поставьте против соответствующей ему цифры в бланке ответов знак«+», если отрицателен - то«-».\n \n1.Много ли у вас друзей, с которыми вы постоянно общаетесь?\n2.Часто ли вам удается убедить большинство своих товарищей в правоте вашего мнения?\n3.Долго ли вас беспокоит чувство обиды, причиненное вам кем-то из ваших товарищей?\n4.Всегда ли вам трудно ориентироваться в создавшейся критической ситуации?\n5.Есть ли у вас стремление к установлению новых знакомств с различными людьми?\n6.Нравится ли вам заниматься общественной работой?\n7.Верно ли, что вам приятнее и проще проводить время с книгами или за какими-либо другими занятиями, чем с людьми?\n8.Если возникли какие-то помехи в осуществлении ваших намерений, то легко ли вы отступаете от своих намерений?\n9.Легко ли вы устанавливаете контакт с людьми, которые значительно старше вас по возрасту?\n10.Любите ли вы придумывать и организовывать со своими товарищами различные игры и развлечения?\n11.Трудно ли для вас включиться в новые компании?\n12.Часто ли вы откладываете на другие дни те дела, которые нужно было бы выполнить сегодня?\n13.Легко ли вам удается установить контакты с незнакомыми людьми?\n14.Стремитесь ли вы добиваться, чтобы ваши товарищи действовали в соответствии с вашими мнениями?\n15.Трудно ли вы осваиваетесь в новом коллективе?\n16.Верно ли, что у вас не бывает конфликтов с товарищами из-за невыполнения ими своих обещаний, обязанностей, обязательств?\n17.Стремитесь ли вы при удобном случае познакомиться и побеседовать с незнакомым человеком?\n18.Часто ли в решении важных дел вы принимаете инициативу на себя?\n19.Раздражают ли вас окружающие люди, и хочется ли вам побыть одному?\n20.Правда ли, что вы обычно плохо ориентируетесь в незнакомой для вас обстановке?\n21.Нравится ли вам постоянно находиться среди людей?\n22.Возникает ли у вас раздражение, если вам не удается закончить начатое дело?\n23.Испытываете ли вы затруднения, неудобства или стеснения, если приходится проявить инициативу, чтобы познакомиться с новым человеком?\n24.Правда ли, что вы утомляетесь от частого общения с товарищами?\n25.Любите ли вы участвовать в коллективных играх?\n26.Часто ли вы проявляете инициативу при решении вопросов, затрагивающих интересы ваших товарищей?\n27.Правда ли, что вы чувствуете себя неуверенно среди малознакомых вам людей?\n28.Верно ли, что вы редко стремитесь к доказательству своей правоты?\n29.Полагаете ли вы, что вам не доставляет особого труда внести оживление в малознакомую для вас компанию?\n30.Принимаете ли вы участие в общественной работе в институте?\n31.Стремитесь ли вы ограничить круг своих знакомых не большим количеством людей?\n32.Верно ли, что вы не стремитесь отстаивать свое мнение или решение, если оно не было сразу принято вашими товарищами?\n33.Чувствуете ли вы себя непринужденно, попав в незнакомую для вас компанию?\n34.Охотно ли вы приступаете к организации различных мероприятий для своих товарищей?\n35.Правда ли, то вы чувствуете себя достаточно уверенным и спокойным, когда приходится говорить что-либо большой группе людей?\n36.Часто ли вы опаздываете в институт, на встречи, свидания?\n37.Верно ли, что у вас много друзей?\n38.Часто ли вы смущаетесь, чувствуя неловкость при общении с малоизвестными вам людьми?\n39.Часто ли вы оказываетесь в центре внимания у своих товарищей?\n40Правда ли, что вы не очень уверенно чувствуете себя в окружении большой  группы своих товарищей?\n";
            OtherTextPanel.Visible = true;
            OtherTextPanel.Location = locationDefault;
            OtherTextPanel.Size = new Size(sizeDefault);
            OtherPanelTextBox.SelectionStart = 0;
            OtherPanelTextBox.ScrollToCaret();
        }

        private void OpenMotivation(object sender, EventArgs e)
        {
            CloseAll();
            Text = "Motivation";
            MotivationPanel.Visible = true;
            MotivationPanel.Location = locationDefault;
            MotivationPanel.Size = new Size(sizeDefault);
        }

        private void TestResult()
        {
            int k = 0;
            if (RadioTB11.Checked == true) k++;
            if (RadioTB21.Checked == true) k++;
            if (RadioTB31.Checked == true) k++;
            if (RadioTB41.Checked == true) k++;
            if (RadioTB51.Checked == true) k++;
            if (RadioTB61.Checked == true) k++;
            if (RadioTB71.Checked == true) k++;
            if (RadioTB81.Checked == true) k++;
            if (RadioTB91.Checked == true) k++;
            if (RadioTB101.Checked == true) k++;

            if (k >= 8)
            {
                TestBoxResult.Text = "Результат: Вы удовлетворены работой, у вас высокий показатель.";
            }
            else
            {
                if (k >= 5)
                {
                    TestBoxResult.Text = "Результат: Есть что-то, что вас не устраивает в работе, средний показатель.";
                }
                else
                {
                    TestBoxResult.Text = "Результат: Вам не нравится работа, низкий показатель.";
                }
            }
        }

        private void RadioTBChecked()
        {
            int k = 0;
            if (RadioTB11.Checked == true) k++;
            else if (RadioTB12.Checked == true) k++;
            if (RadioTB21.Checked == true) k++;
            else if (RadioTB22.Checked == true) k++;
            if (RadioTB31.Checked == true) k++;
            else if (RadioTB32.Checked == true) k++;
            if (RadioTB41.Checked == true) k++;
            else if (RadioTB42.Checked == true) k++;
            if (RadioTB51.Checked == true) k++;
            else if (RadioTB52.Checked == true) k++;
            if (RadioTB61.Checked == true) k++;
            else if (RadioTB62.Checked == true) k++;
            if (RadioTB71.Checked == true) k++;
            else if (RadioTB72.Checked == true) k++;
            if (RadioTB81.Checked == true) k++;
            else if (RadioTB82.Checked == true) k++;
            if (RadioTB91.Checked == true) k++;
            else if (RadioTB92.Checked == true) k++;
            if (RadioTB101.Checked == true) k++;
            else if (RadioTB102.Checked == true) k++;

            if (k == 10) TestButtonResult.BackColor = Color.Green;
            else TestButtonResult.BackColor = Color.Red;
        }

        private void RadioTB_Сhecked(object sender, EventArgs e)
        {
            RadioTBChecked();
        }

        private void TestButtonResult_Click(object sender, EventArgs e)
        {
            if (TestButtonResult.BackColor == Color.Green)
            {
                TestResult();
                TestButtonResult.BackColor = Color.Blue;
            }
        }

        private void MethodicalAddText()
        {
            MethodicalReceptions[0].Add(MethodicalButton1.Text, "\t«ФАНТАСТИЧЕСКАЯ ДОБАВКА» \n       Преподаватель дополняет реальную ситуацию фантастикой. Вы можете переносить учебную ситуацию на фантастическую планету; перенести реального или литературного героя во времени; рассмотреть изучаемую ситуацию с необычной точки зрения, например, глазами инопланетянина или древнего грека… \n\n\t«ЭМОЦИОНАЛЬНОЕ ВХОЖДЕНИЕ В УРОК» \n       Преподаватель начинает урок с \"настройки\". Например, знакомим с планом урока. Это лучше делать в полушуточной манере. Например, так: \"Сначала мы вместе восхитимся глубокими знаниями — а для этого проведем маленький устный опрос. Потом попробуем ответить на вопрос... (звучит тема урока в вопросной форме). Затем потренируем мозги — порешаем задачи. И, наконец, вытащим из тайников памяти кое-что ценное... (называется тема повторения)\". Если есть техническая возможность, хорошей настройкой на урок будет короткая музыкальная фраза. \n\n\t«ТЕАТРАЛИЗАЦИЯ» \n       Знание на время игры становится нашим пространством. Мы погружены в него со всеми своими эмоциями. И замечаем то, что недоступно холодному наблюдателю со стороны. Разыгрывается сценка на учебную тему. \n\n\t«ПОСЛОВИЦА-ПОГОВОРКА» \n       Преподаватель начинает урок с пословицы или поговорки, относящейся к теме урока. \n\n\t«ВЫСКАЗЫВАНИЯ ВЕЛИКИХ» \n       Преподаватель начинает урок с высказывания выдающегося человека (людей), относящегося к теме урока. \n\n\t«ЭПИГРАФ» \n       Преподаватель начинает урок с эпиграфа к данной теме. \n\n\t«ПРОБЛЕМНАЯ СИТУАЦИЯ»\n       Создаётся ситуация противоречия между известным и неизвестным. Последовательность применения данного приема такова: \n   – Самостоятельное решение \n   – Коллективная проверка результатов \n   – Выявление причин разногласий результатов или затруднений выполнения \n   – Постановка цели урока. \n   \n\n\t«ПРОБЛЕМА ПРЕДЫДУЩЕГО УРОКА» \n       В конце урока обучающимся предлагается задание, в ходе которого должны возникнуть трудности с выполнением, из-за недостаточности знаний или недостаточностью времени, что подразумевает продолжение работы на следующем уроке. Таким образом, тему урока можно сформулировать накануне, а на следующем уроке лишь восстановить в памяти и обосновать. \n\n\t«ИНТЕЛЛЕКТУАЛЬНАЯ РАЗМИНКА» \n       Можно начать урок с интеллектуальной разминки — два-три не слишком сложных вопроса на размышление. С традиционного устного короткого опроса — простого опроса, ибо основная его цель — настроить обучающегося на работу, а не устроить ему стресс с головомойкой.\n\n\t«НЕСТАНДАРТНЫЙ ВХОД В УРОК» \n       Универсальный прием, направленный на включении в активную мыследеятельность с первых минут урока. Преподаватель начинает урок с противоречивого факта, который трудно объяснить на основе имеющихся знаний. \n\n\t«АССОЦИАТИВНЫЙ РЯД» \n       К теме или конкретному понятию урока нужно выписать в столбик слова-ассоциации. Выход будет следующим: \n•    если ряд получился сравнительно правильным и достаточным, дать задание составить определение, используя записанные слова; \n•    затем выслушать, сравнить со словарным вариантом, можно добавить новые слова в ассоциативный ряд;\n •    оставить запись на доске, объяснить новую тему, в конце урока вернуться, что-либо добавить или стереть.\n   ");
            MethodicalReceptions[1].Add(MethodicalButton2.Text, "\t«ТЕМА-ВОПРОС» \n    Тема урока формулируется в виде вопроса. Обучающимся необходимо построить план действий, чтобы ответить на поставленный вопрос. Они выдвигают множество мнений, чем больше мнений, чем лучше развито умение слушать друг друга и поддерживать идеи других, тем интереснее и быстрее проходит работа. Руководить процессом отбора может сам преподаватель или выбранный студент, а педагог в этом случае может лишь высказывать свое мнение и направлять деятельность. \n\n\t«РАБОТА НАД ПОНЯТИЕМ» \n    Студентам предлагается для зрительного восприятия название темы урока и педагог просит объяснить значение каждого слова или отыскать в \"Толковом словаре\". \n\n\t«СИТУАЦИЯ ЯРКОГО ПЯТНА» \n    Среди множества однотипных предметов, слов, цифр, фигур одно выделено цветом или размером. Через зрительное восприятие внимание концентрируется на выделенном предмете. Совместно определяется причина обособленности и общности всего предложенного. Далее определяется тема и цели урока. \n\n\t«ПОДВОДЯЩИЙ ДИАЛОГ» \n    На этапе актуализации учебного материала ведется беседа, направленная на обобщение, конкретизацию, логику рассуждения. Диалог подводится к тому, о чем обучающиеся не могут рассказать в силу некомпетентности или недостаточно полного обоснования своих действий. Тем самым возникает ситуация, для которой необходимы дополнительные исследования или действия. Ставится цель. \n\n\t«ГРУППИРОВКА» \n    Ряд слов, предметов, фигур, цифр предлагается учащимся разделить на группы, обосновывая свои высказывания. Основанием классификации будут внешние признаки, а вопрос: \"Почему имеют такие признаки?\" будет задачей урока. \n\n\t«ИСКЛЮЧЕНИЕ» \n    Прием можно использовать через зрительное или слуховое восприятие. Повторяется основа приема \"Яркое пятно\", но в этом случае обучающимся необходимо через анализ общего и отличного, найти лишнее, обосновывая свой выбор. Формулируется учебная цель. \n\n\t«ДОМЫСЛИВАНИЕ» \n    Предлагается тема урока и слова \"помощники\": Повторим; Изучим; Узнаем; Проверим. С помощью слов \"помощников\" учащиеся формулируют цели урока. \n\n\t«ЛИНИЯ ВРЕМЕНИ» \n    Преподаватель чертит на доске линию, на которой обозначает этапы изучения темы, формы контроля; проговаривает о самых важных периодах, требующих от ребят стопроцентной самоотдачи, вместе находят уроки, на которых можно “передохнуть”. “Линия 15 времени” позволяет обучающимся увидеть, что именно может являться конечным продуктом изучения темы, что нужно знать и уметь для успешного усвоения каждой последующей темы. Это упражнение полезно для ребят, которые легче усваивают учебный материал от общего к частному. \n\n\t«ГЕНЕРАТОРЫ – КРИТИКИ» \n    Педагог ставит проблему, не требующую длительного обсуждения. Формируются две группы: генераторы и критики. Пример: Задача первой группы - дать как можно большее число вариантов решений проблемы, которые могут быть самыми фантастическими. Все это делается без предварительной подготовки. Работа проводится быстро. Задача критиков: выбрать из предложенных решений проблемы наиболее подходящие. Задача педагога – направить работу учащихся так, чтобы они могли вывести то или иное правило, решить какую-то проблему, прибегая к своему опыту и знаниям. Данный метод можно использовать для активизации самостоятельной работы учащихся. \n\n\t«НЕОБЪЯВЛЕННАЯ ТЕМА» \n    Приём, направленный создание внешней мотивации изучения темы урока. Данный прием позволяет привлечь интерес обучающихся к изучению новой темы, не блокируя восприятия непонятными терминами. Пример: Преподаватель записывает на доске слово «Тема», выдерживает паузу до тех пор, пока все не обратят внимание на руку педагога, которая не хочет выводит саму тему. Преподаватель: Ребята, извините, но моя рука отказалась написать тему урока, и, кажется, неслучайно! Вот вам еще одна загадка, которую вы разгадаете уже в середине урока: почему рука отказалась записать тему урока? Данный вопрос записывает в уголке классной доски. Преподаватель: Ребята, вам предстоит проанализировать и доказать, с точки зрения полезности, отсутствие темы в начале урока! Но начинать урок нам все равно надо, и начнем с хорошо знакомого материала… \n\n\t«ЗИГЗАГ» \n    Данную стратегию уместно использовать для развития у учащихся следующих умений: \n•    анализировать текст совместно с другими людьми; \n•    вести исследовательскую работу в группе; \n•    доступно передавать информацию другому человеку; \n•    самостоятельно определять направление в изучении какого-то предмета с учетом интересов группы. Пример: Прием используется для изучения и систематизации большого по объему материала. Для этого предстоит сначала разбить текст на смысловые отрывки для взаимообучения. Количество отрывков должно совпадать с количеством членов групп. Например, если текст разбит на 5 смысловых отрывков, то в группах (назовем их условно рабочими) - 5 человек.\n");
            MethodicalReceptions[2].Add(MethodicalButton3.Text, "\t«ИНТЕЛЛЕКТУАЛЬНАЯ РАЗМИНКА» \n    Можно начать урок с интеллектуальной разминки — два-три не слишком сложных вопроса на размышление. Разминку можно проводить по-разному: \n•    Что лишнее? \n•    Обобщить – что это … \n•    Что пропущено – логическая цепочка \n•    Какое слово скрывается и так далее. \n\nТаблички с понятиями и терминами вывешиваются на доске или оформляются в виде мультимедийной презентации и учащимся задаются вопросы. Интеллектуальная разминка не только настраивает учащихся на учебную деятельность, но и развивает мышление, внимание, умение анализировать, обобщать, выделять главное. \n\n\t«ОТСРОЧЕННАЯ ОТГАДКА» \n    Используя работу над изучением этимологии слова, «говорящих фамилий», можно применять этот прием. В конце одного из уроков можно задать вопрос. Следующий урок нужно начать с ответа на этот вопрос.\n\n\t«ИГРА В СЛУЧАЙНОСТЬ» \n    Формула: преподаватель вводит в урок элементы случайного выбора. Там, где правит бал случай, - там азарт. Пробуем поставить и его на службу. Для этого годится рулетка. Достаточно иметь круг из картона со стрелкой на гвоздике. Можно и наоборот – вращать диск относительно неподвижного указателя. Объектом случайного выбора может стать решаемая задача, тема повторения, тема доклада, вызываемый учащийся. Кроме рулетки подбрасывают вверх монетку (орел или решка), тянут жребий, вынимаем бочонки русского лото, с номером учащегося в журнале. \n\n\t«ОБСУЖДЕНИЕ ВЫПОЛНЕНИЯ ДОМАШНЕГО ЗАДАНИЯ»\n    Преподаватель вместе с обучающимися обсуждает вопрос: насколько качественно выполнено домашнее задание. \n\n\t«ЛОВИ ОШИБКУ!» \n    Объясняя материал, преподаватель намеренно допускает ошибки. Сначала обучающиеся заранее предупреждаются об этом. Иногда им можно даже подсказывать «опасные места» интонацией или жестом. Научите обучающихся мгновенно пресекать ошибки условным знаком или пояснением, когда оно требуется. Поощряйте внимание и готовность вмешаться! Студент получает текст (или скажем, разбор решения задачи) со специально допущенными ошибками – пусть «поработает педагогом».\n\n\t«СВОЯ ОПОРА – ШПАРГАЛКА» (КОНКУРС ШПАРГАЛОК) \nФорма учебной работы, в процессе подготовки которой отрабатываются умения «сворачивать и разворачивать информацию» в определенных ограничительных условиях. Студент может отвечать по подготовленной дома «шпаргалке», если: \n1)    «шпаргалка» оформлена на листе бумаги форматом А4; \n2)    в шпаргалке нет текста, а информация представлена отдельными словами, условными знаками, схематичными рисунками, стрелками, расположением единиц информации относительно друг друга; \n3)    количество слов и других единиц информации соответствует принятым условиям (например, на листе может быть не больше 10 слов, трех условных знаков, семи стрелок или линий). \n\nЛучшие «шпаргалки» по мере их использования на уроке вывешиваются на стенде. В конце изучения темы подводятся итоги, происходит награждение победителей. \n\n\t«КРОССВОРД» \n    Кроссворды на уроке – это актуализация и закрепление знаний, привлечение внимания к материалу, интеллектуальная зарядка в занимательной форме. Обучающиеся любят разгадывать загадки, ребусы и кроссворды. \n\n\t«Я БЕРУ ТЕБЯ С СОБОЙ» \n    Приём, направленный на актуализацию знаний обучающихся, способствующий накоплению информации о признаках объектов. Формирует: \n•    умение объединять объекты по общему значению признака; \n•    умение определять имя признака, по которому объекты имеют общее значение; \n•    умение сопоставлять, сравнивать большое количество объектов; \n•    умение составлять целостный образ объекта из отдельных его признаков.\n\n    Педагог загадывает признак, по которому собирается множество объектов и называет первый объект. Студенты пытаются угадать этот признак и по очереди называют объекты, обладающие, по их мнению, тем же значением признака. Преподаватель отвечает, берет он этот объект или нет. Игра продолжается до тех пор, пока кто-то из ребят не определит, по какому признаку собирается множество. Можно использовать в качестве разминки на уроках. \n\n\t«КОРЗИНА ИДЕЙ, ПОНЯТИЙ, ИМЕН» \n    Это прием организации индивидуальной и групповой работы обучающихся на начальной стадии урока, когда идет актуализация имеющегося у них опыта и знаний. Он позволяет выяснить все, что знают или думают обучающиеся по обсуждаемой теме урока. На доске можно нарисовать значок корзины, в которой условно будет собрано все то, что все ребята вместе знают об изучаемой теме.\n");
            MethodicalReceptions[3].Add(MethodicalButton4.Text, "\t«УДИВЛЯЙ!» \n    Приём, направленный на активизацию мыслительной деятельности и привлечение интереса к теме урока. Формирует: умение анализировать; умение выделять и формулировать противоречие. Педагог находит такой угол зрения, при котором даже хорошо известные факты становятся загадкой. Хорошо известно, что ничто так не привлекает внимание и не стимулирует работу, как удивительное. Всегда можно найти такой угол зрения, при котором даже обыденное становится удивительным. Это могут быть факты из биографии писателей. \n\n\t«ПРЕСС-КОНФЕРЕНЦИЯ» \n    Преподаватель намеренно неполно раскрывает тему, предложив обучающимся задать дораскрывающие ее вопросы. \n\n\t«КЛЮЧЕВЫЕ ТЕРМИНЫ» \n    Из текста выбираются четыре-пять ключевых слов. Перед чтением текста учащимся, работающим парами или группами, предлагается дать общую трактовку этих терминов и предположить, как они будут применяться в конкретном контексте той темы, которую им предстоит изучить. После чтения текста, проверить, в этом ли значении употреблялись термины.\n\n\t«ПРИВЛЕКАТЕЛЬНАЯ ЦЕЛЬ»\n    Перед студентами ставится простая, понятная и привлекательная для него цель, выполняя которую он волей-неволей выполняет и то учебное действие, которое планирует педагог. \n\n\t«МУЛЬТИМЕДИЙНАЯ ПРЕЗЕНТАЦИЯ» \n    Мультимедийная презентация - это представление материала с использованием компьютерной техники. Мультимедиа способствует развитию мотивации, коммуникативных способностей, получению навыков, накоплению фактических знаний, а также способствует развитию информационной грамотности. Облегчение процесса восприятия и запоминания информации с помощью ярких образов - это основа любой современной презентации.\n\n\t«ОТСРОЧЕННАЯ ОТГАДКА» \n    Приём, направленный на активизацию мыслительной деятельности обучающихся на уроке. Формирует: умение анализировать и сопоставлять факты; умение определять противоречие; умение находить решение имеющимися ресурсами. \n1 вариант приема. В начале урока преподаватель дает загадку (удивительный факт), отгадка к которой (ключик для понимания) будет открыта на уроке при работе над новым материалом. \n2 вариант приема Загадку (удивительный факт) дать в конце урока, чтобы начать с нее следующее занятие.\n\n\t«ВОПРОСЫ К ТЕКСТУ»\n   К изучаемому тексту предлагается за определенное время составить определенное количество вопросов - суждений: - Почему? - Как доказать? - Чем объяснить? - Вследствие чего? - В каком случае? - Каким образом? Схема с перечнем вопросов-суждений вывешивается на доске и оговаривается что, кто составил 7 вопросов за 7 минут, получает отметку “5”; 6 вопросов – “4”. Прочитав абзац, учащиеся выстраивают суждения, составляют вопрос и записывают его в тетрадь. Этот прием развивает познавательную деятельность обучающихся, их письменную речь.\n\n\t«РАБОТА С ИНТЕРНЕТ-РЕСУРСАМИ»\n    Для студентов работа с Интернет-ресурсами – это доступ к огромному количеству необходимого иллюстративно-информационного материала, которого катастрофически не хватает в библиотеках. Это, прежде всего, толчок к самообразованию и активизации познавательной деятельность обучающихся. \n\n\t«ХОРОШО – ПЛОХО»\n   Приём, направленный на активизацию мыслительной деятельности обучающихся на уроке, формирующий представление о том, как устроено противоречие. Формирует: \n•    умение находить положительные и отрицательные стороны в любом объекте, ситуации; \n•    умение разрешать противоречия (убирать «минусы», сохраняя «плюсы»); \n•    умение оценивать объект, ситуацию с разных позиций, учитывая разные роли. \n•  Вариант 1: Преподаватель задает объект или ситуацию. Обучающиеся (группы) по очереди называют «плюсы» и «минусы». \n•  Вариант 2: Преподаватель задает объект (ситуацию). Обучающийся описывает ситуацию, для которой это полезно. Следующий обучающийся ищет, чем вредна эта последняя ситуация и т. д. \n•  Вариант 3 Обучающиеся делятся на продавцов и покупателей. И те и другие представляют каких-то известных персонажей. Дальше играют по схеме. Только «плюсы» ищут с позиции персонажа – продавца, а «минусы» – с позиции персонажа – покупателя. \n•  Вариант 4 Обучающиеся делятся на три группы: «прокуроры», «адвокаты», «судьи». Первые обвиняют (ищут минусы), вторые защищают (ищут плюсы), третьи пытаются разрешить противоречие (оставить «плюс» и убрать «минус»). \n\n\t«ВОПРОС К ТЕКСТУ»\n    Перед изучением учебного текста ставится задача: составить к тексту список вопросов. Список можно ограничить. Например, 3 репродуктивных вопроса и 3 расширяющих или развивающих. Совет: Пусть на уроках найдется место открытым вопросам: вот это мы изучили; вот это осталось за пределами программы; вот это я не знаю сам; вот это пока не знает никто…\n");
            MethodicalReceptions[4].Add(MethodicalButton5.Text, "\t«СВОЯ ОПОРА» \n    Обучающийся составляет собственный опорный конспект по новому материалу. Этот приём уместен в тех случаях, когда преподаватель сам применяет подобные конспекты и учит пользоваться ими ребят. Как ослабленный вариант приёма можно рекомендовать составление развёрнутого плана ответа (как на экзамене). Замечательно, если обучающиеся успеют объяснить друг другу свои опорные конспекты, хотя бы частично. \n\n\t«ДА-НЕТ» \n    Преподаватель загадывает нечто (число, предмет, литературного или исторического героя и др.). Студенты пытаются найти ответ, задавая вопросы. На эти вопросы педагог отвечает только словами: \"да\", \"нет\", \"и да и нет\". \"Да-нет\" учит: \n•    связывать разрозненные факты в единую картину; \n•    систематизировать уже имеющуюся информацию; \n•    слушать и слышать товарищей.\n\n\t«СОРБОНКА» \n    Прием предназначен для заучивания исторических дат, всевозможных определений, иностранных слов, и т.д. На одной стороне карточки записывается понятие, слово, дата, а на 20 другой – ответ. Обучающийся перебирает карточки, пытается дать ответ и тут же проверяет себя. Анимированный вариант сорбонки может сделать это процесс запоминания более привлекательным и разнообразным. Объектами запоминания могут быть не только слова, даты, термины, но и карты и другие наглядные объекты. \n\n\t«РАБОТА В ГРУППАХ»\n    Группы получают одно и то же задание. В зависимости от типа задания результат работы группы может быть или представлен на проверку преподавателю, или спикер одной из групп раскрывает результаты работы, а другие учащиеся его дополняют или опровергают. \n\n\t«ИГРА – ТРЕНИНГ» \n    Эти игры приходят на помощь в трудный момент — чтобы растворить скуку однообразия... \n1.    Если необходимо проделать большое число однообразных упражнений, преподаватель включает их в игровую оболочку, в которой эти действия выполняются для достижения игровой цели. \n2.    Студенты соревнуются, выполняя по очереди действия в соответствии с определенным правилом, когда всякое последующее действие зависит от предыдущего. \n\n\t«ДЕЛОВАЯ ИГРА «Я – ПЕДАГОГ»» \n    Использование такой формы урока, как деловая игра, можно рассматривать как развитие ролевого подхода. В деловой игре у каждого обучающегося вполне определенная роль. Подготовка и организация деловой игры требует многосторонней и тщательной подготовки, что в свою очередь гарантирует успех такого урока у обучающихся. Играть всегда и всем интереснее, чем учиться. Ведь с удовольствием играя, как правило, не замечаешь процесса обучения. \n\n\t«ЩАДЯЩИЙ ОПРОС» \n    Преподаватель проводит тренировочный опрос, сам, не выслушивая ответов студентов. Группа разбивается на две части по рядам-вариантам. Преподаватель задает вопрос. На него отвечает первая группа. При этом каждый обучающийся дает ответ на этот вопрос своему соседу по парте — обучающемуся второй группы. Затем на этот же вопрос отвечает педагог или сильный обучающийся. Обучающиеся второй группы, прослушав ответ преподавателя, сравнивают его с ответом товарища и выставляют ему оценку или просто \"+\" или \"-\". На следующий вопрос преподавателя отвечают обучающиеся второй группы, а ребята первой их прослушивают. Теперь они в роли преподавателя и после ответа педагога выставляют обучающимся второй группы отметку. Таким образом, задав 10 вопросов, добиваются того, что каждый обучающийся в группе ответит на 5 вопросов, прослушает ответы преподавателя на все вопросы, оценит своего товарища по 5 вопросам. Каждый обучающийся при такой форме опроса выступает и в роли отвечающего, и в роли контролирующего. В конце опроса ребята выставляют друг другу оценки. \n\n\t«ТЕСТЫ» \n    Виды тестов: установочный; тест-напоминание; обучающий; тест-дополнение; диагностический; тест-сличение; итоговый; тест-ранжирование. А также: письменный, компьютерный, тест с выбором ответа, тест с «изюминкой», тест-сопоставление, тест с развёрнутым ответом и др. \n\n\t«ГЛУХИЕ ИНТЕЛЛЕКТ – КАРТЫ» \n    Студентам раздаются распечатанные интеллект – карты с отсутствующими связями, понятиями. Ребята восполняют интеллект-кату. Прием эффективен, если преподаватель при объяснении нового материала демонстрировал полностью заполненную интеллект-карту.  \n\n\t«ЧТЕНИЕ – СУММИРОВАНИЕ ПРОЧИТАННОГО \t\t\tВ ПАРАХ» \n    Этот прием особенно эффективен, когда изучаемый текст достаточно ―густой, перегруженный фактическим материалом, касается сложных предметных областей. Попросите обучающихся разбиться на пары, а затем пары рассчитаться на 1, 2, 3, 4. Каждая пара получает соответствующий номер. Сообщите обучающимся, что они будут сейчас читать статью, но достаточно непривычным образом. Поясните, что статья разделена на четыре части и парам будет дана для изучения часть статьи под соответствующим номером. А теперь каждая из этих ―четвертинок‖ делится пополам. Это делается для того, чтобы один член пары был докладчиком, а другой ответчиком по первой части, на вторую половину они меняются ролями. Однако в конце урока обучающиеся должны знать содержание статьи целиком. В задачу докладчика входит: внимательно прочитать текст и быть готовым суммировать прочитанное. После того, как они почитают свою часть, они должны быть готовы ―доложить партнерам прочитанное своими словами \n\n\t«РАБОТА ПО ДИДАКТИЧЕСКИМ КАРТОЧКАМ» \n    Карточки, должны быть распечатаны и розданы обучающимся. Они содержат вопросы и задания различных уровней сложности. Работа с карточками в личностно-ориентированном уроке начинается с выбора задания обучающимися. Преподаватель не принимает никакого участия в процессе выбора карточки обучающимся. Роль преподавателя при работе с карточками сводится к минимуму. Он становится наблюдателем и, в нужный момент, помощником, а не руководителем. При выборе карточки ребята проходят три этапа: \n•    1 этап – выбор задания (по содержанию) \n•    2 этап – по степени сложности ( * - легкое, ** - сложное) \n•    3 этап – характер задания (творческое, репродуктивное) \n\nОбщее число сочетаний всех наших параметров выбора даёт нам набор ДК, состоящих из 6 карточек. Каждый параметр выбора обозначается на ДК соответствующим значком: тип задания по содержанию, степень его сложности и характер задания. Эти значки помогают каждому учащемуся сделать осознанный выбор.\n");
            MethodicalReceptions[5].Add(MethodicalButton6.Text, "\t«МИНИ-ПРОЕКТЫ» \n    Учебный проект, как комплексный и многоцелевой метод, имеет большое количество видов и разновидностей. Исследовательский мини-проект по структуре напоминает подлинно научное исследование. Оно включает обоснование актуальности выбранной темы, обозначение задач исследования, обязательное выдвижение гипотезы с последующей ее проверкой, обсуждение полученных результатов. При этом используются методы современной науки: лабораторный эксперимент, моделирование, социологический опрос. Обучающиеся могут сами выбрать возрастную группу для опроса в зависимости от поставленной перед ними задачи или группу для опроса определяет преподаватель (этот вариант более приемлем на первоначальном этапе, когда ребята только знакомятся с такой формой работы). \n\n\t«РЕШЕНИЕ СИТУАЦИОННЫХ ЗАДАЧ» \n    Данный тип задач является инновационным инструментарием, формирующим как традиционные предметные образовательные результаты, так и новые – личностные и метапредметные результаты образования. Ситуационные задачи – это задачи, позволяющие обучающемуся осваивать интеллектуальные операции последовательно в процессе работы с информацией: ознакомление – понимание – применение – анализ – синтез – оценка. Специфика ситуационной задачи заключается в том, что она носит ярко выраженный практико-ориентированный характер, но для ее решения необходимо конкретное предметное знание. Кроме этого, такая задача имеет не традиционный номер, а красивое название, отражающее ее смысл. Обязательным элементом задачи является проблемный вопрос, который должен быть сформулирован таким образом, чтобы учащемуся захотелось найти на него ответ. \n\n\t«МИНИ-ИССЛЕДОВАНИЕ» \n    Преподаватель “подталкивает” обучающихся к правильному выбору темы исследования, попросив ответить на следующие вопросы: Что мне интересно больше всего? Чем я хочу заниматься в первую очередь? О чём хотелось бы узнать как можно больше? Ответив на эти вопросы, обучающийся может получить совет преподавателя, какую тему исследования можно выбрать. Тема может быть: - фантастической (обучающийся выдвигает какую-то фантастическую гипотезу); - экспериментальной; - изобретательской; - теоретической. \n\n\t«РАБОТА С КОМПЬЮТЕРОМ» \n    Обучающиеся решают учебные задачи с использованием ТСО. \n\n\t«В СВОЁМ ТЕМПЕ» \n    При решении учебных задач каждый обучающийся работает в темпе, определяемом им самим. \n\n\t«ОЗВУЧИВАНИЕ «НЕМОГО КИНО»» \n    Студенты озвучивают фрагмент художественного, мультипликационного и др. фильма после предварительной подготовки. \n\n\t«РЕСТАВРАТОР» \n    Студенты восстанавливают текстовый фрагмент, намеренно «поврежденный» преподавателем.\n\n\t«РАБОТА С ИЛЛЮСТРАТИВНЫМ МАТЕРИАЛОМ» \n    Методика работы с иллюстративным материалом во многих случаях включает два этапа. На первом этапе создается представление об изображенном, осуществляется запоминание, на втором — деятельность обучающихся направляется на усвоение связей между понятиями, на использование знаний в подобной и новой ситуациях. Наиболее простая и эффективная форма работы с иллюстрациями — выполнение определенных заданий. \n\n\t«СОЗДАЙ ПАСПОРТ» \n    Прием для систематизации, обобщения полученных знаний; для выделения существенных и несущественных признаков изучаемого явления; создания краткой характеристики изучаемого понятия, сравнения его с другими сходными понятиями. Это универсальный прием составления обобщенной характеристики изучаемого явления по определенному плану. \n\n\t«ВОПРОСИТЕЛЬНЫЕ СЛОВА» \n    Прием, направленный на формирование умения задавать вопросы, а также может быть использован для актуализации знаний обучающихся по пройденной теме урока. Обучающимся предлагается таблица вопросов и терминов по изученной теме или новой теме урока. Необходимо составить как можно больше вопросов, используя вопросительные слова и термины из двух столбцов таблицы.\n\n\t«ДЕРЕВО ПРЕДСКАЗАНИЙ» \n    Правила работы с данным приемом таковы: ствол дерева - тема, ветви - предположения, которые ведутся по двум основным направлениям - \"возможно\" и \"вероятно\" ( количество \"ветвей\" не ограничено), и, наконец, \"листья\" - обоснование этих предположений, аргументы в пользу того или иного мнения. \" \n");
            MethodicalReceptions[6].Add(MethodicalButton7.Text, "\t«ТЕСТ» \n    Обучающиеся получают задание выбрать из предложенных вариантов правильный ответ. \n\n\t«СВОЯ ОПОРА» \n    Студент составляет авторский опорный конспект изученной темы. Это имеет смысл делать на листе большого формата. Не обязательно всем повторять одну тему. Пусть, например, половина обучающихся повторяет одну тему, а половина – другую, после чего они попарно раскрывают друг другу свои опоры. Или такая форма работы: несколько обучающихся развешивают свои авторские опоры - плакаты на стене, остальные собираются в малые группы и обсуждают их. \n\n\t«ИНТЕЛЛЕКТ-КАРТЫ» \n    Интеллект-карты отражают процесс ассоциативного мышления. Они отражают связи (смысловые, ассоциативные, причинно-следственные и др.) между понятиями, частями, составляющими проблемы или предметной области которую мы рассматриваем. Интеллект карты эффективны при развитии памяти, генерировании ассоциаций, мозговом штурме, при сотворении общей картины, указании взаимосвязей, планирования. Интеллект-карты позволяют легко понять, запомнить и работать со сложной по структуре и объему информацией. Правила создания интеллект-карт следующие: \n•    Для создания карт используются только цветные карандаши, маркеры и т.д. \n•    Основная идея, проблема или слово располагается в центре. \n•    Для изображения центральной идеи можно использовать рисунки, картинки. \n•    Каждая ветвь имеет свой цвет. \n•    Главные ветви соединяются с центральной идеей, а ветви второго, третьего и т.д. порядка соединяются с главными ветвями. \n•    Ветки должны быть изогнутыми. \n•    Над каждой линией – ветвью пишется только одно ключевое слово. \n•    Для лучшего запоминания и усвоения желательно использовать рисунки, картинки, ассоциации о каждом слове. \n•    Разросшиеся ветви можно заключать в контуры, чтобы они не смешивались с соседними ветвями. \n\nСпециальные информационные технологии позволяют составлять интеллект-карты при помощи специальных программ. Интеллект-карту удобно сочетать с таблицей ЗХУ (Знал, узнал, хочу знать). При составлении интеллект-карты обучающимися самостоятельно должно соблюдаться условие: текст с которым работают учащиеся, должен быть небольшим, т.к. данная работа занимает много времени. \n\n\t«ПОВТОРЯЕМ С КОНТРОЛЕМ» \n    Студенты разрабатывают списки контрольных вопросов ко всей ранее изученной теме. Возможен конкурс списков. Можно провести контрольный опрос по одному из списков. \n\n\t«ПЕРЕСЕЧЕНИЕ ТЕМ» \n    Обучающиеся подбирают (или придумывают) свои примеры, задачи, гипотезы, идеи, вопросы, связывающие последний изученный материал с любой ранее изученной темой, указанной преподавателем. \n\n\t«ПРОБЛЕМНАЯ ЗАДАЧА» \n    Проблемная задача ставит вопрос или вопросы: \"Как разрешить это противоречие? Чем это объяснить?\" Серия проблемных вопросов трансформирует проблемную задачу в модель поисков решения, где рассматриваются различные пути, средства и методы решения. Проблемный метод предполагает следующие шаги: проблемная ситуация → проблемная задача → модель поисков решения → решение. В классификации проблемных задач понятие выделяют задачи с неопределенностью условий или искомого, с избыточными, противоречивыми, частично неверными данными. Главное в проблемном обучении — сам процесс поиска и выбора верных, оптимальных решений, а не мгновенный выход на решение. Хотя преподавателю с самого начала известен кратчайший путь к решению проблемы, сам процесс поиска шаг за шагом ведет к решению проблемы.\n\n\t«ПЛЮС – МИНУС» \n    Цель этого приема – показать неоднозначность любого общественного и исторического явления, например: Найти отрицательное и положительное.\n");
            MethodicalReceptions[7].Add(MethodicalButton8.Text, "\t«ОПРОС ПО ЦЕПОЧКЕ» \n    Рассказ одного обучающегося прерывается в любом месте и продолжается другим обучающимся. Прием применим в случае, когда предполагается развернутый, логически связный ответ.\n\n\t«ПРОГРАММИРУЕМЫЙ ОПРОС» \n    Обучающийся выбирает один верный ответ из нескольких предложенных.\n\n\t«ТИХИЙ ОПРОС» \n    Беседа с одним или несколькими студентами происходит полушепотом, в то время как группа занята другим делом. \n\n\t«БЛИЦ-КОНТРОЛЬНАЯ» \n    Контроль проводится в высоком темпе для выявления степени усвоения простых учебных навыков, которыми обязаны овладеть обучающиеся для дальнейшей успешной учебы. По темпу блиц-контрольная сходна с фактологическим диктантом. Включает в себя 7—10 стандартных заданий. Время — примерно по минуте на задание. Технология проведения: \nдо: условия по вариантам открываются на доске или на плакате. При возможности Линии сравнения Февральская революция 1917 года Октябрьская революция 1917 года 1. Причины и задачи 2. Повод (если есть) 3. Движущие силы 4. Ход революции 5.Характер революции 6. Итоги и значение. 26 условия распечатываются и кладутся на парты текстом вниз. По команде — переворачиваются. \nво время: на парте — чистый лист и ручка. По команде учащиеся приступают к работе. Никаких пояснений или стандартного оформления задания не делается. По истечении времени работа прекращается по четкой команде. \nпосле: работы сдаются преподавателю или применяется вариант самопроверки: \nа)    преподаватель диктует правильные ответы или, что лучше, вывешивает таблицу правильных ответов. Учащиеся отмечают знаками \"+\" и \"-\" свои результаты; \nб)    небольшое обсуждение по вопросам учащихся; \nв)    задается норма оценки. Например: из 7 заданий 6 \"плюсиков\" — отметка \"5\", 5 \"плюсиков\" — \"4\", не менее трех — отметка \"3\"; \n\n\t«ТОЛСТЫЙ И ТОНКИЙ ВОПРОС»\n    Это прием из технологии развития критического мышления используется для организации взаимоопроса. Стратегия позволяет формировать: умение формулировать вопросы; умение соотносить понятия. Тонкий вопрос предполагает однозначный краткий ответ. Толстый вопрос предполагает ответ развернутый. После изучения темы учащимся предлагается сформулировать по три «тонких» и три «толстых» вопроса», связанных с пройденным материалом. Затем они опрашивают друг друга, используя таблицы «толстых» и «тонких» вопросов. \n\n\t«КРУГЛЫЙ СТОЛ»\n    Письменный «Круглый стол» — это метод обучения сообща, при котором лист и ручка постоянно передаются по кругу среди небольшой группы участников игры. К примеру, один из партнеров записывает какую-то идею, затем передает лист соседу слева. Тот добавляет к этой идее какие-то свои соображения и передает лист дальше. В одном из вариантов этой процедуры каждый участник делает запись своим цветом. Это чисто зрительно усиливает ощущение равной лепты, которую вносит каждый в формирование общего мнения, и позволяет преподавателю разобраться и зафиксировать участие каждого. Устный «Круглый стол» — метод обучения сообща, сходный с предыдущим, только проводится он в устной форме. Каждый участник, по очереди, подхватывает и развивает идею, высказанную предыдущим.\n");
            MethodicalReceptions[8].Add(MethodicalButton9.Text, "\t«ВЫБЕРИ ВЕРНОЕ УТВЕРЖДЕНИЕ» \n    Обучающимся предлагается выбрать подходящее утверждение \n1)    Я сам не смог справиться с затруднением; \n2)    У меня не было затруднений;\n3)    Я только слушал предложения других; \n4)    Я выдвигал идеи…. \n\n\t«МОДЕЛИРОВАНИЕ ИЛИ СХЕМАТИЗАЦИЯ» \n    Обучающиеся моделируют или представляют свое понимание, действия в виде рисунка или схемы.\n\n\t«ПОМЕТКИ НА ПОЛЯХ» \n    Обозначение с помощью знаков на полях возле текста или в самом тексте: «+» - знал, «!» - новый материал (узнал), «?» - хочу узнать \n\n\t«ПРОДОЛЖИ ФРАЗУ»\n Карточка с заданием «Продолжить фразу»: \n•    Мне было интересно… \n•    Мы сегодня разобрались…. \n•    Я сегодня понял, что… \n•    Мне было трудно… \n•    Завтра я хочу на уроке… \n\n\t«ЛЕСЕНКА «МОЁ СОСТОЯНИЕ»» \n    Обучающийся отмечает соответствующую ступеньку лесенки. \n•    Комфортно \n•    Уверен в своих силах \n•    Хорошо \n•    Плохо\n•    Крайне скверно\n\n\t«ВОПРОСЫ ИТОГОВОЙ РЕФЛЕКСИИ, КОТОРЫЕ ЗАДАЮТСЯ ПРЕПОДАВАТЕЛЕМ В КОНЦЕ \t\t\tУРОКА» \n•    Как бы вы назвали урок? \n•    Что было самым важным на уроке? \n•    Зачем мы сегодня на уроке…? \n•    Какова тема сегодняшнего урока? \n•    Какова цель урока? \n•    Чему посвятим следующий урок? \n•    Какая задача будет стоять перед нами на следующем уроке? \n•    Что для тебя было легко (трудно)? \n•    Доволен ли ты своей работой? \n•    За что ты хочешь похвалить себя или кого-то из одногруппников? \n\n\t«ХОЧУ СПРОСИТЬ» \n    Рефлексивный прием, способствующий организации эмоционального отклика на уроке. Обучающийся задает вопрос, начиная со слов «Хочу спросить…». На полученный ответ сообщает свое эмоциональное отношение: «Я удовлетворен….» или «Я неудовлетворен, потому что …»\n\n\t«ПРОДОЛЖИ ФРАЗУ…» \n    Прием рефлексии используется чаще всего на уроках после изучения большого раздела. Суть - зафиксировать свои продвижения в учебе, а также, возможно, в отношениях с другими. Рюкзак перемещается от одного учащегося к другому. Каждый не просто фиксирует успех, но и приводит конкретный пример. Если нужно собраться с мыслями, можно сказать \"пропускаю ход\".\n");
        }
        private void MethodicalButton1_Click(object sender, EventArgs e)
        {
            if (!MethodicalSelect)
            {
                CloseAll();
                Text = "Methodical reception";
                OtherPanelTextBox.Text = MethodicalReceptions[0].GetText();
                OtherTextPanel.Visible = true;
                OtherTextPanel.Location = locationDefault;
                OtherTextPanel.Size = new Size(sizeDefault);
                OtherPanelTextBox.SelectionStart = 0;
                OtherPanelTextBox.ScrollToCaret();
            }
            else
            {
                byte MRn = 0;
                if (MethodicalReceptions[MRn].GetPoint())
                {
                    MethodicalReceptions[MRn].Off();
                    MethodicalButton1.BackColor = defaultButtonColor;
                }
                else
                {
                    MethodicalReceptions[MRn].On();
                    MethodicalButton1.BackColor = selectButtonColor;
                }
            }
        }

        private void MethodicalButton2_Click(object sender, EventArgs e)
        {
            if (!MethodicalSelect)
            {
                CloseAll();
                Text = "Methodical reception";
                OtherPanelTextBox.Text = MethodicalReceptions[1].GetText();
                OtherTextPanel.Visible = true;
                OtherTextPanel.Location = locationDefault;
                OtherTextPanel.Size = new Size(sizeDefault);
                OtherPanelTextBox.SelectionStart = 0;
                OtherPanelTextBox.ScrollToCaret();
            }
            else
            {
                byte MRn = 1;
                if (MethodicalReceptions[MRn].GetPoint())
                {
                    MethodicalReceptions[MRn].Off();
                    MethodicalButton2.BackColor = defaultButtonColor;
                }
                else
                {
                    MethodicalReceptions[MRn].On();
                    MethodicalButton2.BackColor = selectButtonColor;
                }
            }
        }

        private void MethodicalButton3_Click(object sender, EventArgs e)
        {
            if (!MethodicalSelect)
            {
                CloseAll();
                Text = "Methodical reception";
                OtherPanelTextBox.Text = MethodicalReceptions[2].GetText();
                OtherTextPanel.Visible = true;
                OtherTextPanel.Location = locationDefault;
                OtherTextPanel.Size = new Size(sizeDefault);
                OtherPanelTextBox.SelectionStart = 0;
                OtherPanelTextBox.ScrollToCaret();
            }
            else
            {
                byte MRn = 2;
                if (MethodicalReceptions[MRn].GetPoint())
                {
                    MethodicalReceptions[MRn].Off();
                    MethodicalButton3.BackColor = defaultButtonColor;
                }
                else
                {
                    MethodicalReceptions[MRn].On();
                    MethodicalButton3.BackColor = selectButtonColor;
                }
            }
        }

        private void MethodicalButton4_Click(object sender, EventArgs e)
        {
            if (!MethodicalSelect)
            {
                CloseAll();
                Text = "Methodical reception";
                OtherPanelTextBox.Text = MethodicalReceptions[3].GetText();
                OtherTextPanel.Visible = true;
                OtherTextPanel.Location = locationDefault;
                OtherTextPanel.Size = new Size(sizeDefault);
                OtherPanelTextBox.SelectionStart = 0;
                OtherPanelTextBox.ScrollToCaret();
            }
            else
            {
                byte MRn = 3;
                if (MethodicalReceptions[MRn].GetPoint())
                {
                    MethodicalReceptions[MRn].Off();
                    MethodicalButton4.BackColor = defaultButtonColor;
                }
                else
                {
                    MethodicalReceptions[MRn].On();
                    MethodicalButton4.BackColor = selectButtonColor;
                }
            }
        }

        private void MethodicalButton5_Click(object sender, EventArgs e)
        {
            if (!MethodicalSelect)
            {
                CloseAll();
                Text = "Methodical reception";
                OtherPanelTextBox.Text = MethodicalReceptions[4].GetText();
                OtherTextPanel.Visible = true;
                OtherTextPanel.Location = locationDefault;
                OtherTextPanel.Size = new Size(sizeDefault);
                OtherPanelTextBox.SelectionStart = 0;
                OtherPanelTextBox.ScrollToCaret();
            }
            else
            {
                byte MRn = 4;
                if (MethodicalReceptions[MRn].GetPoint())
                {
                    MethodicalReceptions[MRn].Off();
                    MethodicalButton5.BackColor = defaultButtonColor;
                }
                else
                {
                    MethodicalReceptions[MRn].On();
                    MethodicalButton5.BackColor = selectButtonColor;
                }
            }
        }

        private void MethodicalButton6_Click(object sender, EventArgs e)
        {
            if (!MethodicalSelect)
            {
                CloseAll();
                Text = "Methodical reception";
                OtherPanelTextBox.Text = MethodicalReceptions[5].GetText();
                OtherTextPanel.Visible = true;
                OtherTextPanel.Location = locationDefault;
                OtherTextPanel.Size = new Size(sizeDefault);
                OtherPanelTextBox.SelectionStart = 0;
                OtherPanelTextBox.ScrollToCaret();
            }
            else
            {
                byte MRn = 5;
                if (MethodicalReceptions[MRn].GetPoint())
                {
                    MethodicalReceptions[MRn].Off();
                    MethodicalButton6.BackColor = defaultButtonColor;
                }
                else
                {
                    MethodicalReceptions[MRn].On();
                    MethodicalButton6.BackColor = selectButtonColor;
                }
            }
        }
        private void MethodicalButton7_Click(object sender, EventArgs e)
        {
            if (!MethodicalSelect)
            {
                CloseAll();
                Text = "Methodical reception";
                OtherPanelTextBox.Text = MethodicalReceptions[6].GetText();
                OtherTextPanel.Visible = true;
                OtherTextPanel.Location = locationDefault;
                OtherTextPanel.Size = new Size(sizeDefault);
                OtherPanelTextBox.SelectionStart = 0;
                OtherPanelTextBox.ScrollToCaret();
            }
            else
            {
                byte MRn = 6;
                if (MethodicalReceptions[MRn].GetPoint())
                {
                    MethodicalReceptions[MRn].Off();
                    MethodicalButton7.BackColor = defaultButtonColor;
                }
                else
                {
                    MethodicalReceptions[MRn].On();
                    MethodicalButton7.BackColor = selectButtonColor;
                }
            }
        }
        private void MethodicalButton8_Click(object sender, EventArgs e)
        {
            if (!MethodicalSelect)
            {
                CloseAll();
                Text = "Methodical reception";
                OtherPanelTextBox.Text = MethodicalReceptions[7].GetText();
                OtherTextPanel.Visible = true;
                OtherTextPanel.Location = locationDefault;
                OtherTextPanel.Size = new Size(sizeDefault);
                OtherPanelTextBox.SelectionStart = 0;
                OtherPanelTextBox.ScrollToCaret();
            }
            else
            {
                byte MRn = 7;
                if (MethodicalReceptions[MRn].GetPoint())
                {
                    MethodicalReceptions[MRn].Off();
                    MethodicalButton8.BackColor = defaultButtonColor;
                }
                else
                {
                    MethodicalReceptions[MRn].On();
                    MethodicalButton8.BackColor = selectButtonColor;
                }
            }
        }

        private void MethodicalButton9_Click(object sender, EventArgs e)
        {
            if (!MethodicalSelect)
            {
                CloseAll();
                Text = "Methodical reception";
                OtherPanelTextBox.Text = MethodicalReceptions[8].GetText();
                OtherTextPanel.Visible = true;
                OtherTextPanel.Location = locationDefault;
                OtherTextPanel.Size = new Size(sizeDefault);
                OtherPanelTextBox.SelectionStart = 0;
                OtherPanelTextBox.ScrollToCaret();
            }
            else
            {
                byte MRn = 8;
                if (MethodicalReceptions[MRn].GetPoint())
                {
                    MethodicalReceptions[MRn].Off();
                    MethodicalButton9.BackColor = defaultButtonColor;
                }
                else
                {
                    MethodicalReceptions[MRn].On();
                    MethodicalButton9.BackColor = selectButtonColor;
                }
            }
        }

        private void Clicked_To_Link(object sender, LinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.LinkText) { UseShellExecute = true });
        }

        //public class ClassTechnicalMaps
        //{
        //    public RichTextBox TTechnicalMap = new RichTextBox();
        //    public RichTextBox TTeacher = new RichTextBox();
        //    public RichTextBox TGroup = new RichTextBox();
        //    public RichTextBox TSubject = new RichTextBox();
        //    public RichTextBox TLessonTopic = new RichTextBox();
        //    public DateTimePicker TDate = new DateTimePicker();
        //    public RichTextBox TTask1 = new RichTextBox();
        //    public RichTextBox TTask2 = new RichTextBox();
        //    public RichTextBox TTask3 = new RichTextBox();
        //    public RichTextBox TResult1 = new RichTextBox();
        //    public RichTextBox TResult2 = new RichTextBox();
        //    public RichTextBox TResult3 = new RichTextBox();
        //    public RichTextBox TFCR1 = new RichTextBox();
        //    public RichTextBox TFCR2 = new RichTextBox();
        //    public RichTextBox TFCR3 = new RichTextBox();
        //    public RichTextBox TResource1 = new RichTextBox();
        //    public RichTextBox TResource2 = new RichTextBox();
        //    public RichTextBox TTAPL1 = new RichTextBox();
        //    public RichTextBox TTAPL2 = new RichTextBox();
        //    public ClassTechnicalMaps()
        //    {
        //        TTechnicalMap.Text = "";
        //        TTeacher.Text = "";
        //        TGroup.Text = "";
        //        TSubject.Text = "";
        //        TLessonTopic.Text = "";
        //        TDate.Text = "";
        //        TTask1.Text = "";
        //        TTask2.Text = "";
        //        TTask3.Text = "";
        //        TResult1.Text = "";
        //        TResult2.Text = "";
        //        TResult3.Text = "";
        //        TFCR1.Text = "";
        //        TFCR2.Text = "";
        //        TFCR3.Text = "";
        //        TResource1.Text = "";
        //        TResource2.Text = "";
        //        TTAPL1.Text = "";
        //        TTAPL2.Text = "";
        //    }
        //};
    }
}