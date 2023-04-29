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
            LessonCompleteRichBox.Text = "\t\tВаша рекомендация по созданию урока"; // Начальная инфа
            string text1 = "\n\n"; // 2 отступа вниз после каждого выбора

            // Информация под конец.
            string OsnInf = "";

            switch (LessonPoint1X)
            {
                case 1:
                    LessonCompleteRichBox.Text = "\tЭто урок, на котором педагог объясняет новый материал. Он строится в соответствии с требованиями ФГОС несколько иначе, нежели прежде. \n\t• В начале следует провести этап мотивации, который, впрочем, немногим отличается от прежнего оргмомента. \n\t• Затем следует этап актуализации изученного (повторения) с попыткой решить проблемную задачу, опираясь лишь на уже известную информацию. \n\t• Вывод о необходимости еще какого-то знания и получение его тем или иным способом (например, в процессе наблюдения или эксперимента). Это так называемое первичное усвоение материала. \n\tА далее: \n\t• Этап самостоятельного осмысления; в его ходе школьники выполняют работу самостоятельно. \n\t• Проверка. Обсуждение вопроса, какое место занимает новое знание в общей системе знаний, каковы возможности его практического применения. \n\t• Инструктаж по домашнему заданию; рефлексия. Разумеется, это приблизительный план хода урока. При этом решаются различные задачи: образовательные (научить, познакомить, проанализировать и т.д.), воспитательные (формировать познавательную и творческую активность, любовь к Родине, к природе, к литературе, воспитывать упорство, любознательность и проч.) и развивающие (формировать умение анализировать, сопоставлять, читать схемы, пользоваться справочной литературой и т.п.).\n\t";
                    LessonCompleteRichBox.Text += text1;
                    switch (LessonPoint2X)
                    {
                        case 1:
                            LessonCompleteRichBox.Text += "\tДля достижения поставленных целей в современных условиях актуально проведение занятий с использованием экскурсий.\n\t Производственные или учебные экскурсии (ПЭ) - это одна из многочисленных форм профориентационной работы с учащимися. Они имеют большое образовательное, политехническое и воспитательное значение.\n\tПЭ служит формой наглядного ознакомления учащихся с техникой и технологией, организацией производства, содержанием труда, условиями труда и пр.\n\tВ основном ПЭ рассматриваются как средство формирования и развития у студентов интереса к различным профессиям. Однако ПЭ - это не только одна из форм внеурочной деятельности педагога по оказанию помощи студентам в их профессиональном самоопределении. ПЭ предусматриваются и учебными программами.\n\tОсновная цель ПЭ - расширение политехнического образования студентов . Экскурсия на какое-либо предприятие, проводимая в органичной связи с содержанием учебных дисциплин, показывает неразрывную связь теории и практики в производственной деятельности людей.\n\t\n\tЭкскурсия (от лат. excursio — прогулка, поездка) — коллективное посещение музея, достопримечательного места, выставки, предприятия и т.п.; поездка, прогулка с образовательной, научной, спортивной или увеселительной целью.\n\tУчебная экскурсия — это проведение учебного занятия в условиях производства, природы, музея с целью наблюдения и изучения студентами различных объектов и явлений действительности.\n\t Являясь самостоятельной формой обучения, экскурсия входит важной составной частью в систему учебно-воспитательной работы и вносит свой весомый вклад в формирование всесторонне развитой личности.\n\tПеред экскурсиями ставятся такие задачи: обогащать знания студентов  (на основе непосредственного восприятия, накопления наглядных представлений и фактов); устанавливать связи теорий с практикой, с жизненными явлениями и процессами; развивать творческие способности студентов (учащихся), их самостоятельность, организованность в учебном труде, чувства коллективизма и взаимопомощи; обогащать эстетические чувства; развивать наблюдательность, память, мышление, эмоции; активизировать познавательную и практическую деятельность; воспитывать положительное отношение к учению. Экскурсия дает широкие возможности для более полного, комплексного использования методов обучения (и в первую очередь проблемных).\n\tВажнейшее назначение учебных экскурсий заключается в выявлении жизненности и актуальности учебного материала, в закреплении и конкретизации знаний, полученных на уроках, в применении знаний и умений на практике. Наглядность — существеннейший признак учебной экскурсии: удельный вес зрительной и слуховой наглядности в получении информации на экскурсии составляет более 70 процентов. Благодаря наглядности студенты (учащиеся) быстрее усваивают знания, которые затем на учебных занятиях становятся опорным фактическим материалом при восприятии новой темы, при обобщении и формировании соответствующих выводов. Экскурсионные наблюдения используются также для проверки, исправления, уточнения уже имеющихся у студентов (учащихся) знаний и представлений, для обогащения их новыми конкретными данными. Так, на экскурсии на промышленное или сельскохозяйственное предприятие происходит наглядное знакомство с практической деятельностью людей, с непосредственным использованием научных знаний, основы которых изучаются на занятии, формируются представления о производственных процессах, организации производства, отношениях в коллективе.\n\tНаблюдая и познавая явления общественной жизни, студенты (учащиеся) сами готовятся к активному участию в различных сферах общественно полезной деятельности.\n\tСтуденты (учащиеся) должны быть осведомлены о развитии и достижениях современной науки и техники.  К сожалению не урок, не факультатив, не просмотр научно- популярного фильма или специальной телепередачи не оказывает на студентов (учащихся) такого влияния, как полное впечатлений непосредственное соприкосновение с технологическим процессом производства. Во время экскурсии студенты (учащиеся) переносят знания в новую ситуацию, открывают для себя новые способы решения познавательных задач.( см. приложение).\n\t В зависимости от типа, содержания и метода проведения экскурсии, возраста студентов (учащихся), местных условий и вида передвижения в состав экскурсионной группы может входить от десяти до сорока студентов.\n\tДлительность учебной экскурсии  определяется в зависимости от учебных задач, конкретных условий проведения.\n\tКаждая экскурсия связана с учебным материалом разных дисциплин\n\tпо профессиям.\n\tЭтапы подготовки экскурсии\n\t \t\n1.     Определение цели и задачи экскурсии.\t\n2.     Выбор темы.\t\n3.     Отбор и изучение экскурсионных объектов.\t\n4.     Составление маршрута экскурсии.\t\n5.     Разработка заданий для учащихся.\t\n6.     Составление методической разработки.\n\t Цель экскурсии: наглядное ознакомление студентов (учащихся) с техникой и технологией , организации с/х  производства.\n\tЗадачи экскурсии:\t\n1. обогащать знания студентов (учащихся) на основе непосредственного восприятия, накопления наглядных представлений и фактов;\t\n2. устанавливать связи теорий с практикой, с жизненными явлениями и процессами\t\n3. развивать творческие способности студентов (учащихся),\t\n4. развивать самостоятельность, организованность в учебном труде, чувства коллективизма и взаимопомощи;\t\n5. развивать наблюдательность, память, мышление, эмоции;\t\n6.активизировать познавательную и практическую деятельность; воспитывать положительное отношение к учению. \n\t В процессе подготовки экскурсии при отборе объектов проводится их оценка по следующим показателям (критериям):\t\n1.     познавательная ценность;\t\n2.     известность (популярность);\t\n3.     месторасположение.\n\tПо мере сбора сведений об объекте студентам (учащимся) рекомендуется составить портфолио, в которое вносятся следующие сведения:\t\n1.     наименование объекта;\t\n2.     завод-изготовитель;\t\n3.     техническая характеристика.\t\n4.     назначение и место в технологическом процессе;\t\n5.     особенности конструкции\n\t\n\tПроведение экскурсии.\n\tРазбивка на группы( по 4-5 человек);\n\tВыдача заданий по объектам;\n\tИнструктаж;\n\tСбор информации согласно выданным заданиям.\n\tОбработка собранного материала.\n\tПодготовка к конференции:  презентация, фильм, репортаж, фотообозрение, доклад, плакаты и т. д\n\t";
                            break;
                        case 2:
                            LessonCompleteRichBox.Text += "\tИмитационные методы активизации учебно-познавательной деятельности подразделяются - на игровые и не игровые.\r\nК игровым, относятся разыгрывание ролей и деловые игры различных модификаций. Они заполняют тот пробел в учебном процессе, которую не могут компенсировать другие методы (например, словесные методы, практические занятия и др.), но не заменяют их. Игровой характер учебно-познавательной деятельности дает возможность ознакомиться со спецификой и особенностями определенной профессиональной деятельности, а также способствует ощущению своей роли в ней. Кроме того, они существенно помогают закреплению и углублению знаний, полученных во время бесед, лекций, рассказов, семинаров, практических занятий, совершенствованию практических навыков и умений, их применению, творческому использованию в решении профессиональных проблем, созданию условий для активного обмена опытом. \r\nОсновная функция этих занятий заключается в обучении путем действий (чем ближе игровая деятельность учащихся к реальной ситуации, тем выше ее учебно-познавательная эффективность).\r\nОсновными разновидностями игровых методов активизации учебно-познавательной деятельности является метод инсценировки и деловые игры.\r\nМетод инсценировки имеет много общего с театром, который вызывает сильные чувства и, соответственно, влияет на эмоционально-волевую сферу личности. Один из древнейших методов обучения, он наиболее эффективен и на сегодня, потому что обеспечивает условия максимального приближения Дидактического процесса к действительности. \r\nХарактерными особенностями этого метода являются, во-первых, ознакомление участников занятия с конкретной Дидактической ситуацией, которая наиболее полно соответствует профессиональной деятельности и требует разрешения; во-вторых, предоставление им ролей конкретных должностных лиц, которые существуют в реальной ситуации; в-третьих, распределение этих ролей между учениками. \r\nМетод инсценировки обеспечивает обучающимся такие условия для занятий, которые не в состоянии создать другие методы обучения – испытать на себе результаты своих решений и действий.\r\nМожно использовать две формы инсценировки занятий: первая – это заранее подготовленное инсценирование; вторая – импровизированное инсценирование, которое по сравнению с первым возникает как бы невзначай, случайно и неожиданно во время обсуждения определенных учебных проблем. \r\nВ первом случае педагог заранее готовит такие ситуации и выдвигает их для обсуждения во время рассмотрения общей учебной проблемы. Во втором – ситуацию предлагают сами студенты во время дискуссии по определенной проблеме, а педагог должен умело инсценировать эту учебную проблему для коллективного разыгрывания.\r\nИнсценировка занятия может осуществиться так: \r\n– роли распределяются между отдельными учениками, а другие выполняют роль активного зрителя или функции «арбитра»; \r\n– обучающиеся разделяются на небольшие группы. Каждая группа выполняет роль определенного должностного лица, участника ситуации и др. Сначала они активно дискутируют в этих группах над решением дидактической проблемы, после чего представители групп предлагают всем ученикам для дискуссионного обсуждения свой вариант.\r\nБезусловно, этот метод требует от педагога всесторонней подготовки, умение методически правильно обрабатывать ситуации, которые должны быть разыгранными, и обладание необходимыми навыками и умениями для их воплощения.\r\nСущественным мотивом проведения таких занятий есть соответствующая подготовленность учащихся к активному участию в них. Учитывая вышесказанное, можно дать некоторые методические рекомендации. \r\nЗанятия методом инсценировки рекомендуется проводить в основном при рассмотрении ситуаций, в основе которых лежат проблемы при изучении тем, касающихся совершенствования стиля и методов работы должностных лиц. Педагог должен умело подойти к выбору конкретной ситуации: во-первых, ее необходимо брать из практики; во-вторых, она должна входить в круг будущих обязанностей студента; в-третьих, быть интересной по содержанию и нестандартной по характеру решения. За то педагог должен вдумчиво проработать конкретную дидактическую ситуацию. Она должна включать общий фон ситуации, конкретную дидактическую проблему, четкое распределение ролей в соответствии с «функциональными обязанностями» и определение характера деятельности обучающихся. Дидактическую проблему, подлежащую инсценировке, нужно подробно описать с четкими общими и индивидуальными инструкциями. Эти описания должны быть объективными, без какого-либо критического анализа и оценочных фактов, но со всеми необходимыми элементами, которые помогут учащимся выяснить сущность дидактической проблемы. \r\nОпределению этих аспектов и недопущению определенных организационных и методических ошибок способствует подробный план инсценировки, где педагог предполагает свои действия и действия участников занятия, расписывает эти действия во времени. \r\nОписание ситуации и конкретные общие и индивидуальные инструкции по выполнению определенных ролей раздаются участникам или накануне занятия, или во время занятия в зависимости от его дидактического и методического замысла. Но в любом случае должно быть достаточно времени для обдумывания дидактической проблемы и осознание роли каждого в ее решении, составление плана и его реализации. \r\nСледовательно, описание должно содержать информацию для учебной группы, с которой знакомятся все участники занятия, и конкретных лиц в соответствии с их ролей. Характер общей информации или инструкции должен помогать участникам занятия понять дидактическую проблему, формировать эмоционально положительное отношение к ней и содействовать активному участию всех учеников в инсценировке. Индивидуальные инструкции доводятся до сведения конкретных исполнителей соответствующих ролей. Если только некоторые ученики получили роли, а остальные – активные зрители или «арбитры», до последних также доводят содержание индивидуальных инструкций. В связи с этим они являются наиболее информированными в этом занятии, потому что, знают как общую, так и индивидуальные инструкции. Поэтому им остается только оценить характер рассуждений каждого исполнителя и их решение. При этом с дидактической целью им можно разъяснить, на что следует обращать особое внимание и Что необходимо оценить. \r\nХод таких занятий во многом зависит от умелого управления. Подготовительными работами руководит, безусловно, педагог, а ходом занятия – как педагог, так и определенный студент в соответствии с конкретной педагогической ситуации и дидактического замысла. Но всегда педагог четко определяет порядок проведения занятия и разъясняет правила дискуссии, ведь успеху всего занятия, прежде всего, способствуют атмосфера эмоциональной приподнятости, «театральности» и отсутствие скованности. \r\nПосле этого начинается обсуждение дидактической проблемы между участниками инсценировки, им необходимо дать время на «вживание» в роли, а также возможность обращаться к педагогу за определенными уточнениями и дополнительной информацией. Во время инсценировки другие участники-зрители не должны мешать исполнителям советами. \r\nТакие занятия заканчиваются общей дискуссией: оценивается динамика их хода, игра как отдельных обучающихся, так и всей учебной группы. В зависимости от дидактического и методического замысла занятия содержание дискуссии может быть разным, но в любом случае педагог должен требовать от участников четкой аргументации и научного обоснования личных взглядов. Обсуждение можно начинать с вопроса к исполнителям: как они сами оценивают исполнение ролей, и какими были бы их действия в реальной ситуации или во время повторной инсценировке? Исполнители в такой способ получают возможность критически оценить свои действия. Это стимулирует начало содержательной дискуссии.\r\nУчастники-зрители сначала оценивают положительные, а затем отрицательные аспекты в действиях исполнителей конкретных ролей. Все оценки систематизируются, анализируются и обобщаются педагогом. Чтобы выяснить отношение исполнителей ролей к критике, необходимо предоставить им возможность ответить на нее, обосновав свою позицию. После этого снова организуется дискуссия по вопросу наиболее обоснованного варианта решения дидактической проблемы. Итоги дискуссии подводит педагог. \r\nДидактически-воспитательная действенность метода инсценировки, как свидетельствует педагогическая практика, является очень высокой, потому что с его помощью можно реализовать такую дидактическую цель, которой нельзя достичь традиционными методами обучения.\r\nОсновные положительные аспекты инсценировки: этот метод облегчает учения; способствует наблюдению за собственными действиями и других; помогает критически их оценить; учит чувствовать мотивы действий товарищей и, соответственно, принимать более обоснованное решение; дает возможность всесторонне проанализировать дидактическую проблему с учетом, как личного мнения, так и мыслей других\r\n";
                            break;
                        case 3:
                            LessonCompleteRichBox.Text += "\t1. Методика подготовки лекции\r\nПри анализе методики подготовки лекции особое внимание следует обращать на решение следующих организационно-методических вопросов:\r\n1. Определение основной цели лекции, ее главной идеи. Она (цель) задается требованиями учебной программы, местом лекции в изучаемой учебной дисциплине и самим названием. Целесообразно начинать подготовку лекции с постановки перед собой вопроса о том, для какой категории слушателей необходима данная лекция и какой конкретно материал необходимо вложить в ее текст. Ответив на поставленные вопросы, преподаватель конкретизирует содержание лекции.\r\n2. Уточнение объема материала, входящего в содержание лекции.\r\nПрактика показывает, что у преподавателя, готовящегося к написанию текста лекции, как правило, материала бывает значительно больше, чем его можно изложить за отведенное время. Следовательно, надо отобрать самое важное  для достижения поставленной цели. В этом случае следует экономить время для раскрытия главного – таково правило наиболее опытных преподавателей. Нехватка времени из-за чрезмерного объема материала – частый недостаток многих  начинающих преподавателей, которые еще не научились рассчитывать время, необходимое для изложения того или иного вопроса. Здесь им поможет простой методический прием: нужно прочитать вслух подготовленный текст, заметив время, а затем увеличить это время примерно на 20-30%.Как показывает практика, столько времени будет затрачено при чтении лекции в аудитории. Безусловно, при определении объема содержания лекции необходимо ориентироваться на требования учебной программы.\r\n3. Детальная проработка структуры лекции способствует уточнению содержания, его лучшему подчинению главной цели и выполнению основных требований. Практика показывает, что опытные преподаватели не ограничивают  проработку структуры определением основных вопросов, а продумывают их структуру. Каждый вопрос они разбивают на подвопросы и формулируют название последних. Это обеспечивает более строгое подчинение материала теме и цели лекции, позволяет лучше отобрать материал и логичнее его расположить.\r\n4. Написание текста лекции. По любой теме целесообразно иметь полный текст лекции. При ее написании преподаватель должен работать над тем, как повысить научность и практическую значимость лекции, реализовать все ее функции, как лучше скомпоновать материал. После того как написан первый вариант текста лекции, в него вносятся коррективы, продолжается работа над точностью и яркостью фраз и выражений. Придание тексту наглядности облегчает пользование им, однако нельзя превращать лекцию в чтение текста. Текст лекции должен вести, направлять изложение материала.\r\n5. Специальная подготовка средств наглядности и решение других организационно-методических вопросов – важный элемент в подготовке лекции. Тот факт, что использование в лекции средств наглядности является обязательным, не вызывает сомнений. Практика показывает, что 5-7 обращений преподавателя к использованию средств изобразительной наглядности бывает вполне достаточно.\r\n2. Методика чтения лекции\r\nВсегда следует помнить, что лекция имеет четкую структуру, включающую в себя: введение, основную часть и заключение. В каждом из ее элементов преподавателю следует соблюдать определенные действия и правила поведения, суть которых и определяет методику чтения лекции.\r\nВо введении к числу основных действий преподавателя можно отнести:\r\n1. Объявление темы и плана лекции, указание основной и дополнительной литературы.\r\n2. Разъяснение целей занятия и способов их достижения.\r\n3. Обозначение места лекции в программе и ее связь с другими дисциплинами.\r\n4. Создание рабочей обстановки в аудитории, вызвать у слушателей интерес к изучаемой теме.\r\nВ основной части лекции преподавателю можно рекомендовать следующие методические приемы:\r\n1. Установление контакта с аудиторией.\r\n2. Убежденное и эмоциональное изложение материала.\r\n3. Установление четких временных рамок на изложение материала по намеченному плану.\r\n4. Использование материала лекции как опорного для лучшего усвоения изучаемой дисциплины.\r\n5. Контроль за грамотностью своей речи (слогообразование, ударение и т.д.) и поведением.\r\n6. Наблюдение за аудиторией и поддержание с ней контакта на протяжении всего занятия.\r\nВ заключительной части лекции преподавателю рекомендуется:\r\n1. Подвести итоги сказанного в основной части и сделать выводы по теме.\r\n2. Ответить на вопросы обучающихся.\r\n3. Напомнить обучающимся о методических указаниях по организации самостоятельной работы.\r\n4. Объявить в аудитории очередную тему занятий и порекомендовать присутствующим ознакомиться с ее основным содержанием.\r\n3.  Правила оформления методической разработки лекции\r\n  Правила оформления титульного листа:\r\nЛицевая  сторона титульного  листа    оформляется  в  соответствии  с приложением 1.  \r\nУказывается:\r\n- название образовательной организации;\r\n- тема: название  темы  должно  соответствовать  ее  названию  в  учебной программе;\r\n- учебная дисциплина или междисциплинарный курс: название дисциплины или МДК указывается в соответствии с учебной программой;\r\n- курс, специальность\r\n- количество часов\r\n- разработчик\r\n- место рассмотрения (одобрения)\r\n Мотивация изучения темы:\r\nраскрывается значимость темы с учетом профильности  по  специальности,  формулируется  актуальность  для современной науки и здравоохранения.\r\nЦели занятия:\r\nУчебные:  ведущая  дидактическая  цель  лекции  определяется содержанием учебного материала, предусмотренного учебной программой, и предполагает усвоение определенного объема знаний. Знания, получаемые обучающимися, должны представлять собой систему, т.е. все они должны быть направлены на достижение конкретных целей обучения, являющихся частью  общей  системы  целей  по  специальности. Цели  формулируются  с  учетом компетентностного подхода.\r\nВоспитательные:  Воспитывающая  функция  опирается  на  принцип воспитывающего  обучения. Процессы  обучения  и  воспитания  находятся  в органичном  единстве. Их  объединяют  общие  цели – сформировать специалиста, понимающего  сущность  и  социальную  значимость  будущей профессии, обладающего чувством профессиональной ответственности за результаты  своего  труда;  воспитание  гражданина, способного  на  основе имеющихся  гуманитарных  и  социально-экономических  знаний  оценивать социально значимые факты и явления, проявляющего готовность соблюдать усвоенные  правовые  и  этические  нормы, определяющие  отношение  к человеку, обществу, окружающей среде и т.д.\r\nРазвивающие:  Суть  развивающей  функции  состоит, прежде  всего, в  том, чтобы  в  процессе  обучения  обеспечить  максимальное  развитие интеллектуальной, эмоциональной и волевой сфер личности, формирование и развитие  познавательных  интересов  и  способностей,  творческой активности.\r\n Формируемые общие и профессиональные компетенции:\r\nперечисляются те общие и профессиональные компетенции, формированию которых будет способствовать материал лекции.\r\nИнтеграционные  связи  (внутри-  и  межмодульные, внутри дисциплинарные, связь с другими учебными дисциплинами):  \r\n Оснащение: необходимо  перечислить  все  виды средств  обучения, используемые  на  лекции. (К  средствам  обучения относятся  учебно-наглядные  пособия, вербальные  средства, технические средства и специальное оборудование).\r\n Этапы занятия (с указанием хронометража)\r\nСписок литературы\r\n";
                            break;
                        case 4:
                            LessonCompleteRichBox.Text += "\tВ форме беседы полезно проводить и опрос и объяснение нового, материала на первой ступени обучения. Характерная особенность этой формы урока состоит в том, что учащиеся принимают в нем активное участие — отвечают на вопросы, делают самостоятельные выводы из демонстрационных опытов, объясняют явления. Все это, конечно, корректирует педагог, он руководит такой беседой, уточняет и окончательно формулирует ответы.\r\nВ начале урока целесообразно в форме беседы провести повторение с целью проверить знания учащихся и восстановить картину пройденного материала, чтобы перейти к последующим вопросам.\r\nЗатем полезно выявить примеры из жизненного опыта обучающихся, связанные с изучаемым вопросом (например, перед введением понятия об архимедовой силе — явления, замеченные ими при плавании), попросить обучающихся попытаться объяснить эти явления, тем самым показать им необходимость получения новых знаний (проблемная ситуация).\r\nПотом следует перейти к демонстрационным или самостоятельным опытам, объяснение которых сначала предложить дать обучающимся. При этом лучше вызвать учащихся для ответа поименно, в противном случае активно будут работать лишь несколько студентов. Сначала педагог задает вопрос, дает время для обдумывания и затем называет фамилию обучающегося. (Полезно иметь специальную тетрадь со списком класса и фиксировать в ней все ответы, за таких 2—3 ответа нужно ставить оценку в журнал. Можно оценить и вопрос обучающегося, если он выявляет знания.) В первую очередь рекомендуется вызвать слабого студента (но не слишком затягивать беседу). Если он ответит неверно, то попросить его внимательно слушать другие ответы, предупредить, что после выяснения правильного ответа он должен будет повторить его. После того как ответ будет найден и окончательно откорректирован учителем, такое повторение следует провести.\r\nДля успешного проведения урока-беседы важно, чтобы педагог установил хороший контакт с классом, наблюдал за ним и добивался полного понимания изучаемого на уроке вопроса.\r\nУрок-беседа — одна из наиболее трудных форм урока. Она требует от педагога хорошей профессиональной подготовки. Нужно тщательно подбирать вопросы и предвидеть возможные варианты ответов на них. Беседа должна проходить живо и непринужденно, только тогда она захватит всех обучающихся класса и даст нужный эффект.\r\nИ на первой ступени обучения часть урока может занимать длительный связный рассказ педагога. Он неизбежен в том случае, когда учащееся не располагают данными для самостоятельных выводов или описаний явления, например, при изложении основных положений молекулярно-кинетической или электронной теории; он необходим при изложении исторических сведений и технических приложений физики.\r\n";
                            break;
                        case 5:
                            LessonCompleteRichBox.Text += "\tПодготовка  встречи. В первую очередь необходимо определиться с темой. Она должна быть актуальной и интересной. При этом ставятся цели встречи — чему должны научиться студенты, какие сделать выводы.\r\nВ соответствии с темой на встречу приглашаются люди, которые смогут отвечать на вопросы в качестве экспертов. Необходимо заранее договориться о посещении, а за день желательно еще раз обзвонить приглашенных людей. Время и место проведения обговариваются вместе с гостями. Продолжительность такого общения не должна быть более 1 часа.\r\nЗа неделю до встречи необходимо раздать пресс-релизы, в которых указываются тема, план, информация о приглашенных гостях и основные направ¬ления беседы. Студенты должны подготовить вопросы, которые педагог затем отдает приглашенным экспертам, чтобы те могли подготовить ответы.\r\nВ помощь преподавателю\r\nВо время проведения встреч, бесед, брифингов могут возникнуть некоторые трудности. Как справляться в сложных ситуациях, направляя общение в нужное русло?\r\nНекоторые студенты все время говорят, не давая высказаться другим. В этом случае можно периодически задавать вопрос: «А что думают по этому поводу другие?» Во внеурочное время преподаватель может поговорить со слишком активными студентами наедине и объяснить им важность того, чтобы в беседе участвовали не только они, но и другие их одногруппники.\r\nВ беседе студенты уклонились от темы. Можно сказать, примерно следующее: «Все, что вы сказали, очень интересно, но мне кажется, мы уклонились от темы. Давайте рассмотрим этот вопрос позже в свободное время, а сейчас вернемся к нашей теме». Еще одним способом является стимулирующий вопрос, который возобновит у ребят интерес к изначальной теме.\r\nНекоторые студенты мешают проведению дискуссии. В этой ситуации не следует срываться на проблемных обучающихся. Необходимо учитывать, что могут быть при¬чины подобного поведения. Надо постараться выяснить, что это за причины. Для этого необходимо понаблюдать за студентом и попробовать выяснить, что стало причиной возникшей с ним проблемы, как можно ее решить и как следует поступить в первую очередь. Можно посоветоваться с другими педагогами по этому поводу.\r\nДискуссия стала непредсказуемой. Такая проблема вполне может возникнуть, поскольку ответы не всегда можно предугадать. Они могут легко увлечься не тем аспектом освещаемой темы и начать развивать свои мысли в этом направлении. В такой ситуации необходимо уметь вовремя менять акцент беседы.\r\nЕсли вопрос, предложенный для обсуждения, не увлек студентов, необходимо иметь в запасе несколько других вопросов, удовлетворяющих основным целям дискуссии.\r\n";
                            break;
                        case 6:
                            LessonCompleteRichBox.Text += "";
                            break;
                    }
                    break;
                case 2:
                    LessonCompleteRichBox.Text = "\t• Первый этап. Организационный этап\n\tОрганизационный этап, очень кратковременный, определяет весь психологический настрой урока. Психологический настрой проводится для создания благоприятной рабочей обстановки, чтобы обучающиеся поняли, что им рады, их ждали.\n\t• Второй этап. Проверка домашнего задания, воспроизведение и коррекция опорных знаний\n\tВыявить пробелы в знаниях и способах деятельности обучающихся.\n\t• Третий этап. Постановка цели и задач урока. Мотивация учебной деятельности \n\tЭто обязательный этап по ФГОС. На данном этапе педагогу необходимо создать проблемную ситуацию так, чтобы студенты сами назвали цель урока, а также саму тему. Результативность учебно-воспитательного процесса, состояние познавательной активности зависят от осознанности обучающегося цели деятельности.\n\tПрактические приемы: опорные схемы, диалог, мозговой штурм, мозговая атака, постановка проблемных вопросов, игровые моменты, раскрытие практической значимости темы, использование музыки и других эстетических средств.\n\t• Четвёртый этап. Первичное закрепление в знакомой ситуации\n\t• Пятый этап. Творческое применение и добывание знаний в новой ситуации (проблемные задания)\n\t• Шестой этап. Информация о домашнем задании, инструктаж по его выполнению\n\tЦель этапа: расширить и углубить знания, умения, полученные на уроке.\n\tЗадачи этапа:\n\t— разъяснить методику выполнения домашнего задания;\n\t— обобщить и систематизировать знания;\n\t— способствовать применению знаний, умений, навыков в разных условиях;\n\t— применить дифференцированный подход.\n\tДомашние задания могут быть: устными или письменными; обычными или программированными; долгосрочными или краткосрочными; требовать от студентов различных усилий мысли (репродуктивные, конструктивные, творческие).\n\t• Седьмой этап. Рефлексия (подведение итогов занятия)\n\tРефлексия — самоанализ и самооценка своей деятельности. Если говорить о рефлексии как этапе урока, то это оценивание своего состояния, эмоций, результатов своей деятельности на занятии.\n\t";
                    LessonCompleteRichBox.Text += text1;
                    switch (LessonPoint2X)
                    {
                        case 1:
                            LessonCompleteRichBox.Text += "\tВиды урока-суда\r\nСуществует два варианта использования данной ролевой игры: полная и частичная. Полное судебное заседание подразумевает один судебный процесс, занимающий все урочное время. Частичный предполагает сразу несколько упрощенных судебных разбирательств в рамках одного урока.\r\n\"Мини-суд\" на уроке\r\nДля проведения урока выбираются сразу несколько микро-тем, которые предстоит обсудить.\r\nДля каждого судебного дела отбираются по три участника: судья, прокурор и адвокат. Каждое судебное заседание длится не более 5-8 минут.\r\nТакой вид урока удобен, когда ребятам нужно решить несколько вопросов по одной теме. Например, изучается тема \"Семейное право\". Ученикам можно предложить сразу несколько ситуаций, требующих судебного вмешательства: развод, исполнение брачного договора, истребование алиментов на ребенка и т.д. Небольшие импровизированные \"суды\" помогут не только показать разнообразие возможных конфликтов, но и более прочно закрепить знание семейного кодекса.\r\nТеперь рассмотрим, как провести урок-суд в полном масштабе.\r\nУрок-суд: подготовка и реализация\r\nВесь процесс удобнее разделить на два этапа: этап подготовки и этап реализации.\r\nI. Подготовка к уроку\r\nПодготовительный этап к такому уроку занимает достаточно много времени, так как необходимо не только распределить роли, но и подготовить \"следственный материал\".\r\n•\tПостановка проблемы и цели урока.\r\nРоль игровых судов в том, чтобы прийти к общему мнению по поставленной проблеме. Здесь не так важен вердикт с точки зрения \"виновен — не виновен\", сколько важно найти ответы на поставленные вопросы и достичь главной цели урока.\r\nТак, для литературного суда целью чаще всего выбирают \"характеристику героя\". Например, почему Печорина стоит причислить к \"лишним людям\"?\r\nМожно выбрать другую цель: \"Главная проблема произведения\". Например, для урока-суда по тексту Н. Лескова \"Леди Макбет Мценского уезда\" взять за гипотезу: \"Можно ли оправдать преступление, совершенное во имя любви?\"\r\nНа уроках истории роль главных героев урока-суда чаще всего отводят выдающимся политикам, государственным деятелям. Цели таких уроков могут быть разнообразными:\r\n•\tвыявить положительные и отрицательные стороны деятельности / политики;\r\n•\tпроанализировать поступки / политику того или иного деятеля с точки зрения современности;\r\n•\tпроанализировать деятельность героя с точки зрения сложившейся исторической обстановки и т.д.\r\nВ роли \"обвиняемого\" иногда выступает не личность, а явление, или группа людей. Например, можно проводить уроки \"Суд над наркоманией\", \"Суд над рабством\", \"Суд над декабристами\" и т.д. В этом случае в качестве цели урока можно выбрать следующие: \"оценка явления с точки зрения современности\", \"анализ пагубности / пользы явления\" и т.д.\r\nНе стоит думать, что урок-суд удобно проводить лишь в рамках гуманитарных предметов. Для точных наук тоже можно найти немало вариантов. Например, \"Суд над обыкновенными дробями\" (цель: доказать значение дробей в математической науке), \"Суд над логарифмами\" (цель: дать обзорное представление о логарифмах числа и логарифмической линейке). По химии: \"Суд над кислородом\" (или любым другим химическим элементом), в ходе которого в игровой форме постигаются свойства этого элемента и его роль в таблице Менделеева, его значение для человеческой деятельности, сферы его применения. По географии \"Суд над природой\" (цель: изучить виды стихийных действий и причины их возникновения), \"Суд над человечеством\" (цель: обсудить важнейшие проблемы экологии и пути их искоренения).  \r\nТаким образом, выбор \"обвиняемого\" зависит от фантазии педагога. Важнее другое — четко сформулировать проблему и цель урока-суда.\r\n•\tРаспределение ролей.\r\nВажно, чтобы в процессе были задействованы все обучающиеся. Поэтому, желательно подбирать такую тему, чтобы ситуация охватывала как можно больше студентов.\r\nВозможные роли:\r\n•\tОбвиняемый;\r\n•\tПотерпевший;\r\n•\tСудья;\r\n•\tПрисяжные заседатели;\r\n•\tСекретарь суда;\r\n•\tОбвинитель (прокурор);\r\n•\tПомощники прокурора;\r\n•\tЗащитник (адвокат);\r\n•\tПомощники адвоката;\r\n•\tСвидетели обвинения;\r\n•\tСвидетели защиты;\r\n•\tНезависимые эксперты.\r\n\r\nРоли обучающиеся выбирают, по возможности, самостоятельно, ориентируясь на свои убеждения, желания и отношение к поставленной проблеме.\r\n•\tРабота с классом.\r\nЕсли урок-суд проводится впервые, то педагог должен объяснить, как проходит судебный процесс, растолковать, в чем заключается роль каждого из участников. Желательно предоставить схему планируемого урока, чтобы ребята могли сориентироваться и по времени, и по ходу действия.\r\nПример схемы урока:\r\nВступительное слово судьи: представление героев \"суда\", представление обвиняемого и подзащитного, объявление главной проблемы (цели урока).\r\n•\tОбвинительная речь прокурора.\r\n•\tВыступление независимых экспертов.\r\n•\tВыступление свидетелей обвинения.\r\n•\tРечь защитника.\r\n•\tВыступления свидетелей защиты.\r\n•\t\"Последнее слово\" обвиняемого.\r\n•\tСовещание судей.\r\n•\tПриговор.\r\n•\tПодведение итогов (рефлексия).\r\n\r\nРабота в группах.\r\nНа этом этапе удобнее объединить участников будущего процесса в три группы: обвинение, защита, независимые эксперты. Здесь начинается самая интересная и самая объемная часть работы — поиск улик и доказательств. Если это литературный суд, то обязательно цитирование текста произведения. Можно привлечь альтернативные источники — критические статьи, рецензии и дневники автора. Если суд исторический, то подробно изучаются научные статьи и гипотезы, мнения авторитетных ученых.\r\nЗатем участники групп обсуждают те моменты, которые кажутся им наиболее убедительными, подчеркивающими и доказывающими их правоту. Здесь учителю важно направить работу каждой группы, по возможности объяснить, как должна строиться защита или обвинение.\r\nИндивидуальная работа.\r\nКаждый участник будущего процесса составляет план своего выступления, готовит вопросы для оппонентов.\r\nРоль педагога на данном этапе сводится к консультированию. Можно подсказать студентам дополнительные источники информации, скорректировать их поиск, помочь с составлением плана выступления. Но важно, чтобы работа проводилась по большей части самостоятельно.\r\nОсобенно важная роль отводится судье. В ходе процесса судья должен не просто выслушивать мнения героев, но и обязательно задавать вопросы. Причем вопросы не обязательно должны быть уточняющими — по поводу каких-то деталей или несущественных мелочей. Хорошо, если получится задавать вопросы провокационные, заставляющие задуматься: \"А правильно ли я выбрал роль в процессе?\" Такие вопросы должны заставлять искать ответ не в тексте, а в жизненной позиции каждого участника, то есть учить детей анализировать материал, вырабатывать и отстаивать свою точку зрения.\r\nЭтап реализации\r\nДля урока желательно расставить мебель в комнате таким образом, чтобы воссоздать обстановку судебного зала: отдельные места для защиты и обвинения, скамья подсудимого, верховное место судьи.\r\nВажно!\r\nСледует четко следовать намеченному плану проведения судебного заседания. То есть, если для речи прокурора, например, отведено 3 минуты, то важно придерживаться этого времени и не давать студенту растекаться мыслью по древу.\r\nУрок-суд не предполагает обмена мнениями. Цель уроков — другая: в ходе дискуссии прийти к единому мнению по поставленной проблеме.\r\nДля воссоздания \"полной картины\" желательно придерживаться форм обращения, принятых в суде (Ваша честь, господин прокурор / адвокат, \"Встать! Суд идет!\", \"Слово предоставляется…\" и т.д.). Можно ввести и моменты приведения свидетелей к присяге. Но, если такие мелочи занимают много времени, их лучше пропустить, оставив лишь общую фабулу процесса.\r\nНе стоит забывать и о техническом оснащении. Например, можно рекомендовать ученикам использовать в своих выступлениях наглядные материалы, презентации, схемы, графики и т.д.\r\nЗавершающий этап урока является одним из основных. После того, как вынесен приговор, необходимо проанализировать итоги урока, то есть провести рефлексию.\r\nПри этом важно учесть следующие моменты:\r\n•\tстепень активности обучающихся и степень их подготовленности;\r\n•\tиспользование дополнительной информации, продуктивность самостоятельной работы;\r\n•\tоценка обучающимися итогов урока: согласны или нет с вердиктом?\r\n•\tоценка обучающимися степени \"интересности\" и познавательности такой формы урока.\r\n";
                            break;
                        case 2:
                            LessonCompleteRichBox.Text += "\tДля достижения поставленных целей в современных условиях актуально проведение занятий с использованием экскурсий.\r\n Производственные или учебные экскурсии (ПЭ) - это одна из многочисленных форм профориентационной работы с учащимися. Они имеют большое образовательное, политехническое и воспитательное значение.\r\nПЭ служит формой наглядного ознакомления учащихся с техникой и технологией, организацией производства, содержанием труда, условиями труда и пр.\r\nВ основном ПЭ рассматриваются как средство формирования и развития у студентов интереса к различным профессиям. Однако ПЭ - это не только одна из форм внеурочной деятельности педагога по оказанию помощи студентам в их профессиональном самоопределении. ПЭ предусматриваются и учебными программами.\r\nОсновная цель ПЭ - расширение политехнического образования студентов . Экскурсия на какое-либо предприятие, проводимая в органичной связи с содержанием учебных дисциплин, показывает неразрывную связь теории и практики в производственной деятельности людей.\r\n\r\nЭкскурсия (от лат. excursio — прогулка, поездка) — коллективное посещение музея, достопримечательного места, выставки, предприятия и т.п.; поездка, прогулка с образовательной, научной, спортивной или увеселительной целью.\r\nУчебная экскурсия — это проведение учебного занятия в условиях производства, природы, музея с целью наблюдения и изучения студентами различных объектов и явлений действительности.\r\n Являясь самостоятельной формой обучения, экскурсия входит важной составной частью в систему учебно-воспитательной работы и вносит свой весомый вклад в формирование всесторонне развитой личности.\r\nПеред экскурсиями ставятся такие задачи: обогащать знания студентов  (на основе непосредственного восприятия, накопления наглядных представлений и фактов); устанавливать связи теорий с практикой, с жизненными явлениями и процессами; развивать творческие способности студентов (учащихся), их самостоятельность, организованность в учебном труде, чувства коллективизма и взаимопомощи; обогащать эстетические чувства; развивать наблюдательность, память, мышление, эмоции; активизировать познавательную и практическую деятельность; воспитывать положительное отношение к учению. Экскурсия дает широкие возможности для более полного, комплексного использования методов обучения (и в первую очередь проблемных).\r\nВажнейшее назначение учебных экскурсий заключается в выявлении жизненности и актуальности учебного материала, в закреплении и конкретизации знаний, полученных на уроках, в применении знаний и умений на практике. Наглядность — существеннейший признак учебной экскурсии: удельный вес зрительной и слуховой наглядности в получении информации на экскурсии составляет более 70 процентов. Благодаря наглядности студенты (учащиеся) быстрее усваивают знания, которые затем на учебных занятиях становятся опорным фактическим материалом при восприятии новой темы, при обобщении и формировании соответствующих выводов. Экскурсионные наблюдения используются также для проверки, исправления, уточнения уже имеющихся у студентов (учащихся) знаний и представлений, для обогащения их новыми конкретными данными. Так, на экскурсии на промышленное или сельскохозяйственное предприятие происходит наглядное знакомство с практической деятельностью людей, с непосредственным использованием научных знаний, основы которых изучаются на занятии, формируются представления о производственных процессах, организации производства, отношениях в коллективе.\r\nНаблюдая и познавая явления общественной жизни, студенты (учащиеся) сами готовятся к активному участию в различных сферах общественно полезной деятельности.\r\nСтуденты (учащиеся) должны быть осведомлены о развитии и достижениях современной науки и техники.  К сожалению не урок, не факультатив, не просмотр научно- популярного фильма или специальной телепередачи не оказывает на студентов (учащихся) такого влияния, как полное впечатлений непосредственное соприкосновение с технологическим процессом производства. Во время экскурсии студенты (учащиеся) переносят знания в новую ситуацию, открывают для себя новые способы решения познавательных задач.( см. приложение).\r\n В зависимости от типа, содержания и метода проведения экскурсии, возраста студентов (учащихся), местных условий и вида передвижения в состав экскурсионной группы может входить от десяти до сорока студентов.\r\nДлительность учебной экскурсии  определяется в зависимости от учебных задач, конкретных условий проведения.\r\nКаждая экскурсия связана с учебным материалом разных дисциплин\r\nпо профессиям.\r\nЭтапы подготовки экскурсии\r\n \r\n1.     Определение цели и задачи экскурсии.\r\n2.     Выбор темы.\r\n3.     Отбор и изучение экскурсионных объектов.\r\n4.     Составление маршрута экскурсии.\r\n5.     Разработка заданий для учащихся.\r\n6.     Составление методической разработки.\r\n Цель экскурсии: наглядное ознакомление студентов (учащихся) с техникой и технологией , организации с/х  производства.\r\nЗадачи экскурсии:\r\n1. обогащать знания студентов (учащихся) на основе непосредственного восприятия, накопления наглядных представлений и фактов;\r\n2. устанавливать связи теорий с практикой, с жизненными явлениями и процессами\r\n3. развивать творческие способности студентов (учащихся),\r\n4. развивать самостоятельность, организованность в учебном труде, чувства коллективизма и взаимопомощи;\r\n5. развивать наблюдательность, память, мышление, эмоции;\r\n6.активизировать познавательную и практическую деятельность; воспитывать положительное отношение к учению. \r\n В процессе подготовки экскурсии при отборе объектов проводится их оценка по следующим показателям (критериям):\r\n1.     познавательная ценность;\r\n2.     известность (популярность);\r\n3.     месторасположение.\r\nПо мере сбора сведений об объекте студентам (учащимся) рекомендуется составить портфолио, в которое вносятся следующие сведения:\r\n1.     наименование объекта;\r\n2.     завод-изготовитель;\r\n3.     техническая характеристика.\r\n4.     назначение и место в технологическом процессе;\r\n5.     особенности конструкции\r\n\r\nПроведение экскурсии.\r\nРазбивка на группы( по 4-5 человек);\r\nВыдача заданий по объектам;\r\nИнструктаж;\r\nСбор информации согласно выданным заданиям.\r\nОбработка собранного материала.\r\nПодготовка к конференции:  презентация, фильм, репортаж, фотообозрение, доклад, плакаты и т. д\r\n";
                            break;
                        case 3:
                            LessonCompleteRichBox.Text += "\tКак подготовить урок-конференцию?\r\nПодготовка к такому уроку проходит в несколько этапов, чаще всего в четыре.\r\nЭтап 1\r\nНа первом этапе педагог выбирает тему урока-конференции и рассматривает целесообразность рассмотрения того или иного материала студентам. Эти выступления — своего рода мини-проекты, работа над которыми занимает обычно одну - две недели.\r\nИтак, на первом этапе педагог выбирает общую тему и размышляет над тем, какие мини-темы он может предложить студентам. Это могут быть биографии известных лиц, история открытий, варианты применения физического закона и тому подобное.\r\nЭтап 2\r\nНа втором этапе педагог подбирает необходимые материалы — те, которые он порекомендует студентам. По каждой теме он, по возможности, стремится порекомендовать несколько источников, среди них книги, периодические издания и интернет-ресурсы.\r\nЭтап 3\r\nНа третьем этапе педагог предлагает школьникам темы. Чаще всего педагог сам делит студентов на группы, которые будут готовить свои выступления. Каждая группа получает свое задание и рекомендации по его выполнению. Можно поручить группам самим выбрать тему из большого списка; можно предложить вытянуть жребий; наконец, педагог сам может предложить тему каждой конкретной группе. Этот вопрос нужно решать в зависимости от возможностей класса и особенностей психологии, а также с учётом специфики темы.\r\nЖелательно сразу оговорить форму подачи информации от каждой группы и регламент.\r\nОбсуждая форму, следует обратить внимание студентов на то, что скучно слушать сухие факты, что чтение с листа неинтересно, и сразу предложить подготовить рассказ, а не чтение реферата.\r\nЕсть смысл также оговорить, что необходим какой-нибудь интерактивный элемент: мини-тест, небольшая викторина, игра на одну-две минуты, какое-то творческое задание для слушателей. Надо также решить, будут ли докладчики выступать с компьютерными презентациями или оформлять стенды, плакаты, стенгазеты.\r\nЭтап 4\r\nНа четвертом этапе педагог консультирует конкретные группы ребят.\r\nВажно! Следует обратить внимание на то, что в конце урока обязательно должны подводиться итоги.\r\nОднако эти итоги могут быть не окончательными. Если класс достаточно большой доклады едва ли могут быть слишком короткими. Семь, а то и десять минут — это, наверное, минимум по какой-либо серьёзной теме, а значит, все присутствующие на конференции выступить не смогут.\r\nЧтобы остальные студенты, которые в этот раз не участвуют в конференции, не скучали, им следует подготовить опросные листы для голосования. На основании этих опросных листов участникам конференции могут добавляться дополнительные баллы или может выдаваться приз зрительских симпатий.\r\nЗалог успеха\r\nЧтобы подготовить успешный урок-конференцию, необходимо несколько составляющих.\r\n•\tВо-первых, это тщательная проработка темы и всех ее особенностей педагогом. Он должен удачно разработать систему, четко поставить перед учениками задачу, составить разумный план.\r\n•\tВо-вторых, студенты должны быть достаточной степени мотивированы на тщательную подработку своей темы; если мотивация обучающихся низкая, то интересного и продуктивного урока ожидать не приходится.\r\n•\tНаконец, важно четкое следование регламенту, объективная оценка выступлений, конкретные требования, которые должны неукоснительно выполняться; это касается и длительности выступлений, и оформления их, и выставления оценок, и использования опросника.\r\nЕще одним секретом успеха является соответствующее оформление кабинета для проведения такого урока. У выступающих должны быть бейджики, листы в папке. У членов жюри (если они есть) и у студентов, которые не участвуют в выступлении, а заполняют опросники, должны быть опознавательные знаки (хотя бы те же бейджики с надписью «Эксперт»).\r\nЕсли урок-конференция проводится в форме деловой игры и участники изображают представителей других стран (или других цивилизаций, например), то также желательно использование соответствующих атрибутов. Неплохо, если на уроке снимается видео: это придаст мероприятию солидности и потренирует студентов не бояться камеры. Создать соответствующий настрой, который поможет студентам воспринять урок не как рутинное мероприятие, а как нечто необычное, — это немалая часть успеха.\r\n";
                            break;
                        case 4:
                            LessonCompleteRichBox.Text += "\t«Деловая игра» - эффективна в том случае, если педагоги имеют достаточные знания по проблеме, которая отражается в игре. Она предполагает большую предварительную работу, в которой педагоги получают необходимые знания через различные формы, методы и средства:\r\n•\tнаглядную агитацию,\r\n•\tтематические выставки,\r\n•\tконсультации,\r\n•\tбеседы,\r\n•\tобсуждения.\r\nДеловая (ролевая) игра – эффективный метод взаимодействия педагогов. Она является формой моделирования тех систем отношений, которые существуют в реальной действительности или в том или ином виде деятельности, в них приобретаются новые методические навыки и приемы.\r\nДеловая игра – это форма совершенствования развития, восприятие лучшего опыта, утверждения себя как педагога во многих педагогических ситуациях. Необходимое условие эффективности деловой игры – добровольное и заинтересованное участие всех педагогов, открытость, искренность ответов, их полнота.\r\nЗаранее готовятся карточки с вопросами или 2-3 педагогическими ситуациями по проблеме.\r\nСтолы необходимо расставить так, чтобы выделилось 2 или 3 команды (на усмотрение руководителя МО) по 4-5 человек участников деловой игры. Педагоги по желанию рассаживаются за столы, и тем самым сразу определяются команды участников. Одна из команд – эксперты судьи – это наиболее компетентные педагоги по предлагаемой проблеме.\r\nКаждой команде вручается карточка, выбирается капитан, который будет оглашать общий вывод команды, работая над заданием. Командам дается время для подготовки решения, затем заслушиваются ответы. Порядок ответов определяется жребием капитанов. Каждой группой вносится не менее 3-х дополнений отвечающей группе, ставится поощрительный балл, который входит в общий счет очков. В конце игры определяется команда – победитель за лучший (обстоятельный, полный, доказательный) ответ.\r\nДеловые игры бывают следующих видов:\r\n•\tимитационные, где осуществляется копирование с последующим анализом.\r\n•\tуправленческие, в которых осуществляется воспроизведение конкретных управленческих функций);\r\n•\tисследовательские, связанные с научно-исследовательской работой, где через игровую форму изучаются методики по конкретным направлениям;\r\n•\tорганизационно-деятельные. Участники этих игр моделируют раннее неизвестное содержание деятельности по определенной теме.\r\n•\tигры-тренинги. Это упражнения, закрепляющие те или иные навыки;\r\n•\tигры проективные, в которых составляется собственный проект, алгоритм каких-либо действий, план деятельности и осуществляется защита предложенного проекта.\r\n\r\nПримером проективных игр может быть тема: «Как провести итоговый педсовет?» (или родительское собрание, или практический семинар и другое).\r\nПри организации и проведении деловой игры роль руководителя игры различна – до игры он инструктор, в процессе ее проведения – консультант, на последнем этапе – руководитель дискуссии.\r\nОсновная цель игры – живое моделирование образовательно-воспитательного процесса, формирование конкретных практических умений педагогов, более быстрая адаптация к обновлению содержания, формирование у них интереса и культуры саморазвития; отработка определенных профессиональных навыков, педагогических технологий.\r\nМетодика организации и проведения:\r\nПроцесс организации и проведения игры можно разделить на 4 этапа:\r\nКонструирование игры:\r\nчетко сформировать общую цель игры и частные цели для участников;\r\nразработать общие правила игры.\r\n•\tОрганизационная подготовка конкретной игры с реализацией определенной дидактической цели:\r\n•\tруководитель разъясняет участникам смысл игры, знакомит с общей программой и правилами, распределяет роли и ставит перед их исполнителями конкретные задачи, которые должны быть ими решены;\r\n•\tназначаются эксперты, которые наблюдают ход игры, анализируют моделируемые ситуации, дают оценку;\r\n•\tопределяют время, условия и длительность игры.\r\n•\tХод игры.\r\n•\tПодведение итогов, подробный анализ игры:\r\n•\tобщая оценка игры, подробный анализ, реализация целей и задач, удачные и слабые стороны, их причины;\r\n•\tсамооценка участниками исполнения полученных заданий, степень личной удовлетворенности;\r\n•\tхарактеристика профессиональных знаний и умений, выявленных в процессе игры;\r\n•\tанализ и оценка игры экспертами.\r\nКритерием для такой оценки может служить количество и содержательность выдвинутых идей (предложений), степень самостоятельности суждений, их практическая значимость.\r\nВ заключении руководитель подводит итог игры.\r\n";
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
                    LessonCompleteRichBox.Text = "\tТакому уроку в свете нового ФГОС придается особое значение, поскольку он помогает обучающимся «разложить все по полочкам».  \r\n• На первом этапе (мотивационном) стоит обсудить, зачем необходима систематизация знаний. Уместны будут такие образы, как кладовая, книгохранилище и т.п. По какому принципу мы разложим там наши знания? На какую полочку попадет то, что мы изучили? Какая часть информации будет востребована особенно часто? \r\n• Затем проводится повторение на другом качественном уровне: обучающимся предлагаются вопросы в нестандартной формулировке или с необычным условием. \r\n• Контроль (в соответствии с ФГОС – лучше самоконтроль) проводится тоже с акцентом на обобщение (если ты неправильно решишь эту часть задачи, это отразится – на чем?). Цель работы – не только обобщить, но вписать полученную информацию в контекст общих знаний ученика о мире. \r\n• Особенно важно на таком уроке тщательно проработать этап рефлексии и проговорить на нем как принципы классификации, так и значение материала, его место в системе знаний.\r\n";
                    LessonCompleteRichBox.Text += text1;
                    switch (LessonPoint2X)
                    {
                        case 1:
                            LessonCompleteRichBox.Text += "\tЦель — освоение какой-либо небольшой темы в течение только одного академического часа. Другое дело, что компоненты урока могут идти в разной последовательности в зависимости от темы и особенностей класса.\r\nПример плана комбинированного урока можно представить себе так:\r\n1.\tЗагадка, намекающая на тему урока.\r\n2.\tПостановка проблемы, формулировка темы и задачи урока.\r\n3.\tПроверка домашнего задания.\r\n4.\tПовторение изученного на прошлых уроках.\r\n5.\tУсвоение нового материала.\r\n6.\tОтработка.\r\n7.\tКонтроль.\r\n8.\tОбъяснение домашнего задания.\r\n9.\tРефлексия.\r\nРазумеется, возможны различные варианты, план комбинированного урока позволяет части его переставлять в соответствии с дидактической задачей, вместо загадки, можно предложить детям задачу или проблему, какую-нибудь игру и т.п.\r\nВарианты начала урока:\r\n•\tсообщение о какой-то памятной дате, имеющей (или даже нет) отношение к предмету (день рождения писателя, композитора, политического деятеля; годовщина исторического события, открытия, выхода в свет книги);\r\n•\tзагадка или необычный факт в форме новости;\r\n•\tотрывок из литературного произведения или афоризм;\r\n•\tобщий комплимент классу и т.п.\r\n•\t\r\nМетодика проведения комбинированного урока по ФГОС требует от педагога, по возможности, не сообщать тему урока, а предлагать догадаться самим. Причем одновременно ценность новых знаний необходимо обосновать.\r\nВ связи с этим обычно рекомендуется начинать объяснение проблемной задачей. Суть приема в том, что студентам предлагается решить задачу, или предсказать результат опыта, или предположить, как пишется какое-то слово и т.п. Подбирается материал таким образом, чтобы для правильного ответа требовались именно те знания, которые планируется изучать на текущем уроке.\r\nПланируя комбинированный урок, крайне важно оставить достаточно времени на этап выработки навыка применения полученных знаний на практике. Причем желательно придумывать такие задания, которые будут стимулировать творческую активность школьников. Хорошо также дать задания, позволяющие использовать полученные знания в нестандартных условиях, взглянуть на материал под другим углом.\r\nОднако, предлагая учащимся практическую работу, необходимо сначала удостовериться, что весь теоретический материал ими усвоен. Поэтому хорошо, если практике предшествует небольшой устный опрос, позволяющий «начерно» оценить степень осознания материала. Но при этом не надо забывать, что без практики теоретический материал мертв и все равно не может быть до конца осознан.\r\nНа этом этапе хорошим решением станет выполнение образцового задания на доске и последующая самостоятельная работа учащихся с разноуровневыми карточками, причем слабым ученикам предлагаются задания, максимально совпадающие с образцовым, а более сильным — в большей или меньшей степени отличающиеся от него, чтобы простимулировать творческий подход к работе. Желательно также создать ситуацию успеха, поэтому не следует предлагать слишком сложные задания. Да и времени на их обдумывание на комбинированном уроке слишком мало.\r\nМожно провести закрепление в виде какой-либо игры, индивидуальной или командной. Неплохо зарекомендовали себя приемы, требующие логики и творческого подхода:\r\n•\tОбщее – уникальное.\r\n•\tЦепочка соответствий.\r\n•\tШесть шляп.\r\n•\tКейсы\r\n•\tИ т.д.\r\nМожно дать небольшую проверочную работу, например, с использованием перфокарт.\r\nПри анализе комбинированного урока следует обратить внимание на то же, что и при разборе любого другого урока. Указав вид урока — комбинированный — отдельно анализируются его этапы. Характеристика комбинированного урока включает в себя разбор как отдельных приемов, так и урока в целом.\r\nКомбинированный тип урока — хорошо зарекомендовавшая себя на протяжении долгого времени форма урока, поистине бессмертная, благодаря своей универсальности и удобству для любого класса и предмета. Не стоит отказываться от него, несмотря на обилие новых форм и технологий — гибкость и поливариантность такого урока предлагает широкие возможности для использования новых приемов в его структуре.\r\n";
                            break;
                        case 2:
                            LessonCompleteRichBox.Text += "\t«Деловая игра» - эффективна в том случае, если педагоги имеют достаточные знания по проблеме, которая отражается в игре. Она предполагает большую предварительную работу, в которой педагоги получают необходимые знания через различные формы, методы и средства:\r\n•\tнаглядную агитацию,\r\n•\tтематические выставки,\r\n•\tконсультации,\r\n•\tбеседы,\r\n•\tобсуждения.\r\nДеловая (ролевая) игра – эффективный метод взаимодействия педагогов. Она является формой моделирования тех систем отношений, которые существуют в реальной действительности или в том или ином виде деятельности, в них приобретаются новые методические навыки и приемы.\r\nДеловая игра – это форма совершенствования развития, восприятие лучшего опыта, утверждения себя как педагога во многих педагогических ситуациях. Необходимое условие эффективности деловой игры – добровольное и заинтересованное участие всех педагогов, открытость, искренность ответов, их полнота.\r\nЗаранее готовятся карточки с вопросами или 2-3 педагогическими ситуациями по проблеме.\r\nСтолы необходимо расставить так, чтобы выделилось 2 или 3 команды (на усмотрение руководителя МО) по 4-5 человек участников деловой игры. Педагоги по желанию рассаживаются за столы, и тем самым сразу определяются команды участников. Одна из команд – эксперты судьи – это наиболее компетентные педагоги по предлагаемой проблеме.\r\nКаждой команде вручается карточка, выбирается капитан, который будет оглашать общий вывод команды, работая над заданием. Командам дается время для подготовки решения, затем заслушиваются ответы. Порядок ответов определяется жребием капитанов. Каждой группой вносится не менее 3-х дополнений отвечающей группе, ставится поощрительный балл, который входит в общий счет очков. В конце игры определяется команда – победитель за лучший (обстоятельный, полный, доказательный) ответ.\r\nДеловые игры бывают следующих видов:\r\n•\tимитационные, где осуществляется копирование с последующим анализом.\r\n•\tуправленческие, в которых осуществляется воспроизведение конкретных управленческих функций);\r\n•\tисследовательские, связанные с научно-исследовательской работой, где через игровую форму изучаются методики по конкретным направлениям;\r\n•\tорганизационно-деятельные. Участники этих игр моделируют раннее неизвестное содержание деятельности по определенной теме.\r\n•\tигры-тренинги. Это упражнения, закрепляющие те или иные навыки;\r\n•\tигры проективные, в которых составляется собственный проект, алгоритм каких-либо действий, план деятельности и осуществляется защита предложенного проекта.\r\n\r\nПримером проективных игр может быть тема: «Как провести итоговый педсовет?» (или родительское собрание, или практический семинар и другое).\r\nПри организации и проведении деловой игры роль руководителя игры различна – до игры он инструктор, в процессе ее проведения – консультант, на последнем этапе – руководитель дискуссии.\r\nОсновная цель игры – живое моделирование образовательно-воспитательного процесса, формирование конкретных практических умений педагогов, более быстрая адаптация к обновлению содержания, формирование у них интереса и культуры саморазвития; отработка определенных профессиональных навыков, педагогических технологий.\r\nМетодика организации и проведения:\r\nПроцесс организации и проведения игры можно разделить на 4 этапа:\r\nКонструирование игры:\r\nчетко сформировать общую цель игры и частные цели для участников;\r\nразработать общие правила игры.\r\n•\tОрганизационная подготовка конкретной игры с реализацией определенной дидактической цели:\r\n•\tруководитель разъясняет участникам смысл игры, знакомит с общей программой и правилами, распределяет роли и ставит перед их исполнителями конкретные задачи, которые должны быть ими решены;\r\n•\tназначаются эксперты, которые наблюдают ход игры, анализируют моделируемые ситуации, дают оценку;\r\n•\tопределяют время, условия и длительность игры.\r\n•\tХод игры.\r\n•\tПодведение итогов, подробный анализ игры:\r\n•\tобщая оценка игры, подробный анализ, реализация целей и задач, удачные и слабые стороны, их причины;\r\n•\tсамооценка участниками исполнения полученных заданий, степень личной удовлетворенности;\r\n•\tхарактеристика профессиональных знаний и умений, выявленных в процессе игры;\r\n•\tанализ и оценка игры экспертами.\r\nКритерием для такой оценки может служить количество и содержательность выдвинутых идей (предложений), степень самостоятельности суждений, их практическая значимость.\r\nВ заключении руководитель подводит итог игры\r\n";
                            break;
                        case 3:
                            LessonCompleteRichBox.Text += "\tЦелью урока-практикума является закрепление материала посредством заданий разной сложности. К его задачам относится:\r\n1.\tПроверка уровня освоенности темы.\r\n2.\tФормирование:\r\n•\tнавыка коллективной деятельности;\r\n•\tнавыка само- и взаимопроверки;\r\n•\tнавыка объективной само- и взаимооценки.\r\n1.\tРазвитие:\r\n•\tумения объяснять – связывать несколько мыслей в одну с применением принципов логики;\r\n•\tумения выделять главное в большом объеме информации.\r\n1.\tВоспитание:\r\n•\tкоммуникативности;\r\n•\tответственности, любви к труду;\r\n•\tуважительного отношения к другим людям, вне зависимости от того, что они говорят.\r\n1.\tПовышение интереса к предмету.\r\n2.\tПроявление творческих способностей.\r\nВиды урока-практикума\r\nЕсть несколько видов урока-практикума:\r\n•\tустановочные;\r\n•\tиллюстративные;\r\n•\tтренировочные;\r\n•\tисследовательские;\r\n•\tтворческие;\r\n•\tобобщающие.\r\nФормы урока-практикума\r\nИмеют место две формы урока-практикума:\r\n•\tпрактическая работа;\r\n•\tлабораторная работа.\r\nУрок-практикум в форме практической работы вырабатывает конструктивные умения, а урок-практикум в форме лабораторной работы – экспериментальные.\r\nПо поводу лабораторной работы, т.е. учебного эксперимента, следует отметить один важный момент. У него, в отличие от научного эксперимента, уже есть итог, правда, о нем не знают обучающиеся.\r\nТипы урока-практикума\r\nТипы урока-практикума:\r\n•\tурок-практикум углубления теории;\r\n•\tурок-практикум групповой обработки информации;\r\n•\tурок-практикум индивидуальной обработки информации;\r\n•\tурок-практикум контроля;\r\n•\tурок-практикум зачет;\r\n•\tурок-практикум комбинированного типа, сочетающий в себе несколько типов, например, урок-практикум группой обработки информации и урок-практикум зачет.\r\nПлан урока-практикума\r\nПлан урока-практикума включает в себя:\r\n1.\tСообщение темы, цели и задач урока-практикума.\r\n2.\tМотивация к уроку-практикуму.\r\n3.\tОзнакомление с планом и инструкциями урока-практикума.\r\n4.\tПодготовка учебной литературы и оборудования к уроку-практикуму.\r\n5.\tНепосредственное проведение урока-практикума.\r\n6.\tВыводу по уроку-практикуму.\r\nОрганизация урока-практикума\r\nПервое, что необходимо сделать для организации урока-практикума – конечно же, определиться с темой, целями и задачами. Далее:\r\n1.\tНемного ускориться в прохождении курса. Это необходимо для того, чтобы освободить как минимум два учебных часа на урок-практикум.\r\n2.\tНаписать план (для учителя) и инструкции (для учеников). Требования должны соответствовать уровню подготовки обучающихся: сильным следует давать сложные задания, а слабым более «лояльные».\r\n3.\tПодготовить учебную литературу и оборудование. Нехватку или отсутствие оборудования можно компенсировать творческим заданием или контрольной работой в письменном виде.\r\nИндивидуальный подход в организации урока-практикума\r\nНесмотря на то, что на рассматриваемом нами уроке используется групповой подход, это не отменяет другого – индивидуального подхода в виде:\r\n•\tвыполнении работы по образцу из учебника или с листа от педагога;\r\n•\tвыполнении работы с таблицами и схемами;\r\n•\tвыполнении работы с учебной литературой, в частности, словарями и справочниками.\r\nНа то, как пройдет урок-практикум, влияет, во-первых, уровень освоенности темы студентом и, во-вторых, опыт педагога. На таком уроке знания усваиваются намного лучше, так как складывается неформальная обстановка.\r\n";
                            break;
                        case 4:
                            LessonCompleteRichBox.Text += "\t•\tКонкурсный урок – это творческое учебное занятие по индивидуальному сценарию, режиссуре и содержанию, опирающееся на современные классические принципы обучения и воспитания учащихся\r\n•\tКонкурсный урок — это не просто современный урок, это особый урок, ибо он естественная часть предъявляемого взыскательной аудитории педагогического опыта.\r\n•\tВажно, чтобы урок был профессиональным! Проблемным! Важно, чтобы он был уроком взаимодействия, диалога!\r\n•\tКонкурсный урок должен быть иллюстрацией системы работы педагога, научных позиций, технологий, педагогических позиций, предъявленных в разных формах (эссе, обобщение опыта, статьи в журнал).\r\n•\tВажно, чтобы после урока у конкурсанта осталось ощущение праздника творческого единения с детьми, соавторами, соисполнителями задуманного.\r\n•\tБезусловно, конкурсный урок своеобразен по содержанию, ориентированному на незнакомых детей.\r\n•\tЗалог его успешности в умении поставить цель, определить задачи и педагогически грамотно подобрать нужные для их решения средства.\r\n•\tУчителю-конкурсанту необходимы и такие качества, как способность импровизировать, умение слушать и слышать незнакомых детей, чутко реагировать в диалоге на их вопросы и ответы.\r\n•\tЗаметим, что не менее важны раскованность и сдержанность, спокойствие, умение ориентироваться в реальной, порой непред-сказуемой ситуации, управлять своим творческим самочувствием.\r\n\r\nПри всем различии предметов и образовательных областей для оценки каждого конкурсанта к ним предъявляются обязательные требования, которые ежегодно входят в критерии оценки:\r\n•\tГлубокое знание своего предмета.\r\n•\tНекорректное оперирование научными понятиями, небрежность, неточности, оговорки, речевая безграмотность недопустимы.\r\n•\tГрамотное, в соответствии с целями и задачами урока использование новых, современных, а иногда и традиционных, но работающих на результат, способов передачи знаний.\r\n•\tДопускается интерпретация описанных в педагогической литературе авторских методик (технологий), а еще лучше - предъявление собственной апробированной методики (технологии).\r\n•\tКоммуникативные способности, актерское и ораторское мастерство. К сожалению, педагогической техникой конкурсанты владеют явно недостаточно.\r\n•\tУмение достигать результата образовательной деятельности при любом уровне подготовленности класса. Ссылка на слабый уровень подготовки детей неуместна.\r\nОчевидно, что каждый предмет имеет свое образовательно-информационное поле и требует использования специфических методов, приемов и форм организации учебного занятия.\r\nОшибки при самоанализе урока, мероприятия\r\n•\tРедко бывает объективным со стороны участника;\r\n•\tЦениться объективный анализ, когда педагог констатирует, что получилось не так, как планировал, в каком месте отошёл от запланированного, т.к. урок пошёл не «по сценарию». Это говорит о мобильности педагога, его умении выйти достойно из непредвиденной ситуации;\r\n•\tРедко педагог аргументирует отбор содержания урока (занятия) – не просто, что по программе, а почему взят именно этот материал;\r\n•\tОт педагога больше ждут импровизации, а не только домашней заготовки, от которой учитель не может отойти.\r\n";
                            break;
                        case 5:
                            LessonCompleteRichBox.Text += "\tПодготовка к диспуту\r\n1. Выбор темы, ее утверждение. Можно провести анкети¬рование на темы: «Какие вопросы тебя особенно волнуют, и ты\r\nне находишь на них ответа?», «О чем бы ты хотел поспорить, поговорить откровенно с товарищами?» и др.\r\n2. Формулирование вопросов по выбранной теме. Реко¬мендуется сформулировать три-четыре вопроса, но чтобы они звучали проблематично. Например, существуют ли критерии современного человека? Быть современным — значит быть мод¬ным. Согласны ли вы с таким утверждением? и т.п.\r\n3. Собственно подготовительный период, главной задачей которого является изучение мнения коллектива по выдвинутым во¬просам, включает в себя следующие моменты: а) анкетирование по вопросам диспута; б) составление анкетных карточек, противопо¬ложных по мнению (с них-то можно и начать диспут: зачитать одну, потом — другую, попросить каждого доказать свое мнение по поводу выделенных точек зрения); в) изучение учащимися рекомендован¬ной литературы; г) инсценирование (или «модель») будущего дис¬пута: за несколько дней до диспута рекомендуется собрать несколь¬ко самых активных учащихся класса для выяснения их мнения по вопросам диспута. Это могут быть члены временной инициативной группы. Не навязывая своего мнения, педагог просит этих школьни¬ков подготовить более тщательно свои выступления для того, чтобы на диспуте они дали «толчок» для начала общего спора\r\nФормулировка темы должна быть острой, проблематичной, будить мысль учащихся, заключать в себе нравственную или эстетическую проблему, которая в жизни, в литературе решается по-разному, вызывает противоречивые суждения. Таким образом, педагогически ценной является такая тема диспута, которая взволнует учащихся, «заденет их за живое», привлечет внимание своей необычностью, новизной.\r\n-Прежде чем спорить, подумай, о чем будешь спорить.\r\n-Спорь честно и искренне, не искажай мыслей и слов своих товарищей.\r\n-Помни, что доказательством и лучшим способом опровержения являются точные и бесспорные факты.\r\n-Доказывая и опровергая, говори ясно, просто, отчетливо, точно.\r\n-Старайся говорить своими словами.\r\n-Если доказали ошибочность твоего мнения, имей мужество признать правоту своего «противника».\r\n— Заканчивай выступление, подведи итоги, сформулируй выводы.\r\nВ ходе обсуждения основной темы диспута обычно возникает немало вопросов, имеющих косвенное к ней отношение. В заключительном слове, давая обстоятельный и убедительный ответ на все вопросы, ведущий, ссылаясь на мнение выступающих, выделяет новые мировоззренческие и нравственные проблемы, ценные для воспитания учащихся. Таким образом, на диспуте учащиеся не только учатся спорить, думать, отстаивать свои убеждения, но и получают ответы на интересующие их вопросы, растут духовно.\r\nЗаключительное слово, желательно, чтобы было кратким, ярким и убедительным, так как оно произносится искренне и задушевно, страстно и доказательно, выслушивается с исключительным вниманием, запоминается надолго.\r\nТехнология диспута\r\nРазновидностью учебной встречи является диспут. Организация диспута, основанного на столкновении разных мнений, — сложное и ответственное дело. Успех диспута во многом определяется темой, заключающей в себе, как минимум, две разноречивые позиции. Педагог тщательно продумывает задачи диспута, его предполагаемое течение, возможные варианты и, главное, выводы, к которым учащиеся должны прийти в результате обсуждения. В ходе дискуссии необходимо следить за соблюдением правил ведения дискуссии.\r\nПравила проведения дискуссии\r\n1.\tДискуссия — это спор во имя истины; здесь важен обмен мнениями, основанными на конкретных фактах, аргументах, доказательствах, результатах исследований.\r\n2.\tДискуссия успешна, если все участники хорошо знают предмет обсуждения, не отвлекаются на другие проблемы.\r\n3.\tСопоставление своей и чужой точек зрения, опровержение неправильной должно быть этичным.\r\n4.\tНе обидь, не оскорби, не унизь человека — девиз всякой дискуссии.\r\n5.\tЧеловека уважают в споре уже за то, что он искренен, хотя и ошибается.\r\n6.\tДискуссия — это школа, вырабатывающая демократическое восприятие плюрализма мнений, отношений к поступку, действию.\r\nДиалог завершается принятием решения, при котором каждый из учеников берет на себя какую-то работу, дело, конкретное обязательство. Учитель — оказать профессиональную помощь типа консультации, собеседования; родители — создать максимально благоприятные для ребенка условия, подросток воспитать в себе волевые качества, предъявить к себе требования последовательно и постоянно заботиться о здоровье и вести здоровый образ жизни.\r\nОчень велика роль ведущего на диспуте. Он обязан предоставлять слово желающим, следить за соблюдением регламента, регулировать очередность выступлений и заботиться о том, чтобы накал встречи не спадал до конца.\r\nКак руководить дискуссией в группе\r\n1.\tПриглашать к участию стеснительных детей.\r\n2.\tНаправлять комментарии и вопросы одного ученика к другому.\r\n3.\tЕсли вы не уверены, что поняли то, что сказал ученик, значит и другие ученики тоже не смогли это понять.\r\n4.\tВытягивать больше информации.\r\n5.\tНе отвлекаться от предмета дискуссии.\r\n6.\tДавать время подумать над ответом: некоторые студенты легче высказываются, если предварительно записывают свои мысли.\r\n7.\tКогда студент заканчивает ответ, оглядеть класс, оценить реакцию других.\r\n";
                            break;
                        case 6:
                            LessonCompleteRichBox.Text += "\tПо содержанию можно выделить такие виды викторины:\r\n1) тематические\r\n2) развлекательно - развивающие\r\n3) лингвистические\r\n4) межтематические\r\nТематические викторины  используются наиболее часто. С помощью тематических викторин можно сообщить дополнительные сведения по какой-либо теме или обобщить ее изучение, проверить степень информированности студентов, их умение самостоятельно пользоваться рекомендованной преподавателем литературой, давать доказательные и точные ответы.\r\nРазвлекательно-развивающие викто¬рины способствуют развитию сообрази¬тельности, находчивости, гибкости мыш¬ления, логики. Часто используются кроссворды и различные вопросы.\r\nЛингвистические викторины способствуют самостоятельной работе обучающихся над языковым материалом, учат некоторым приёмам самостоятельной работы со словом, более внимательному отношению к различным языковым явлениям.\r\nМежтематические викторины выяв¬ляют разносторонние знания обучающихся; учат их обращаться друг к другу; внимательно относиться к тому, что каждый из них знает, умеет; способствуют взаимообо¬гащению в процессе обучения.\r\nВ числе основных требований к проведению викторин следующие:\r\n1)    четкая учебно-воспитательная направленность, ориентация обучающихся на информацию, представляющую общеобразовательную и практическую значимость;\r\n2)    актуальность и связь с жизнью;\r\n3)    доступность источников информации;\r\n4)    занимательность и новизна\r\n\r\nСтруктура викторины:\r\n1) вводная часть\r\n2) ра¬бота в группах\r\n3) заключительную часть\r\nВводная часть. Перед обучающимися ставится задача, они получают раздаточ¬ный материал, их информируют о после¬довательности видов деятельности в про¬цессе работы. Виды деятельности таковы: а) все команды получают одинаковую задачу и материал для выполнения в от-веденное время; б) материал у команд может быть разным (например, при проведении викторины о Германии можно предложить  командам разную тематику: одной команде — «Природа и климат страны», другой — «Население», третьей — «Экономика»); в) команды мо¬гут работать одновременно в отведенное время или же меняться для выполнения различных заданий; г) на викторине мо¬гут быть предусмотрены и индивидуаль¬ные конкурсы капитанов, консультантов; выбор представителя может быть сделан по решению команды.\r\nРабота в группах. На этом этапе обучающиеся знакомятся с материалом викторины, планируют работу и время, распределяют вопросы между членами команды, совместно обсуждают получен¬ный результат, дорабатывают и коррек¬тируют ответы.\r\nЗаключительная часть. Подводятся итоги работы, анализируется выполне¬ние заданий, дается оценка групповой и индивидуальной работы, проводится разбор типичных ошибок, акцентирует¬ся внимание на вопросах, вызвавших особые трудности. Этот этап позволяет преподавателю проконтролировать свою рабо¬ту, скорректировать планирование, наметить план по ликвидации пробелов.\r\n";
                            break;
                    }
                    break;
                case 4:
                    LessonCompleteRichBox.Text = "\tЖелательно обеспечить наличие разно уровневых заданий, а также возможность выбора задания для ученика (например, тест с заданиями разной бальной системы; оценка выставляется в зависимости от количества полученных баллов). На таком уроке, кроме образовательных задач (контроль знаний по теме или разделу), решаются также воспитательные (создание условий для формирования правильной самооценки; упорство в достижении цели) и развивающие (умение анализировать, сравнивать, классифицировать; если работа групповая, то и коммуникативные навыки).";
                    LessonCompleteRichBox.Text += text1;
                    switch (LessonPoint2X)
                    {
                        case 1:
                            LessonCompleteRichBox.Text += "\tПланирование деятельности по составлению тестов.\r\n1. Определить, с какой целью составляется тест.\r\n2. Просмотреть и изучить материал по теме в различных источниках (сеть Internet, энциклопедии, практические пособия, учебная литература).\r\n3. Просмотреть и выбрать форму теста.\r\n4. Определить количество вопросов в тесте.\r\n5. Составить вопросы и подобрать варианты ответов.\r\n6. Продумать критерии оценивания.\r\n7. Написать инструкцию к выполнению теста.\r\n8. Проверить орфографию текста, соответствие нумерации.\r\n9. Проанализировать составленный тест согласно критериям оценивания.\r\n10. Оформить готовый тест.\r\n11. Оформить бланк ответов к тесту.\r\nФормы тестовых заданий\r\n1. - задания закрытой формы, в которых выбирают правильный ответ из данного набора ответов к тексту задания;\r\n2. - задания открытой формы, требующие при выполнении самостоятельного формулирования ответа;\r\n3. - задание на соответствие, выполнение которых связано с установлением соответствия между элементами двух множеств;\r\n4. - задания па установление правильной последовательности, в которых требуется указать порядок действий или процессов, перечисленных в задании.\r\n \r\nОбщие рекомендации к составлению тестов\r\n· не следует прибегать к формулированию задания на воспроизведение, если вместо него может быть предложена каче¬ственная или количественная задача;\r\n· не следует стремиться к только словесному формирова¬нию вопросов. При использовании рисунков, схем, графиков и др. значительно сокращается текст вопроса и в то же время по¬вышается выразительность задачи;\r\n· предпочитайте в формулировках не констатацию фак¬тов, а выявление причинно-следственных связей;\r\n· прибегайте к формулировкам, побуждающим к система¬тизации и классификации явлений;\r\n· изыскивайте возможность формулировки задания, на¬правленного на установление общности и различия в явлениях;\r\n· избегайте однообразных формулировок;\r\n· чаще ставьте проблемы, помогающие решать задачи, с которыми приходиться сталкиваться в каждодневной работе.\r\nТребования при составлении теста:\r\n1) Строгое соответствие источникам информации, которы¬ми пользуются учащиеся (соответствие содержанию и объему полученной ими информации).\r\n2) Простота (задание должно требовать от испытуемого решения только одного вопроса).\r\n3) Однозначность задания (формулировка вопроса должна исчерпывающим образом разъяснять поставленную перед испы¬туемым задачу, причем язык и термины, способы и индексация обозначений, графические изображения и иллюстрации задания и ответов к нему должны быть безусловно и однозначно понятны всеми учащимися).\r\n4) Предпочтительнее подробный вопрос (задание) и лако¬ничные ответы.\r\n5)Идентичность всех ответов по форме, содержанию, объ¬ему, количеству представленных позиций.\r\n6) Оптимальное количество вариантов ответа — четыре-пять.\r\n7) Грамматическое и логическое соответствие ответов во¬просу (заданию).\r\n8) Совер¬шенно неприемлемы абсурдные, очевидно неправильные ответы.\r\n9) Обучающая функция теста возрастает, если необходимо отметить неправильный или негативный ответ, а также в случае, когда все ответы правильные, но один предпочтительнее по тем или иным критериям.\r\n \r\nСтруктура теста\r\nОбъем работы: 6-8 листов; нумерация страниц - снизу, справа;\r\n1 лист – титульный ;\r\n2 - 7 лист – содержание теста;\r\n8 лист – список используемой литературы\r\nОтметка: зачет / незачет\r\nКритерии оценивания: ²зачет² выставляется, если:\r\n- содержание теста соответствует заданной теме, выдержаны все требования к его оформлению;\r\n- основные требования к оформлению теста соблюдены, но при этом допущены недочеты, например: неточно и некорректно составлены вопросы (задания), имеются упущения в оформлении;\r\nзачет не выставляется, если:\r\n- вопросы или задания теста не соответствуют заданной теме, обнаруживается существенное непонимание проблемы;\r\n- тест обучающимся не представлен.\r\nКраткая характеристика программ для создания тестов:\r\nHotPotatoes – программа, предоставляющая преподавателям возможность самостоятельно создавать интерактивные задания и тесты для контроля и самоконтроля учащихся. С помощью программы можно создать 10 типов упражнений и тестов по различным дисциплинам с использованием текстовой, графической, аудио- и видеоинформации. В этой программе удобно составлять кроссворды, которые можно использовать в интерактивном и печатном варианте.\r\nhttp://hotpot.uvic.ca/\r\nADTester. С помощью ADTester возможна организация проведения тестирования в любых образовательных учреждениях. Тестирование может проводиться как с целью выявления знаний учащихся в той или иной области, так и для обучающих целей.\r\nhttp://www.adtester.org/\r\n«MyTest». Пакет программ для создания и проведения компьютерного тестирования, сбора и анализа результатов, выставления оценки по указанной в тесте шкале. С помощью программы MyTest возможна организация и проведение тестирования в любых образовательных учреждениях как с целью выявить уровень знаний по любым учебным дисциплинам, так и с обучающими целями.\r\nhttp://mytest.klyaksa.net/htm/download/index.htm\r\nKnowing. Программа позволяет создавать тесты и автоматически оценивать результаты тестирования. Эта программа проста в использовании. Но функции ограничены, например, можно составлять задания только с одним выбором ответа.\r\nhttp://www.globalpage.ru/download/\r\n";
                            break;
                        case 2:
                            LessonCompleteRichBox.Text += "\tБазовые правила при построении вопросов:\r\n•\t– респондент всегда прав;\r\n•\t– каков вопрос – таков и ответ.\r\nТребования к формулировке вопросов:\r\n•\t– ясность (понятность для респондента; нельзя включать сложную, непонятную для респондентов терминологию, понятия, которые способны затруднить восприятие респондентами);\r\n•\t– конкретность (не допускать двоякого толкования понятий или вопроса в целом);\r\n•\t– проблемность (прямая или косвенная направленность вопроса на интересующую корреспондента проблему, но формулировка не должна наводить на ответ);\r\n•\t– последовательность (значимо выстроить порядок вопросов так, чтобы они не шокировали респондента, а позволяли постепенно конкретизировать и подробно раскрывать ответы).\r\nИнтервью и беседа применяются как основной метод в структурированных исследованиях, при экспертном опросе, а также в этнологических экспедициях по заранее составленным опросникам. Беседа – основная форма повседневного взаимодействия людей друг с другом. Однако простое обыденное общение и беседа как метод исследования существенно отличны друг от друга по целеполаганию, процедуре проведения, форме фиксации.\r\nИнтервью – очный вид опроса. Интервью – встреча лицом к лицу. Буквальный перевод слова \"интервью\" – \"взгляд между\", т.е. взаимный обмен взглядами между двумя людьми, обсуждающими определенную тему, интересующую обоих. Отсюда специфика интервью – разговор, где присутствует определенная динамика и существует возможность обратной связи и уточнения непонятного (в отличие от анкеты). Ведущий принцип – вопросы исходят практически только от корреспондента, а ответы – от респондента.\r\nИнтервью требует специальной предварительной подготовки. Важна не только правильность формулировки вопроса, но и интонирование, последовательность вопросов, внешний вид корреспондента и многое другое. Но при интервью или беседе в отличие от анкеты можно наблюдать за реакциями на вопросы и невербальными компонентами общения, дающими зачастую очень много информации.\r\nВиды интервью:\r\n•\t1) стандартизованное (формализованное) – предполагаемые вопросы беседы формулируются заранее, и отход от них не допускается;\r\n•\t2) нестандартизованное (неформализованное, свободное) – обозначается только тема и ключевые вопросы интервью, вопросы формулируются и уточняются по ходу интервью;\r\n•\t3) фокусированное (направленное) – по поводу одного события, документа, явления и т.п.;\r\n•\t4) ненаправленное – неформализованное интервью на общие темы или по поводу разнохарактерных вопросов.\r\nТребования к интервью:\r\n•\t– не допускается подсказка (это влечет к увеличению субъективизма);\r\n•\t– нельзя проявлять чрезмерную настойчивость в опросе;\r\n•\t– важно учитывать культурный уровень интервьюера;\r\n•\t– важна организация единого социально-психологического пространства между корреспондентом и респондентом;\r\n•\t– а главное – корреспондент больше молчит, а респондент больше говорит, но не наоборот; важно не только уметь задать вопрос, но и уметь выслушать на него ответ.\r\nХарактер интервью также может различаться по типу вопросов:\r\n•\t– с точной и с неточной формулировкой вопроса;\r\n•\t– подготовленные заранее вопросы и вопросы, задаваемые по ходу интервью;\r\n•\t– общие и частные вопросы;\r\n•\t– наводящие и нейтральные вопросы.\r\nКроме того, выделяют следующие виды вопросов: вводные, отслеживающие, проясняющие, конкретизирующие, прямые, косвенные, структурированные, вопросы-интерпретации, а также смысловое молчание (паузы).\r\nСуществуют различные стили проведения интервью. Например, выделяют жесткий и мягкий стили ведения интервью. Интервью может вестись:\r\n•\t– с позиции респондента (мягко, соучаствующее);\r\n•\t– с позиции, противоположной позиции респондента (жестко, недоверчиво);\r\n•\t– с собственной позиции интервьюера (может быть как \"мягким\", так и \"жестким\").\r\nБеседа – в отличие от интервью в ней две участвующие стороны (задающий вопросы и отвечающий на них) находятся примерно в равном положении. Под беседой чаще всего понимается диалоговый метод исследования, идущий еще от Сократа. Важно умение вести диалог, т.е. не только интересоваться собеседником и корректно ставить ему вопросы, но уметь слышать вопросы другого и содержательно на них отвечать.\r\nОпрос экспертов. Методика в целом такая же, как при обычном опросе или анкетировании. Специфика – отбор экспертов, т.е. определение выборки опрашиваемых. Правильность метода зависит от правильности выбора эксперта. Этот метод чаще применяется при пилотажном исследовании.\r\nПри выборе эксперта значимо учитывать компетентность эксперта в нужной теме. Выбор по параметрам: известность, профессионализм, принадлежность к области выбора, определение отношения к виду деятельности, включенность в событие и пр.\r\nНарративное интервью – направляемый исследователем свободный рассказ респондента о своей жизни или каких-то ситуациях. Различают биографическое интервью (повествование мемуарного характера, о жизненном пути) и интервью о событиях и фактах жизни (рассказ о конкретных жизненно значимых происшествиях, переживаниях, встречах с людьми). Основной акцент в вопросах делается на индивидуальных событиях жизни респондента, его переживаниях и оценках. Нарративное интервью используется наравне с письменными методами сбора нарративных текстов. Одно из перспективных направлений психологических исследований, дающее материал о жизненном пути человека во взаимосвязи с социокультурной ситуацией развития.\r\nДискуссия (от лат. discussio – рассмотрение, исследование) – публичное обсуждение какого-либо спорного вопроса, проблемы; спор. Посредством обсуждения некоторых спорных для участников дискуссии вопросов происходит выявление и исследование как проблемы, так и точек зрения по ее поводу. В дискуссии каждая сторона, оппонируя мнению собеседника, аргументирует свою позицию и претендует на достижение своей цели. Благодаря этому дискуссия может выступать активным методом получения информации по тем или иным вопросам. Хотя в ситуации противопоставления зачастую срабатывает механизм противоборства, уводящий исследователя от выявления истинных мнений участников дискуссии. Дискуссия в исследовательских целях – тонкий и глубокий метод изучения индивидуальных и социальных мнений. Основные квалификационные требования к исследователю – умение организовать и корректно провести дискуссию. В ряде случаев в форме свободной дискуссии могут разговориться самые молчаливые респонденты.\r\nЭтапы исследования с помощью методов устного опроса:\r\n•\t1. Выбор темы – формулировка цели исследования, отвечающая на вопросы \"почему?\" и \"что?\", будет изучаться.\r\n•\t2. Планирование – определение логики исследования (какие, в какой последовательности, в каком стиле, при какой ситуации, кому именно будут задаваться вопросы; определение места и времени выборки).\r\n•\t3. Опрос – проведение беседы, интервью или дискуссии по запланированной схеме.\r\n•\t4. Расшифровка – перевод аудиозаписи в письменный текст.\r\n•\t5. Анализ – опираясь на цель и тему опроса, а также с учетом природы полученного материала, выбирается и применяется тот или иной метод анализа (качественный, количественный, качественно-количественный; обобщенный или детальный и т.д.).\r\n•\t6. Верификация (проверка) – выясняется, насколько полученные тексты надежны (тексты опросов однородны) и валидны (тексты опроса реализуют именно ту цель, которая была поставлена исследователем).\r\n•\t7. Написание отчета – изложение результатов исследования в заданной форме с соблюдением этических правил и методических норм.\r\nМожно выделить следующие критерии качества интервью или беседы:\r\n•\t– объем спонтанных, подробных, конкретных и соответствующих теме ответов, полученных в ходе опроса;\r\n•\t– соотношение по объему вопросов корреспондента и ответов респондента (чем короче вопросы и длиннее ответы, тем лучше);\r\n•\t– глубина прослеживания и прояснения смысла исследователем различных аспектов ответов респондента;\r\n•\t– наличие интерпретаций ответов по ходу опроса, а также их верификация;\r\n•\t– \"интервью говорит само за себя\" – текст опроса как самодостаточный рассказ, который не нуждается в большом количестве лишних описаний и объяснений.\r\n";
                            break;
                        case 3:
                            LessonCompleteRichBox.Text += "\tПо содержанию можно выделить такие виды викторины:\r\n1) тематические\r\n2) развлекательно - развивающие\r\n3) лингвистические\r\n4) межтематические\r\nТематические викторины  используются наиболее часто. С помощью тематических викторин можно сообщить дополнительные сведения по какой-либо теме или обобщить ее изучение, проверить степень информированности студентов, их умение самостоятельно пользоваться рекомендованной преподавателем литературой, давать доказательные и точные ответы.\r\nРазвлекательно-развивающие викто¬рины способствуют развитию сообрази¬тельности, находчивости, гибкости мыш¬ления, логики. Часто используются кроссворды и различные вопросы.\r\nЛингвистические викторины способствуют самостоятельной работе обучающихся над языковым материалом, учат некоторым приёмам самостоятельной работы со словом, более внимательному отношению к различным языковым явлениям.\r\nМежтематические викторины выяв¬ляют разносторонние знания обучающихся; учат их обращаться друг к другу; внимательно относиться к тому, что каждый из них знает, умеет; способствуют взаимообо¬гащению в процессе обучения.\r\nВ числе основных требований к проведению викторин следующие:\r\n1)    четкая учебно-воспитательная направленность, ориентация обучающихся на информацию, представляющую общеобразовательную и практическую значимость;\r\n2)    актуальность и связь с жизнью;\r\n3)    доступность источников информации;\r\n4)    занимательность и новизна\r\n\r\nСтруктура викторины:\r\n1) вводная часть\r\n2) ра¬бота в группах\r\n3) заключительную часть\r\nВводная часть. Перед обучающимися ставится задача, они получают раздаточ¬ный материал, их информируют о после¬довательности видов деятельности в про¬цессе работы. Виды деятельности таковы: а) все команды получают одинаковую задачу и материал для выполнения в от-веденное время; б) материал у команд может быть разным (например, при проведении викторины о Германии можно предложить  командам разную тематику: одной команде — «Природа и климат страны», другой — «Население», третьей — «Экономика»); в) команды мо¬гут работать одновременно в отведенное время или же меняться для выполнения различных заданий; г) на викторине мо¬гут быть предусмотрены и индивидуаль¬ные конкурсы капитанов, консультантов; выбор представителя может быть сделан по решению команды.\r\nРабота в группах. На этом этапе обучающиеся знакомятся с материалом викторины, планируют работу и время, распределяют вопросы между членами команды, совместно обсуждают получен¬ный результат, дорабатывают и коррек¬тируют ответы.\r\nЗаключительная часть. Подводятся итоги работы, анализируется выполне¬ние заданий, дается оценка групповой и индивидуальной работы, проводится разбор типичных ошибок, акцентирует¬ся внимание на вопросах, вызвавших особые трудности. Этот этап позволяет преподавателю проконтролировать свою рабо¬ту, скорректировать планирование, наметить план по ликвидации пробелов.\r\n";
                            break;
                        case 4:
                            LessonCompleteRichBox.Text += "\tТребования к подготовке и проведению коллоквиума: \r\n1. Минимальное количество часов, отводимое на коллоквиум, не может быть менее 2 часов на одну группу. Как правило, коллоквиум проводится в рамках 2 - 4 часов аудиторного времени. Исходя из опыта крупнейших вузов страны время, отводимое на самостоятельную подготовку обучающегося к коллоквиуму, составляет 9 часов в счёт трудоёмкости освоения данной учебной дисциплины по учебному плану.\r\n2. Материал программы учебной дисциплины (часть, раздел, темы), отнесенный к коллоквиуму, должен по трудоемкости освоения 10 студентом составлять 25-30% от всего объема трудозатрат по данной дисциплине и в дальнейшем не выносится на экзамен. \r\n3. При подготовке к коллоквиуму преподаватель обязан: \r\n• определить задачи, круг обсуждаемых вопросов, практических заданий, время проведения; \r\n• подобрать литературу для студентов; \r\n• консультировать обучающихся по ходу подготовки коллоквиума и проверять их готовность; \r\n• заранее объявить дату, тему и план коллоквиума. \r\n\r\n4. Методическое обеспечение коллоквиума должно содержать следующие обязательные компоненты: \r\n• формулировки темы и вопросов, заданий по освоению её содержания; \r\n• требования к заданиям и умениям, которые должен продемонстрировать обучающийся при освоении содержания данной темы; \r\n• списки обязательной и дополнительной литературы, перечень интернет-ресурсов; \r\n• терминологический минимум, который должен освоить обучающийся при самостоятельном изучении темы; \r\n• методические указания по освоению содержания представленной темы; \r\n• разработанный и утвержденный уровень компетенций; \r\n• критерии оценки ответов на коллоквиуме. \r\n Форма проведения коллоквиумов \r\n1. Коллоквиум проводится, как правило, во внеаудиторное время. В порядке исключения с учетом наличия ресурсов обеспечения учебного процесса и по рекомендации Методического совета Университета решением 11 проректора по учебной работе коллоквиум может быть проведён в аудиторное время, выделенное на изучение данной учебной дисциплины. \r\n2. В случае неудовлетворительного результата сдачи коллоквиума студенту разрешается его пересдать в оставшийся до экзаменационной сессии период с оформлением индивидуального зачетного листа, выдаваемого в деканате. При не сданном коллоквиуме студент не допускается до экзамена по этой дисциплине. \r\n3. Итоговая оценка по учебной дисциплине, по которой предусматривается сдача коллоквиума, выставляется по результатам сдачи экзамена в установленном порядке. \r\n4. Если коллоквиум проводится в письменной форме, то результаты деятельности студентов представляют собой: \r\n• развёрнутые ответы на контрольные вопросы; \r\n• решения контрольных заданий. \r\n\r\n5. Объем одного блока вопросов должен соответствовать общей трудоемкости дисциплины и содержать 20-30 вопросов. Вопросы не должны предполагать односложный (однословный) ответ. \r\n6. Основанием для принятия (зачёта) коллоквиума является ведомость, выдаваемая деканатом в установленном порядке. По результатам сдачи студентами коллоквиума выносятся следующие оценки: «зачтено» - правильных ответов равно или более 50%, «незачтено» - правильных ответов менее 50% от их общего числа. Определение количества правильных ответов производится преподавателем по опросным картам или по результатам письменных ответов и решению задач. Для повышения объективности оценки преподаватель может провести собеседование со студентом по его письменным ответам на вопросы и результатам решения задач. \r\n7. Продолжительность сдачи студентами коллоквиума устанавливается преподавателем по согласованию с заведующим кафедрой исходя из формы его проведения и содержания контрольных заданий.  \r\n8. Результаты коллоквиума преподаватель фиксирует в ведомости, выданной ему деканатом для проведения коллоквиума. Указанная ведомость заполняется и сдается в деканат в день проведения коллоквиума. \r\n9. Материалы сдачи студентами коллоквиума (опросные карты, письменные ответы на контрольные вопросы, решение задач и другие) должны храниться на кафедре с соблюдением мер конфиденциальности. \r\n10. Составление и ежегодное обновление вопросов и задач должно быть предусмотрено индивидуальным планом преподавателя, ведущим данную дисциплину. \r\nОсобенности проведение устного коллоквиум по теме или разделу дисциплины: \r\nСобеседование ведется с каждым студентом индивидуально в присутствии малой группы (5-6 человек). В случае затруднения студента при ответе на поставленный вопрос, последний может быть переадресован другим. При этом студенты могут дополнять друг друга, дискутировать, задавать вопросы, всесторонне обсуждая проблему. Таким образом, коллоквиум представляет собой групповую форму беседы преподавателя со студентами с целью выяснения их знаний. При этом каждому выставляется дифференцированная оценка. На коллоквиуме студенты могут пользоваться своими записями изученных материалов. Не следует сводить коллоквиум к семинару. Если семинар сегодня не рекомендуется проводить лишь вопросно-ответным методом, то на коллоквиуме такой метод является основным. На коллоквиуме студент должен продемонстрировать, что он: \r\n• знает содержание и структуру работы, отдельных её глав и параграфов (если на коллоквиум выносится отдельный труд); \r\n• уяснил логику изложения материала; \r\n• умеет выделить узловые идеи и положения; \r\n• умеет обобщать материал с помощью схем, таблиц, вопросов и делать записи прочитанного (сделать выписки, составить план, тезисы, аннотацию, резюме, конспект); \r\n• видит связь изучаемой теории с практикой; \r\n• имеет собственное мнение о прочитанном.\r\n";
                            break;
                        case 5:
                            LessonCompleteRichBox.Text += "\t•\tКонкурсный урок – это творческое учебное занятие по индивидуальному сценарию, режиссуре и содержанию, опирающееся на современные классические принципы обучения и воспитания учащихся\r\n•\tКонкурсный урок — это не просто современный урок, это особый урок, ибо он естественная часть предъявляемого взыскательной аудитории педагогического опыта.\r\n•\tВажно, чтобы урок был профессиональным! Проблемным! Важно, чтобы он был уроком взаимодействия, диалога!\r\n•\tКонкурсный урок должен быть иллюстрацией системы работы педагога, научных позиций, технологий, педагогических позиций, предъявленных в разных формах (эссе, обобщение опыта, статьи в журнал).\r\n•\tВажно, чтобы после урока у конкурсанта осталось ощущение праздника творческого единения с детьми, соавторами, соисполнителями задуманного.\r\n•\tБезусловно, конкурсный урок своеобразен по содержанию, ориентированному на незнакомых детей.\r\n•\tЗалог его успешности в умении поставить цель, определить задачи и педагогически грамотно подобрать нужные для их решения средства.\r\n•\tУчителю-конкурсанту необходимы и такие качества, как способность импровизировать, умение слушать и слышать незнакомых детей, чутко реагировать в диалоге на их вопросы и ответы.\r\n•\tЗаметим, что не менее важны раскованность и сдержанность, спокойствие, умение ориентироваться в реальной, порой непред-сказуемой ситуации, управлять своим творческим самочувствием.\r\n\r\nПри всем различии предметов и образовательных областей для оценки каждого конкурсанта к ним предъявляются обязательные требования, которые ежегодно входят в критерии оценки:\r\n•\tГлубокое знание своего предмета.\r\n•\tНекорректное оперирование научными понятиями, небрежность, неточности, оговорки, речевая безграмотность недопустимы.\r\n•\tГрамотное, в соответствии с целями и задачами урока использование новых, современных, а иногда и традиционных, но работающих на результат, способов передачи знаний.\r\n•\tДопускается интерпретация описанных в педагогической литературе авторских методик (технологий), а еще лучше - предъявление собственной апробированной методики (технологии).\r\n•\tКоммуникативные способности, актерское и ораторское мастерство. К сожалению, педагогической техникой конкурсанты владеют явно недостаточно.\r\n•\tУмение достигать результата образовательной деятельности при любом уровне подготовленности класса. Ссылка на слабый уровень подготовки детей неуместна.\r\nОчевидно, что каждый предмет имеет свое образовательно-информационное поле и требует использования специфических методов, приемов и форм организации учебного занятия.\r\nОшибки при самоанализе урока, мероприятия\r\n•\tРедко бывает объективным со стороны участника;\r\n•\tЦениться объективный анализ, когда педагог констатирует, что получилось не так, как планировал, в каком месте отошёл от запланированного, т.к. урок пошёл не «по сценарию». Это говорит о мобильности педагога, его умении выйти достойно из непредвиденной ситуации;\r\n•\tРедко педагог аргументирует отбор содержания урока (занятия) – не просто, что по программе, а почему взят именно этот материал;\r\n•\tОт педагога больше ждут импровизации, а не только домашней заготовки, от которой учитель не может отойти.\r\n";
                            break;
                        case 6:
                            LessonCompleteRichBox.Text += "";
                            break;
                    }
                    break;
                case 5:
                    LessonCompleteRichBox.Text = "\tУрок коррекции знаний. Он по-прежнему важен, потому что помогает школьнику осознать причину ошибок, скорректировать знания, наметить план работы на будущее. Более низкая, чем хотелось бы, оценка должна стать стимулом для дальнейшей работы, указателем, в каком направлении следует двигаться. Если урок коррекции не выполнит эту задачу, оценка так и останется обидной цифрой в журнале, что нежелательно во всех отношениях. Поэтому к планированию урока коррекции надо подготовиться особенно тщательно и особенное внимание уделить мотивационной части. \r\nСтруктура урока \r\n• Мотивационная часть. \r\n• В начале урока проводится работа над наиболее часто встречающимися ошибками, но педагог не комментирует суть ошибки, а предлагает студентам определить, в чем ее причина и как ее можно было избежать. Обычно это коллективный этап работы. \r\n• Если позволяет время, затем можно провести групповой этап, разделив студентов на набольшие группы в соответствии с их ошибками. Тем, кто выполнил работу безошибочно, на данном этапе можно предложить задания повышенной сложности. \r\n• Следует провести этап индивидуальной работы, в ходе которого предложить каждому студенту наметить для себя план коррекции (повторить какую-либо тему) и определиться, что он может сделать сам, а в чем ему нужна помощь. \r\n• Рефлексия на таком уроке особенно важна (собственно, предыдущий этап как раз и есть подготовка к качественной рефлексии).\r\n";
                    LessonCompleteRichBox.Text += text1;
                    switch (LessonPoint2X)
                    {
                        case 1:
                            LessonCompleteRichBox.Text += "\t Этапы подготовки и проведения урока-зачёта.\r\n1.\t Предварительная подготовка к уроку-зачёту.\r\n2.\tПроведение урока-зачёта.\r\n3.\tПодведение итогов и внесение корректив.\r\n1этап.   Предварительная подготовка.\r\nПодготовительная работа начинается на первом вводном уроке по теме. Учитель анализирует требования программы по теме, определяет основные задания, учитывая три уровня усвоения:\r\n1.\tПонимание, запоминание, воспроизведение материала.\r\n2.\tПрименение знаний и  умений в знакомой ситуации.\r\n3.\tПрименение знаний и умений в новой ситуации.\r\nУчитель сообщает тему и дату проведения урока-зачёта, его место и значение в изучении новой темы, знакомит с требованиями, которые будут предъявлены к учащимся, предлагает индивидуальные задания по тем вопросам, в которых некоторые ученики ранее не разбирались.\r\nНа стенде.\r\n1.\tПеречень знаний, умений и навыков.\r\n2.\tВопросы и задания.\r\n3.\tСоветы по организации различных видов учебной деятельности: памятки, алгоритмы ,планы и образцы решений   наиболее сложных задач по теме.\r\n4.\tПримерная контрольная работа.\r\n5.\t Литература по теме.\r\n2 этап.  Проведение зачёта.\r\nНа зачётном уроке опрашивать можно не всех учащихся. Учащиеся, успешно усвоившие учебный материал могут получить зачёт по обязательному материалу автоматически.  Они могут помочь учителю принимать зачёт у остальных учащихся, либо им предлагаются дифференцированные задания повышенной сложности.\r\nЗачёт может быть письменным или устным. Можно проводить и комбинированные зачёты.\r\n3 этап.  Подведение итогов работы.\r\nОценка труда учащихся.\r\nЕсли зачёт устный, то оцениваются ответы учащихся на этом же уроке. Если письменный или комбинированный, то на следующем уроке, после проверки работ учителем.\r\nВиды зачётов.\r\n        1).Открытый тематический зачёт.\r\n        2). Закрытый тематический зачёт.\r\n        3). Открытый текущий зачёт.\r\n        4). Закрытый текущий зачёт.\r\nВ открытом тематическом зачёте учащиеся предварительно знакомятся со списком задач обязательного уровня. В закрытом тематическом зачёте список задач в явном виде учащимся не предъявляется. Но это не означает, что учащимся совсем неизвестно, какие виды задач относятся к обязательным. В ходе изучения материала учитель акцентирует внимание учащихся на задачах обязательного уровня, подчёркивая, что подобные задачи нужно будет решать на зачёте.\r\nМетодические рекомендации по  проведения закрытого зачётного урока.\r\nЦель: проверка достижения учащимися уровня обязательной подготовки; овладение важнейшими умениями и навыками.\r\nЗадача: установить уровень овладения знаниями по конкретной теме.\r\nПодготовка: в процессе изучения темы отводится специальное время на формирование и отработку умений решать задачи обязательного уровня.\r\nВремя проведения: за один - два урока запланированного окончания изученной темы.\r\nФормы: устная (опрос по билетам); письменная (контрольная работа); смешанная (часть учащихся класса опрашивается устно, а остальные задания письменно и сдают учителю на проверку).\r\nПлан проведения: разминка, самостоятельная работа, решение (обязательная) устных задач (часть), устный (дополнительная) мини-экзамен (часть), тест.\r\nПодведение итогов: проводится на следующем уроке (объявляется количество набранных баллов и оценка).\r\nКорректировка: разбираются задачи, вызвавшие у учащихся наибольшие трудности. Время на пересдачу зачетов отводится на уроке. Предлагается индивидуальная карточка - задание или задача из зачета в качестве дополнительного задания.\r\nМетодические рекомендации по проведению открытого зачётного урока.\r\nЦель: учет и контроль знаний, умений и навыков.\r\nЗадача: установить уровень овладения знаниями по конкретной теме.\r\nПодготовка: в начале изучения темы вывешивается в классе или раздается учащимся список задач, отвечающим уровню обязательной подготовки по данной теме, и сообщает, что после ее изучения будет зачет.\r\nВремя проведения: на специально выделенном уроке.\r\nФорма: проверочная работа.\r\nПлан проведения: разминка, самостоятельная работа, обязательная часть, дополнительная часть.\r\nПодведение итогов: проводится на следующем уроке (объявляется количество набранных баллов и оценка).\r\nКорректировка: разбираются задачи, вызвавшие у учащихся наибольшие трудности. Время на пересдачу зачетов отводится на следующем уроке. Предлагается индивидуальное задание.\r\nТекущие зачеты\r\nпроводятся несколько раз в ходе изучения темы. От тематических они отличаются тем, что охватывают меньший по объему материал; поэтому, как правило, на их проведение не требуется отводить весь урок. Это могут быть небольшие работы, рассчитанные на 10-15 минут и направленные на проверку одного - двух умений, формируемых в течение нескольких уроков.\r\n";
                            break;
                        case 2:
                            LessonCompleteRichBox.Text += "\tЭкзамен проводится в объеме программы учебной дисциплины. Форма и порядок проведения экзамена определяются кафедрой. Для проведения экзамена на кафедре разрабатываются:\r\n- экзаменационные билеты, количество которых должно быть больше числа экзаменующихся курсантов (слушателей и студентов) учебной группы;\r\n- практические задания, решаемые на экзамене;\r\n- перечень средств материального обеспечения экзамена (стенды, плакаты, справочная и нормативная литература и т.п.)\r\nМатериалы для проведения экзамена обсуждаются на заседании кафедры и утверждаются заместителем начальника университета по учебной работе не позднее 10 дней до начала экзаменационной сессии.\r\nВ экзаменационный билет включаются два теоретических вопроса.\r\nПредварительное ознакомление обучающихся с экзаменационными билетами не разрешается\r\nЭкзамен принимается заведующим кафедрой, заместителем начальника кафедры, профессорами и доцентами. В отдельных случаях с разрешения заведующего кафедрой в помощь основному экзаменатору могут привлекаться преподаватели, ведущие семинарские и практические занятия.\r\nНа экзамене, кроме экзаменатора и экзаменуемых, имеют право присутствовать начальник и заместитель начальника университета, начальники и заместители начальника УМЦ, факультета и кафедры. Другие лица только с разрешения начальника университета. В аудитории (учебном кабинете), где проводится экзамен, должны быть: программы учебной дисциплины, экзаменационная ведомость, комплект экзаменационных билетов, перечень вопросов экзаменационных билетов с указанием номеров билетов.\r\nВ аудитории могут одновременно находиться не более пяти экзаменующихся.\r\nДля подготовки к ответу курсантам (слушателям и студентам) отводится не более 20 минут. Норма времени на прием экзамена – 15 минут на одного обучающегося.\r\nПо окончании ответа на вопросы билета экзаменатор может задавать дополнительные и уточняющие вопросы в пределах учебного материала, вынесенного на экзамен.\r\nПрерывать экзаменующегося при ответе не рекомендуется.\r\nОценка по результатам экзамена объявляется курсанту (слушателю и студенту), заноситься в экзаменационную ведомость и зачетную книжку. Неудовлетворительные оценки проставляются только в экзаменационной ведомости (в зачетные книжки не заносятся).\r\nЕсли неявка была по неуважительной причине, то начальником центра организации и координации учебно-методической работы в ведомости проставляется неудовлетворительная оценка. Другие записи или прочерки в экзаменационной ведомости не допускаются.\r\n";
                            break;
                        case 3:
                            LessonCompleteRichBox.Text += "\tСтруктура семинарского занятия обычно включает в себя следующие этапы: \r\n1. Организационный момент \r\n2. Вступительное слово преподавателя направлено на психологическую установку студентов к предстоящей работе и на актуальность рассматриваемой проблемы. Он объявляет тему, цели и задачи семинарского занятия, определяет его место в изучаемом курсе. Также определяет порядок выступлений и их регламент. \r\n3. Основная часть семинара. Заслушивание ответов на вопросы, докладов, рефератов. Последовательное обсуждение ответов, рефератов, докладов. Выработка мнений и суждений, формирование в результате дискуссии правильных суждений и др. Обсуждение темы зависит от методики работы преподавателя, которую он реализует на конкретном семинарском занятии. \r\n4. Заключительное слово преподавателя (подведение итогов занятия). Анализ качества выступлений студентов, оценка их деятельности, степень подготовленности учебной группы, уровень культуры мышления участников. Преподаватель также поясняет используемую им систему поощрения и снижения оценки, определяет степень достижения цели семинара. Для обеспечения обратной связи преподавателю необходимо организовать рефлексию семинара. Здесь для студентов используются вопросы «Что я получил на сегодняшнем занятии?», «Удалось ли мне доказать свою точку зрения?», «Кто из участников помогал/мешал мне в работе?» и т.д., а также экспресс-опросы, анкеты. \r\n5. Домашнее задание. \r\nПодготовка преподавателя к проведению семинара \r\nРезультативность и эффективность семинара в значительной степени зависит от преподавателя. В отличии от обучаемых, преподаватель должен изучить более широкий перечень литературы по теме. Особенность работы преподавателя с литературой состоит в том, что он ее изучает не только с целью познания, но и для того, чтобы определить, как можно полезнее использовать важную и наиболее ценную информацию в интересах полного и глубокого осознания и прочного усвоения обучаемыми, выносимых на обсуждение вопросов и проблем, обеспечить реализацию поставленных перед занятием учебных целей. При этом преподаватель всегда выделяет важные детали вопросов, которые могут быть не замечены обучаемыми, но имеющие важное значение для углубления их знаний и для практической деятельности. Преподаватель должен продумать и наметить дополнительные (наводящие) вопросы, стимулируя этим активность обучаемых и глубокое всестороннее изучение вопросов. Следует предусмотреть вероятность альтернативных ответов и подготовиться к их анализу и сравнению, выявлению положительных сторон и недостатков. Затем следует продумать методику проведения семинара, каждый обучаемый должен принять активное участие в семинаре. Сначала продумать вступительное слово, затем методику обсуждения каждого вопроса. Необходимо продумать также структуру ожидаемого ответа. К подведению итогов семинара преподаватель готовится в процессе занятия. Необходимо определить систему критериев и показателей, пользуясь которыми преподаватель мог бы более или менее объективно проанализировать и оценить ответ каждого обучаемого, сравнить ответы студентов между собой, оценить их качество по форме и содержанию и подвести обоснованные итоги подготовки обучаемых и степень достижения целей.\r\n";
                            break;
                        case 4:
                            LessonCompleteRichBox.Text += "\tПодготовительный этап: обсуждаем условия и правила игры\r\nУсловия аукциона необходимо заранее обсудить с обучающимися. Чем старше ученики, тем более сложную систему торгов и оценивания можно предложить.\r\nВариант 1. Например, простая форма аукциона: каждый ученик получает по 15 монет (у.е.). Каждый лот оценивается в 2 монеты. Право отвечать получает тот, кто предложит наибольшую цену. Задача учеников: потратить все монеты.\r\nВариант 2: Все лоты раскладываются на игровом поле (как на \"Поле чудес\"). Ученики (или группа учеников) крутит барабан и получает выпавший лот. Их задача: правильно решить предложенную задачу (ответить на вопрос). Каждый правильный, подробный и развернутый ответ оценивается в 2 монеты. За дополнения выдается из банка по 1 монете. Выигрывает та команда (группа), которая получила наиболее количество монет.\r\nВариант 3: Каждый ученик изначально имеет определенную сумму у.е. (например, по 1000). В ходе торгов он (или группа учащихся) могут выкупить лот, назвав максимальную цену. Если ответ на вопрос в лоте будет правильным, подробным, исчерпывающим, то команда или ученик могут получить поощрение из банка в размере 100 у.е. За неполные ответы или неправильные возможны штрафные санкции (до 300 у.е.).\r\nВариант 4: Без денег. Это самый простой вид аукциона. Класс делится на команды. В продажу поступают лоты, но в качестве выкупа будут правильные ответы.\r\nНапример, для урока русского языка в 3-ем классе. Тема: Части речи. Лот №1 Имя существительное.\r\nИтак, на продажу выставлен лот № 1. После объявления темы команды дают поочередно характеристики имени существительного: самостоятельная часть речи, отвечает на вопросы \"Кто? Что?\", склоняется по падежам, изменяется по числам, имеет род, имеет склонение и т.д. За каждый правильный ответ команда получает по 2 балла. Лот уходит к той команде, которая наберет самое большое количество очков. Если количество баллов получается одинаковым, можно предложить дополнительное задание. С проигравшей команды можно взимать \"комиссионные\" в виде частушек, песни, стихотворения и т.д.\r\nКак видите, вариантов воплощения самой идеи аукциона много. Важно только сначала все подробно обсудить с учениками, чтобы в ходе урока не возникало недопонимания и трений среди участников. Очень удобно, когда учет растраченных и заработанных средств ведется в реальном режиме. Для этого можно использовать, к примеру, доску, где в заранее подготовленную таблицу будут вноситься все изменения.\r\nПодготовка учащихся к уроку-аукциону\r\nУроки-аукционы ценны тем, что учащиеся должны повторить, обобщить целый пласт знаний по теме до урока. А для более успешного выступления приветствуется подбор новых, интересных фактов по теме.\r\nКак правило, о проведении аукциона целесообразно объявить заранее — за 1-2 недели. Желательно дать ученикам список тем, которые будут обсуждаться на уроке, список литературы и возможных ресурсов, где можно найти информацию по данной тематике, приблизительный перечень заданий.\r\nСамые активные классы могут сами придумывать задания к лотам. Либо вопросы друг другу можно выставить как один из лотов. В этом случае на аукционе можно ввести систему поощрительных баллов: \"За самое необычное задание\", \"За самый интересный вопрос\" и т.д.\r\nВарианты лотов\r\n•\tЗадания \"Кто быстрее?\" Кто быстрее решит примеры, кто быстрее составит анаграмму, кто быстрее отгадает задку и т.д.\r\n•\tВикторины. Такие лоты хороши для разминки, а потому их целесообразнее выставлять первыми.\r\n•\tТесты.\r\n•\tКроссворды, чайнворды.\r\n•\tИсторические сведения (уместны для любого предмета).\r\n•\tЦифровые диктанты или диктанты \"да-нет\". Можно проводить как устно, так и письменно.\r\n•\tИгровые задания. Лоты строятся по примеру любых дидактических игр, которые ваши ученики уже знают и умеют в них играть.\r\n•\tВидео или аудио вопросы.\r\n•\t\"Черный ящик\". В ящике лежит предмет, который ученики должны связать с темой урока.\r\n•\tПрактические задания (на них стоит сделать основной упор, так как именно практическое применение правил лучше всего показывает степень усвоения темы).\r\n•\tТворческие задания (составить задачу, нарисовать сюжетную картинку, собрать паззл, придумать стихотворение и т.д.).\r\n•\tЗадания повышенной сложности. За них и \"цена\" назначается выше.\r\nОформление урока-аукциона\r\nУрок-аукцион позволяет использовать максимально возможное количество наглядных изобразительных и звуковых средств. Очень помогает в проведении аукциона интерактивная доска, на которой удобно представлять отдельные задания и вести общий подсчет баллов.\r\nДополнительно класс можно оформить как зал проведения торгов: за кафедрой, где будет находиться аукционист, установить металлический гонг или специальный молоточек. Хорошо, если будет вывешен плакат с правилами проведения аукциона. Кроме того, каждому ученику можно вручить специальное приглашение на аукцион (такие же можно раздать коллегам, если вы решите их пригласить на свой урок).\r\nНе забывайте о поощрениях. Конечно, главное поощрение — положительная оценка за урок. Но и награды в виде медалей, дипломов или грамот также приветствуются.\r\nТипичные ошибки в организации урока-аукциона и как их избежать\r\n•\tЧрезмерное увлечение \"продажами\". Нельзя позволять ученикам \"переигрывать\", отводя значительную часть времени на \"торги\". Особенно, если вы решите продавать лоты за у.е. Желательно сразу установить регламент: например, окончательной становится цена, названная третьей или установите максимальную ставку, выше которой поднимать цены нельзя, то есть блиц-цену. Можно установить и размер аукционного шага.\r\n•\tНе регламентировано время. Желательно регламентировать и время ответов на задания одного лота. А чтобы обстановка как можно больше походила на атмосферу настоящего аукциона, можно установить гонг, удары которого будут сигнализировать об окончании торгов.\r\n•\tСлишком много лотов. Лучше всего выбирать микротемы, а не материал целого курса.\r\n•\tОднообразие лотов. Будет скучно и малоэффективно, если все ваши задания будут строиться одинаково: например, только вопросы-ответы. Желательно разнообразить работу, включив в состав лотов разные задачи как из теории, так и  из практики. Ведь ваша задача — привлечь всех учеников. Поэтому необходимо предусмотреть задания и творческого плана, и на эрудицию и общее развитие.\r\n•\tНезнание правил аукциона. Выше уже отмечалось, что если учащиеся не поняли принципа проведения аукциона, то хаоса и обид не избежать. Поэтому рекомендуется предварительно обсудить все правила. А еще лучше, если вы будете иногда включать систему аукциона в качестве одного из этапов урока еще на предварительном этапе подготовки. Например, проводить в форме аукциона проверку домашнего задания или проверку практического задания, данного как закрепление к теме. \r\nДля тех, кто никак не решится на аукцион\r\n•\tНе стоит сразу отвергать даже кажущиеся невероятными формы нестандартных уроков. Чем меньше будет шаблонов в вашем преподавании, тем больше шансов на успех.\r\n•\tБольше творчества! Но творчества не ради развлечения, а направленного на реализацию идеи познания в самой легкой и интересной форме. \r\n";
                            break;
                        case 5:
                            LessonCompleteRichBox.Text += "•\tКонкурсный урок – это творческое учебное занятие по индивидуальному сценарию, режиссуре и содержанию, опирающееся на современные классические принципы обучения и воспитания учащихся\r\n•\tКонкурсный урок — это не просто современный урок, это особый урок, ибо он естественная часть предъявляемого взыскательной аудитории педагогического опыта.\r\n•\tВажно, чтобы урок был профессиональным! Проблемным! Важно, чтобы он был уроком взаимодействия, диалога!\r\n•\tКонкурсный урок должен быть иллюстрацией системы работы педагога, научных позиций, технологий, педагогических позиций, предъявленных в разных формах (эссе, обобщение опыта, статьи в журнал).\r\n•\tВажно, чтобы после урока у конкурсанта осталось ощущение праздника творческого единения с детьми, соавторами, соисполнителями задуманного.\r\n•\tБезусловно, конкурсный урок своеобразен по содержанию, ориентированному на незнакомых детей.\r\n•\tЗалог его успешности в умении поставить цель, определить задачи и педагогически грамотно подобрать нужные для их решения средства.\r\n•\tУчителю-конкурсанту необходимы и такие качества, как способность импровизировать, умение слушать и слышать незнакомых детей, чутко реагировать в диалоге на их вопросы и ответы.\r\n•\tЗаметим, что не менее важны раскованность и сдержанность, спокойствие, умение ориентироваться в реальной, порой непред-сказуемой ситуации, управлять своим творческим самочувствием.\r\n\r\nПри всем различии предметов и образовательных областей для оценки каждого конкурсанта к ним предъявляются обязательные требования, которые ежегодно входят в критерии оценки:\r\n•\tГлубокое знание своего предмета.\r\n•\tНекорректное оперирование научными понятиями, небрежность, неточности, оговорки, речевая безграмотность недопустимы.\r\n•\tГрамотное, в соответствии с целями и задачами урока использование новых, современных, а иногда и традиционных, но работающих на результат, способов передачи знаний.\r\n•\tДопускается интерпретация описанных в педагогической литературе авторских методик (технологий), а еще лучше - предъявление собственной апробированной методики (технологии).\r\n•\tКоммуникативные способности, актерское и ораторское мастерство. К сожалению, педагогической техникой конкурсанты владеют явно недостаточно.\r\n•\tУмение достигать результата образовательной деятельности при любом уровне подготовленности класса. Ссылка на слабый уровень подготовки детей неуместна.\r\nОчевидно, что каждый предмет имеет свое образовательно-информационное поле и требует использования специфических методов, приемов и форм организации учебного занятия.\r\nОшибки при самоанализе урока, мероприятия\r\n•\tРедко бывает объективным со стороны участника;\r\n•\tЦениться объективный анализ, когда педагог констатирует, что получилось не так, как планировал, в каком месте отошёл от запланированного, т.к. урок пошёл не «по сценарию». Это говорит о мобильности педагога, его умении выйти достойно из непредвиденной ситуации;\r\n•\tРедко педагог аргументирует отбор содержания урока (занятия) – не просто, что по программе, а почему взят именно этот материал;\r\n•\tОт педагога больше ждут импровизации, а не только домашней заготовки, от которой учитель не может отойти.\r\n";
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
                    LessonCompleteRichBox.Text += "\n\t" + item.GetOp() + "\n";
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
            OtherPanelTextBox.Text = "ПРЕЗЕНТАЦИОННОЕ СОПРОВОЖДЕНИЕ УРОКА – НОВОЕ КАЧЕСТВО ЗАНЯТИЙ.\r\nМультимедийный урок предполагает применение:\r\n1. ППС – программно-прикладных средств;\r\n2. видео- и аудиоматериалов;\r\n3. презентационного сопровождения урока.\r\nМультимедийные презентации используются для того, чтобы выступающий смог на большом экране или мониторе наглядно продемонстрировать дополнительные материалы к своему сообщению.\r\n Презентации - это способ подачи информации, в котором присутствуют рисунки, фотографии, анимация и звук. Кроме того, презентация имеет сюжет, сценарий и структуру, организованную для удобного восприятия информации.\r\n  Отличительной особенностью презентации является её интерактивность, то есть создаваемая для пользователя возможность взаимодействия через элементы управления. А в широком смысле этого слова, презентация — это комплексное представление всей полноты теоретического, фактического и визуального материала в виде логически сменяющей друг друга последовательности наглядного материала (слайдов).\r\n Формирование знаний, умений, навыков обучающихся с использованием презентации способствует наиболее оптимальному изучению, систематизации и оптимизации как уже изученного, так и нового материала. Она развивает навыки работы с персональным компьютером, обобщения материала и умения правильно и структурировано предоставить его для окружающих людей.\r\n Презентация также косвенно развивает навыки публичных выступлений. Именно благодаря использованию презентации, у обучающихся появляется возможность выделить наиболее актуальные вопросы и наиболее значимые проблемы изучаемой темы.\r\n Презентационное сопровождение урока – новое качество урока. Использование презентации на уроках способствует:\r\nповышению темпа и производительности урока;\r\nучету индивидуальных особенностей учащихся;\r\nактивизации познавательной деятельности учащихся;\r\nэстетическому оформлению урока, эмоциональному воздействию на учащихся.\r\nОбязательное условие - сочетание презентаций с другими видами работы.\r\nНЕКОТОРЫЕ ПРАВИЛА ОФОРМЛЕНИЯ ПРЕЗЕНТАЦИЙ\r\n1. В ходе подготовки, внимательно следить и корректировать используемые цветовые схемы. Нельзя использовать слишком яркие цвета, — они способствуют быстрому утомлению и отрицательно сказываются на эмоциональном состоянии учащихся; одновременно с этим, не рекомендуется использовать и слишком тусклые цвета и оттенки, — они также плохо влияют на психологическое состояние учащихся, способствуют рассеиванию внимания и систематической отвлеченности учащегося от работы на уроке. Выбор цветовой гаммы должен проводиться в зависимости от аудитории. Достаточно использовать около 3 подходящих цветов. Главное, чтобы цветовое разнообразие не отвлекало от темы презентации.\r\n2. Рекомендуется цветом или жирным шрифтом выделять ключевые фрагменты, на которых Вы останавливаетесь при обсуждении.\r\n3. Слайды должны быть аккуратным. Неряшливо сделанные слайды (разнобой в шрифтах и отступах, опечатки и т.д.) не допускаются.\r\n4. Необходима титульная страница, на которой указывается тема, автор, организация, дата.\r\n5. Оптимальное число строк на слайде — от 6 до 11. Перегруженность и мелкий шрифт тяжелы для восприятия. Недогруженность оставляет впечатление, что вы что-то не дописали, не объяснили.\r\n6. Размещайте на слайде только минимально необходимое количество текста. Избыток информации на слайде помешает сфокусироваться на главных аспектах вашей презентации.\r\nПАМЯТКА ДЛЯ СОСТАВЛЕНИЯ ПРЕЗЕНТАЦИИ\r\n1. Анализ состава, цели, характера и состояния аудитории (для кого создается презентация).\r\n2. Продумать место презентации в структуре урока, цель презентации.\r\nВыбор, разработка вариантов использования презентации определяется в соответствии с типом урока и дидактическими целями урока.\r\nПрезентация может целиком соответствовать структуре урока.\r\nПрезентация может быть одним из элементов урока (например, использоваться при опросе, закреплении или объяснении материала).\r\nВ форме презентации может быть представлен методический аппарат урока (схемы, таблицы, познавательные задания, вопросы, текстовый материал и т.д.)\r\nВ форме презентации-игры может быть урок или один из элементов урока.\r\nС точки зрения организации можно выделить\r\nнепрерывно выполняющиеся презентации (видеоряд к лекции)\r\nинтерактивные презентации (презентация-игра, презентация-тест, таблицы и т.д.)\r\nпрезентация со сценарием (презентации в соответствии с типом и целью урока)\r\nНа сегодняшний день именно презентация со сценарием все шире используется в учебной и внеурочной работе.\r\n3. Отбор материала для презентации.\r\nДля визуального отражения необходимо отбирать наиболее важные, значимые факты,     процессы, явления изучаемой темы.\r\nПродумать, как идея каждого слайда раскрывает основную идею, цель  всей презентации?\r\nПродумать какими наглядными средствами (карты, схемы, графики, таблицы фото, иллюстрации, тексты и т.д.) будут наиболее эффективно отражены  основные идеи урока.\r\nНеобходимо оптимально сочетать визуальный и фактический материал. Продумать: что будет на слайде? что будет говориться? как будет сделан переход к следующему слайду?\r\n4. Размещение визуального и фактического материала на слайде.\r\nПрезентация не должна быть перегружена спецэффектами и текстом. Наиболее важные слова, идеи, фрагменты можно выделять цветом или жирным шрифтом  на слайде, чтобы они сразу бросались в глаза.\r\n5. Подбор текста к слайду.\r\nПодготовка к речи: написание текста, плана (соответствующего слайдам презентации).  Распространённая ошибка — читать слайд дословно. Лучше всего, если на слайде будет написано определение, а словами будет рассказываться его содержательный смысл. Информация на слайде может быть более формальной и строго изложенной, чем в речи. Речь и слайды не должны совпадать, тогда презентация станет «объёмной». Речь должна быть более популярна и образна.\r\n6. Рассчитать время презентации в рамках урока.\r\n7. Важное правило: сочетание презентации с другими видами работы на уроке.\r\n8. Презентация включает в себя следующие элементы:\r\nнаглядность   (иллюстрации, карты)\r\nчеткая структура темы и урока в целом (план урока, логические схемы)\r\nметодический аппарат (вопросы и задания в течение урока)\r\nзакрепление пройденного (задания, в том числе и в тестовой форме)\r\nигровые элементы (анимация)\r\nработа с источниками\r\nматериалы исторических сайтов (гиперссылки – документы , Интернет)\r\n";
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
            OtherPanelTextBox.Text = "Для диагностики учебной мотивации студентов мы рекомендуем Вам провести тестирование среди своих обучающихся. Ниже приведены несколько вариантов тестирования. Они помогут Вам выявить мотивы студентов и повысить среди них мотивацию к обучению на уроках по дисциплинам профессионального цикла.\r\nДиагностика учебной мотивации студентов.\r\nОписание теста:  Это коммуникативные, профессиональные, учебно-познавательные, широкие социальные мотивы, а также мотивы творческой самореализации, избегания неудачи и престижа.\r\nИнструкция к тесту : Оцените по 5-балльной системе приведенные мотивы учебной деятельности по значимости для Вас: 1 балл соответствует минимальной значимости мотива, 5 баллов – максимальной.\r\nТест\r\n1. Учусь, потому что мне нравится избранная профессия.\r\n 2. Чтобы обеспечить успешность будущей профессиональной деятельности.\r\n 3. Хочу стать специалистом.\r\n 4. Чтобы дать ответы на актуальные вопросы, относящиеся к сфере будущей профессиональной деятельности.\r\n 5. Хочу в полной мере использовать имеющиеся у меня задатки, способности и склонности к выбранной профессии.\r\n 6. Чтобы не отставать от друзей.\r\n 7. Чтобы работать с людьми, надо иметь глубокие и всесторонние знания.\r\n 8. Потому что хочу быть в числе лучших студентов.\r\n 9. Потому что хочу, чтобы наша учебная группа стала лучшей в институте.\r\n 10. Чтобы заводить знакомства и общаться с интересными людьми.\r\n 11. Потому что полученные знания позволят мне добиться всего необходимого.\r\n 12. Необходимо окончить институт, чтобы у знакомых не изменилось мнение обо мне, как способном, перспективном человеке.\r\n 13. Чтобы избежать осуждения и наказания за плохую учебу.\r\n 14. Хочу быть уважаемым человеком учебного коллектива.\r\n 15. Не хочу отставать от сокурсников, не желаю оказаться среди отстающих.\r\n 16. Потому что от успехов в учебе зависит уровень моей материальной обеспеченности в будущем.\r\n 17. Успешно учиться, сдавать экзамены на «4» и «5».\r\n 18. Просто нравится учиться.\r\n 19. Попав в институт, вынужден учиться, чтобы окончить его.\r\n 20. Быть постоянно готовым к очередным занятиям.\r\n 21. Успешно продолжить обучение на последующих курсах, чтобы дать ответы на конкретные учебные вопросы.\r\n 22. Чтобы приобрести глубокие и прочные знания.\r\n 23. Потому что в будущем думаю заняться научной деятельностью по специальности.\r\n 24. Любые знания пригодятся в будущей профессии.\r\n 25. Потому что хочу принести больше пользы обществу.\r\n 26. Стать высококвалифицированным специалистом.\r\n 27. Чтобы узнавать новое, заниматься творческой деятельностью.\r\n 28. Чтобы дать ответы на проблемы развития общества, жизнедеятельности людей.\r\n 29. Быть на хорошем счету у преподавателей.\r\n 30. Добиться одобрения родителей и окружающих.\r\n 31. Учусь ради исполнения долга перед родителями, школой.\r\n 32. Потому что знания придают мне уверенность в себе.\r\n 33. Потому что от успехов в учебе зависит мое будущее служебное положение.\r\n 34. Хочу получить диплом с хорошими оценками, чтобы иметь преимущество перед другими.\r\nОбработка и интерпретация результатов теста\r\n• Шкала 1. Коммуникативные мотивы: 7, 10, 14, 32.\r\n • Шкала 2. Мотивы избегания: 6, 12, 13, 15, 19.\r\n • Шкала 3. Мотивы престижа: 8, 9, 29, 30, 34.\r\n • Шкала 4. Профессиональные мотивы: 1, 2, 3, 4, 5, 26.\r\n • Шкала 5. Мотивы творческой самореализации: 27, 28.\r\n • Шкала 6. Учебно-познавательные мотивы: 17, 18, 20, 21, 22, 23, 24.\r\n • Шкала 7. Социальные мотивы: 11, 16, 25, 31, 33.\r\nПри обработке результатов тестирования необходимо подсчитать средний показатель по каждой шкале опросника.\r\n \r\n\r\n\r\n \r\nМетодика С.С. Гриншпун «Мотивы выбора профессии»\r\nИнструкция: Вы выбрали профессию. Каковы причины, определяющие Ваш выбор? Из перечисленных ниже выберите наиболее значимые для Вас. В бланке ответов напротив соответствующего номера отметьте выраженную в баллах степень значимости для Вас того или иного мотива:\r\n4 балла - очень значим;\r\n3 балла - имеет значение;\r\n2 балла - скорее значим, чем незначим;\r\n1 балл - скорее незначим, чем значим;\r\n0 балла - не имеет значения.\r\n«Причинами выбора мною профессии являются…»\r\n1.      Убеждение, что данная профессия имеет высокий престиж в обществе.\r\n2.      Влияние семейных традиций.\r\n3.      Желание руководить людьми.\r\n4.      Стремление получить диплом о высшем образовании независимо от специальности.\r\n5.      Возможность получить профессию без длительного обучения.\r\n6.      желание работать в престижном месте.\r\n7.      Желание иметь модную профессию.\r\n8.      возможность быть в центре внимания, путешествовать, носить специальную форму одежды и т.п.\r\n9.      Желание приобрести материальную независимость от родителей.\r\n10. Возможность индивидуальной трудовой деятельности.\r\n11. Возможность удовлетворить свои материальные потребности.\r\n12. Возможность предпринимательской деятельности.\r\n13. Необходимость материально обеспечить семью.\r\n14. Желание приобрести экономические знания.\r\n15. Стремление найти удачный способ зарабатывать.\r\n16. Интерес к материальной стороне профессии или должности.\r\n17. Интерес к содержанию профессии, желание узнать, в чем заключаются обязанности специалиста в избираемой профессии.\r\n18. Стремление к самосовершенствованию, развитию навыков и умений в избираемой сфере трудовой деятельности.\r\n19. Хорошая успеваемость в школе по предметам, соответствующим избираемой сфере трудовой деятельности.\r\n20. Мечта заниматься любимой работой.\r\n21. Уверенность, что избранная профессия соответствует моим способностям.\r\n22. Стремление сделать свою жизнь насыщенной, интересной, увлекательной.\r\n23. Возможность проявить самостоятельность в работе.\r\n24. Желание приносить пользу людям.\r\n25. Желание попробовать различные варианты решения профессиональной задачи.\r\n26. Возможность привлечь свои разнообразные знания, напрямую с профессией не вязанные.\r\n27. Стремление узнать новое о давно известном и возможность усвоить трудное.\r\n28. Возможность выдвигать свои идеи, предлагать новые проблемы для решения, реализовывать их независимо от работающих рядом.\r\n29. Желание заниматься несколькими делами одновременно или переключаться с одного дела на другое.\r\n30. Стремление решать профессиональные задачи самому, а не следовать указаниям других.\r\n31. Возможность самовыражения, проявления своих способностей.\r\n\r\n\r\n\r\n\r\nМетодика В.К. Гербачевского «Определение уровня притязаний»\r\nИнструкция: прочтите каждое из приведенных в опроснике высказываний и отметьте, в какой степени Вы согласны или не согласны с ним. Обведите кружком соответствующую цифру в бланке ответов. Все высказывания относятся к тому, о чем Вы думаете, что чувствуете или хотите от Вашей учебной деятельности.\r\n \r\n1.\tУчеба мне уже порядком надоела\r\n2.\tЯ учусь на пределе своих сил\r\n3.\tЯ хочу показать все, на что способен\r\n4.\tЯ чувствую, что меня вынуждают стремиться к высокому результату\r\n5.\tМне интересно, что получится\r\n6.\tУчеба – довольно сложное занятие\r\n7.\tТо, что я делаю, никому не нужно\r\n8.\tМеня интересует, лучше или хуже мои результаты, чем у других\r\n9.\tМне бы хотелось поскорее заняться своими делами\r\n10.\tДумаю, что мои результаты в учебе будут высокими\r\n11.\tУчеба может причинить мне неприятности\r\n12.\tЧем лучше показываешь результат, тем больше хочется его превзойти\r\n13.\tЯ проявляю достаточно старания\r\n14.\tЯ считаю, что мой результат не случаен\r\n15.\tУчеба не вызывает у меня большого интереса\r\n16.\tЯ сам ставлю перед собой задачи\r\n17.\tЯ беспокоюсь по поводу своих результатов\r\n18.\tЯ ощущаю прилив сил\r\n19.\tЛучших результатов мне не добиться\r\n20.\tУчеба имеет для меня определенное значение\r\n21.\tЯ хочу ставить всё более и более трудные цели\r\n22.\tК своим результатам я отношусь равнодушно\r\n23.\tЧем дольше учишься, тем становится интереснее\r\n24.\tЯ не собираюсь «выкладываться» в учебе\r\n25.\tСкорее всего, мои результаты будут низкими\r\n26.\tКак ни старайся, результат от этого не измениться\r\n27.\tЯ бы занялся сейчас чем угодно, только не учебой\r\n28.\tУчеба – довольно простое занятие\r\n29.\tЯ способен на лучший результат\r\n30.\tЧем труднее цель, тем больше желание её достичь\r\n31.\tЯ чувствую, что могу преодолеть все трудности на пути к цели\r\n32.\tМне безразлично, какими будут мои результаты по сравнению с другими\r\n33.\tЯ увлекся учебой\r\n34.\tЯ хочу избежать низкого результата в учебе\r\n35.\tЯ чувствую себя независимым\r\n36.\tМне кажется, что я зря трачу время\r\n37.\tЯ учусь вполсилы\r\n38.\tМеня интересуют границы моих возможностей\r\n39.\tЯ хочу, чтобы мой результат в учебе оказался одним из лучших\r\n40.\tЯ сделаю все, что в моих силах для достижения цели\r\n41.\tЯ чувствую, что у меня ничего не выйдет\r\n42.\tИспытание – это лотерея\r\n \r\n\r\n\r\n \r\nМетодика исследования уровня субъективного контроля\r\n \r\nИнструкция: внимательно прочитайте каждое высказывание, напишите в бланке ответов только те высказывания, с которыми вы полностью согласны.\r\n \r\n1.\tПродвижение по службе больше зависит от удачного стечения обстоятельств, чем от личных способностей и усилий.\r\n2.\tБольшинство разводов происходит оттого, что люди не захотели приспособиться друг к другу.\r\n3.\tБолезнь - дело случая; если уж суждено заболеть, то ничего не поделаешь.\r\n4.\tЛюди оказываются одинокими из-за того, что сами не проявляют интереса и дружелюбия к окружающим.\r\n5.\tОсуществление моих желаний часто зависит от везения.\r\n6.\tБесполезно предпринимать усилия для того, чтобы завоевать симпатию других людей.\r\n7.\tВнешние обстоятельства, родители и благосостояние влияют на семейное счастье не меньше чем отношения супругов.\r\n8.\tЯ часто чувствую, что мало влияю на то, что происходит со мной.\r\n9.\tКак правило, руководство оказывается более эффективным, когда полностью контролирует действия подчиненных, а не полагается на их самостоятельность.\r\n10.\tМои отметки в школе часто зависели от случайных обстоятельств (например, от настроения учителя), чем от моих собственных усилий.\r\n11.\tКогда я строю планы, то, в общем, верю, что смогу осуществить их.\r\n12.\tТо, что многим людям кажется удачей или везением, на самом деле является результатом долгих целенаправленных усилий.\r\n13.\tДумаю, что правильный образ жизни может больше помочь здоровью, чем врачи и лекарства.\r\n14.\tЕсли люди не подходят друг другу то, как бы они ни старались, наладить семейную жизнь они все равно не смогут.\r\n15.\tТо хорошее, что я делаю, обычно бывает по достоинству оценено другими.\r\n16.\tДети вырастают такими, какими их воспитывают родители.\r\n17.\tДумаю, что случай или судьба не играют важной роли в моей жизни.\r\n18.\tЯ стараюсь не планировать далеко вперед, потому что многое зависит от того, как сложатся обстоятельства.\r\n19.\tМои отметки в школе больше всего зависели от моих усилий и степени подготовленности.\r\n20.\tВ семейных конфликтах я чаще чувствую вину за собой, чем за противоположной стороной.\r\n21.\tЖизнь людей зависит от стечения обстоятельств.\r\n22.\tЯ предпочитаю такое руководство, при котором можно самостоятельно определять, что и как делать.\r\n23.\tДумаю, что мой образ жизни ни в коей мере не является причиной моих болезней.\r\n24.\tКак правило, именно неудачное стечение обстоятельств мешает людям добиться успеха в своем деле.\r\n25.\tВ конце концов, за плохое управление организацией ответственны сами люди, которые в ней работают\r\n26.\tЯ часто чувствую, что ничего не могу изменить в сложившихся отношениях в семье.\r\n27.\tЕсли очень захочу я смогу расположить к себе любого.\r\n28.\tНа подрастающее поколение влияет так много разных обстоятельств, что усилия родителей по их воспитанию часто оказываются бесполезными.\r\n29.\tТо, что со мной случается,  дело моих рук.\r\n30.\tТрудно бывает понять, почему руководители поступают так, а не иначе.\r\n31.\tЧеловек, который не смог добиться успеха в своей работе, скорее всего, не проявил достаточно усилий.\r\n32.\tЧаще всего я могу добиться от членов моей семьи того, что я хочу.\r\n33.\tВ неприятностях и неудачах, происходивших в моей жизни, чаще были виноваты другие люди, чем я сам.\r\n34.\tРебенка всегда можно уберечь от простуды, если за ним следить и правильно его одевать.\r\n35.\tВ сложных обстоятельствах я предпочитаю подождать, пока проблемы разрешатся сами собой.\r\n36.\tУспех является результатом упорной работы и мало зависит от случая или везения.\r\n37.\tЯ чувствую, что от меня больше, чем от кого бы то ни было, зависит счастье моей семьи.\r\n38.\tМне всегда было трудно понять, почему я нравлюсь одним людям и не нравлюсь другим.\r\n39.\tЯ всегда предпочитаю принять решение и действовать самостоятельно, а не надеяться на помощь других людей или на судьбу.\r\n40.\tК сожалению, заслуги человека часто остаются непризнанными, несмотря на все его старания.\r\n41.\tВ семейной жизни бывают такие ситуации, которые не возможно разрешить даже при самом сильном желании.\r\n42.\tСпособные люди, не сумевшие реализовать свои возможности, должны винить в этом только самих себя.\r\n43.\tМногие мои успехи были возможны только благодаря помощи других людей.\r\n44.\tБольшинство неудач в моей жизни произошло от незнания или лени и мало зависело от везения или невезения.\r\n \r\n \r\n\r\n\r\n \r\nМетодика исследования степени развития рефлексивных способностей личности\r\n1.Стремитесь ли вы записать по возможности полнее все или большинство лекционных курсов?\r\nа)да;\r\nб)нет.\r\n2.При подготовке к экзаменам полагаетесь ли вы целиком на свою память или работаете с карандашом в руке?\r\nа)да, целиком полагаюсь на свою память;\r\nб)нет, работаю с карандашом.\r\n3.Свойственно ли вам в процессе подготовки к экзамену контролировать, проверять себя, чтобы выяснить, насколько хорошо усвоен материал?\r\nа)да;\r\nб)нет.\r\n4.Готовясь к экзаменам, доверяетесь ли вы целиком своей памяти или стремитесь записать основные положения, схемы, закономерности, факты?\r\nа)да, целиком доверяюсь своей памяти;\r\nб)нет, стремлюсь записать основное.\r\n5.Если вы не успели подготовить материал, идете ли вы сдавать экзамен со своей группой или откладываете (при возможности) на 2-3 дня?\r\nа)да, иду на риск;\r\nб)нет, откладываю.\r\n6.Стремитесь ли вы по каждой вынесенной на экзамен теме подготовить основные положения, тезисы для ответа?\r\nа)да;\r\nб)нет.\r\n7.Напишите ваше мнение, полезны ли экзамены?\r\nа) да, я люблю экзамены, они помогают заново осмыслить материал;\r\nб) нет, для меня они тяжелы.\r\n8.Обычно вы идете на экзамен подготовленными по всем вопросам?\r\nа)да;\r\nб)нет.\r\n9.Если вы беретесь за выполнение неинтересного для вас поручения, то обычно:\r\nа)стараетесь его выполнить как можно быстрее, не вдаваясь в подробности, лишь бы от вас отвязались;\r\nб)для вас результат собственных усилий слишком значим, чтобы что-то делать кое-как.\r\n10.При выполнении значимого и интересного дела для вас главное:\r\nа)оценка окружающими того, что вы делаете;\r\nб)ваше собственное мнение.\r\n11.Приступая к важному для вас делу, вы:\r\nа)стараетесь все заранее спланировать, составляете развернутый план предстоящих действий;\r\nб)скорее действуете по обстоятельствам.\r\n12.Вы думаете, что:\r\nа)не все надо делать одинаково тщательно;\r\nб)затрудняетесь сказать;\r\nв)любую работу следует выполнять тщательно, если за нее взялся.\r\n13.Вы настолько осторожны и практичны, что с вами случается меньше неприятных неожиданностей, чем с другими людьми?\r\nа)да;\r\nб)трудно сказать;\r\nв)нет.\r\n14.В большинстве дел вы:\r\nа)предпочитаете рискнуть; б)не знаете, как поступить; в)предпочитаете действовать наверняка.\r\n\r\n\r\n\r\nМетодика «Коммуникативные и организаторские способности»\r\nИнструкция: Вам необходимо ответить на все вопросы, которые будут предложены. Свободно выражайте свое мнение и отвечайте на них так: если ваш ответ на вопрос положителен, то поставьте против соответствующей ему цифры в бланке ответов знак «+», если отрицателен - то «-».\r\n \r\n1.Много ли у вас друзей, с которыми вы постоянно общаетесь?\r\n2.Часто ли вам удается убедить большинство своих товарищей в правоте вашего мнения?\r\n3.Долго ли вас беспокоит чувство обиды, причиненное вам кем-то из ваших товарищей?\r\n4.Всегда ли вам трудно ориентироваться в создавшейся критической ситуации?\r\n5.Есть ли у вас стремление к установлению новых знакомств с различными людьми?\r\n6.Нравится ли вам заниматься общественной работой?\r\n7.Верно ли, что вам приятнее и проще проводить время с книгами или за какими-либо другими занятиями, чем с людьми?\r\n8.Если возникли какие-то помехи в осуществлении ваших намерений, то легко ли вы отступаете от своих намерений?\r\n9.Легко ли вы устанавливаете контакт с людьми, которые значительно старше вас по возрасту?\r\n10.Любите ли вы придумывать и организовывать со своими товарищами различные игры и развлечения?\r\n11.Трудно ли для вас включиться в новые компании?\r\n12.Часто ли вы откладываете на другие дни те дела, которые нужно было бы выполнить сегодня?\r\n13.Легко ли вам удается установить контакты с незнакомыми людьми?\r\n14.Стремитесь ли вы добиваться, чтобы ваши товарищи действовали в соответствии с вашими мнениями?\r\n15.Трудно ли вы осваиваетесь в новом коллективе?\r\n16.Верно ли, что у вас не бывает конфликтов с товарищами из-за невыполнения ими своих обещаний, обязанностей, обязательств?\r\n17.Стремитесь ли вы при удобном случае познакомиться и побеседовать с незнакомым человеком?\r\n18.Часто ли в решении важных дел вы принимаете инициативу на себя?\r\n19.Раздражают ли вас окружающие люди, и хочется ли вам побыть одному?\r\n20.Правда ли, что вы обычно плохо ориентируетесь в незнакомой для вас обстановке?\r\n21.Нравится ли вам постоянно находиться среди людей?\r\n22.Возникает ли у вас раздражение, если вам не удается закончить начатое дело?\r\n23.Испытываете ли вы затруднения, неудобства или стеснения, если приходится проявить инициативу, чтобы познакомиться с новым человеком?\r\n24.Правда ли, что вы утомляетесь от частого общения с товарищами?\r\n25.Любите ли вы участвовать в коллективных играх?\r\n26.Часто ли вы проявляете инициативу при решении вопросов, затрагивающих интересы ваших товарищей?\r\n27.Правда ли, что вы чувствуете себя неуверенно среди малознакомых вам людей?\r\n28.Верно ли, что вы редко стремитесь к доказательству своей правоты?\r\n29.Полагаете ли вы, что вам не доставляет особого труда внести оживление в малознакомую для вас компанию?\r\n30.Принимаете ли вы участие в общественной работе в институте?\r\n31.Стремитесь ли вы ограничить круг своих знакомых не большим количеством людей?\r\n32.Верно ли, что вы не стремитесь отстаивать свое мнение или решение, если оно не было сразу принято вашими товарищами?\r\n33.Чувствуете ли вы себя непринужденно, попав в незнакомую для вас компанию?\r\n34.Охотно ли вы приступаете к организации различных мероприятий для своих товарищей?\r\n35.Правда ли, то вы чувствуете себя достаточно уверенным и спокойным, когда приходится говорить что-либо большой группе людей?\r\n36.Часто ли вы опаздываете в институт, на встречи, свидания?\r\n37.Верно ли, что у вас много друзей?\r\n38.Часто ли вы смущаетесь, чувствуя неловкость при общении с малоизвестными вам людьми?\r\n39.Часто ли вы оказываетесь в центре внимания у своих товарищей?\r\n40Правда ли, что вы не очень уверенно чувствуете себя в окружении большой  группы своих товарищей?\r\n";
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
            MethodicalReceptions[0].Add(MethodicalButton1.Text, "\t«ФАНТАСТИЧЕСКАЯ ДОБАВКА» \n\tПреподаватель дополняет реальную ситуацию фантастикой. Вы можете переносить учебную ситуацию на фантастическую планету; перенести реального или литературного героя во времени; рассмотреть изучаемую ситуацию с необычной точки зрения, например, глазами инопланетянина или древнего грека… \n\t«ЭМОЦИОНАЛЬНОЕ ВХОЖДЕНИЕ В УРОК» \n\tПреподаватель начинает урок с \"настройки\". Например, знакомим с планом урока. Это лучше делать в полушуточной манере. Например, так: \"Сначала мы вместе восхитимся глубокими знаниями — а для этого проведем маленький устный опрос. Потом попробуем ответить на вопрос... (звучит тема урока в вопросной форме). Затем потренируем мозги — порешаем задачи. И, наконец, вытащим из тайников памяти кое-что ценное... (называется тема повторения)\". Если есть техническая возможность, хорошей настройкой на урок будет короткая музыкальная фраза. \n\t«ТЕАТРАЛИЗАЦИЯ» \n\tЗнание на время игры становится нашим пространством. Мы погружены в него со всеми своими эмоциями. И замечаем то, что недоступно холодному наблюдателю со стороны. Разыгрывается сценка на учебную тему. \n\t«ПОСЛОВИЦА-ПОГОВОРКА» \n\tПреподаватель начинает урок с пословицы или поговорки, относящейся к теме урока. \n\t«ВЫСКАЗЫВАНИЯ ВЕЛИКИХ» \n\tПреподаватель начинает урок с высказывания выдающегося человека (людей), относящегося к теме урока. \n\t«ЭПИГРАФ» \n\tПреподаватель начинает урок с эпиграфа к данной теме. \n\t«ПРОБЛЕМНАЯ СИТУАЦИЯ»\n\tСоздаётся ситуация противоречия между известным и неизвестным. Последовательность применения данного приема такова: \n\t– Самостоятельное решение \n\t– Коллективная проверка результатов \n\t– Выявление причин разногласий результатов или затруднений выполнения \n\t– Постановка цели урока. \n\t\n\t«ПРОБЛЕМА ПРЕДЫДУЩЕГО УРОКА» \n\tВ конце урока обучающимся предлагается задание, в ходе которого должны возникнуть трудности с выполнением, из-за недостаточности знаний или недостаточностью времени, что подразумевает продолжение работы на следующем уроке. Таким образом, тему урока можно сформулировать накануне, а на следующем уроке лишь восстановить в памяти и обосновать. \n\t«ИНТЕЛЛЕКТУАЛЬНАЯ РАЗМИНКА» \n\tМожно начать урок с интеллектуальной разминки — два-три не слишком сложных вопроса на размышление. С традиционного устного короткого опроса — простого опроса, ибо основная его цель — настроить обучающегося на работу, а не устроить ему стресс с головомойкой.\n\t «НЕСТАНДАРТНЫЙ ВХОД В УРОК» \n\tУниверсальный прием, направленный на включении в активную мыследеятельность с первых минут урока. Преподаватель начинает урок с противоречивого факта, который трудно объяснить на основе имеющихся знаний. \n\t«АССОЦИАТИВНЫЙ РЯД» \n\tК теме или конкретному понятию урока нужно выписать в столбик слова-ассоциации. Выход будет следующим: \n\t• если ряд получился сравнительно правильным и достаточным, дать задание составить определение, используя записанные слова; \n\t• затем выслушать, сравнить со словарным вариантом, можно добавить новые слова в ассоциативный ряд;\n\t • оставить запись на доске, объяснить новую тему, в конце урока вернуться, что-либо добавить или стереть.\n\t");
            MethodicalReceptions[1].Add(MethodicalButton2.Text, "\t«ТЕМА-ВОПРОС» \r\nТема урока формулируется в виде вопроса. Обучающимся необходимо построить план действий, чтобы ответить на поставленный вопрос. Они выдвигают множество мнений, чем больше мнений, чем лучше развито умение слушать друг друга и поддерживать идеи других, тем интереснее и быстрее проходит работа. Руководить процессом отбора может сам преподаватель или выбранный студент, а педагог в этом случае может лишь высказывать свое мнение и направлять деятельность. \r\n«РАБОТА НАД ПОНЯТИЕМ» \r\nСтудентам предлагается для зрительного восприятия название темы урока и педагог просит объяснить значение каждого слова или отыскать в \"Толковом словаре\". \r\n«СИТУАЦИЯ ЯРКОГО ПЯТНА» \r\nСреди множества однотипных предметов, слов, цифр, фигур одно выделено цветом или размером. Через зрительное восприятие внимание концентрируется на выделенном предмете. Совместно определяется причина обособленности и общности всего предложенного. Далее определяется тема и цели урока. \r\n«ПОДВОДЯЩИЙ ДИАЛОГ» \r\nНа этапе актуализации учебного материала ведется беседа, направленная на обобщение, конкретизацию, логику рассуждения. Диалог подводится к тому, о чем обучающиеся не могут рассказать в силу некомпетентности или недостаточно полного обоснования своих действий. Тем самым возникает ситуация, для которой необходимы дополнительные исследования или действия. Ставится цель. \r\n«ГРУППИРОВКА» \r\nРяд слов, предметов, фигур, цифр предлагается учащимся разделить на группы, обосновывая свои высказывания. Основанием классификации будут внешние признаки, а вопрос: \"Почему имеют такие признаки?\" будет задачей урока. \r\n«ИСКЛЮЧЕНИЕ» \r\nПрием можно использовать через зрительное или слуховое восприятие. Повторяется основа приема \"Яркое пятно\", но в этом случае обучающимся необходимо через анализ общего и отличного, найти лишнее, обосновывая свой выбор. Формулируется учебная цель. \r\n«ДОМЫСЛИВАНИЕ» \r\nПредлагается тема урока и слова \"помощники\": Повторим; Изучим; Узнаем; Проверим. С помощью слов \"помощников\" учащиеся формулируют цели урока. \r\n«ЛИНИЯ ВРЕМЕНИ» \r\nПреподаватель чертит на доске линию, на которой обозначает этапы изучения темы, формы контроля; проговаривает о самых важных периодах, требующих от ребят стопроцентной самоотдачи, вместе находят уроки, на которых можно “передохнуть”. “Линия 15 времени” позволяет обучающимся увидеть, что именно может являться конечным продуктом изучения темы, что нужно знать и уметь для успешного усвоения каждой последующей темы. Это упражнение полезно для ребят, которые легче усваивают учебный материал от общего к частному. \r\n«ГЕНЕРАТОРЫ – КРИТИКИ» \r\nПедагог ставит проблему, не требующую длительного обсуждения. Формируются две группы: генераторы и критики. Пример: Задача первой группы - дать как можно большее число вариантов решений проблемы, которые могут быть самыми фантастическими. Все это делается без предварительной подготовки. Работа проводится быстро. Задача критиков: выбрать из предложенных решений проблемы наиболее подходящие. Задача педагога – направить работу учащихся так, чтобы они могли вывести то или иное правило, решить какую-то проблему, прибегая к своему опыту и знаниям. Данный метод можно использовать для активизации самостоятельной работы учащихся. \r\n«НЕОБЪЯВЛЕННАЯ ТЕМА» \r\nПриём, направленный создание внешней мотивации изучения темы урока. Данный прием позволяет привлечь интерес обучающихся к изучению новой темы, не блокируя восприятия непонятными терминами. Пример: Преподаватель записывает на доске слово «Тема», выдерживает паузу до тех пор, пока все не обратят внимание на руку педагога, которая не хочет выводит саму тему. Преподаватель: Ребята, извините, но моя рука отказалась написать тему урока, и, кажется, неслучайно! Вот вам еще одна загадка, которую вы разгадаете уже в середине урока: почему рука отказалась записать тему урока? Данный вопрос записывает в уголке классной доски. Преподаватель: Ребята, вам предстоит проанализировать и доказать, с точки зрения полезности, отсутствие темы в начале урока! Но начинать урок нам все равно надо, и начнем с хорошо знакомого материала… \r\n«ЗИГЗАГ» \r\nДанную стратегию уместно использовать для развития у учащихся следующих умений: \r\n• анализировать текст совместно с другими людьми; \r\n• вести исследовательскую работу в группе; \r\n• доступно передавать информацию другому человеку; \r\n• самостоятельно определять направление в изучении какого-то предмета с учетом интересов группы. Пример: Прием используется для изучения и систематизации большого по объему материала. Для этого предстоит сначала разбить текст на смысловые отрывки для взаимообучения. Количество отрывков должно совпадать с количеством членов групп. Например, если текст разбит на 5 смысловых отрывков, то в группах (назовем их условно рабочими) - 5 человек.\r\n");
            MethodicalReceptions[2].Add(MethodicalButton3.Text, "\t«ИНТЕЛЛЕКТУАЛЬНАЯ РАЗМИНКА» \r\nМожно начать урок с интеллектуальной разминки — два-три не слишком сложных вопроса на размышление. Разминку можно проводить по-разному: \r\n• Что лишнее? \r\n• Обобщить – что это … \r\n• Что пропущено – логическая цепочка \r\n• Какое слово скрывается и так далее. \r\n\r\nТаблички с понятиями и терминами вывешиваются на доске или оформляются в виде мультимедийной презентации и учащимся задаются вопросы. Интеллектуальная разминка не только настраивает учащихся на учебную деятельность, но и развивает мышление, внимание, умение анализировать, обобщать, выделять главное. \r\n«ОТСРОЧЕННАЯ ОТГАДКА» \r\nИспользуя работу над изучением этимологии слова, «говорящих фамилий», можно применять этот прием. В конце одного из уроков можно задать вопрос. Следующий урок нужно начать с ответа на этот вопрос.\r\n«ИГРА В СЛУЧАЙНОСТЬ» \r\nФормула: преподаватель вводит в урок элементы случайного выбора. Там, где правит бал случай, - там азарт. Пробуем поставить и его на службу. Для этого годится рулетка. Достаточно иметь круг из картона со стрелкой на гвоздике. Можно и наоборот – вращать диск относительно неподвижного указателя. Объектом случайного выбора может стать решаемая задача, тема повторения, тема доклада, вызываемый учащийся. Кроме рулетки подбрасывают вверх монетку (орел или решка), тянут жребий, вынимаем бочонки русского лото, с номером учащегося в журнале. \r\n«ОБСУЖДЕНИЕ ВЫПОЛНЕНИЯ ДОМАШНЕГО ЗАДАНИЯ»\r\nПреподаватель вместе с обучающимися обсуждает вопрос: насколько качественно выполнено домашнее задание. \r\n«ЛОВИ ОШИБКУ!» \r\nОбъясняя материал, преподаватель намеренно допускает ошибки. Сначала обучающиеся заранее предупреждаются об этом. Иногда им можно даже подсказывать «опасные места» интонацией или жестом. Научите обучающихся мгновенно пресекать ошибки условным знаком или пояснением, когда оно требуется. Поощряйте внимание и готовность вмешаться! Студент получает текст (или скажем, разбор решения задачи) со специально допущенными ошибками – пусть «поработает педагогом».\r\n«СВОЯ ОПОРА – ШПАРГАЛКА» (КОНКУРС ШПАРГАЛОК) \r\nФорма учебной работы, в процессе подготовки которой отрабатываются умения «сворачивать и разворачивать информацию» в определенных ограничительных условиях. Студент может отвечать по подготовленной дома «шпаргалке», если: \r\n1) «шпаргалка» оформлена на листе бумаги форматом А4; \r\n2) в шпаргалке нет текста, а информация представлена отдельными словами, условными знаками, схематичными рисунками, стрелками, расположением единиц информации относительно друг друга; \r\n3) количество слов и других единиц информации соответствует принятым условиям (например, на листе может быть не больше 10 слов, трех условных знаков, семи стрелок или линий). \r\n\r\nЛучшие «шпаргалки» по мере их использования на уроке вывешиваются на стенде. В конце изучения темы подводятся итоги, происходит награждение победителей. \r\n«КРОССВОРД» \r\nКроссворды на уроке – это актуализация и закрепление знаний, привлечение внимания к материалу, интеллектуальная зарядка в занимательной форме. Обучающиеся любят разгадывать загадки, ребусы и кроссворды. \r\n«Я БЕРУ ТЕБЯ С СОБОЙ» \r\nПриём, направленный на актуализацию знаний обучающихся, способствующий накоплению информации о признаках объектов. Формирует: \r\n• умение объединять объекты по общему значению признака; \r\n• умение определять имя признака, по которому объекты имеют общее значение; \r\n• умение сопоставлять, сравнивать большое количество объектов; \r\n• умение составлять целостный образ объекта из отдельных его признаков.\r\n\r\n Педагог загадывает признак, по которому собирается множество объектов и называет первый объект. Студенты пытаются угадать этот признак и по очереди называют объекты, обладающие, по их мнению, тем же значением признака. Преподаватель отвечает, берет он этот объект или нет. Игра продолжается до тех пор, пока кто-то из ребят не определит, по какому признаку собирается множество. Можно использовать в качестве разминки на уроках. \r\n«КОРЗИНА ИДЕЙ, ПОНЯТИЙ, ИМЕН» \r\nЭто прием организации индивидуальной и групповой работы обучающихся на начальной стадии урока, когда идет актуализация имеющегося у них опыта и знаний. Он позволяет выяснить все, что знают или думают обучающиеся по обсуждаемой теме урока. На доске можно нарисовать значок корзины, в которой условно будет собрано все то, что все ребята вместе знают об изучаемой теме.\r\n");
            MethodicalReceptions[3].Add(MethodicalButton4.Text, "\t«УДИВЛЯЙ!» \r\nПриём, направленный на активизацию мыслительной деятельности и привлечение интереса к теме урока. Формирует: умение анализировать; умение выделять и формулировать противоречие. Педагог находит такой угол зрения, при котором даже хорошо известные факты становятся загадкой. Хорошо известно, что ничто так не привлекает внимание и не стимулирует работу, как удивительное. Всегда можно найти такой угол зрения, при котором даже обыденное становится удивительным. Это могут быть факты из биографии писателей. \r\n«ПРЕСС-КОНФЕРЕНЦИЯ» \r\nПреподаватель намеренно неполно раскрывает тему, предложив обучающимся задать дораскрывающие ее вопросы. \r\n«КЛЮЧЕВЫЕ ТЕРМИНЫ» \r\nИз текста выбираются четыре-пять ключевых слов. Перед чтением текста учащимся, работающим парами или группами, предлагается дать общую трактовку этих терминов и предположить, как они будут применяться в конкретном контексте той темы, которую им предстоит изучить. После чтения текста, проверить, в этом ли значении употреблялись термины.\r\n «ПРИВЛЕКАТЕЛЬНАЯ ЦЕЛЬ»\r\nПеред студентами ставится простая, понятная и привлекательная для него цель, выполняя которую он волей-неволей выполняет и то учебное действие, которое планирует педагог. \r\n\r\n\r\n«МУЛЬТИМЕДИЙНАЯ ПРЕЗЕНТАЦИЯ» \r\nМультимедийная презентация - это представление материала с использованием компьютерной техники. Мультимедиа способствует развитию мотивации, коммуникативных способностей, получению навыков, накоплению фактических знаний, а также способствует развитию информационной грамотности. Облегчение процесса восприятия и запоминания информации с помощью ярких образов - это основа любой современной презентации.\r\n«ОТСРОЧЕННАЯ ОТГАДКА» \r\nПриём, направленный на активизацию мыслительной деятельности обучающихся на уроке. Формирует: умение анализировать и сопоставлять факты; умение определять противоречие; умение находить решение имеющимися ресурсами. \r\n1 вариант приема. В начале урока преподаватель дает загадку (удивительный факт), отгадка к которой (ключик для понимания) будет открыта на уроке при работе над новым материалом. \r\n2 вариант приема Загадку (удивительный факт) дать в конце урока, чтобы начать с нее следующее занятие.\r\n \r\n«ВОПРОСЫ К ТЕКСТУ»\r\n \r\nК изучаемому тексту предлагается за определенное время составить определенное количество вопросов - суждений: - Почему? - Как доказать? - Чем объяснить? - Вследствие чего? - В каком случае? - Каким образом? Схема с перечнем вопросов-суждений вывешивается на доске и оговаривается что, кто составил 7 вопросов за 7 минут, получает отметку “5”; 6 вопросов – “4”. Прочитав абзац, учащиеся выстраивают суждения, составляют вопрос и записывают его в тетрадь. Этот прием развивает познавательную деятельность обучающихся, их письменную речь.\r\n \r\n«РАБОТА С ИНТЕРНЕТ-РЕСУРСАМИ» \r\n\r\nДля студентов работа с Интернет-ресурсами – это доступ к огромному количеству необходимого иллюстративно-информационного материала, которого катастрофически не хватает в библиотеках. Это, прежде всего, толчок к самообразованию и активизации познавательной деятельность обучающихся. \r\n\r\n\r\n\r\n\r\n«ХОРОШО – ПЛОХО» \r\n\r\nПриём, направленный на активизацию мыслительной деятельности обучающихся на уроке, формирующий представление о том, как устроено противоречие. Формирует: \r\n• умение находить положительные и отрицательные стороны в любом объекте, ситуации; \r\n• умение разрешать противоречия (убирать «минусы», сохраняя «плюсы»); \r\n• умение оценивать объект, ситуацию с разных позиций, учитывая разные роли. \r\nВариант 1 Преподаватель задает объект или ситуацию. Обучающиеся (группы) по очереди называют «плюсы» и «минусы». \r\nВариант 2 Преподаватель задает объект (ситуацию). Обучающийся описывает ситуацию, для которой это полезно. Следующий обучающийся ищет, чем вредна эта последняя ситуация и т. д. \r\nВариант 3 Обучающиеся делятся на продавцов и покупателей. И те и другие представляют каких-то известных персонажей. Дальше играют по схеме. Только «плюсы» ищут с позиции персонажа – продавца, а «минусы» – с позиции персонажа – покупателя. \r\nВариант 4 Обучающиеся делятся на три группы: «прокуроры», «адвокаты», «судьи». Первые обвиняют (ищут минусы), вторые защищают (ищут плюсы), третьи пытаются разрешить противоречие (оставить «плюс» и убрать «минус»). \r\n\r\n«ВОПРС К ТЕКСТУ» \r\n\r\nПеред изучением учебного текста ставится задача: составить к тексту список вопросов. Список можно ограничить. Например, 3 репродуктивных вопроса и 3 расширяющих или развивающих. Совет: Пусть на уроках найдется место открытым вопросам: вот это мы изучили; вот это осталось за пределами программы; вот это я не знаю сам; вот это пока не знает никто…\r\n");
            MethodicalReceptions[4].Add(MethodicalButton5.Text, "\t«СВОЯ ОПОРА» \r\nОбучающийся составляет собственный опорный конспект по новому материалу. Этот приём уместен в тех случаях, когда преподаватель сам применяет подобные конспекты и учит пользоваться ими ребят. Как ослабленный вариант приёма можно рекомендовать составление развёрнутого плана ответа (как на экзамене). Замечательно, если обучающиеся успеют объяснить друг другу свои опорные конспекты, хотя бы частично. \r\n«ДА-НЕТ» \r\nПреподаватель загадывает нечто (число, предмет, литературного или исторического героя и др.). Студенты пытаются найти ответ, задавая вопросы. На эти вопросы педагог отвечает только словами: \"да\", \"нет\", \"и да и нет\". \"Да-нет\" учит: \r\n• связывать разрозненные факты в единую картину; \r\n• систематизировать уже имеющуюся информацию; \r\n• слушать и слышать товарищей. \r\n\r\n«СОРБОНКА» \r\nПрием предназначен для заучивания исторических дат, всевозможных определений, иностранных слов, и т.д. На одной стороне карточки записывается понятие, слово, дата, а на 20 другой – ответ. Обучающийся перебирает карточки, пытается дать ответ и тут же проверяет себя. Анимированный вариант сорбонки может сделать это процесс запоминания более привлекательным и разнообразным. Объектами запоминания могут быть не только слова, даты, термины, но и карты и другие наглядные объекты. \r\n«РАБОТА В ГРУППАХ»\r\nГруппы получают одно и то же задание. В зависимости от типа задания результат работы группы может быть или представлен на проверку преподавателю, или спикер одной из групп раскрывает результаты работы, а другие учащиеся его дополняют или опровергают. \r\n«ИГРА – ТРЕНИНГ» \r\nЭти игры приходят на помощь в трудный момент — чтобы растворить скуку однообразия... \r\n1. Если необходимо проделать большое число однообразных упражнений, преподаватель включает их в игровую оболочку, в которой эти действия выполняются для достижения игровой цели. \r\n2. Студенты соревнуются, выполняя по очереди действия в соответствии с определенным правилом, когда всякое последующее действие зависит от предыдущего. \r\n\r\n\r\n\r\n«ДЕЛОВАЯ ИГРА «Я – ПЕДАГОГ»» \r\nИспользование такой формы урока, как деловая игра, можно рассматривать как развитие ролевого подхода. В деловой игре у каждого обучающегося вполне определенная роль. Подготовка и организация деловой игры требует многосторонней и тщательной подготовки, что в свою очередь гарантирует успех такого урока у обучающихся. Играть всегда и всем интереснее, чем учиться. Ведь с удовольствием играя, как правило, не замечаешь процесса обучения. \r\n«ЩАДЯЩИЙ ОПРОС» \r\nПреподаватель проводит тренировочный опрос, сам, не выслушивая ответов студентов. Группа разбивается на две части по рядам-вариантам. Преподаватель задает вопрос. На него отвечает первая группа. При этом каждый обучающийся дает ответ на этот вопрос своему соседу по парте — обучающемуся второй группы. Затем на этот же вопрос отвечает педагог или сильный обучающийся. Обучающиеся второй группы, прослушав ответ преподавателя, сравнивают его с ответом товарища и выставляют ему оценку или просто \"+\" или \"-\". На следующий вопрос преподавателя отвечают обучающиеся второй группы, а ребята первой их прослушивают. Теперь они в роли преподавателя и после ответа педагога выставляют обучающимся второй группы отметку. Таким образом, задав 10 вопросов, добиваются того, что каждый обучающийся в группе ответит на 5 вопросов, прослушает ответы преподавателя на все вопросы, оценит своего товарища по 5 вопросам. Каждый обучающийся при такой форме опроса выступает и в роли отвечающего, и в роли контролирующего. В конце опроса ребята выставляют друг другу оценки. \r\n«ТЕСТЫ» \r\nВиды тестов: установочный; тест-напоминание; обучающий; тест-дополнение; диагностический; тест-сличение; итоговый; тест-ранжирование. А также: письменный, компьютерный, тест с выбором ответа, тест с «изюминкой», тест-сопоставление, тест с развёрнутым ответом и др. \r\n«ГЛУХИЕ ИНТЕЛЛЕКТ – КАРТЫ» \r\nСтудентам раздаются распечатанные интеллект – карты с отсутствующими связями, понятиями. Ребята восполняют интеллект-кату. Прием эффективен, если преподаватель при объяснении нового материала демонстрировал полностью заполненную интеллект-карту.  \r\n«ЧТЕНИЕ – СУММИРОВАНИЕ ПРОЧИТАННОГО В ПАРАХ» \r\nЭтот прием особенно эффективен, когда изучаемый текст достаточно ―густой, перегруженный фактическим материалом, касается сложных предметных областей. Попросите обучающихся разбиться на пары, а затем пары рассчитаться на 1, 2, 3, 4. Каждая пара получает соответствующий номер. Сообщите обучающимся, что они будут сейчас читать статью, но достаточно непривычным образом. Поясните, что статья разделена на четыре части и парам будет дана для изучения часть статьи под соответствующим номером. А теперь каждая из этих ―четвертинок‖ делится пополам. Это делается для того, чтобы один член пары был докладчиком, а другой ответчиком по первой части, на вторую половину они меняются ролями. Однако в конце урока обучающиеся должны знать содержание статьи целиком. В задачу докладчика входит: внимательно прочитать текст и быть готовым суммировать прочитанное. После того, как они почитают свою часть, они должны быть готовы ―доложить партнерам прочитанное своими словами \r\n«РАБОТА ПО ДИДАКТИЧЕСКИМ КАРТОЧКАМ» \r\nКарточки, должны быть распечатаны и розданы обучающимся. Они содержат вопросы и задания различных уровней сложности. Работа с карточками в личностно-ориентированном уроке начинается с выбора задания обучающимися. Преподаватель не принимает никакого участия в процессе выбора карточки обучающимся. Роль преподавателя при работе с карточками сводится к минимуму. Он становится наблюдателем и, в нужный момент, помощником, а не руководителем. При выборе карточки ребята проходят три этапа: \r\n• 1 этап – выбор задания (по содержанию) \r\n• 2 этап – по степени сложности ( * - легкое, ** - сложное) \r\n• 3 этап – характер задания (творческое, репродуктивное) \r\n\r\nОбщее число сочетаний всех наших параметров выбора даёт нам набор ДК, состоящих из 6 карточек. Каждый параметр выбора обозначается на ДК соответствующим значком: тип задания по содержанию, степень его сложности и характер задания. Эти значки помогают каждому учащемуся сделать осознанный выбор.\r\n");
            MethodicalReceptions[5].Add(MethodicalButton6.Text, "\t«МИНИ-ПРОЕКТЫ» \r\nУчебный проект, как комплексный и многоцелевой метод, имеет большое количество видов и разновидностей. Исследовательский мини-проект по структуре напоминает подлинно научное исследование. Оно включает обоснование актуальности выбранной темы, обозначение задач исследования, обязательное выдвижение гипотезы с последующей ее проверкой, обсуждение полученных результатов. При этом используются методы современной науки: лабораторный эксперимент, моделирование, социологический опрос. Обучающиеся могут сами выбрать возрастную группу для опроса в зависимости от поставленной перед ними задачи или группу для опроса определяет преподаватель (этот вариант более приемлем на первоначальном этапе, когда ребята только знакомятся с такой формой работы). \r\n«РЕШЕНИЕ СИТУАЦИОННЫХ ЗАДАЧ» \r\nДанный тип задач является инновационным инструментарием, формирующим как традиционные предметные образовательные результаты, так и новые – личностные и метапредметные результаты образования. Ситуационные задачи – это задачи, позволяющие обучающемуся осваивать интеллектуальные операции последовательно в процессе работы с информацией: ознакомление – понимание – применение – анализ – синтез – оценка. Специфика ситуационной задачи заключается в том, что она носит ярко выраженный практико-ориентированный характер, но для ее решения необходимо конкретное предметное знание. Кроме этого, такая задача имеет не традиционный номер, а красивое название, отражающее ее смысл. Обязательным элементом задачи является проблемный вопрос, который должен быть сформулирован таким образом, чтобы учащемуся захотелось найти на него ответ. \r\n«МИНИ-ИССЛЕДОВАНИЕ» \r\nПреподаватель “подталкивает” обучающихся к правильному выбору темы исследования, попросив ответить на следующие вопросы: Что мне интересно больше всего? Чем я хочу заниматься в первую очередь? О чём хотелось бы узнать как можно больше? Ответив на эти вопросы, обучающийся может получить совет преподавателя, какую тему исследования можно выбрать. Тема может быть: - фантастической (обучающийся выдвигает какую-то фантастическую гипотезу); - экспериментальной; - изобретательской; - теоретической. \r\n«РАБОТА С КОМПЬЮТЕРОМ» \r\nОбучающиеся решают учебные задачи с использованием ТСО. \r\n«В СВОЁМ ТЕМПЕ» \r\nПри решении учебных задач каждый обучающийся работает в темпе, определяемом им самим. \r\n«ОЗВУЧИВАНИЕ «НЕМОГО КИНО»» \r\nСтуденты озвучивают фрагмент художественного, мультипликационного и др. фильма после предварительной подготовки. \r\n«РЕСТАВРАТОР» \r\nСтуденты восстанавливают текстовый фрагмент, намеренно «поврежденный» преподавателем.\r\n«РАБОТА С ИЛЛЮСТРАТИВНЫМ МАТЕРИАЛОМ» \r\nМетодика работы с иллюстративным материалом во многих случаях включает два этапа. На первом этапе создается представление об изображенном, осуществляется запоминание, на втором — деятельность обучающихся направляется на усвоение связей между понятиями, на использование знаний в подобной и новой ситуациях. Наиболее простая и эффективная форма работы с иллюстрациями — выполнение определенных заданий. \r\n«СОЗДАЙ ПАСПОРТ» \r\nПрием для систематизации, обобщения полученных знаний; для выделения существенных и несущественных признаков изучаемого явления; создания краткой характеристики изучаемого понятия, сравнения его с другими сходными понятиями. Это универсальный прием составления обобщенной характеристики изучаемого явления по определенному плану. \r\n«ВОПРОСИТЕЛЬНЫЕ СЛОВА» \r\nПрием, направленный на формирование умения задавать вопросы, а также может быть использован для актуализации знаний обучающихся по пройденной теме урока. Обучающимся предлагается таблица вопросов и терминов по изученной теме или новой теме урока. Необходимо составить как можно больше вопросов, используя вопросительные слова и термины из двух столбцов таблицы.\r\n«ДЕРЕВО ПРЕДСКАЗАНИЙ» \r\nПравила работы с данным приемом таковы: ствол дерева - тема, ветви - предположения, которые ведутся по двум основным направлениям - \"возможно\" и \"вероятно\" ( количество \"ветвей\" не ограничено), и, наконец, \"листья\" - обоснование этих предположений, аргументы в пользу того или иного мнения. \" \r\n");
            MethodicalReceptions[6].Add(MethodicalButton7.Text, "\t«ТЕСТ» \r\nОбучающиеся получают задание выбрать из предложенных вариантов правильный ответ. \r\n«СВОЯ ОПОРА» \r\nСтудент составляет авторский опорный конспект изученной темы. Это имеет смысл делать на листе большого формата. Не обязательно всем повторять одну тему. Пусть, например, половина обучающихся повторяет одну тему, а половина – другую, после чего они попарно раскрывают друг другу свои опоры. Или такая форма работы: несколько обучающихся развешивают свои авторские опоры - плакаты на стене, остальные собираются в малые группы и обсуждают их. \r\n\r\n «ИНТЕЛЛЕКТ-КАРТЫ» \r\nИнтеллект-карты отражают процесс ассоциативного мышления. Они отражают связи (смысловые, ассоциативные, причинно-следственные и др.) между понятиями, частями, составляющими проблемы или предметной области которую мы рассматриваем. Интеллект карты эффективны при развитии памяти, генерировании ассоциаций, мозговом штурме, при сотворении общей картины, указании взаимосвязей, планирования. Интеллект-карты позволяют легко понять, запомнить и работать со сложной по структуре и объему информацией. Правила создания интеллект-карт следующие: \r\n• Для создания карт используются только цветные карандаши, маркеры и т.д. \r\n• Основная идея, проблема или слово располагается в центре. \r\n• Для изображения центральной идеи можно использовать рисунки, картинки. \r\n• Каждая ветвь имеет свой цвет. \r\n• Главные ветви соединяются с центральной идеей, а ветви второго, третьего и т.д. порядка соединяются с главными ветвями. \r\n• Ветки должны быть изогнутыми. \r\n• Над каждой линией – ветвью пишется только одно ключевое слово. \r\n• Для лучшего запоминания и усвоения желательно использовать рисунки, картинки, ассоциации о каждом слове. \r\n• Разросшиеся ветви можно заключать в контуры, чтобы они не смешивались с соседними ветвями. \r\n\r\nСпециальные информационные технологии позволяют составлять интеллект-карты при помощи специальных программ. Интеллект-карту удобно сочетать с таблицей ЗХУ (Знал, узнал, хочу знать). При составлении интеллект-карты обучающимися самостоятельно должно соблюдаться условие: текст с которым работают учащиеся, должен быть небольшим, т.к. данная работа занимает много времени. \r\n«ПОВТОРЯЕМ С КОНТРОЛЕМ» \r\nСтуденты разрабатывают списки контрольных вопросов ко всей ранее изученной теме. Возможен конкурс списков. Можно провести контрольный опрос по одному из списков. \r\n«ПЕРЕСЕЧЕНИЕ ТЕМ» \r\nОбучающиеся подбирают (или придумывают) свои примеры, задачи, гипотезы, идеи, вопросы, связывающие последний изученный материал с любой ранее изученной темой, указанной преподавателем. \r\n«ПРОБЛЕМНАЯ ЗАДАЧА» \r\nПроблемная задача ставит вопрос или вопросы: \"Как разрешить это противоречие? Чем это объяснить?\" Серия проблемных вопросов трансформирует проблемную задачу в модель поисков решения, где рассматриваются различные пути, средства и методы решения. Проблемный метод предполагает следующие шаги: проблемная ситуация → проблемная задача → модель поисков решения → решение. В классификации проблемных задач понятие выделяют задачи с неопределенностью условий или искомого, с избыточными, противоречивыми, частично неверными данными. Главное в проблемном обучении — сам процесс поиска и выбора верных, оптимальных решений, а не мгновенный выход на решение. Хотя преподавателю с самого начала известен кратчайший путь к решению проблемы, сам процесс поиска шаг за шагом ведет к решению проблемы.\r\n «ПЛЮС – МИНУС» \r\nЦель этого приема – показать неоднозначность любого общественного и исторического явления, например: Найти отрицательное и положительное.\r\n");
            MethodicalReceptions[7].Add(MethodicalButton8.Text, "\t«ОПРОС ПО ЦЕПОЧКЕ» \r\nРассказ одного обучающегося прерывается в любом месте и продолжается другим обучающимся. Прием применим в случае, когда предполагается развернутый, логически связный ответ.\r\n«ПРОГРАММИРУЕМЫЙ ОПРОС» \r\nОбучающийся выбирает один верный ответ из нескольких предложенных.\r\n«ТИХИЙ ОПРОС» \r\nБеседа с одним или несколькими студентами происходит полушепотом, в то время как группа занята другим делом. \r\n«БЛИЦ-КОНТРОЛЬНАЯ» \r\nКонтроль проводится в высоком темпе для выявления степени усвоения простых учебных навыков, которыми обязаны овладеть обучающиеся для дальнейшей успешной учебы. По темпу блиц-контрольная сходна с фактологическим диктантом. Включает в себя 7—10 стандартных заданий. Время — примерно по минуте на задание. Технология проведения: \r\nдо: условия по вариантам открываются на доске или на плакате. При возможности Линии сравнения Февральская революция 1917 года Октябрьская революция 1917 года 1. Причины и задачи 2. Повод (если есть) 3. Движущие силы 4. Ход революции 5.Характер революции 6. Итоги и значение. 26 условия распечатываются и кладутся на парты текстом вниз. По команде — переворачиваются. \r\nво время: на парте — чистый лист и ручка. По команде учащиеся приступают к работе. Никаких пояснений или стандартного оформления задания не делается. По истечении времени работа прекращается по четкой команде. \r\nпосле: работы сдаются преподавателю или применяется вариант самопроверки: а) преподаватель диктует правильные ответы или, что лучше, вывешивает таблицу правильных ответов. Учащиеся отмечают знаками \"+\" и \"—\" свои результаты; б) небольшое обсуждение по вопросам учащихся; в) задается норма оценки. Например: из 7 заданий 6 \"плюсиков\" — отметка \"5\", 5 \"плюсиков\" — \"4\", не менее трех — отметка \"3\"; \r\n«ТОЛСТЫЙ И ТОНКИЙ ВОПРОС»\r\n Это прием из технологии развития критического мышления используется для организации взаимоопроса. Стратегия позволяет формировать: умение формулировать вопросы; умение соотносить понятия. Тонкий вопрос предполагает однозначный краткий ответ. Толстый вопрос предполагает ответ развернутый. После изучения темы учащимся предлагается сформулировать по три «тонких» и три «толстых» вопроса», связанных с пройденным материалом. Затем они опрашивают друг друга, используя таблицы «толстых» и «тонких» вопросов. \r\n«КРУГЛЫЙ СТОЛ»\r\nПисьменный «Круглый стол» — это метод обучения сообща, при котором лист и ручка постоянно передаются по кругу среди небольшой группы участников игры. К примеру, один из партнеров записывает какую-то идею, затем передает лист соседу слева. Тот добавляет к этой идее какие-то свои соображения и передает лист дальше. В одном из вариантов этой процедуры каждый участник делает запись своим цветом. Это чисто зрительно усиливает ощущение равной лепты, которую вносит каждый в формирование общего мнения, и позволяет преподавателю разобраться и зафиксировать участие каждого. Устный «Круглый стол» — метод обучения сообща, сходный с предыдущим, только проводится он в устной форме. Каждый участник, по очереди, подхватывает и развивает идею, высказанную предыдущим.\r\n");
            MethodicalReceptions[8].Add(MethodicalButton9.Text, "\t«ВЫБЕРИ ВЕРНОЕ УТВЕРЖДЕНИЕ» \r\nОбучающимся предлагается выбрать подходящее утверждение \r\n1) Я сам не смог справиться с затруднением; \r\n2) У меня не было затруднений;\r\n3) Я только слушал предложения других; \r\n4) Я выдвигал идеи…. \r\n\r\n«МОДЕЛИРОВАНИЕ ИЛИ СХЕМАТИЗАЦИЯ» \r\nОбучающиеся моделируют или представляют свое понимание, действия в виде рисунка или схемы.\r\n«ПОМЕТКИ НА ПОЛЯХ» \r\nОбозначение с помощью знаков на полях возле текста или в самом тексте: «+» - знал, «!» - новый материал (узнал), «?» - хочу узнать \r\n«ПРОДОЛЖИ ФРАЗУ»\r\n Карточка с заданием «Продолжить фразу»: \r\n• Мне было интересно… \r\n• Мы сегодня разобрались…. \r\n• Я сегодня понял, что… \r\n• Мне было трудно… \r\n• Завтра я хочу на уроке… \r\n\r\n«ЛЕСЕНКА «МОЁ СОСТОЯНИЕ»» \r\nОбучающийся отмечает соответствующую ступеньку лесенки. \r\nКомфортно \r\n                                                                                      Уверен в своих силах \r\n                                                                             Хорошо \r\n                                                                   Плохо \r\n                                           Крайне скверно\r\n«ВОПРОСЫ ИТОГОВОЙ РЕФЛЕКСИИ, КОТОРЫЕ ЗАДАЮТСЯ ПРЕПОДАВАТЕЛЕМ В КОНЦЕ УРОКА» \r\n• Как бы вы назвали урок? \r\n• Что было самым важным на уроке? \r\n• Зачем мы сегодня на уроке…? \r\n• Какова тема сегодняшнего урока? \r\n• Какова цель урока? \r\n• Чему посвятим следующий урок? \r\n• Какая задача будет стоять перед нами на следующем уроке? \r\n• Что для тебя было легко (трудно)? \r\n• Доволен ли ты своей работой? \r\n• За что ты хочешь похвалить себя или кого-то из одногруппников? \r\n\r\n«ХОЧУ СПРОСИТЬ» \r\nРефлексивный прием, способствующий организации эмоционального отклика на уроке. Обучающийся задает вопрос, начиная со слов «Хочу спросить…». На полученный ответ сообщает свое эмоциональное отношение: «Я удовлетворен….» или «Я неудовлетворен, потому что …»\r\n «ПРОДОЛЖИ ФРАЗУ…» \r\nПрием рефлексии используется чаще всего на уроках после изучения большого раздела. Суть - зафиксировать свои продвижения в учебе, а также, возможно, в отношениях с другими. Рюкзак перемещается от одного учащегося к другому. Каждый не просто фиксирует успех, но и приводит конкретный пример. Если нужно собраться с мыслями, можно сказать \"пропускаю ход\".\r\n");
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