﻿using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Numerics;
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

        string InstructionHelperText = "Здесь описана основная функция приложения и то, как рекомендуется работать с материалами.";
        string MenuHelperText = "С помощью этого меню, Вы можете узнать много полезной информации. Нажмите на интересующую Вас клавишу.";
        string CreateLessonText1 = "Выберите урок в зависимости от дидактической цели.";
        string CreateLessonText2 = "Выберите урок в зависимости от его формы.";
        string CreateLessonText3 = "Выберите этап урока, на котором хотели бы использовать методические приёмы по повышению мотивации студентов. Можно выбрать несколько. После закройте это окошечко и нажмите кнопку Далее.";
        string OtherText = "Здесь вы можете проверить себя и узнать дополнительную информацию по созданию презентаций и диагностике учебной мотивации студентов.";
        string MethodicalText = "Здесь Вы можете посмотреть различные методические приемы по мотивации студентов на разных этапах урока.";
        string MethodicalTextSelect = "Выберите этап урока, на котором хотели бы использовать методические приёмы по повышению мотивации студентов. Можно выбрать несколько. После закройте это окошечко и нажмите кнопку Далее.";
        string TeacherTestText = "Тест на удовлетворённость работой (Р. Кунина).";
        string TestRecomendation = "По результатам тестирования можно выделить шесть рекомендаций, которые помогут Вам поддерживать собственное благополучие \r\n\r\n1. Повышайте «эмоциональную» квалификацию\r\n\r\n \r\n    Профессиональное развитие является одним из важных факторов высокого субъективного благополучия учителей. Но программы повышения квалификации могут быть направлены не только на развитие профессиональных знаний, но и на сферу эмоций педагогов.\r\n\r\n    Пример программы по развитию осознанности —  программа «Повышение осведомленности и жизнестойкости в сфере образования» (Cultivating Awareness and Resilience in Education, CARE). Она предназначена для обучения учителей и других работников образовательной сферы. Педагогов учат тому, что называется осознанностью: успокаивать тело и разум с помощью дыхания и движения, а также использовать идеи позитивной психологии, чтобы лучше регулировать свои эмоции. \r\n\r\n    На программе же педагоги учатся сделать паузу, поразмышлять и получить более точное представление о ситуации. Например, в момент столкновения с триггером можно сфокусироваться на дыхании.  Сосредоточить внимание на дыхании — это простой способ замедлиться и переключить внимание со стрессовой ситуации, а также перевести свое тело из состояния стресса в состояние расслабления. Проследив за своим дыханием даже на протяжении 30 секунд, можно уберечь себя от поспешных выводов и поступков. \r\n\r\n    В течение дня также можно попробовать практиковать «самопроверку» — остановиться и подумать, что чувствуете вы и ваше тело: усталость, грусть, холод, жажду и т. д. Цель техники состоит в том, чтобы, осознав и признав свои ощущения,  почувствовать себя в настоящем моменте.    \r\n\r\n \r\n2. Установите рабочие границы\r\n\r\n    Соблюдение рабочих границ позволяет не только сохранить баланс между личной и профессиональной жизнью, но и улучшить общее психологическое состояние. \r\n\r\n    Начните с постановки небольших целей и для этого в течение недели или двух ведите дневник, записывая туда все свои дела. Это позволит увидеть закономерности в своем расписании и понять, что можно изменить. \r\n\r\n    Например, чтобы снизить затраты времени на планирование сделайте универсальный банк заданий и видов активности, из которых, как из конструктора, можно затем создавать различные занятия.\r\n\r\n    С помощью дневника необходимо найти и установить комфортные для себя границы между работой и личной жизнью. Сначала определите для себя время работы и время, когда вы не будете отвечать на рабочие сообщения или звонки. Сделайте полноценный перерыв на обед, не совмещая его с решением рабочих задач, установите  время для последней проверки электронной почты и мессенджеров. \r\n\r\n    Также важно не забывать о своих личных интересах и хобби. Учителя должны находить время для занятий спортом, чтения, путешествий или других увлечений, которые помогают им расслабиться и восстановить энергию. \r\n\r\n    Также эксперты фонда предостерегают: «Не переусердствуйте: учителя — люди добросовестные, и есть соблазн ответить «да» на все, о чем вас спрашивают. Спросите себя, поддерживают ли эти предложения ваши приоритеты, и говорите «нет», когда это необходимо».\r\n\r\n\r\n3. Укрепляйте отношения с коллегами\r\n\r\n    Исследования показали, что эмоциональное выгорание «заразно»: учителя, которые контактируют с «перегоревшими коллегами, сами подвергаются большему риску. Межличностные взаимодействия между педагогами действуют в школе как «каналы распространения выгорания». \r\n\r\n    Для учителей важны три группы поддержки. Директора школ могут создавать позитивную и благоприятную рабочую среду. Коллеги способны поддерживать друг друга, работать сообща, снижать групповой стресс и требования профессиональной жизни и помогать регулировать эмоции. Учащиеся могут стать «эмоциональным вознаграждением» за работу педагога и придавать смысл профессии.\r\n\r\n\r\n4. Учите учеников ценить ваши усилия\r\n\r\n    Это поможет создать атмосферу уважения и признания, которая, в свою очередь, повысит ваше субъективное благополучие.\r\n\r\n    Как учителя могут создать положительные отношения с обучающимися? Во-первых, они могут проявлять интерес к жизни и предпочтениям своих учеников; во-вторых, использовать позитивное общение, включая похвалу и поддержку, чтобы помочь учащимся почувствовать себя увереннее и успешнее; в-третьих, подключать различные инновационные методы, такие как игры и коллективные задания, чтобы помочь ученикам улучшить свои отношения друг с другом и с ними.\r\n\r\n \r\n5. Развивайте свою креативность\r\n\r\n    Подходите к подготовке занятий творчески, исследуйте разные методики и формы обучения. Это поможет не только сделать уроки более интересными для учеников, но и добавит вам энтузиазм и удовольствие от работы.\r\n\r\n    Исследования показывают, чем выше степень креативности у учителя, тем выше и уровень его благополучия. Такие учителя испытывают большее чувство удовлетворенности от своей работы и имеют более высокую мотивацию.\r\n\r\n    Важно участвовать в профессиональных сообществах людей со схожими интересами, которые могут поддержать новаторский взгляд педагога.\r\n\r\n    Развивать креативность учителя можно через изучение и внедрение новых методов обучения, направленных на развитие изобретательности учеников. Внедряя такие методы, педагог вынужден мыслить открыто, развивать и свои творческие способности. Например, учитель может задавать учащимся открытые вопросы, не имеющие одного верного ответа и требующие творческого поиска решения. \r\n\r\n\r\n6. Внедряйте технологии\r\n\r\n    Использование цифровых технологий может позволить учителям снизить стресс, связанный с подготовкой к урокам и оценкой работ студентов. Например, использование онлайн-инструментов для автоматического сбора, проверки и оценки работ, таких, как Учи.ру или  ЯКласс, может существенно сократить время, затрачиваемое на эти процессы.\r\n    С помощью различных сервисов можно лучше организовать свое рабочее время. Например, использовать различные планировщики задач, такие, как Notion или Evernote. \r\n\r\n    Благодаря развитию технологий упростилась и коммуникация. Исследования продемонстрировали, что использование цифровых средств общения позволяет установить с родителями учащихся более открытые, партнерские отношения. Однако увеличение количества цифровой коммуникации несет риск размывания границ между работой и личной жизнью. Решение можно найти, используя, например, сервис VK Мессенджер, который позволяет учителю иметь два профиля — личный и рабочий; а значит, во время отдыха можно продолжать общаться с родными и друзьями, не отвлекаясь на рабочую переписку.    \r\n\r\n    Такие сообщества, как, например, Форум классных руководителей или Амбассадоры цифрового образования,  позволяют участникам оперативно реагировать на запросы  и поддерживать друг друга и  в профессиональных вопросах, и в личном общении, делиться экспертизой и  участвовать в событиях друг друга (викторинах, семинарах и т. д.). \r\n\r\n    Кроме того, использование цифровых технологий может помочь учителям проводить более интерактивные уроки, что сделает их интереснее и для учеников, и для самих педагогов. Например, с помощью сервиса Учи.ру можно создавать игровые задания.\r\n";
        string CheckYourselfText1 = "Посмотрите на очередность текста слева и нажимайте по такой же очереди на текст справа. Каждый верный ответ - 1 балл.";
        string CheckYourselfText2 = "Вам нужно выбрать 2 подходящих варианта ответа. Каждый ответ оценивается от 1 до 2 балла.";
        //ClassTechnicalMaps CTM = new ClassTechnicalMaps();
        Color defaultButtonColor = SystemColors.ControlLight;
        Color selectButtonColor = Color.Teal;
        bool MethodicalSelect;


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

            LiteraturesRichTextBox.Text = "1. Гин А. А. Приемы педагогической техники. Свобода выбора. Открытость. Деятельность. Обратная Связь. Идеальность/ М.: Вита-Пресс, 2019 г. \r\n2. Селевко Г.К. Современные образовательные технологии: Учебное пособие./М.: Народное образование, 2017 г. \r\n3. Поляков С. Педагогическая инноватика: от идеи до практики/ М., 2018 г. \r\n4. Карабанова О.А. Что такое универсальные учебные действия и зачем они нужны /Муниципальное образование: инновации и эксперимент. – 2019 г. - № 2. \r\n5. Формирование универсальных учебных действий в основной школе: от действия к мысли. Система заданий : пособие для учителя. / Под ред. А.Г. Асмолова. - М.: Просвещение, 2016 г. \r\n6. Якушина Е.В. Готовимся к уроку в условиях новых ФГОС/ М., 2019 г. \r\n7. Лукьянова М.И. и др. Личностно - ориетированный урок: конструирование и диагностика. Учебно-методическое пособие/ Под ред. М.И.Лукьяновой. – М.: Центр педагогический поиск, 2017 г. \r\n8. Кашлев С.С. Технология интерактивного обучения. /Минск: Белорусский верасень, 2017 г. \r\n9. Брыкова О.В., Громова Т.В. Проектная деятельность в учебном процессе / М.: Чистые пруды, 2020 г. \r\n10. Бондарева Н.А. Технологические карты конструирования уроков / М.: Просвещение, 2018 г. \r\n11. Чернобай. С.В. Технология подготовки урока в современной информационной образовательной среде)/ М.: Просвещение, 2019 г.\r\n12. Прягаева, Е.А. Резервы качества современного урока в условиях реализации федерального образовательного стандарта среднего профессионального образования / Е.А. Прягаева // Научно-методический электронный журнал «Концепт». – 2017. – Т. 36. – С. 126–130. \r\n13. Прядильникова, О.В. Проектирование современного учебного занятия в среднем профессиональном образовании в свете требований ФГОС СПО: учебное пособие / О.В. Прядильникова. – Уфа, 2019. – 42 с. \r\n14. http://pedsovet.su/ \r\n15. http://e-koncept.ru/2015/95617/htm \r\n16. http://zdamsam.ru/v1756.html\r\n";

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

        private void HelperNewLocation(int xRight, int yDown)
        {
            HelperLabel.Location = new Point(HelperLabel.Location.X + xRight, HelperLabel.Location.Y + yDown);
            HelperButtonClose.Location = new Point(HelperButtonClose.Location.X + xRight, HelperButtonClose.Location.Y + yDown);
            HelperPictureBox.Location = new Point(HelperPictureBox.Location.X + xRight, HelperPictureBox.Location.Y + yDown);
        }

        private void OpenHelper(string str, int xSize = 0, int ySize = 0, int xLocationLeft = 0, int yLocationUp = 0)
        {
            // Размер и местоположение меняется только для текста
            HelperPictureBox.Visible = true;
            HelperLabel.Visible = true;
            HelperButtonClose.Visible = true;
            HelperLabel.Location = new Point(226 - xSize - xLocationLeft, 230 - ySize - yLocationUp);
            HelperLabel.Size = new Size(270 + xSize, 120 + ySize);
            HelperButtonClose.Location = new Point(226 - xSize - xLocationLeft, 230 - ySize - yLocationUp);
            HelperPictureBox.Location = new Point(389, 344);
            HelperLabel.Text = str;

            switch (Text)
            {
                case "Главное меню":
                    HelperPictureBox.BackColor = MainMenu.BackColor;
                    HelperLabel.BackColor = MainMenu.BackColor;
                    HelperButtonClose.BackColor = MainMenu.BackColor;
                    break;
                case "Меню":
                    HelperPictureBox.BackColor = Menu.BackColor;
                    HelperLabel.BackColor = Menu.BackColor;
                    HelperButtonClose.BackColor = Menu.BackColor;
                    break;
                case "Инструкция":
                    HelperPictureBox.BackColor = Instruction.BackColor;
                    HelperLabel.BackColor = Instruction.BackColor;
                    HelperButtonClose.BackColor = Instruction.BackColor;
                    break;
                case "Литература":
                    HelperPictureBox.BackColor = Literatures.BackColor;
                    HelperLabel.BackColor = Literatures.BackColor;
                    HelperButtonClose.BackColor = Literatures.BackColor;
                    break;
                case "Создание урока":
                    HelperPictureBox.BackColor = CreateLesson.BackColor;
                    HelperLabel.BackColor = CreateLesson.BackColor;
                    HelperButtonClose.BackColor = CreateLesson.BackColor;
                    break;
                case "Технологическая карта":
                    HelperPictureBox.BackColor = TechnologicalMap.BackColor;
                    HelperLabel.BackColor = TechnologicalMap.BackColor;
                    HelperButtonClose.BackColor = TechnologicalMap.BackColor;
                    break;
                case "Дополнительно":
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
            HelperClose(a, b);
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
            TestPanel2.Visible = false;
            CheckYourselfPanel.Visible = false;
        }

        private void OpenMainMenu()
        {
            Text = "Главное меню";
            CloseAll();
            OpenHelper(MainMenuHelperText, 60, 50);
            HelperNewLocation(-50, -30);
            MainMenu.Visible = true;
            MainMenu.Size = new Size(sizeDefault);
            MainMenu.Location = locationDefault;
        }

        private void LessonPointVisibleDefault()
        {
            LessonPoint11.Visible = true;
            LessonPoint12.Visible = true;
            LessonPoint13.Visible = true;
            LessonPoint14.Visible = true;
            LessonPoint15.Visible = true;
            LessonPoint16.Visible = true;
        }
        private void LessonPointDefault()
        {
            LessonPoint11.BackColor = CreateLesson.BackColor;
            LessonPoint12.BackColor = CreateLesson.BackColor;
            LessonPoint13.BackColor = CreateLesson.BackColor;
            LessonPoint14.BackColor = CreateLesson.BackColor;
            LessonPoint15.BackColor = CreateLesson.BackColor;
            LessonPoint16.BackColor = CreateLesson.BackColor;
            LessonButton1.BackColor = Color.Red;
            LessonButton1.Text = "";
        }

        private void ButtonMainBack(object sender, EventArgs e)
        {
            if (Text == "Инструкция" || Text == "Литература" || Text == "Меню")
            {
                OpenMainMenu();
            }
            else
            if (Text == "Главное меню" || Text == "Создание урока" || Text == "Технологическая карта" || Text == "Дополнительно" || Text == "Урок создан")
            {
                if (Text == "Создание урока")
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
                if (Text == "Тест")
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
            else if (Text == "Методические приемы по мотивации студентов")
            {
                OpenMenu(sender, e);
            }
            else if (Text == "Методический прием")
            {
                OpenMethodical(sender, e);
            }
            else if (Text == "Рекомендации по созданию презентации" || Text == "Диагностика учебной мотивации студента")
            {
                OpenOther(sender, e);
            }
            else if (Text == "Как мотивировать студентов к обучению")
            {
                OpenMenu(sender, e);
            }
            else if (Text == "Рекомендации по тесту")
            {
                OpenOther(sender, e);
            }
            else if (Text == "Проверь себя")
            {
                OpenMenu(sender, e);
            }
        }
        private void OpenInstruction(object sender, EventArgs e)
        {
            CloseAll();
            Text = "Инструкция";
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
            Text = "Литература";
            CloseAll();
            Literatures.Visible = true;
            Literatures.Size = new Size(sizeDefault);
            Literatures.Location = locationDefault;
            HelperClose(sender, e);
        }
        private void MainMenuButtonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void OpenMenu(object sender, EventArgs e)
        {
            MethodicalSelect = false;
            CloseAll();
            Text = "Меню";
            OpenHelper(MenuHelperText, 0, 0, 0, 0);
            HelperNewLocation(-50, -160);
            Menu.Visible = true;
            Menu.Size = new Size(sizeDefault);
            Menu.Location = locationDefault;
            CheckYListButton.Clear();
            CheckYListText.Clear();
        }
        private void HelperClose(object sender, EventArgs e)
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
            Text = "Создание урока";
            CreateLesson.Visible = true;
            CreateLesson.Location = locationDefault;
            CreateLesson.Size = new Size(sizeDefault);

            OpenLessonPoint1X();
        }
        private void OpenTechnologicalMap(object sender, EventArgs e)
        {
            CloseAll();
            Text = "Технологическая карта";
            TechnologicalMap.Visible = true;
            TechnologicalMap.Location = locationDefault;
            TechnologicalMap.Size = new Size(sizeDefault);
        }
        private void OpenOther(object sender, EventArgs e)
        {
            CloseAll();
            Text = "Дополнительно";
            Other.Visible = true;
            Other.Location = locationDefault;
            Other.Size = new Size(sizeDefault);
            OpenHelper(OtherText, 10, 10, 0, 0);
            HelperNewLocation(-50, -50);
        }

        private void OpenLessonComplete(object sender, EventArgs e)
        {
            CloseAll();
            Text = "Урок создан";
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
            LessonPointVisibleDefault();
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
            LessonPointVisibleDefault();
            OpenHelper("Выберите урок в зависимости от его формы.", 54, -20, 80, -80);
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
            Text = "Создание урока";
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
                    LessonCompleteRichBox.Text = "   Урок усвоения новых знаний, на котором педагог объясняет новый материал. Он строится в соответствии с требованиями ФГОС несколько иначе, нежели прежде. \r\n\r\n   • В начале следует провести этап мотивации, который, впрочем, немногим отличается от прежнего оргмомента. \r\n   • Затем следует этап актуализации изученного (повторения) с попыткой решить проблемную задачу, опираясь лишь на уже известную информацию. \r\n   • Вывод о необходимости еще какого-то знания и получение его тем или иным способом (например, в процессе наблюдения или эксперимента). Это так называемое первичное усвоение материала. \r\n\r\n    А далее: \r\n\r\n   • Этап самостоятельного осмысления; в его ходе студенты выполняют работу самостоятельно. \r\n   • Проверка. Обсуждение вопроса, какое место занимает новое знание в общей системе знаний, каковы возможности его практического применения. \r\n   • Инструктаж по домашнему заданию; рефлексия. Разумеется, это приблизительный план хода урока. При этом решаются различные задачи: образовательные (научить, познакомить, проанализировать и т.д.), воспитательные (формировать познавательную и творческую активность, любовь к Родине, к природе, к литературе, воспитывать упорство, любознательность и проч.) и развивающие (формировать умение анализировать, сопоставлять, читать схемы, пользоваться справочной литературой и т.п.).\r\n";
                    LessonCompleteRichBox.Text += text1;
                    switch (LessonPoint2X)
                    {
                        case 1:
                            LessonCompleteRichBox.Text += "   Для достижения поставленных целей в современных условиях актуально проведение занятий с использованием экскурсий.\r\n\r\n    Производственные или учебные экскурсии (ПЭ) - это одна из многочисленных форм профориентационной работы с обучающимися. Они имеют большое образовательное, политехническое и воспитательное значение.\r\n\r\n    ПЭ служит формой наглядного ознакомления учащихся с техникой и технологией, организацией производства, содержанием труда, условиями труда и пр.\r\n\r\n    Основная цель ПЭ - расширение политехнического образования студентов. Экскурсия на какое-либо предприятие, проводимая в органичной связи с содержанием учебных дисциплин, показывает неразрывную связь теории и практики в производственной деятельности людей.\r\n \r\n    В зависимости от типа, содержания и метода проведения экскурсии, возраста студентов, местных условий и вида передвижения в состав экскурсионной группы может входить от десяти до сорока студентов. Длительность учебной экскурсии  определяется в зависимости от учебных задач, конкретных условий проведения.\r\n\r\n    Этапы подготовки экскурсии\r\n \r\n   1.     Определение цели и задачи экскурсии.\r\n   2.     Выбор темы.\r\n   3.     Отбор и изучение экскурсионных объектов.\r\n   4.     Составление маршрута экскурсии.\r\n   5.     Разработка заданий для учащихся.\r\n   6.     Составление методической разработки.\r\n\r\n    Цель экскурсии: наглядное ознакомление студентов с техникой и технологией , организацией  производства.\r\n\r\n    Задачи экскурсии:\r\n\r\n   1. обогащать знания студентов (учащихся) на основе непосредственного восприятия, накопления наглядных представлений и фактов;\r\n   2. устанавливать связи теорий с практикой, с жизненными явлениями и процессами\r\n   3. развивать творческие способности студентов (учащихся),\r\n   4. развивать самостоятельность, организованность в учебном труде, чувства коллективизма и взаимопомощи;\r\n   5. развивать наблюдательность, память, мышление, эмоции;\r\n   6.активизировать познавательную и практическую деятельность; воспитывать положительное отношение к учению.\r\n \r\n    В процессе подготовки экскурсии при отборе объектов проводится их оценка по следующим показателям (критериям):\r\n\r\n   1.     познавательная ценность;\r\n   2.     известность (популярность);\r\n   3.     месторасположение.\r\n\r\n    По мере сбора сведений об объекте студентам (учащимся) рекомендуется составить портфолио, в которое вносятся следующие сведения:\r\n\r\n   1.     наименование объекта;\r\n   2.     завод-изготовитель;\r\n   3.     техническая характеристика.\r\n   4.     назначение и место в технологическом процессе;\r\n   5.     особенности конструкции\r\n\r\n    Проведение экскурсии.\r\n\r\nРазбивка на группы( по 4-5 человек);\r\nВыдача заданий по объектам;\r\nИнструктаж;\r\nСбор информации согласно выданным заданиям.\r\n\r\n    Обработка собранного материала.\r\n    Подготовка к конференции:  презентация, фильм, репортаж, фотообозрение, доклад, плакаты и т. д\r\n";
                            break;
                        case 2:
                            LessonCompleteRichBox.Text += "    Основными разновидностями игровых методов активизации учебно-познавательной деятельности является метод инсценировки.\r\n\r\n    Метод инсценировки имеет много общего с театром, который вызывает сильные чувства и, соответственно, влияет на эмоционально-волевую сферу личности. Один из древнейших методов обучения, он наиболее эффективен и на сегодня, потому что обеспечивает условия максимального приближения дидактического процесса к действительности. \r\n\r\n    Характерными особенностями этого метода являются, во-первых, ознакомление участников занятия с конкретной дидактической ситуацией, которая наиболее полно соответствует профессиональной деятельности и требует разрешения; во-вторых, предоставление им ролей конкретных должностных лиц, которые существуют в реальной ситуации; в-третьих, распределение этих ролей между студентами. \r\n\r\n    Метод инсценировки обеспечивает обучающимся такие условия для занятий, которые не в состоянии создать другие методы обучения – испытать на себе результаты своих решений и действий.\r\n\r\n    Можно использовать две формы инсценировки занятий: \r\n   • первая – это заранее подготовленное инсценирование; \r\n   • вторая – импровизированное инсценирование, которое по сравнению с первым возникает как бы невзначай, случайно и неожиданно во время обсуждения определенных учебных проблем. \r\n\r\n    В первом случае педагог заранее готовит такие ситуации и выдвигает их для обсуждения во время рассмотрения общей учебной проблемы. Во втором – ситуацию предлагают сами студенты во время дискуссии по определенной проблеме, а педагог должен умело инсценировать эту учебную проблему для коллективного разыгрывания.\r\n\r\n    Инсценировка занятия может осуществиться так: \r\n\r\n   – роли распределяются между отдельными учениками, а другие выполняют роль активного зрителя или функции «арбитра»; \r\n   – обучающиеся разделяются на небольшие группы. Каждая группа выполняет роль определенного должностного лица, участника ситуации и др. Сначала они активно дискутируют в этих группах над решением дидактической проблемы, после чего представители групп предлагают всем студентам для дискуссионного обсуждения свой вариант.\r\n\r\n    Безусловно, этот метод требует от педагога всесторонней подготовки, умение методически правильно обрабатывать ситуации, которые должны быть разыгранными, и обладание необходимыми навыками и умениями для их воплощения.\r\n\r\n   • Занятия методом инсценировки рекомендуется проводить в основном при рассмотрении ситуаций, в основе которых лежат проблемы при изучении тем, касающихся совершенствования стиля и методов работы должностных лиц. Педагог должен умело подойти к выбору конкретной ситуации: во-первых, ее необходимо брать из практики; во-вторых, она должна входить в круг будущих обязанностей студента; в-третьих, быть интересной по содержанию и нестандартной по характеру решения.  \r\n\r\n   • Педагог должен вдумчиво проработать конкретную дидактическую ситуацию. Она должна включать общий фон ситуации, конкретную дидактическую проблему, четкое распределение ролей в соответствии с «функциональными обязанностями» и определение характера деятельности обучающихся. Дидактическую проблему, подлежащую инсценировке, нужно подробно описать с четкими общими и индивидуальными инструкциями. Эти описания должны быть объективными, без какого-либо критического анализа и оценочных фактов, но со всеми необходимыми элементами, которые помогут обучающимся выяснить сущность дидактической проблемы. \r\n\r\n   • Описание ситуации и конкретные общие и индивидуальные инструкции по выполнению определенных ролей раздаются участникам или накануне занятия, или во время занятия в зависимости от его дидактического и методического замысла. Но в любом случае должно быть достаточно времени для обдумывания дидактической проблемы и осознание роли каждого в ее решении, составление плана и его реализации. \r\n\r\n   • Индивидуальные инструкции доводятся до сведения конкретных исполнителей соответствующих ролей. Если только некоторые ученики получили роли, а остальные – активные зрители или «арбитры», до последних также доводят содержание индивидуальных инструкций. В связи с этим они являются наиболее информированными в этом занятии, потому что, знают как общую, так и индивидуальные инструкции. Поэтому им остается только оценить характер рассуждений каждого исполнителя и их решение. При этом с дидактической целью им можно разъяснить, на что следует обращать особое внимание и Что необходимо оценить. \r\n\r\n    • Ход таких занятий во многом зависит от умелого управления. Подготовительными работами руководит, безусловно, педагог, а ходом занятия – как педагог, так и определенный студент в соответствии с конкретной педагогической ситуации и дидактического замысла. Но всегда педагог четко определяет порядок проведения занятия и разъясняет правила дискуссии, ведь успеху всего занятия, прежде всего, способствуют атмосфера эмоциональной приподнятости, «театральности» и отсутствие скованности. \r\n\r\n    • После этого начинается обсуждение дидактической проблемы между участниками инсценировки, им необходимо дать время на «вживание» в роли, а также возможность обращаться к педагогу за определенными уточнениями и дополнительной информацией. Во время инсценировки другие участники-зрители не должны мешать исполнителям советами. \r\n\r\n    • Такие занятия заканчиваются общей дискуссией: оценивается динамика их хода, игра как отдельных обучающихся, так и всей учебной группы. В зависимости от дидактического и методического замысла занятия содержание дискуссии может быть разным, но в любом случае педагог должен требовать от участников четкой аргументации и научного обоснования личных взглядов. Обсуждение можно начинать с вопроса к исполнителям: как они сами оценивают исполнение ролей, и какими были бы их действия в реальной ситуации или во время повторной инсценировке? Исполнители в такой способ получают возможность критически оценить свои действия. Это стимулирует начало содержательной дискуссии.\r\n\r\n    • Участники-зрители сначала оценивают положительные, а затем отрицательные аспекты в действиях исполнителей конкретных ролей. Все оценки систематизируются, анализируются и обобщаются педагогом. Чтобы выяснить отношение исполнителей ролей к критике, необходимо предоставить им возможность ответить на нее, обосновав свою позицию. После этого снова организуется дискуссия по вопросу наиболее обоснованного варианта решения дидактической проблемы. Итоги дискуссии подводит педагог. \r\n";
                            break;
                        case 3:
                            LessonCompleteRichBox.Text += "    I. Методика подготовки лекции\r\n\r\n    При анализе методики подготовки лекции особое внимание следует обращать на решение следующих организационно-методических вопросов:\r\n\r\n    1. Определение основной цели лекции, ее главной идеи. Она (цель) задается требованиями учебной программы, местом лекции в изучаемой учебной дисциплине и самим названием. Целесообразно начинать подготовку лекции с постановки перед собой вопроса о том, для какой категории слушателей необходима данная лекция и какой конкретно материал необходимо вложить в ее текст. Ответив на поставленные вопросы, преподаватель конкретизирует содержание лекции.\r\n\r\n    2. Уточнение объема материала, входящего в содержание лекции.\r\n    Практика показывает, что у преподавателя, готовящегося к написанию текста лекции, как правило, материала бывает значительно больше, чем его можно изложить за отведенное время. Следовательно, надо отобрать самое важное для достижения поставленной цели. В этом случае следует экономить время для раскрытия главного – таково правило наиболее опытных преподавателей. Нехватка времени из-за чрезмерного объема материала – частый недостаток многих начинающих преподавателей, которые еще не научились рассчитывать время, необходимое для изложения того или иного вопроса. Здесь им поможет простой методический прием: нужно прочитать вслух подготовленный текст, заметив время, а затем увеличить это время примерно на 20-30%. Как показывает практика, столько времени будет затрачено при чтении лекции в аудитории. Безусловно, при определении объема содержания лекции необходимо ориентироваться на требования учебной программы.\r\n\r\n    3. Детальная проработка структуры лекции способствует уточнению содержания, его лучшему подчинению главной цели и выполнению основных требований. Практика показывает, что опытные преподаватели не ограничивают проработку структуры определением основных вопросов, а продумывают их структуру. Каждый вопрос они разбивают на подвопросы и формулируют название последних. Это обеспечивает более строгое подчинение материала теме и цели лекции, позволяет лучше отобрать материал и логичнее его расположить.\r\n\r\n    4. Написание текста лекции. По любой теме целесообразно иметь полный текст лекции. При ее написании преподаватель должен работать над тем, как повысить научность и практическую значимость лекции, реализовать все ее функции, как лучше скомпоновать материал. После того как написан первый вариант текста лекции, в него вносятся коррективы, продолжается работа над точностью и яркостью фраз и выражений. Придание тексту наглядности облегчает пользование им, однако нельзя превращать лекцию в чтение текста. Текст лекции должен вести, направлять изложение материала.\r\n    \r\n    5. Специальная подготовка средств наглядности и решение других организационно-методических вопросов – важный элемент в подготовке лекции. Тот факт, что использование в лекции средств наглядности является обязательным, не вызывает сомнений. Практика показывает, что 5-7 обращений преподавателя к использованию средств изобразительной наглядности бывает вполне достаточно.\r\n\r\n    II. Методика чтения лекции\r\n\r\n    Всегда следует помнить, что лекция имеет четкую структуру, включающую в себя: введение, основную часть и заключение. В каждом из ее элементов преподавателю следует соблюдать определенные действия и правила поведения, суть которых и определяет методику чтения лекции.\r\n\r\n    Во введении к числу основных действий преподавателя можно отнести:\r\n\r\n    1. Объявление темы и плана лекции, указание основной и дополнительной литературы.\r\n    2. Разъяснение целей занятия и способов их достижения.\r\n    3. Обозначение места лекции в программе и ее связь с другими дисциплинами.\r\n    4. Создание рабочей обстановки в аудитории, вызвать у слушателей интерес к изучаемой теме.\r\n\r\n    В основной части лекции преподавателю можно рекомендовать следующие методические приемы:\r\n\r\n    1. Установление контакта с аудиторией.\r\n    2. Убежденное и эмоциональное изложение материала.\r\n    3. Установление четких временных рамок на изложение материала по намеченному плану.\r\n    4. Использование материала лекции как опорного для лучшего усвоения изучаемой дисциплины.\r\n    5. Контроль за грамотностью своей речи (слогообразование, ударение и т.д.) и поведением.\r\n    6. Наблюдение за аудиторией и поддержание с ней контакта на протяжении всего занятия.\r\n\r\n    В заключительной части лекции преподавателю рекомендуется:\r\n\r\n    1. Подвести итоги сказанного в основной части и сделать выводы по теме.\r\n    2. Ответить на вопросы обучающихся.\r\n    3. Напомнить обучающимся о методических указаниях по организации самостоятельной работы.\r\n    4. Объявить в аудитории очередную тему занятий и порекомендовать присутствующим ознакомиться с ее основным содержанием.\r\n";
                            break;
                        case 4:
                            LessonCompleteRichBox.Text += "    В форме беседы полезно проводить и опрос и объяснение нового, материала на первой ступени обучения. Характерная особенность этой формы урока состоит в том, что учащиеся принимают в нем активное участие — отвечают на вопросы, делают самостоятельные выводы из демонстрационных опытов, объясняют явления. Все это, конечно, корректирует педагог, он руководит такой беседой, уточняет и окончательно формулирует ответы.\r\n\r\n    • В начале урока целесообразно в форме беседы провести повторение с целью проверить знания обучающихся и восстановить картину пройденного материала, чтобы перейти к последующим вопросам.\r\n\r\n    • Затем полезно выявить примеры из жизненного опыта обучающихся, связанные с изучаемым вопросом, попросить обучающихся попытаться объяснить эти явления, тем самым показать им необходимость получения новых знаний (проблемная ситуация).\r\n\r\n    • Потом следует перейти к демонстрационным или самостоятельным опытам, объяснение которых сначала предложить дать обучающимся. При этом лучше вызвать студентов для ответа поименно, в противном случае активно будут работать лишь несколько студентов. Сначала педагог задает вопрос, дает время для обдумывания и затем называет фамилию обучающегося. В первую очередь рекомендуется вызвать слабого студента (но не слишком затягивать беседу). Если он ответит неверно, то попросить его внимательно слушать другие ответы, предупредить, что после выяснения правильного ответа он должен будет повторить его. После того как ответ будет найден и окончательно откорректирован педагогом, такое повторение следует провести.\r\n\r\n    Для успешного проведения урока-беседы важно, чтобы педагог установил хороший контакт с классом, наблюдал за ним и добивался полного понимания изучаемого на уроке вопроса.\r\n\r\n    Урок-беседа — одна из наиболее трудных форм урока. Она требует от педагога хорошей профессиональной подготовки. Нужно тщательно подбирать вопросы и предвидеть возможные варианты ответов на них. Беседа должна проходить живо и непринужденно, только тогда она захватит всех обучающихся класса и даст нужный эффект.\r\n";
                            break;
                        case 5:
                            LessonCompleteRichBox.Text += "    Подготовка  встречи. \r\n\r\n    В первую очередь необходимо определиться с темой. Она должна быть актуальной и интересной. При этом ставятся цели встречи — чему должны научиться студенты, какие сделать выводы.\r\n\r\n    В соответствии с темой на встречу приглашаются люди, которые смогут отвечать на вопросы в качестве экспертов. Необходимо заранее договориться о посещении, а за день желательно еще раз обзвонить приглашенных людей. Время и место проведения обговариваются вместе с гостями. Продолжительность такого общения не должна быть более 1 часа.\r\n\r\n    За неделю до встречи необходимо раздать пресс-релизы, в которых указываются тема, план, информация о приглашенных гостях и основные направ¬ления беседы. Студенты должны подготовить вопросы, которые педагог затем отдает приглашенным экспертам, чтобы те могли подготовить ответы.\r\n\r\n    В помощь преподавателю\r\n\r\n    Во время проведения встреч, бесед, брифингов могут возникнуть некоторые трудности. Как справляться в сложных ситуациях, направляя общение в нужное русло?\r\n\r\n    • Некоторые студенты все время говорят, не давая высказаться другим.\r\n\r\n   В этом случае можно периодически задавать вопрос: «А что думают по этому поводу другие?» Во внеурочное время преподаватель может поговорить со слишком активными студентами наедине и объяснить им важность того, чтобы в беседе участвовали не только они, но и другие их одногруппники.\r\n\r\n    • В беседе студенты уклонились от темы. \r\n\r\n   Можно сказать, примерно следующее: «Все, что вы сказали, очень интересно, но мне кажется, мы уклонились от темы. Давайте рассмотрим этот вопрос позже в свободное время, а сейчас вернемся к нашей теме». Еще одним способом является стимулирующий вопрос, который возобновит у ребят интерес к изначальной теме.\r\n\r\n    • Некоторые студенты мешают проведению дискуссии. \r\n\r\n   В этой ситуации не следует срываться на проблемных обучающихся. Необходимо учитывать, что могут быть при¬чины подобного поведения. Надо постараться выяснить, что это за причины. Для этого необходимо понаблюдать за студентом и попробовать выяснить, что стало причиной возникшей с ним проблемы, как можно ее решить и как следует поступить в первую очередь. Можно посоветоваться с другими педагогами по этому поводу.\r\n\r\n    • Дискуссия стала непредсказуемой. \r\n\r\n   Такая проблема вполне может возникнуть, поскольку ответы не всегда можно предугадать. Они могут легко увлечься не тем аспектом освещаемой темы и начать развивать свои мысли в этом направлении. В такой ситуации необходимо уметь вовремя менять акцент беседы.\r\nЕсли вопрос, предложенный для обсуждения, не увлек студентов, необходимо иметь в запасе несколько других вопросов, удовлетворяющих основным целям дискуссии.\r\n";
                            break;
                        case 6:
                            LessonCompleteRichBox.Text += "";
                            break;
                    }
                    break;
                case 2:
                    //LessonCompleteRichBox.Text = "•    Первый этап. Организационный этап\n   Организационный этап, очень кратковременный, определяет весь психологический настрой урока. Психологический настрой проводится для создания благоприятной рабочей обстановки, чтобы обучающиеся поняли, что им рады, их ждали.\n•    Второй этап. Проверка домашнего задания, воспроизведение и коррекция опорных знаний\n   Выявить пробелы в знаниях и способах деятельности обучающихся.\n•    Третий этап. Постановка цели и задач урока. Мотивация учебной деятельности \n   Это обязательный этап по ФГОС. На данном этапе педагогу необходимо создать проблемную ситуацию так, чтобы студенты сами назвали цель урока, а также саму тему. Результативность учебно-воспитательного процесса, состояние познавательной активности зависят от осознанности обучающегося цели деятельности.\n   Практические приемы: опорные схемы, диалог, мозговой штурм, мозговая атака, постановка проблемных вопросов, игровые моменты, раскрытие практической значимости темы, использование музыки и других эстетических средств.\n•    Четвёртый этап. Первичное закрепление в знакомой ситуации\n•    Пятый этап. Творческое применение и добывание знаний в новой ситуации (проблемные задания)\n•    Шестой этап. Информация о домашнем задании, инструктаж по его выполнению\n   Цель этапа: расширить и углубить знания, умения, полученные на уроке.\n   Задачи этапа:\n   — разъяснить методику выполнения домашнего задания;\n   — обобщить и систематизировать знания;\n   — способствовать применению знаний, умений, навыков в разных условиях;\n   — применить дифференцированный подход.\n   Домашние задания могут быть: устными или письменными; обычными или программированными; долгосрочными или краткосрочными; требовать от студентов различных усилий мысли (репродуктивные, конструктивные, творческие).\n•    Седьмой этап. Рефлексия (подведение итогов занятия)\n   Рефлексия — самоанализ и самооценка своей деятельности. Если говорить о рефлексии как этапе урока, то это оценивание своего состояния, эмоций, результатов своей деятельности на занятии.\n   ";
                    LessonCompleteRichBox.Text = "   Урок комплексного применения знаний (урок закрепления изученного материала)\r\n\r\n\tПервый этап. Организационный этап\r\n\r\n    Организационный этап, очень кратковременный, определяет весь психологический настрой урока. Психологический настрой проводится для создания благоприятной рабочей обстановки, чтобы обучающиеся поняли, что им рады, их ждали.\r\n\r\n\tВторой этап. Проверка домашнего задания, воспроизведение и коррекция опорных знаний\r\n\r\n    Выявить пробелы в знаниях и способах деятельности обучающихся.\r\n\r\n\tТретий этап. Постановка цели и задач урока. Мотивация учебной деятельности \r\n\r\n    Это обязательный этап по ФГОС. На данном этапе педагогу необходимо создать проблемную ситуацию так, чтобы студенты сами назвали цель урока, а также саму тему. Результативность учебно-воспитательного процесса, состояние познавательной активности зависят от осознанности обучающегося цели деятельности.\r\n    Практические приемы: опорные схемы, диалог, мозговой штурм, мозговая атака, постановка проблемных вопросов, игровые моменты, раскрытие практической значимости темы, использование музыки и других эстетических средств.\r\n\r\n\tЧетвёртый этап. Первичное закрепление в знакомой ситуации\r\n\tПятый этап. Творческое применение и добывание знаний в новой ситуации (проблемные задания)\r\n\tШестой этап. Информация о домашнем задании, инструктаж по его выполнению\r\n\r\nЦель этапа: расширить и углубить знания, умения, полученные на уроке.\r\nЗадачи этапа:\r\n— разъяснить методику выполнения домашнего задания;\r\n— обобщить и систематизировать знания;\r\n— способствовать применению знаний, умений, навыков в разных условиях;\r\n— применить дифференцированный подход.\r\n    Домашние задания могут быть: устными или письменными; обычными или программированными; долгосрочными или краткосрочными; требовать от студентов различных усилий мысли (репродуктивные, конструктивные, творческие).\r\n\r\n\tСедьмой этап. Рефлексия (подведение итогов занятия)\r\n\r\n    Рефлексия — самоанализ и самооценка своей деятельности. Если говорить о рефлексии как этапе урока, то это оценивание своего состояния, эмоций, результатов своей деятельности на занятии.\r\n";
                    LessonCompleteRichBox.Text += text1;
                    switch (LessonPoint2X)
                    {
                        case 1:
                            LessonCompleteRichBox.Text += "    • Урок-суд: подготовка и реализация\r\n\r\n    I. Подготовка к уроку\r\n\r\n    Подготовительный этап к такому уроку занимает достаточно много времени, так как необходимо не только распределить роли, но и подготовить \"следственный материал\".\r\n\r\n    1. Постановка проблемы и цели урока.\r\n\r\n    Роль игровых судов в том, чтобы прийти к общему мнению по поставленной проблеме. Здесь не так важен вердикт с точки зрения \"виновен — не виновен\", сколько важно найти ответы на поставленные вопросы и достичь главной цели урока.\r\n    В роли \"обвиняемого\" иногда выступает не личность, а явление, или группа людей. Например, можно проводить уроки \"Суд над наркоманией\", \"Суд над рабством\", \"Суд над декабристами\" и т.д. В этом случае в качестве цели урока можно выбрать следующие: \"оценка явления с точки зрения современности\", \"анализ пагубности / пользы явления\" и т.д. \r\n    Таким образом, выбор \"обвиняемого\" зависит от фантазии педагога. Важнее другое — четко сформулировать проблему и цель урока-суда.\r\n\r\n    2. Распределение ролей.\r\n\r\n    Важно, чтобы в процессе были задействованы все обучающиеся. Поэтому, желательно подбирать такую тему, чтобы ситуация охватывала как можно больше студентов.\r\n\r\n    Возможные роли:\r\n•\tОбвиняемый;\r\n•\tПотерпевший;\r\n•\tСудья;\r\n•\tПрисяжные заседатели;\r\n•\tСекретарь суда;\r\n•\tОбвинитель (прокурор);\r\n•\tПомощники прокурора;\r\n•\tЗащитник (адвокат);\r\n•\tПомощники адвоката;\r\n•\tСвидетели обвинения;\r\n•\tСвидетели защиты;\r\n•\tНезависимые эксперты.\r\n\r\n    Роли обучающиеся выбирают, по возможности, самостоятельно, ориентируясь на свои убеждения, желания и отношение к поставленной проблеме.\r\n\r\n    3. Работа с классом.\r\n\r\n    Если урок-суд проводится впервые, то педагог должен объяснить, как проходит судебный процесс, растолковать, в чем заключается роль каждого из участников. Желательно предоставить схему планируемого урока, чтобы ребята могли сориентироваться и по времени, и по ходу действия.\r\n\r\n    Пример схемы урока:\r\n\r\n    Вступительное слово судьи: представление героев \"суда\", представление обвиняемого и подзащитного, объявление главной проблемы (цели урока).\r\n\r\n•\tОбвинительная речь прокурора.\r\n•\tВыступление независимых экспертов.\r\n•\tВыступление свидетелей обвинения.\r\n•\tРечь защитника.\r\n•\tВыступления свидетелей защиты.\r\n•\t\"Последнее слово\" обвиняемого.\r\n•\tСовещание судей.\r\n•\tПриговор.\r\n•\tПодведение итогов (рефлексия).\r\n\r\n    4. Работа в группах.\r\n\r\n    На этом этапе удобнее объединить участников будущего процесса в три группы: обвинение, защита, независимые эксперты. Здесь начинается самая интересная и самая объемная часть работы — поиск улик и доказательств. \r\n    Затем участники групп обсуждают те моменты, которые кажутся им наиболее убедительными, подчеркивающими и доказывающими их правоту. Здесь учителю важно направить работу каждой группы, по возможности объяснить, как должна строится защита или обвинение.\r\n\r\n    5. Индивидуальная работа.\r\n\r\n    Каждый участник будущего процесса составляет план своего выступления, готовит вопросы для оппонентов.\r\n    Роль педагога на данном этапе сводится к консультированию. Можно подсказать студентам дополнительные источники информации, скорректировать их поиск, помочь с составлением плана выступления. Но важно, чтобы работа проводилась по большей части самостоятельно.\r\n    Особенно важная роль отводится судье. В ходе процесса судья должен не просто выслушивать мнения героев, но и обязательно задавать вопросы. Причем вопросы не обязательно должны быть уточняющими — по поводу каких-то деталей или несущественных мелочей. Хорошо, если получится задавать вопросы провокационные, заставляющие задуматься: \"А правильно ли я выбрал роль в процессе?\" Такие вопросы должны заставлять искать ответ не в тексте, а в жизненной позиции каждого участника, то есть учить детей анализировать материал, вырабатывать и отстаивать свою точку зрения.\r\n\r\n    II. Этап реализации.\r\n\r\n    Для урока желательно расставить мебель в комнате таким образом, чтобы воссоздать обстановку судебного зала: отдельные места для защиты и обвинения, скамья подсудимого, верховное место судьи.\r\n\r\n    ВАЖНО!\r\n    Следует четко следовать намеченному плану проведения судебного заседания. То есть, если для речи прокурора, например, отведено 3 минуты, то важно придерживаться этого времени и не давать студенту растекаться мыслью по древу.\r\n\r\n    Урок-суд не предполагает обмена мнениями. Цель уроков — другая: в ходе дискуссии прийти к единому мнению по поставленной проблеме.\r\n    Для воссоздания \"полной картины\" желательно придерживаться форм обращения, принятых в суде (Ваша честь, господин прокурор / адвокат, \"Встать! Суд идет!\", \"Слово предоставляется…\" и т.д.). Можно ввести и моменты приведения свидетелей к присяге. Но, если такие мелочи занимают много времени, их лучше пропустить, оставив лишь общую фабулу процесса.\r\n\r\n    Не стоит забывать и о техническом оснащении. Например, можно рекомендовать ученикам использовать в своих выступлениях наглядные материалы, презентации, схемы, графики и т.д.\r\n    Завершающий этап урока является одним из основных. После того, как вынесен приговор, необходимо проанализировать итоги урока, то есть провести рефлексию.\r\n\r\n    При этом важно учесть следующие моменты:\r\n\r\n•\tстепень активности обучающихся и степень их подготовленности;\r\n•\tиспользование дополнительной информации, продуктивность самостоятельной работы;\r\n•\tоценка обучающимися итогов урока: согласны или нет с вердиктом?\r\n•\tоценка обучающимися степени \"интересности\" и познавательности такой формы урока.\r\n";
                            break;
                        case 2:
                            LessonCompleteRichBox.Text += "    Для достижения поставленных целей в современных условиях актуально проведение занятий с использованием экскурсий.\r\n\r\n    Производственные или учебные экскурсии (ПЭ) - это одна из многочисленных форм профориентационной работы с обучающимися. Они имеют большое образовательное, политехническое и воспитательное значение.\r\n\r\n    ПЭ служит формой наглядного ознакомления учащихся с техникой и технологией, организацией производства, содержанием труда, условиями труда и пр.\r\n\r\n    Основная цель ПЭ - расширение политехнического образования студентов. Экскурсия на какое-либо предприятие, проводимая в органичной связи с содержанием учебных дисциплин, показывает неразрывную связь теории и практики в производственной деятельности людей.\r\n \r\n    В зависимости от типа, содержания и метода проведения экскурсии, возраста студентов, местных условий и вида передвижения в состав экскурсионной группы может входить от десяти до сорока студентов. Длительность учебной экскурсии  определяется в зависимости от учебных задач, конкретных условий проведения.\r\n\r\n    Этапы подготовки экскурсии\r\n \r\n   1.     Определение цели и задачи экскурсии.\r\n   2.     Выбор темы.\r\n   3.     Отбор и изучение экскурсионных объектов.\r\n   4.     Составление маршрута экскурсии.\r\n   5.     Разработка заданий для учащихся.\r\n   6.     Составление методической разработки.\r\n\r\n    Цель экскурсии: наглядное ознакомление студентов с техникой и технологией , организацией  производства.\r\n\r\n    Задачи экскурсии:\r\n\r\n   1. обогащать знания студентов (учащихся) на основе непосредственного восприятия, накопления наглядных представлений и фактов;\r\n   2. устанавливать связи теорий с практикой, с жизненными явлениями и процессами\r\n   3. развивать творческие способности студентов (учащихся),\r\n   4. развивать самостоятельность, организованность в учебном труде, чувства коллективизма и взаимопомощи;\r\n   5. развивать наблюдательность, память, мышление, эмоции;\r\n   6.активизировать познавательную и практическую деятельность; воспитывать положительное отношение к учению.\r\n \r\n    В процессе подготовки экскурсии при отборе объектов проводится их оценка по следующим показателям (критериям):\r\n\r\n   1.     познавательная ценность;\r\n   2.     известность (популярность);\r\n   3.     месторасположение.\r\n\r\n    По мере сбора сведений об объекте студентам (учащимся) рекомендуется составить портфолио, в которое вносятся следующие сведения:\r\n\r\n   1.     наименование объекта;\r\n   2.     завод-изготовитель;\r\n   3.     техническая характеристика.\r\n   4.     назначение и место в технологическом процессе;\r\n   5.     особенности конструкции\r\n\r\n    Проведение экскурсии.\r\n\r\nРазбивка на группы( по 4-5 человек);\r\nВыдача заданий по объектам;\r\nИнструктаж;\r\nСбор информации согласно выданным заданиям.\r\n\r\n    Обработка собранного материала.\r\n    Подготовка к конференции:  презентация, фильм, репортаж, фотообозрение, доклад, плакаты и т. д\r\n";
                            break;
                        case 3:
                            LessonCompleteRichBox.Text += "    • Как подготовить урок-конференцию?\r\n\r\n    Этап 1\r\n\r\n    На первом этапе педагог выбирает тему урока-конференции и рассматривает целесообразность рассмотрения того или иного материала студентам. Эти выступления — своего рода мини-проекты, работа над которыми занимает обычно одну - две недели.\r\n    Итак, на первом этапе педагог выбирает общую тему и размышляет над тем, какие мини-темы он может предложить студентам. Это могут быть биографии известных лиц, история открытий, варианты применения физического закона и тому подобное.\r\n\r\n    Этап 2\r\n\r\n    На втором этапе педагог подбирает необходимые материалы — те, которые он порекомендует студентам. По каждой теме он, по возможности, стремится порекомендовать несколько источников, среди них книги, периодические издания и интернет-ресурсы.\r\n\r\n    Этап 3\r\n\r\n    На третьем этапе педагог предлагает студентам темы. Чаще всего педагог сам делит студентов на группы, которые будут готовить свои выступления. Каждая группа получает свое задание и рекомендации по его выполнению. \r\n    Желательно сразу оговорить форму подачи информации от каждой группы и регламент.\r\n    Есть смысл также оговорить, что необходим какой-нибудь интерактивный элемент: мини-тест, небольшая викторина, игра на одну-две минуты, какое-то творческое задание для слушателей. Надо также решить, будут ли докладчики выступать с компьютерными презентациями или оформлять стенды, плакаты, стенгазеты.\r\n\r\n    Этап 4\r\n\r\n    На четвертом этапе педагог консультирует конкретные группы ребят.\r\n\r\n    ВАЖНО! Следует обратить внимание на то, что в конце урока обязательно должны подводиться итоги.\r\n\r\n    Однако эти итоги могут быть не окончательными. Если класс достаточно большой доклады едва ли могут быть слишком короткими. Семь, а то и десять минут — это, наверное, минимум по какой-либо серьёзной теме, а значит, все присутствующие на конференции выступить не смогут.\r\n    Чтобы остальные студенты, которые в этот раз не участвуют в конференции, не скучали, им следует подготовить опросные листы для голосования. На основании этих опросных листов участникам конференции могут добавляться дополнительные баллы или может выдаваться приз зрительских симпатий.\r\n";
                            break;
                        case 4:
                            LessonCompleteRichBox.Text += "    Деловая (ролевая) игра – эффективный метод взаимодействия педагогов. Она является формой моделирования тех систем отношений, которые существуют в реальной действительности или в том или ином виде деятельности, в них приобретаются новые методические навыки и приемы.\r\n\r\n    Заранее готовятся карточки с вопросами или 2-3 педагогическими ситуациями по проблеме.\r\n\r\n    Столы необходимо расставить так, чтобы выделилось 2 или 3 команды по 4-5 человек участников деловой игры. Педагоги по желанию рассаживаются за столы, и тем самым сразу определяются команды участников. Одна из команд – эксперты судьи – это наиболее компетентные педагоги по предлагаемой проблеме.\r\n\r\n    Каждой команде вручается карточка, выбирается капитан, который будет оглашать общий вывод команды, работая над заданием. Командам дается время для подготовки решения, затем заслушиваются ответы. Порядок ответов определяется жребием капитанов. Каждой группой вносится не менее 3-х дополнений отвечающей группе, ставится поощрительный балл, который входит в общий счет очков. В конце игры определяется команда – победитель за лучший (обстоятельный, полный, доказательный) ответ.\r\n\r\n    Деловые игры бывают следующих видов:\r\n•\tимитационные, где осуществляется копирование с последующим анализом.\r\n•\tуправленческие, в которых осуществляется воспроизведение конкретных управленческих функций);\r\n•\tисследовательские, связанные с научно-исследовательской работой, где через игровую форму изучаются методики по конкретным направлениям;\r\n•\tорганизационно-деятельные. Участники этих игр моделируют раннее неизвестное содержание деятельности по определенной теме.\r\n•\tигры-тренинги. Это упражнения, закрепляющие те или иные навыки;\r\n•\tигры проективные, в которых составляется собственный проект, алгоритм каких-либо действий, план деятельности и осуществляется защита предложенного проекта.\r\n\r\n    При организации и проведении деловой игры роль руководителя игры различна – до игры он инструктор, в процессе ее проведения – консультант, на последнем этапе – руководитель дискуссии.\r\n\r\n    Основная цель игры – живое моделирование образовательно-воспитательного процесса, формирование конкретных практических умений педагогов, более быстрая адаптация к обновлению содержания, формирование у них интереса и культуры саморазвития; отработка определенных профессиональных навыков, педагогических технологий.\r\n\r\n    Методика организации и проведения:\r\n\r\n    Процесс организации и проведения игры можно разделить на 4 этапа:\r\n          Конструирование игры:\r\n\r\n•\tОрганизационная подготовка конкретной игры с реализацией определенной дидактической цели: руководитель разъясняет участникам смысл игры, знакомит с общей программой и правилами, распределяет роли и ставит перед их исполнителями конкретные задачи, которые должны быть ими решены;\r\n•\tназначаются эксперты, которые наблюдают ход игры, анализируют моделируемые ситуации, дают оценку;\r\n•\tопределяют время, условия и длительность игры.\r\n\r\n\r\n     Ход игры.\r\n\r\n•\tПодведение итогов, подробный анализ игры: общая оценка игры, подробный анализ, реализация целей и задач, удачные и слабые стороны, их причины;\r\n•\tсамооценка участниками исполнения полученных заданий, степень личной удовлетворенности;\r\n•\tхарактеристика профессиональных знаний и умений, выявленных в процессе игры;\r\n•\tанализ и оценка игры экспертами.\r\n\r\n    Критерием для такой оценки может служить количество и содержательность выдвинутых идей (предложений), степень самостоятельности суждений, их практическая значимость.\r\n    В заключении руководитель подводит итог игры.\r\n";
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
                    //LessonCompleteRichBox.Text = "   Такому уроку в свете нового ФГОС придается особое значение, поскольку он помогает обучающимся«разложить все по полочкам».  \n•    На первом этапе (мотивационном) стоит обсудить, зачем необходима систематизация знаний. Уместны будут такие образы, как кладовая, книгохранилище и т.п. По какому принципу мы разложим там наши знания? На какую полочку попадет то, что мы изучили? Какая часть информации будет востребована особенно часто? \n•    Затем проводится повторение на другом качественном уровне: обучающимся предлагаются вопросы в нестандартной формулировке или с необычным условием. \n•    Контроль (в соответствии с ФГОС – лучше самоконтроль) проводится тоже с акцентом на обобщение (если ты неправильно решишь эту часть задачи, это отразится – на чем?). Цель работы – не только обобщить, но вписать полученную информацию в контекст общих знаний студента о мире. \n•    Особенно важно на таком уроке тщательно проработать этап рефлексии и проговорить на нем как принципы классификации, так и значение материала, его место в системе знаний.\n";
                    LessonCompleteRichBox.Text = "   Уроку рефлексии в свете нового ФГОС придается особое значение, поскольку он помогает обучающимся «разложить все по полочкам».\r\n  \r\n   • На первом этапе (мотивационном) стоит обсудить, зачем необходима систематизация знаний. Уместны будут такие образы, как кладовая, книгохранилище и т.п. По какому принципу мы разложим там наши знания? На какую полочку попадет то, что мы изучили? Какая часть информации будет востребована особенно часто? \r\n   • Затем проводится повторение на другом качественном уровне: обучающимся предлагаются вопросы в нестандартной формулировке или с необычным условием. \r\n   • Контроль (в соответствии с ФГОС – лучше самоконтроль) проводится тоже с акцентом на обобщение (если ты неправильно решишь эту часть задачи, это отразится – на чем?). Цель работы – не только обобщить, но вписать полученную информацию в контекст общих знаний ученика о мире. \r\n   • Особенно важно на таком уроке тщательно проработать этап рефлексии и проговорить на нем как принципы классификации, так и значение материала, его место в системе знаний.\r\n";
                    LessonCompleteRichBox.Text += text1;
                    switch (LessonPoint2X)
                    {
                        case 1:
                            LessonCompleteRichBox.Text += "    Цель комбинированного урока — освоение какой-либо небольшой темы в течение только одного академического часа. Другое дело, что компоненты урока могут идти в разной последовательности в зависимости от темы и особенностей аудитории.\r\n\r\n    Пример плана комбинированного урока можно представить себе так:\r\n1.\tЗагадка, намекающая на тему урока.\r\n2.\tПостановка проблемы, формулировка темы и задачи урока.\r\n3.\tПроверка домашнего задания.\r\n4.\tПовторение изученного на прошлых уроках.\r\n5.\tУсвоение нового материала.\r\n6.\tОтработка.\r\n7.\tКонтроль.\r\n8.\tОбъяснение домашнего задания.\r\n9.\tРефлексия.\r\n\r\n    Разумеется, возможны различные варианты, план комбинированного урока позволяет части его переставлять в соответствии с дидактической задачей, вместо загадки, можно предложить студентам задачу или проблему, какую-нибудь игру и т.п.\r\n\r\n    Варианты начала урока:\r\n    • сообщение о какой-то памятной дате, имеющей (или даже нет) отношение к предмету (день рождения писателя, композитора, политического деятеля; годовщина исторического события, открытия, выхода в свет книги);\r\n    • загадка или необычный факт в форме новости;\r\n    • отрывок из литературного произведения или афоризм;\r\n    • общий комплимент классу и т.п.\r\n\r\n    Методика проведения комбинированного урока по ФГОС требует от педагога, по возможности, не сообщать тему урока, а предлагать догадаться самим. Причем одновременно ценность новых знаний необходимо обосновать.\r\n\r\n    В связи с этим обычно рекомендуется начинать объяснение проблемной задачей. Суть приема в том, что студентам предлагается решить задачу, или предсказать результат опыта, или предположить, как пишется какое-то слово и т.п. Подбирается материал таким образом, чтобы для правильного ответа требовались именно те знания, которые планируется изучать на текущем уроке.\r\n\r\n    Планируя комбинированный урок, крайне важно оставить достаточно времени на этап выработки навыка применения полученных знаний на практике. Причем желательно придумывать такие задания, которые будут стимулировать творческую активность студентов. Хорошо также дать задания, позволяющие использовать полученные знания в нестандартных условиях, взглянуть на материал под другим углом.\r\n\r\n    Однако, предлагая обучающимся практическую работу, необходимо сначала удостовериться, что весь теоретический материал ими усвоен. Поэтому хорошо, если практике предшествует небольшой устный опрос, позволяющий «начерно» оценить степень осознания материала. Но при этом не надо забывать, что без практики теоретический материал мертв и все равно не может быть до конца осознан.\r\n\r\n    Можно провести закрепление в виде какой-либо игры, индивидуальной или командной. Неплохо зарекомендовали себя приемы, требующие логики и творческого подхода:\r\n    • Общее – уникальное.\r\n    • Цепочка соответствий.\r\n    • Шесть шляп.\r\n    • Кейсы\r\n    • И т.д.\r\n\r\n    Можно дать небольшую проверочную работу, например, с использованием перфокарт.\r\n    При анализе комбинированного урока следует обратить внимание на то же, что и при разборе любого другого урока. Указав вид урока — комбинированный — отдельно анализируются его этапы. Характеристика комбинированного урока включает в себя разбор как отдельных приемов, так и урока в целом.\r\n";
                            break;
                        case 2:
                            LessonCompleteRichBox.Text += "    Деловая (ролевая) игра – эффективный метод взаимодействия педагогов. Она является формой моделирования тех систем отношений, которые существуют в реальной действительности или в том или ином виде деятельности, в них приобретаются новые методические навыки и приемы.\r\n\r\n    Заранее готовятся карточки с вопросами или 2-3 педагогическими ситуациями по проблеме.\r\n\r\n    Столы необходимо расставить так, чтобы выделилось 2 или 3 команды по 4-5 человек участников деловой игры. Педагоги по желанию рассаживаются за столы, и тем самым сразу определяются команды участников. Одна из команд – эксперты судьи – это наиболее компетентные педагоги по предлагаемой проблеме.\r\n\r\n    Каждой команде вручается карточка, выбирается капитан, который будет оглашать общий вывод команды, работая над заданием. Командам дается время для подготовки решения, затем заслушиваются ответы. Порядок ответов определяется жребием капитанов. Каждой группой вносится не менее 3-х дополнений отвечающей группе, ставится поощрительный балл, который входит в общий счет очков. В конце игры определяется команда – победитель за лучший (обстоятельный, полный, доказательный) ответ.\r\n\r\n    Деловые игры бывают следующих видов:\r\n•\tимитационные, где осуществляется копирование с последующим анализом.\r\n•\tуправленческие, в которых осуществляется воспроизведение конкретных управленческих функций);\r\n•\tисследовательские, связанные с научно-исследовательской работой, где через игровую форму изучаются методики по конкретным направлениям;\r\n•\tорганизационно-деятельные. Участники этих игр моделируют раннее неизвестное содержание деятельности по определенной теме.\r\n•\tигры-тренинги. Это упражнения, закрепляющие те или иные навыки;\r\n•\tигры проективные, в которых составляется собственный проект, алгоритм каких-либо действий, план деятельности и осуществляется защита предложенного проекта.\r\n\r\n    При организации и проведении деловой игры роль руководителя игры различна – до игры он инструктор, в процессе ее проведения – консультант, на последнем этапе – руководитель дискуссии.\r\n\r\n    Основная цель игры – живое моделирование образовательно-воспитательного процесса, формирование конкретных практических умений педагогов, более быстрая адаптация к обновлению содержания, формирование у них интереса и культуры саморазвития; отработка определенных профессиональных навыков, педагогических технологий.\r\n\r\n    Методика организации и проведения:\r\n\r\n    Процесс организации и проведения игры можно разделить на 4 этапа:\r\n          Конструирование игры:\r\n\r\n•\tОрганизационная подготовка конкретной игры с реализацией определенной дидактической цели: руководитель разъясняет участникам смысл игры, знакомит с общей программой и правилами, распределяет роли и ставит перед их исполнителями конкретные задачи, которые должны быть ими решены;\r\n•\tназначаются эксперты, которые наблюдают ход игры, анализируют моделируемые ситуации, дают оценку;\r\n•\tопределяют время, условия и длительность игры.\r\n\r\n\r\n     Ход игры.\r\n\r\n•\tПодведение итогов, подробный анализ игры: общая оценка игры, подробный анализ, реализация целей и задач, удачные и слабые стороны, их причины;\r\n•\tсамооценка участниками исполнения полученных заданий, степень личной удовлетворенности;\r\n•\tхарактеристика профессиональных знаний и умений, выявленных в процессе игры;\r\n•\tанализ и оценка игры экспертами.\r\n\r\n    Критерием для такой оценки может служить количество и содержательность выдвинутых идей (предложений), степень самостоятельности суждений, их практическая значимость.\r\n    В заключении руководитель подводит итог игры.\r\n";
                            break;
                        case 3:
                            LessonCompleteRichBox.Text += "    Целью урока-практикума является закрепление материала посредством заданий разной сложности. К его задачам относится:\r\n\r\n        1. Проверка уровня освоенности темы.\r\n        2. Формирование:\r\n\r\n   • навыка коллективной деятельности;\r\n   • навыка само- и взаимопроверки;\r\n   • навыка объективной само- и взаимооценки.\r\n\r\n        3. Развитие:\r\n\r\n   • умения объяснять – связывать несколько мыслей в одну с применением принципов логики;\r\n   • умения выделять главное в большом объеме информации.\r\n\r\n        4. Воспитание:\r\n\r\n   • коммуникативности;\r\n   • ответственности, любви к труду;\r\n   • уважительного отношения к другим людям, вне зависимости от того, что они говорят.\r\n\r\n        5.Повышение интереса к предмету.\r\n        6.Проявление творческих способностей.\r\n\r\n    План урока-практикума включает в себя:\r\n1.\tСообщение темы, цели и задач урока-практикума.\r\n2.\tМотивация к уроку-практикуму.\r\n3.\tОзнакомление с планом и инструкциями урока-практикума.\r\n4.\tПодготовка учебной литературы и оборудования к уроку-практикуму.\r\n5.\tНепосредственное проведение урока-практикума.\r\n6.\tВыводу по уроку-практикуму.\r\n\r\n    Организация урока-практикума\r\n    Первое, что необходимо сделать для организации урока-практикума – конечно же, определиться с темой, целями и задачами. Далее:\r\n1.\tНемного ускориться в прохождении курса. Это необходимо для того, чтобы освободить как минимум два учебных часа на урок-практикум.\r\n2.\tНаписать план (для учителя) и инструкции (для учеников). Требования должны соответствовать уровню подготовки обучающихся: сильным следует давать сложные задания, а слабым более «лояльные».\r\n3.\tПодготовить учебную литературу и оборудование. Нехватку или отсутствие оборудования можно компенсировать творческим заданием или контрольной работой в письменном виде.\r\n\r\n    Индивидуальный подход в организации урока-практикума\r\n    Несмотря на то, что на рассматриваемом нами уроке используется групповой подход, это не отменяет другого – индивидуального подхода в виде:\r\n   • выполнении работы по образцу из учебника или с листа от педагога;\r\n   • выполнении работы с таблицами и схемами;\r\n   • выполнении работы с учебной литературой, в частности, словарями и справочниками.\r\n\r\n    На то, как пройдет урок-практикум, влияет, во-первых, уровень освоенности темы студентом и, во-вторых, опыт педагога. На таком уроке знания усваиваются намного лучше, так как складывается неформальная обстановка.\r\n";
                            break;
                        case 4:
                            LessonCompleteRichBox.Text += "    Урок-конкурс может иметь место в любом классе на завершающем этапе работы практически над любой темой с учетом условий обучения. Целесообразно комплексный подход при разработке урока, т.е. необходимо реализация языковых и речевых навыков и умений учащихся, меж предметных связей коллективная подготовка к уроку сплачивает ребят стремлением к победе, желанием каждого внести свою посильную лепту в общее дело. \r\n    \r\n    В связи с этим необходимо предусмотреть как задания для индивидуальной подготовки, но общее для всех, так и задания для коллективного их выполнения командами – участницами. \r\n\r\n    Примерная формулировка цели урока: \r\n\r\n   • Практическая цель: совершенствование языковых и речевых навыков и умений уч-ся в процессе подготовки к конкурсу и в процессе выполнения ими конкурсных заданий. \r\n   • Образовательная цель: расширение кругозора учащихся. \r\n   • Развивающая цель: привитие интереса уч-ся к предмету, развитие познавательной активности, развитие навыков и умений в ходе поиска конкретного практического материала для выполнения задания. \r\n   • Воспитательная цель: воспитание детей в духе коллективизма, повышение ответственности уч-ся за качество выполнения домашних заданий в духе подготовки к уроку-конкурсу и выполнение заданий на уроке. \r\n\r\n    В ходе подготовки и проведении урока-конкурса функции учителя реализуются так:\r\n\r\n   • Конструктивно планирующая: при составлении сценария, условия конкурса, критериев оценки результатов. \r\n   • Организационная и коммуникативно - обучающая: при организации работы учащихся по выполнению типичных заданий в серии урока, предваряющих урок-конкурс, в ходе индивидуальной работы с ведущими конкурса, которые будут распоряжаться комплексом средств обучения на уроке, отражать результаты соревнования на уроке. Организующая функция учителя в большей мере актуализируется и на самом уроке на младшей степени обучения, т.к. языковая база уч-ся в это время недостаточна, чтобы самостоятельно провести урок-конкурс. \r\n   • Воспитывающая сочетается со всеми вышеупомянутыми функциями на всех этапах работы над материалом. Подготовительная работа начинается задолго до проведения урока-конкурса, учитель объявляет о сроках проведения и его теме во вводной беседе. \r\n\r\n   Необходимо нацелить уч-ся на систематическую, активную работу на уроках, тщательное выполнение домашнего задания, самостоятельное изучение материала. Кроме темы, списка литературы, необходимо заранее сообщить условия конкурса, критерии оценок, состав команд, жюри. \r\n\r\n    Примерные условия конкурса\r\n \r\n   1. Объем высказывания. \r\n   2. Логика высказывания \r\n   3. Правильность высказывания \r\n   4. Фонетическое оформление речи \r\n   5. Количество ошибок \r\n   6. Знание фактического материала \r\n   7. Эмоциональная окрашенность речи \r\n   8. Оригинальность решения поставленной задачи. \r\n\r\n    Составление сценария урока-конкурса, в ходе воплощения которого речевой деятельности учителя отводится минимальное время, в основном как члену жюри при подведении итогов. Сценарием могут быть предусмотрены ведущие из числа способных учащихся, которые будут давать указания.\r\n";
                            break;
                        case 5:
                            LessonCompleteRichBox.Text += "    Подготовка к диспуту\r\n   1. Выбор темы, ее утверждение. Можно провести анкети¬рование на темы: «Какие вопросы тебя особенно волнуют, и ты не находишь на них ответа?», «О чем бы ты хотел поспорить, поговорить откровенно с товарищами?» и др.\r\n   2. Формулирование вопросов по выбранной теме. Реко¬мендуется сформулировать три-четыре вопроса, но чтобы они звучали проблематично. Например, существуют ли критерии современного человека? Быть современным — значит быть мод¬ным. Согласны ли вы с таким утверждением? и т.п.\r\n   3. Собственно подготовительный период, главной задачей которого является изучение мнения коллектива по выдвинутым во¬просам, включает в себя следующие моменты: \r\n  а) анкетирование по вопросам диспута; \r\n  б) составление анкетных карточек, противопо¬ложных по мнению (с них-то можно и начать диспут: зачитать одну, потом — другую, попросить каждого доказать свое мнение по поводу выделенных точек зрения); \r\n  в) изучение учащимися рекомендован¬ной литературы; \r\n  г) инсценирование (или «модель») будущего дис¬пута: за несколько дней до диспута рекомендуется собрать несколь¬ко самых активных студентов для выяснения их мнения по вопросам диспута. Это могут быть члены временной инициативной группы. Не навязывая своего мнения, педагог просит этих студентов подготовить более тщательно свои выступления для того, чтобы на диспуте они дали «толчок» для начала общего спора\r\n\r\n    Формулировка темы должна быть острой, проблематичной, будить мысль учащихся, заключать в себе нравственную или эстетическую проблему, которая в жизни, в литературе решается по-разному, вызывает противоречивые суждения. Таким образом, педагогически ценной является такая тема диспута, которая взволнует обучающихся, «заденет их за живое», привлечет внимание своей необычностью, новизной.\r\n\r\n    Таким образом, на диспуте учащиеся не только учатся спорить, думать, отстаивать свои убеждения, но и получают ответы на интересующие их вопросы, растут духовно.\r\n    Заключительное слово, желательно, чтобы было кратким, ярким и убедительным, так как оно произносится искренне и задушевно, страстно и доказательно, выслушивается с исключительным вниманием, запоминается надолго.\r\n\r\n    Правила проведения дискуссии\r\n1.\tДискуссия — это спор во имя истины; здесь важен обмен мнениями, основанными на конкретных фактах, аргументах, доказательствах, результатах исследований.\r\n2.\tДискуссия успешна, если все участники хорошо знают предмет обсуждения, не отвлекаются на другие проблемы.\r\n3.\tСопоставление своей и чужой точек зрения, опровержение неправильной должно быть этичным.\r\n4.\tНе обидь, не оскорби, не унизь человека — девиз всякой дискуссии.\r\n5.\tЧеловека уважают в споре уже за то, что он искренен, хотя и ошибается.\r\n6.\tДискуссия — это школа, вырабатывающая демократическое восприятие плюрализма мнений, отношений к поступку, действию.\r\n\r\n    Очень велика роль ведущего на диспуте. Он обязан предоставлять слово желающим, следить за соблюдением регламента, регулировать очередность выступлений и заботиться о том, чтобы накал встречи не спадал до конца.\r\n\r\n    Как руководить дискуссией в группе:\r\n1.\tПриглашать к участию стеснительных детей.\r\n2.\tНаправлять комментарии и вопросы одного ученика к другому.\r\n3.\tЕсли вы не уверены, что поняли то, что сказал ученик, значит и другие ученики тоже не смогли это понять.\r\n4.\tВытягивать больше информации.\r\n5.\tНе отвлекаться от предмета дискуссии.\r\n6.\tДавать время подумать над ответом: некоторые студенты легче высказываются, если предварительно записывают свои мысли.\r\n7.\tКогда студент заканчивает ответ, оглядеть класс, оценить реакцию других.\r\n";
                            break;
                        case 6:
                            LessonCompleteRichBox.Text += "    По содержанию можно выделить такие виды викторины:\r\n\r\n   1) тематические\r\n   2) развлекательно - развивающие\r\n   3) лингвистические\r\n   4) межтематические\r\n\r\n    Тематические викторины  используются наиболее часто. С помощью тематических викторин можно сообщить дополнительные сведения по какой-либо теме или обобщить ее изучение, проверить степень информированности студентов, их умение самостоятельно пользоваться рекомендованной преподавателем литературой, давать доказательные и точные ответы.\r\n\r\n    Развлекательно-развивающие викто¬рины способствуют развитию сообрази¬тельности, находчивости, гибкости мыш¬ления, логики. Часто используются кроссворды и различные вопросы.\r\n\r\n    Лингвистические викторины способствуют самостоятельной работе обучающихся над языковым материалом, учат некоторым приёмам самостоятельной работы со словом, более внимательному отношению к различным языковым явлениям.\r\n\r\n    Межтематические викторины выяв¬ляют разносторонние знания обучающихся; учат их обращаться друг к другу; внимательно относиться к тому, что каждый из них знает, умеет; способствуют взаимообо¬гащению в процессе обучения.\r\n\r\n    В числе основных требований к проведению викторин следующие:\r\n\r\n   1)    четкая учебно-воспитательная направленность, ориентация обучающихся на информацию, представляющую общеобразовательную и практическую значимость;\r\n   2)    актуальность и связь с жизнью;\r\n   3)    доступность источников информации;\r\n   4)    занимательность и новизна.\r\n\r\n    Структура викторины:\r\n\r\n   1) вводная часть\r\n   2) ра¬бота в группах\r\n   3) заключительную часть\r\n\r\n    Вводная часть. Перед обучающимися ставится задача, они получают раздаточ¬ный материал, их информируют о после¬довательности видов деятельности в про¬цессе работы. Виды деятельности таковы: \r\n   а) все команды получают одинаковую задачу и материал для выполнения в от¬веденное время; \r\n   б) материал у команд может быть разным; \r\n   в) команды мо¬гут работать одновременно в отведенное время или же меняться для выполнения различных заданий; \r\n   г) на викторине мо¬гут быть предусмотрены и индивидуаль¬ные конкурсы капитанов, консультантов; выбор представителя может быть сделан по решению команды.\r\n\r\n    Работа в группах. На этом этапе обучающиеся знакомятся с материалом викторины, планируют работу и время, распределяют вопросы между членами команды, совместно обсуждают получен¬ный результат, дорабатывают и коррек¬тируют ответы.\r\n\r\n    Заключительная часть. Подводятся итоги работы, анализируется выполне¬ние заданий, дается оценка групповой и индивидуальной работы, проводится разбор типичных ошибок, акцентирует¬ся внимание на вопросах, вызвавших особые трудности. Этот этап позволяет преподавателю проконтролировать свою рабо¬ту, скорректировать планирование, наметить план по ликвидации пробелов.\r\n";
                            break;
                    }
                    break;
                case 4:
                    LessonCompleteRichBox.Text = "   Урок развивающего контроля -  один из типов уроков, предложенных в рамках ФГОС. Проводятся такие уроки по завершении большого блока раздела или темы. Их цель — не только провести контрольный срез знаний, но и сделать акцент на самоконтроле, на развитии самоанализа у студентов.\r\n \r\n   Желательно обеспечить наличие разно уровневых заданий, а также возможность выбора задания для ученика (например, тест с заданиями разной бальной системы; оценка выставляется в зависимости от количества полученных баллов). На таком уроке, кроме образовательных задач (контроль знаний по теме или разделу), решаются также воспитательные (создание условий для формирования правильной самооценки; упорство в достижении цели) и развивающие (умение анализировать, сравнивать, классифицировать; если работа групповая, то и коммуникативные навыки).\r\n";
                    LessonCompleteRichBox.Text += text1;
                    switch (LessonPoint2X)
                    {
                        case 1:
                            LessonCompleteRichBox.Text += "    Планирование деятельности по составлению тестов.\r\n\r\n   1. Определить, с какой целью составляется тест.\r\n   2. Просмотреть и изучить материал по теме в различных источниках (сеть Internet, энциклопедии, практические пособия, учебная литература).\r\n   3. Просмотреть и выбрать форму теста.\r\n   4. Определить количество вопросов в тесте.\r\n   5. Составить вопросы и подобрать варианты ответов.\r\n   6. Продумать критерии оценивания.\r\n   7. Написать инструкцию к выполнению теста.\r\n   8. Проверить орфографию текста, соответствие нумерации.\r\n   9. Проанализировать составленный тест согласно критериям оценивания.\r\n  10. Оформить готовый тест.\r\n  11. Оформить бланк ответов к тесту.\r\n\r\n    Формы тестовых заданий\r\n\r\n   1. - задания закрытой формы, в которых выбирают правильный ответ из данного набора ответов к тексту задания;\r\n   2. - задания открытой формы, требующие при выполнении самостоятельного формулирования ответа;\r\n   3. - задание на соответствие, выполнение которых связано с установлением соответствия между элементами двух множеств;\r\n   4. - задания па установление правильной последовательности, в которых требуется указать порядок действий или процессов, перечисленных в задании.\r\n \r\nТребования при составлении теста:\r\n   1) Строгое соответствие источникам информации, которы¬ми пользуются учащиеся (соответствие содержанию и объему полученной ими информации).\r\n   2) Простота (задание должно требовать от испытуемого решения только одного вопроса).\r\n   3) Однозначность задания (формулировка вопроса должна исчерпывающим образом разъяснять поставленную перед испы¬туемым задачу, причем язык и термины, способы и индексация обозначений, графические изображения и иллюстрации задания и ответов к нему должны быть безусловно и однозначно понятны всеми учащимися).\r\n   4) Предпочтительнее подробный вопрос (задание) и лако¬ничные ответы.\r\n   5)Идентичность всех ответов по форме, содержанию, объ¬ему, количеству представленных позиций.\r\n   6) Оптимальное количество вариантов ответа — четыре-пять.\r\n   7) Грамматическое и логическое соответствие ответов во¬просу (заданию).\r\n   8) Совер¬шенно неприемлемы абсурдные, очевидно неправильные ответы.\r\n   9) Обучающая функция теста возрастает, если необходимо отметить неправильный или негативный ответ, а также в случае, когда все ответы правильные, но один предпочтительнее по тем или иным критериям.\r\n \r\n    Краткая характеристика программ для создания тестов:\r\n\r\n   HotPotatoes – программа, предоставляющая преподавателям возможность самостоятельно создавать интерактивные задания и тесты для контроля и самоконтроля учащихся. С помощью программы можно создать 10 типов упражнений и тестов по различным дисциплинам с использованием текстовой, графической, аудио- и видеоинформации. В этой программе удобно составлять кроссворды, которые можно использовать в интерактивном и печатном варианте.\r\nhttp://hotpot.uvic.ca/\r\n\r\n    ADTester. С помощью ADTester возможна организация проведения тестирования в любых образовательных учреждениях. Тестирование может проводиться как с целью выявления знаний учащихся в той или иной области, так и для обучающих целей.\r\nhttp://www.adtester.org/\r\n\r\n    «MyTest». Пакет программ для создания и проведения компьютерного тестирования, сбора и анализа результатов, выставления оценки по указанной в тесте шкале. С помощью программы MyTest возможна организация и проведение тестирования в любых образовательных учреждениях как с целью выявить уровень знаний по любым учебным дисциплинам, так и с обучающими целями.\r\nhttp://mytest.klyaksa.net/htm/download/index.htm\r\n\r\n    Knowing. Программа позволяет создавать тесты и автоматически оценивать результаты тестирования. Эта программа проста в использовании. Но функции ограничены, например, можно составлять задания только с одним выбором ответа.\r\nhttp://www.globalpage.ru/download/\r\n";
                            break;
                        case 2:
                            LessonCompleteRichBox.Text += "    Базовые правила при построении вопросов:\r\n\r\n•\t– респондент всегда прав;\r\n•\t– каков вопрос – таков и ответ.\r\n\r\n    Требования к формулировке вопросов:\r\n\r\n•\t– ясность (понятность для респондента; нельзя включать сложную, непонятную для респондентов терминологию, понятия, которые способны затруднить восприятие респондентами);\r\n•\t– конкретность (не допускать двоякого толкования понятий или вопроса в целом);\r\n•\t– проблемность (прямая или косвенная направленность вопроса на интересующую корреспондента проблему, но формулировка не должна наводить на ответ);\r\n•\t– последовательность (значимо выстроить порядок вопросов так, чтобы они не шокировали респондента, а позволяли постепенно конкретизировать и подробно раскрывать ответы).\r\n\r\n    Интервью – очный вид опроса. Интервью – встреча лицом к лицу. Ведущий принцип – вопросы исходят практически только от корреспондента, а ответы – от респондента.\r\n    Интервью требует специальной предварительной подготовки. Важна не только правильность формулировки вопроса, но и интонирование, последовательность вопросов, внешний вид корреспондента и многое другое. Но при интервью или беседе в отличие от анкеты можно наблюдать за реакциями на вопросы и невербальными компонентами общения, дающими зачастую очень много информации.\r\n\r\n    Виды интервью:\r\n\r\n•\t1) стандартизованное (формализованное) – предполагаемые вопросы беседы формулируются заранее, и отход от них не допускается;\r\n•\t2) нестандартизованное (неформализованное, свободное) – обозначается только тема и ключевые вопросы интервью, вопросы формулируются и уточняются по ходу интервью;\r\n•\t3) фокусированное (направленное) – по поводу одного события, документа, явления и т.п.;\r\n•\t4) ненаправленное – неформализованное интервью на общие темы или по поводу разнохарактерных вопросов.\r\n\r\nТребования к интервью:\r\n\r\n•\t– не допускается подсказка (это влечет к увеличению субъективизма);\r\n•\t– нельзя проявлять чрезмерную настойчивость в опросе;\r\n•\t– важно учитывать культурный уровень интервьюера;\r\n•\t– важна организация единого социально-психологического пространства между корреспондентом и респондентом;\r\n•\t– а главное – корреспондент больше молчит, а респондент больше говорит, но не наоборот; важно не только уметь задать вопрос, но и уметь выслушать на него ответ.\r\n\r\n\r\n    Беседа – в отличие от интервью в ней две участвующие стороны (задающий вопросы и отвечающий на них) находятся примерно в равном положении. Под беседой чаще всего понимается диалоговый метод исследования. Важно умение вести диалог, т.е. не только интересоваться собеседником и корректно ставить ему вопросы, но уметь слышать вопросы другого и содержательно на них отвечать.\r\n\r\n    Опрос экспертов. Методика в целом такая же, как при обычном опросе или анкетировании. Специфика – отбор экспертов, т.е. определение выборки опрашиваемых. Правильность метода зависит от правильности выбора эксперта. Этот метод чаще применяется при пилотажном исследовании.\r\n    При выборе эксперта значимо учитывать компетентность эксперта в нужной теме. Выбор по параметрам: известность, профессионализм, принадлежность к области выбора, определение отношения к виду деятельности, включенность в событие и пр.\r\n\r\n    Этапы исследования с помощью методов устного опроса:\r\n\r\n•\t1. Выбор темы – формулировка цели исследования, отвечающая на вопросы \"почему?\" и \"что?\", будет изучаться.\r\n•\t2. Планирование – определение логики исследования (какие, в какой последовательности, в каком стиле, при какой ситуации, кому именно будут задаваться вопросы; определение места и времени выборки).\r\n•\t3. Опрос – проведение беседы, интервью или дискуссии по запланированной схеме.\r\n•\t4. Расшифровка – перевод аудиозаписи в письменный текст.\r\n•\t5. Анализ – опираясь на цель и тему опроса, а также с учетом природы полученного материала, выбирается и применяется тот или иной метод анализа (качественный, количественный, качественно-количественный; обобщенный или детальный и т.д.).\r\n•\t6. Верификация (проверка) – выясняется, насколько полученные тексты надежны (тексты опросов однородны) и валидны (тексты опроса реализуют именно ту цель, которая была поставлена исследователем).\r\n•\t7. Написание отчета – изложение результатов исследования в заданной форме с соблюдением этических правил и методических норм.\r\n";
                            break;
                        case 3:
                            LessonCompleteRichBox.Text += "    По содержанию можно выделить такие виды викторины:\r\n\r\n   1) тематические\r\n   2) развлекательно - развивающие\r\n   3) лингвистические\r\n   4) межтематические\r\n\r\n    Тематические викторины  используются наиболее часто. С помощью тематических викторин можно сообщить дополнительные сведения по какой-либо теме или обобщить ее изучение, проверить степень информированности студентов, их умение самостоятельно пользоваться рекомендованной преподавателем литературой, давать доказательные и точные ответы.\r\n\r\n    Развлекательно-развивающие викто¬рины способствуют развитию сообрази¬тельности, находчивости, гибкости мыш¬ления, логики. Часто используются кроссворды и различные вопросы.\r\n\r\n    Лингвистические викторины способствуют самостоятельной работе обучающихся над языковым материалом, учат некоторым приёмам самостоятельной работы со словом, более внимательному отношению к различным языковым явлениям.\r\n\r\n    Межтематические викторины выяв¬ляют разносторонние знания обучающихся; учат их обращаться друг к другу; внимательно относиться к тому, что каждый из них знает, умеет; способствуют взаимообо¬гащению в процессе обучения.\r\n\r\n    В числе основных требований к проведению викторин следующие:\r\n\r\n   1)    четкая учебно-воспитательная направленность, ориентация обучающихся на информацию, представляющую общеобразовательную и практическую значимость;\r\n   2)    актуальность и связь с жизнью;\r\n   3)    доступность источников информации;\r\n   4)    занимательность и новизна.\r\n\r\n    Структура викторины:\r\n\r\n   1) вводная часть\r\n   2) ра¬бота в группах\r\n   3) заключительную часть\r\n\r\n    Вводная часть. Перед обучающимися ставится задача, они получают раздаточ¬ный материал, их информируют о после¬довательности видов деятельности в про¬цессе работы. Виды деятельности таковы: \r\n   а) все команды получают одинаковую задачу и материал для выполнения в от¬веденное время; \r\n   б) материал у команд может быть разным; \r\n   в) команды мо¬гут работать одновременно в отведенное время или же меняться для выполнения различных заданий; \r\n   г) на викторине мо¬гут быть предусмотрены и индивидуаль¬ные конкурсы капитанов, консультантов; выбор представителя может быть сделан по решению команды.\r\n\r\n    Работа в группах. На этом этапе обучающиеся знакомятся с материалом викторины, планируют работу и время, распределяют вопросы между членами команды, совместно обсуждают получен¬ный результат, дорабатывают и коррек¬тируют ответы.\r\n\r\n    Заключительная часть. Подводятся итоги работы, анализируется выполне¬ние заданий, дается оценка групповой и индивидуальной работы, проводится разбор типичных ошибок, акцентирует¬ся внимание на вопросах, вызвавших особые трудности. Этот этап позволяет преподавателю проконтролировать свою рабо¬ту, скорректировать планирование, наметить план по ликвидации пробелов.\r\n";
                            break;
                        case 4:
                            LessonCompleteRichBox.Text += "    Требования к подготовке и проведению коллоквиума: \r\n\r\n   1. Минимальное количество часов, отводимое на коллоквиум, не может быть менее 2 часов на одну группу. Как правило, коллоквиум проводится в рамках 2 - 4 часов аудиторного времени.\r\n   2. Материал программы учебной дисциплины (часть, раздел, темы), отнесенный к коллоквиуму, должен по трудоемкости освоения 10 студентом составлять 25-30% от всего объема трудозатрат по данной дисциплине и в дальнейшем не выносится на экзамен. \r\n   3. При подготовке к коллоквиуму преподаватель обязан:\r\n \r\n  • определить задачи, круг обсуждаемых вопросов, практических заданий, время проведения; \r\n  • подобрать литературу для студентов; \r\n  • консультировать обучающихся по ходу подготовки коллоквиума и проверять их готовность; \r\n  • заранее объявить дату, тему и план коллоквиума.\r\n \r\n\r\n   4. Методическое обеспечение коллоквиума должно содержать следующие обязательные компоненты: \r\n\r\n  • формулировки темы и вопросов, заданий по освоению её содержания; \r\n  • требования к заданиям и умениям, которые должен продемонстрировать обучающийся при освоении содержания данной темы; \r\n  • списки обязательной и дополнительной литературы, перечень интернет-ресурсов; \r\n  • терминологический минимум, который должен освоить обучающийся при самостоятельном изучении темы; \r\n  • методические указания по освоению содержания представленной темы; \r\n  • разработанный и утвержденный уровень компетенций; \r\n  • критерии оценки ответов на коллоквиуме. \r\n\r\n    Особенности проведение устного коллоквиум по теме или разделу дисциплины: \r\n\r\n    Собеседование ведется с каждым студентом индивидуально в присутствии малой группы (5-6 человек). В случае затруднения студента при ответе на поставленный вопрос, последний может быть переадресован другим. При этом студенты могут дополнять друг друга, дискутировать, задавать вопросы, всесторонне обсуждая проблему. Таким образом, коллоквиум представляет собой групповую форму беседы преподавателя со студентами с целью выяснения их знаний. При этом каждому выставляется дифференцированная оценка. На коллоквиуме студенты могут пользоваться своими записями изученных материалов. Не следует сводить коллоквиум к семинару. Если семинар сегодня не рекомендуется проводить лишь вопросно-ответным методом, то на коллоквиуме такой метод является основным. На коллоквиуме студент должен продемонстрировать, что он: \r\n\r\n   • знает содержание и структуру работы, отдельных её глав и параграфов (если на коллоквиум выносится отдельный труд); \r\n   • уяснил логику изложения материала; \r\n   • умеет выделить узловые идеи и положения; \r\n   • умеет обобщать материал с помощью схем, таблиц, вопросов и делать записи прочитанного (сделать выписки, составить план, тезисы, аннотацию, резюме, конспект); \r\n   • видит связь изучаемой теории с практикой; \r\n   • имеет собственное мнение о прочитанном.\r\n";
                            break;
                        case 5:
                            LessonCompleteRichBox.Text += "    Урок-конкурс может иметь место в любом классе на завершающем этапе работы практически над любой темой с учетом условий обучения. Целесообразно комплексный подход при разработке урока, т.е. необходимо реализация языковых и речевых навыков и умений учащихся, меж предметных связей коллективная подготовка к уроку сплачивает ребят стремлением к победе, желанием каждого внести свою посильную лепту в общее дело. \r\n    \r\n    В связи с этим необходимо предусмотреть как задания для индивидуальной подготовки, но общее для всех, так и задания для коллективного их выполнения командами – участницами. \r\n\r\n    Примерная формулировка цели урока: \r\n\r\n   • Практическая цель: совершенствование языковых и речевых навыков и умений уч-ся в процессе подготовки к конкурсу и в процессе выполнения ими конкурсных заданий. \r\n   • Образовательная цель: расширение кругозора учащихся. \r\n   • Развивающая цель: привитие интереса уч-ся к предмету, развитие познавательной активности, развитие навыков и умений в ходе поиска конкретного практического материала для выполнения задания. \r\n   • Воспитательная цель: воспитание детей в духе коллективизма, повышение ответственности уч-ся за качество выполнения домашних заданий в духе подготовки к уроку-конкурсу и выполнение заданий на уроке. \r\n\r\n    В ходе подготовки и проведении урока-конкурса функции учителя реализуются так:\r\n\r\n   • Конструктивно планирующая: при составлении сценария, условия конкурса, критериев оценки результатов. \r\n   • Организационная и коммуникативно - обучающая: при организации работы учащихся по выполнению типичных заданий в серии урока, предваряющих урок-конкурс, в ходе индивидуальной работы с ведущими конкурса, которые будут распоряжаться комплексом средств обучения на уроке, отражать результаты соревнования на уроке. Организующая функция учителя в большей мере актуализируется и на самом уроке на младшей степени обучения, т.к. языковая база уч-ся в это время недостаточна, чтобы самостоятельно провести урок-конкурс. \r\n   • Воспитывающая сочетается со всеми вышеупомянутыми функциями на всех этапах работы над материалом. Подготовительная работа начинается задолго до проведения урока-конкурса, учитель объявляет о сроках проведения и его теме во вводной беседе. \r\n\r\n   Необходимо нацелить уч-ся на систематическую, активную работу на уроках, тщательное выполнение домашнего задания, самостоятельное изучение материала. Кроме темы, списка литературы, необходимо заранее сообщить условия конкурса, критерии оценок, состав команд, жюри. \r\n\r\n    Примерные условия конкурса\r\n \r\n   1. Объем высказывания. \r\n   2. Логика высказывания \r\n   3. Правильность высказывания \r\n   4. Фонетическое оформление речи \r\n   5. Количество ошибок \r\n   6. Знание фактического материала \r\n   7. Эмоциональная окрашенность речи \r\n   8. Оригинальность решения поставленной задачи. \r\n\r\n    Составление сценария урока-конкурса, в ходе воплощения которого речевой деятельности учителя отводится минимальное время, в основном как члену жюри при подведении итогов. Сценарием могут быть предусмотрены ведущие из числа способных учащихся, которые будут давать указания.\r\n";
                            break;
                        case 6:
                            LessonCompleteRichBox.Text += "";
                            break;
                    }
                    break;
                case 5:
                    //LessonCompleteRichBox.Text = "   Урок коррекции знаний. Он по-прежнему важен, потому что помогает школьнику осознать причину ошибок, скорректировать знания, наметить план работы на будущее. Более низкая, чем хотелось бы, оценка должна стать стимулом для дальнейшей работы, указателем, в каком направлении следует двигаться. Если урок коррекции не выполнит эту задачу, оценка так и останется обидной цифрой в журнале, что нежелательно во всех отношениях. Поэтому к планированию урока коррекции надо подготовиться особенно тщательно и особенное внимание уделить мотивационной части. \nСтруктура урока \n•    Мотивационная часть. \n•    В начале урока проводится работа над наиболее часто встречающимися ошибками, но педагог не комментирует суть ошибки, а предлагает студентам определить, в чем ее причина и как ее можно было избежать. Обычно это коллективный этап работы. \n•    Если позволяет время, затем можно провести групповой этап, разделив студентов на набольшие группы в соответствии с их ошибками. Тем, кто выполнил работу безошибочно, на данном этапе можно предложить задания повышенной сложности. \n•    Следует провести этап индивидуальной работы, в ходе которого предложить каждому студенту наметить для себя план коррекции (повторить какую-либо тему) и определиться, что он может сделать сам, а в чем ему нужна помощь. \n•    Рефлексия на таком уроке особенно важна (собственно, предыдущий этап как раз и есть подготовка к качественной рефлексии).\n";
                    LessonCompleteRichBox.Text = "    Урок коррекции знаний по-прежнему важен, потому что помогает студенту осознать причину ошибок, скорректировать знания, наметить план работы на будущее. Более низкая, чем хотелось бы, оценка должна стать стимулом для дальнейшей работы, указателем, в каком направлении следует двигаться. Если урок коррекции не выполнит эту задачу, оценка так и останется обидной цифрой в журнале, что нежелательно во всех отношениях. Поэтому к планированию урока коррекции надо подготовиться особенно тщательно и особенное внимание уделить мотивационной части. \r\n\r\n    Структура урока\r\n \r\n   • Мотивационная часть. \r\n   • В начале урока проводится работа над наиболее часто встречающимися ошибками, но педагог не комментирует суть ошибки, а предлагает студентам определить, в чем ее причина и как ее можно было избежать. Обычно это коллективный этап работы. \r\n   • Если позволяет время, затем можно провести групповой этап, разделив студентов на набольшие группы в соответствии с их ошибками. Тем, кто выполнил работу безошибочно, на данном этапе можно предложить задания повышенной сложности. \r\n   • Следует провести этап индивидуальной работы, в ходе которого предложить каждому студенту наметить для себя план коррекции (повторить какую-либо тему) и определиться, что он может сделать сам, а в чем ему нужна помощь. \r\n   • Рефлексия на таком уроке особенно важна (собственно, предыдущий этап как раз и есть подготовка к качественной рефлексии).\r\n";
                    LessonCompleteRichBox.Text += text1;
                    switch (LessonPoint2X)
                    {
                        case 1:
                            LessonCompleteRichBox.Text += "• Этапы подготовки и проведения урока-зачёта.\r\n1.\t Предварительная подготовка к уроку-зачёту.\r\n2.\tПроведение урока-зачёта.\r\n3.\tПодведение итогов и внесение корректив.\r\n    1этап.   Предварительная подготовка.\r\n    Подготовительная работа начинается на первом вводном уроке по теме. Учитель анализирует требования программы по теме, определяет основные задания, учитывая три уровня усвоения:\r\n1.\tПонимание, запоминание, воспроизведение материала.\r\n2.\tПрименение знаний и  умений в знакомой ситуации.\r\n3.\tПрименение знаний и умений в новой ситуации.\r\n    Учитель сообщает тему и дату проведения урока-зачёта, его место и значение в изучении новой темы, знакомит с требованиями, которые будут предъявлены к учащимся, предлагает индивидуальные задания по тем вопросам, в которых некоторые ученики ранее не разбирались.\r\n• На стенде.\r\n1.\tПеречень знаний, умений и навыков.\r\n2.\tВопросы и задания.\r\n3.\tСоветы по организации различных видов учебной деятельности: памятки, алгоритмы ,планы и образцы решений   наиболее сложных задач по теме.\r\n4.\tПримерная контрольная работа.\r\n5.\t Литература по теме.\r\n    2 этап.  Проведение зачёта.\r\n    На зачётном уроке опрашивать можно не всех учащихся. Учащиеся, успешно усвоившие учебный материал могут получить зачёт по обязательному материалу автоматически.  Они могут помочь учителю принимать зачёт у остальных учащихся, либо им предлагаются дифференцированные задания повышенной сложности.\r\n    Зачёт может быть письменным или устным. Можно проводить и комбинированные зачёты.\r\n    3 этап.  Подведение итогов работы.\r\n    Оценка труда учащихся.\r\n    Если зачёт устный, то оцениваются ответы учащихся на этом же уроке. Если письменный или комбинированный, то на следующем уроке, после проверки работ учителем.\r\n• Виды зачётов.\r\n        1).Открытый тематический зачёт.\r\n        2). Закрытый тематический зачёт.\r\n        3). Открытый текущий зачёт.\r\n        4). Закрытый текущий зачёт.\r\n    В открытом тематическом зачёте учащиеся предварительно знакомятся со списком задач обязательного уровня. В закрытом тематическом зачёте список задач в явном виде учащимся не предъявляется. Но это не означает, что учащимся совсем неизвестно, какие виды задач относятся к обязательным. В ходе изучения материала учитель акцентирует внимание учащихся на задачах обязательного уровня, подчёркивая, что подобные задачи нужно будет решать на зачёте.\r\n• Методические рекомендации по  проведения закрытого зачётного урока.\r\n    Цель: проверка достижения учащимися уровня обязательной подготовки; овладение важнейшими умениями и навыками.\r\n    Задача: установить уровень овладения знаниями по конкретной теме.\r\n    Подготовка: в процессе изучения темы отводится специальное время на формирование и отработку умений решать задачи обязательного уровня.\r\n    Время проведения: за один - два урока запланированного окончания изученной темы.\r\n    Формы: устная (опрос по билетам); письменная (контрольная работа); смешанная (часть учащихся класса опрашивается устно, а остальные задания письменно и сдают учителю на проверку).\r\n    План проведения: разминка, самостоятельная работа, решение (обязательная) устных задач (часть), устный (дополнительная) мини-экзамен (часть), тест.\r\n    Подведение итогов: проводится на следующем уроке (объявляется количество набранных баллов и оценка).\r\n    Корректировка: разбираются задачи, вызвавшие у учащихся наибольшие трудности. Время на пересдачу зачетов отводится на уроке. Предлагается индивидуальная карточка - задание или задача из зачета в качестве дополнительного задания.\r\n• Методические рекомендации по проведению открытого зачётного урока.\r\n    Цель: учет и контроль знаний, умений и навыков.\r\n    Задача: установить уровень овладения знаниями по конкретной теме.\r\n    Подготовка: в начале изучения темы вывешивается в классе или раздается учащимся список задач, отвечающим уровню обязательной подготовки по данной теме, и сообщает, что после ее изучения будет зачет.\r\n    Время проведения: на специально выделенном уроке.\r\n    Форма: проверочная работа.\r\n    План проведения: разминка, самостоятельная работа, обязательная часть, дополнительная часть.\r\n    Подведение итогов: проводится на следующем уроке (объявляется количество набранных баллов и оценка).\r\n    Корректировка: разбираются задачи, вызвавшие у учащихся наибольшие трудности. Время на пересдачу зачетов отводится на следующем уроке. Предлагается индивидуальное задание.\r\n• Текущие зачеты\r\n    проводятся несколько раз в ходе изучения темы. От тематических они отличаются тем, что охватывают меньший по объему материал; поэтому, как правило, на их проведение не требуется отводить весь урок. Это могут быть небольшие работы, рассчитанные на 10-15 минут и направленные на проверку одного - двух умений, формируемых в течение нескольких уроков.\r\n- экзамен \r\n    Экзамен проводится в объеме программы учебной дисциплины. Форма и порядок проведения экзамена определяются кафедрой. Для проведения экзамена на кафедре разрабатываются:\r\n   - экзаменационные билеты, количество которых должно быть больше числа экзаменующихся курсантов (слушателей и студентов) учебной группы;\r\n   - практические задания, решаемые на экзамене;\r\n   - перечень средств материального обеспечения экзамена (стенды, плакаты, справочная и нормативная литература и т.п.)\r\n    Материалы для проведения экзамена обсуждаются на заседании кафедры и утверждаются заместителем начальника университета по учебной работе не позднее 10 дней до начала экзаменационной сессии.\r\n    В экзаменационный билет включаются два теоретических вопроса.\r\n    Предварительное ознакомление обучающихся с экзаменационными билетами не разрешается\r\n    Экзамен принимается заведующим кафедрой, заместителем начальника кафедры, профессорами и доцентами. В отдельных случаях с разрешения заведующего кафедрой в помощь основному экзаменатору могут привлекаться преподаватели, ведущие семинарские и практические занятия.\r\n    На экзамене, кроме экзаменатора и экзаменуемых, имеют право присутствовать начальник и заместитель начальника университета, начальники и заместители начальника УМЦ, факультета и кафедры. Другие лица только с разрешения начальника университета. В аудитории (учебном кабинете), где проводится экзамен, должны быть: программы учебной дисциплины, экзаменационная ведомость, комплект экзаменационных билетов, перечень вопросов экзаменационных билетов с указанием номеров билетов.\r\n    В аудитории могут одновременно находиться не более пяти экзаменующихся.\r\n    Для подготовки к ответу курсантам (слушателям и студентам) отводится не более 20 минут. Норма времени на прием экзамена – 15 минут на одного обучающегося.\r\n    По окончании ответа на вопросы билета экзаменатор может задавать дополнительные и уточняющие вопросы в пределах учебного материала, вынесенного на экзамен.\r\n    Прерывать экзаменующегося при ответе не рекомендуется.\r\n    Оценка по результатам экзамена объявляется курсанту (слушателю и студенту), заноситься в экзаменационную ведомость и зачетную книжку. Неудовлетворительные оценки проставляются только в экзаменационной ведомости (в зачетные книжки не заносятся).\r\n    Если неявка была по неуважительной причине, то начальником центра организации и координации учебно-методической работы в ведомости проставляется неудовлетворительная оценка. Другие записи или прочерки в экзаменационной ведомости не допускаются.\r\n";
                            break;
                        case 2:
                            LessonCompleteRichBox.Text += "    Экзамен проводится в объеме программы учебной дисциплины. Форма и порядок проведения экзамена определяются кафедрой. Для проведения экзамена на кафедре разрабатываются:\r\n   - экзаменационные билеты, количество которых должно быть больше числа экзаменующихся курсантов (слушателей и студентов) учебной группы;\r\n   - практические задания, решаемые на экзамене;\r\n   - перечень средств материального обеспечения экзамена (стенды, плакаты, справочная и нормативная литература и т.п.)\r\n    Материалы для проведения экзамена обсуждаются на заседании кафедры и утверждаются заместителем начальника университета по учебной работе не позднее 10 дней до начала экзаменационной сессии.\r\n    В экзаменационный билет включаются два теоретических вопроса.\r\n    Предварительное ознакомление обучающихся с экзаменационными билетами не разрешается\r\n    Экзамен принимается заведующим кафедрой, заместителем начальника кафедры, профессорами и доцентами. В отдельных случаях с разрешения заведующего кафедрой в помощь основному экзаменатору могут привлекаться преподаватели, ведущие семинарские и практические занятия.\r\n    На экзамене, кроме экзаменатора и экзаменуемых, имеют право присутствовать начальник и заместитель начальника университета, начальники и заместители начальника УМЦ, факультета и кафедры. Другие лица только с разрешения начальника университета. В аудитории (учебном кабинете), где проводится экзамен, должны быть: программы учебной дисциплины, экзаменационная ведомость, комплект экзаменационных билетов, перечень вопросов экзаменационных билетов с указанием номеров билетов.\r\n    В аудитории могут одновременно находиться не более пяти экзаменующихся.\r\n    Для подготовки к ответу курсантам (слушателям и студентам) отводится не более 20 минут. Норма времени на прием экзамена – 15 минут на одного обучающегося.\r\n    По окончании ответа на вопросы билета экзаменатор может задавать дополнительные и уточняющие вопросы в пределах учебного материала, вынесенного на экзамен.\r\n    Прерывать экзаменующегося при ответе не рекомендуется.\r\n    Оценка по результатам экзамена объявляется курсанту (слушателю и студенту), заноситься в экзаменационную ведомость и зачетную книжку. Неудовлетворительные оценки проставляются только в экзаменационной ведомости (в зачетные книжки не заносятся).\r\n    Если неявка была по неуважительной причине, то начальником центра организации и координации учебно-методической работы в ведомости проставляется неудовлетворительная оценка. Другие записи или прочерки в экзаменационной ведомости не допускаются.\r\n";
                            break;
                        case 3:
                            LessonCompleteRichBox.Text += "• Структура семинарского занятия обычно включает в себя следующие этапы: \r\n   1. Организационный момент \r\n   2. Вступительное слово преподавателя направлено на психологическую установку студентов к предстоящей работе и на актуальность рассматриваемой проблемы. Он объявляет тему, цели и задачи семинарского занятия, определяет его место в изучаемом курсе. Также определяет порядок выступлений и их регламент. \r\n   3. Основная часть семинара. Заслушивание ответов на вопросы, докладов, рефератов. Последовательное обсуждение ответов, рефератов, докладов. Выработка мнений и суждений, формирование в результате дискуссии правильных суждений и др. Обсуждение темы зависит от методики работы преподавателя, которую он реализует на конкретном семинарском занятии. \r\n   4. Заключительное слово преподавателя (подведение итогов занятия). Анализ качества выступлений студентов, оценка их деятельности, степень подготовленности учебной группы, уровень культуры мышления участников. Преподаватель также поясняет используемую им систему поощрения и снижения оценки, определяет степень достижения цели семинара. Для обеспечения обратной связи преподавателю необходимо организовать рефлексию семинара. Здесь для студентов используются вопросы «Что я получил на сегодняшнем занятии?», «Удалось ли мне доказать свою точку зрения?», «Кто из участников помогал/мешал мне в работе?» и т.д., а также экспресс-опросы, анкеты. \r\n   5. Домашнее задание. \r\n• Подготовка преподавателя к проведению семинара \r\n    Результативность и эффективность семинара в значительной степени зависит от преподавателя. В отличии от обучаемых, преподаватель должен изучить более широкий перечень литературы по теме. Особенность работы преподавателя с литературой состоит в том, что он ее изучает не только с целью познания, но и для того, чтобы определить, как можно полезнее использовать важную и наиболее ценную информацию в интересах полного и глубокого осознания и прочного усвоения обучаемыми, выносимых на обсуждение вопросов и проблем, обеспечить реализацию поставленных перед занятием учебных целей. При этом преподаватель всегда выделяет важные детали вопросов, которые могут быть не замечены обучаемыми, но имеющие важное значение для углубления их знаний и для практической деятельности. Преподаватель должен продумать и наметить дополнительные (наводящие) вопросы, стимулируя этим активность обучаемых и глубокое всестороннее изучение вопросов. Следует предусмотреть вероятность альтернативных ответов и подготовиться к их анализу и сравнению, выявлению положительных сторон и недостатков. Затем следует продумать методику проведения семинара, каждый обучаемый должен принять активное участие в семинаре. Сначала продумать вступительное слово, затем методику обсуждения каждого вопроса. Необходимо продумать также структуру ожидаемого ответа. К подведению итогов семинара преподаватель готовится в процессе занятия. Необходимо определить систему критериев и показателей, пользуясь которыми преподаватель мог бы более или менее объективно проанализировать и оценить ответ каждого обучаемого, сравнить ответы студентов между собой, оценить их качество по форме и содержанию и подвести обоснованные итоги подготовки обучаемых и степень достижения целей.\r\n";
                            break;
                        case 4:
                            LessonCompleteRichBox.Text += "• Подготовительный этап: обсуждаем условия и правила игры\r\n    Условия аукциона необходимо заранее обсудить с обучающимися. Чем старше ученики, тем более сложную систему торгов и оценивания можно предложить.\r\n• Вариант 1. Например, простая форма аукциона: каждый ученик получает по 15 монет (у.е.). Каждый лот оценивается в 2 монеты. Право отвечать получает тот, кто предложит наибольшую цену. Задача учеников: потратить все монеты.\r\n• Вариант 2: Все лоты раскладываются на игровом поле (как на \"Поле чудес\"). Ученики (или группа учеников) крутит барабан и получает выпавший лот. Их задача: правильно решить предложенную задачу (ответить на вопрос). Каждый правильный, подробный и развернутый ответ оценивается в 2 монеты. За дополнения выдается из банка по 1 монете. Выигрывает та команда (группа), которая получила наиболее количество монет.\r\n• Вариант 3: Каждый ученик изначально имеет определенную сумму у.е. (например, по 1000). В ходе торгов он (или группа учащихся) могут выкупить лот, назвав максимальную цену. Если ответ на вопрос в лоте будет правильным, подробным, исчерпывающим, то команда или ученик могут получить поощрение из банка в размере 100 у.е. За неполные ответы или неправильные возможны штрафные санкции (до 300 у.е.).\r\n• Вариант 4: Без денег. Это самый простой вид аукциона. Класс делится на команды. В продажу поступают лоты, но в качестве выкупа будут правильные ответы.\r\n    Например, для урока русского языка в 3-ем классе. Тема: Части речи. Лот №1 Имя существительное.\r\n    Итак, на продажу выставлен лот № 1. После объявления темы команды дают поочередно характеристики имени существительного: самостоятельная часть речи, отвечает на вопросы \"Кто? Что?\", склоняется по падежам, изменяется по числам, имеет род, имеет склонение и т.д. За каждый правильный ответ команда получает по 2 балла. Лот уходит к той команде, которая наберет самое большое количество очков. Если количество баллов получается одинаковым, можно предложить дополнительное задание. С проигравшей команды можно взимать \"комиссионные\" в виде частушек, песни, стихотворения и т.д.\r\n    Как видите, вариантов воплощения самой идеи аукциона много. Важно только сначала все подробно обсудить с учениками, чтобы в ходе урока не возникало недопонимания и трений среди участников. Очень удобно, когда учет растраченных и заработанных средств ведется в реальном режиме. Для этого можно использовать, к примеру, доску, где в заранее подготовленную таблицу будут вноситься все изменения.\r\n• Подготовка учащихся к уроку-аукциону\r\n    Уроки-аукционы ценны тем, что учащиеся должны повторить, обобщить целый пласт знаний по теме до урока. А для более успешного выступления приветствуется подбор новых, интересных фактов по теме.\r\n    Как правило, о проведении аукциона целесообразно объявить заранее — за 1-2 недели. Желательно дать ученикам список тем, которые будут обсуждаться на уроке, список литературы и возможных ресурсов, где можно найти информацию по данной тематике, приблизительный перечень заданий.\r\n    Самые активные классы могут сами придумывать задания к лотам. Либо вопросы друг другу можно выставить как один из лотов. В этом случае на аукционе можно ввести систему поощрительных баллов: \"За самое необычное задание\", \"За самый интересный вопрос\" и т.д.\r\n    Варианты лотов\r\n•\tЗадания \"Кто быстрее?\" Кто быстрее решит примеры, кто быстрее составит анаграмму, кто быстрее отгадает задку и т.д.\r\n•\tВикторины. Такие лоты хороши для разминки, а потому их целесообразнее выставлять первыми.\r\n•\tТесты.\r\n•\tКроссворды, чайнворды.\r\n•\tИсторические сведения (уместны для любого предмета).\r\n•\tЦифровые диктанты или диктанты \"да-нет\". Можно проводить как устно, так и письменно.\r\n•\tИгровые задания. Лоты строятся по примеру любых дидактических игр, которые ваши ученики уже знают и умеют в них играть.\r\n•\tВидео или аудио вопросы.\r\n•\t\"Черный ящик\". В ящике лежит предмет, который ученики должны связать с темой урока.\r\n•\tПрактические задания (на них стоит сделать основной упор, так как именно практическое применение правил лучше всего показывает степень усвоения темы).\r\n•\tТворческие задания (составить задачу, нарисовать сюжетную картинку, собрать паззл, придумать стихотворение и т.д.).\r\n•\tЗадания повышенной сложности. За них и \"цена\" назначается выше.\r\n• Оформление урока-аукциона\r\n    Урок-аукцион позволяет использовать максимально возможное количество наглядных изобразительных и звуковых средств. Очень помогает в проведении аукциона интерактивная доска, на которой удобно представлять отдельные задания и вести общий подсчет баллов.\r\n    Дополнительно класс можно оформить как зал проведения торгов: за кафедрой, где будет находиться аукционист, установить металлический гонг или специальный молоточек. Хорошо, если будет вывешен плакат с правилами проведения аукциона. Кроме того, каждому ученику можно вручить специальное приглашение на аукцион (такие же можно раздать коллегам, если вы решите их пригласить на свой урок).\r\n    Не забывайте о поощрениях. Конечно, главное поощрение — положительная оценка за урок. Но и награды в виде медалей, дипломов или грамот также приветствуются.\r\n    Типичные ошибки в организации урока-аукциона и как их избежать\r\n•\tЧрезмерное увлечение \"продажами\". Нельзя позволять ученикам \"переигрывать\", отводя значительную часть времени на \"торги\". Особенно, если вы решите продавать лоты за у.е. Желательно сразу установить регламент: например, окончательной становится цена, названная третьей или установите максимальную ставку, выше которой поднимать цены нельзя, то есть блиц-цену. Можно установить и размер аукционного шага.\r\n•\tНе регламентировано время. Желательно регламентировать и время ответов на задания одного лота. А чтобы обстановка как можно больше походила на атмосферу настоящего аукциона, можно установить гонг, удары которого будут сигнализировать об окончании торгов.\r\n•\tСлишком много лотов. Лучше всего выбирать микротемы, а не материал целого курса.\r\n•\tОднообразие лотов. Будет скучно и малоэффективно, если все ваши задания будут строиться одинаково: например, только вопросы-ответы. Желательно разнообразить работу, включив в состав лотов разные задачи как из теории, так и  из практики. Ведь ваша задача — привлечь всех учеников. Поэтому необходимо предусмотреть задания и творческого плана, и на эрудицию и общее развитие.\r\n•\tНезнание правил аукциона. Выше уже отмечалось, что если учащиеся не поняли принципа проведения аукциона, то хаоса и обид не избежать. Поэтому рекомендуется предварительно обсудить все правила. А еще лучше, если вы будете иногда включать систему аукциона в качестве одного из этапов урока еще на предварительном этапе подготовки. Например, проводить в форме аукциона проверку домашнего задания или проверку практического задания, данного как закрепление к теме. \r\n    Для тех, кто никак не решится на аукцион\r\n•\tНе стоит сразу отвергать даже кажущиеся невероятными формы нестандартных уроков. Чем меньше будет шаблонов в вашем преподавании, тем больше шансов на успех.\r\n•\tБольше творчества! Но творчества не ради развлечения, а направленного на реализацию идеи познания в самой легкой и интересной форме. \r\n";
                            break;
                        case 5:
                            LessonCompleteRichBox.Text += "•\tКонкурсный урок – это творческое учебное занятие по индивидуальному сценарию, режиссуре и содержанию, опирающееся на современные классические принципы обучения и воспитания учащихся\r\n•\tКонкурсный урок — это не просто современный урок, это особый урок, ибо он естественная часть предъявляемого взыскательной аудитории педагогического опыта.\r\n•\tВажно, чтобы урок был профессиональным! Проблемным! Важно, чтобы он был уроком взаимодействия, диалога!\r\n•\tКонкурсный урок должен быть иллюстрацией системы работы педагога, научных позиций, технологий, педагогических позиций, предъявленных в разных формах (эссе, обобщение опыта, статьи в журнал).\r\n•\tВажно, чтобы после урока у конкурсанта осталось ощущение праздника творческого единения с детьми, соавторами, соисполнителями задуманного.\r\n•\tБезусловно, конкурсный урок своеобразен по содержанию, ориентированному на незнакомых детей.\r\n•\tЗалог его успешности в умении поставить цель, определить задачи и педагогически грамотно подобрать нужные для их решения средства.\r\n•\tУчителю-конкурсанту необходимы и такие качества, как способность импровизировать, умение слушать и слышать незнакомых детей, чутко реагировать в диалоге на их вопросы и ответы.\r\n•\tЗаметим, что не менее важны раскованность и сдержанность, спокойствие, умение ориентироваться в реальной, порой непред-сказуемой ситуации, управлять своим творческим самочувствием.\r\n\r\n    При всем различии предметов и образовательных областей для оценки каждого конкурсанта к ним предъявляются обязательные требования, которые ежегодно входят в критерии оценки:\r\n•\tГлубокое знание своего предмета.\r\n•\tНекорректное оперирование научными понятиями, небрежность, неточности, оговорки, речевая безграмотность недопустимы.\r\n•\tГрамотное, в соответствии с целями и задачами урока использование новых, современных, а иногда и традиционных, но работающих на результат, способов передачи знаний.\r\n•\tДопускается интерпретация описанных в педагогической литературе авторских методик (технологий), а еще лучше - предъявление собственной апробированной методики (технологии).\r\n•\tКоммуникативные способности, актерское и ораторское мастерство. К сожалению, педагогической техникой конкурсанты владеют явно недостаточно.\r\n•\tУмение достигать результата образовательной деятельности при любом уровне подготовленности класса. Ссылка на слабый уровень подготовки детей неуместна.\r\n    Очевидно, что каждый предмет имеет свое образовательно-информационное поле и требует использования специфических методов, приемов и форм организации учебного занятия.\r\nОшибки при самоанализе урока, мероприятия\r\n•\tРедко бывает объективным со стороны участника;\r\n•\tЦениться объективный анализ, когда педагог констатирует, что получилось не так, как планировал, в каком месте отошёл от запланированного, т.к. урок пошёл не «по сценарию». Это говорит о мобильности педагога, его умении выйти достойно из непредвиденной ситуации;\r\n•\tРедко педагог аргументирует отбор содержания урока (занятия) – не просто, что по программе, а почему взят именно этот материал;\r\n•\tОт педагога больше ждут импровизации, а не только домашней заготовки, от которой учитель не может отойти.\r\n";
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
                        //MainMenuCloseHelper(sender, e);
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
            TestBoxResult.Text = "Результат: ";
        }

        private void OpenPrevTest(object sender, EventArgs e)
        {
            CloseAll();
            Text = "Тест";
            OpenHelper(TeacherTestText);
            HelperNewLocation(-50, -50);
            OpenTestPanel.Visible = true;
            OpenTestPanel.Location = locationDefault;
            OpenTestPanel.Size = new Size(sizeDefault);
        }

        private void OpenTest(object sender, EventArgs e)
        {
            TestButtonOpenTestPanel2.Visible = false;
            CloseAll();
            Text = "Тест";
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
                Text = "Методические приемы по мотивации студентов";
            MethodicalPanel.Visible = true;
            MethodicalPanel.Location = locationDefault;
            MethodicalPanel.Size = new Size(sizeDefault);

            if (MethodicalSelect)
            {
                OpenHelper(MethodicalTextSelect, 80, 0, 88, -100);
                //LessonButton2.Text = "-_-";
                HelperNewLocation(-30, 150);
            }
            else
            {
                OpenHelper(MethodicalText, 80, 0, 88, -100);
                HelperNewLocation(-30, 150);
            }
            //Point HLT = new Point(HelperLabel.Location.X - 168, HelperLabel.Location.Y + 100);
            //HelperLabel.Location = HLT;
            //HelperButtonClose.Location = HLT;
        }

        private void OpenPresent(object sender, EventArgs e)
        {
            CloseAll();
            Text = "Рекомендации по созданию презентации";
            OtherPanelTextBox.Text = "ПРЕЗЕНТАЦИОННОЕ СОПРОВОЖДЕНИЕ УРОКА – НОВОЕ КАЧЕСТВО ЗАНЯТИЙ.\r\n    Мультимедийные презентации используются для того, чтобы выступающий смог на большом экране или мониторе наглядно продемонстрировать дополнительные материалы к своему сообщению.\r\n\r\n     Презентации - это способ подачи информации, в котором присутствуют рисунки, фотографии, анимация и звук. Кроме того, презентация имеет сюжет, сценарий и структуру, организованную для удобного восприятия информации.\r\n\r\n     Отличительной особенностью презентации является её интерактивность, то есть создаваемая для пользователя возможность взаимодействия через элементы управления. А в широком смысле этого слова, презентация — это комплексное представление всей полноты теоретического, фактического и визуального материала в виде логически сменяющей друг друга последовательности наглядного материала (слайдов).\r\n\r\n    Использование презентации на уроках способствует:\r\n•\tповышению темпа и производительности урока;\r\n•\tучету индивидуальных особенностей учащихся;\r\n•\tактивизации познавательной деятельности учащихся;\r\n•\tэстетическому оформлению урока, эмоциональному воздействию на учащихся.\r\nНЕКОТОРЫЕ ПРАВИЛА ОФОРМЛЕНИЯ ПРЕЗЕНТАЦИЙ\r\n    1. В ходе подготовки, внимательно следить и корректировать используемые цветовые схемы. Нельзя использовать слишком яркие цвета, — они способствуют быстрому утомлению и отрицательно сказываются на эмоциональном состоянии учащихся; одновременно с этим, не рекомендуется использовать и слишком тусклые цвета и оттенки, — они также плохо влияют на психологическое состояние учащихся, способствуют рассеиванию внимания и систематической отвлеченности учащегося от работы на уроке. Выбор цветовой гаммы должен проводиться в зависимости от аудитории. Достаточно использовать около 3 подходящих цветов. Главное, чтобы цветовое разнообразие не отвлекало от темы презентации.\r\n    2. Рекомендуется цветом или жирным шрифтом выделять ключевые фрагменты, на которых Вы останавливаетесь при обсуждении.\r\n    3. Слайды должны быть аккуратным. Неряшливо сделанные слайды (разнобой в шрифтах и отступах, опечатки и т.д.) не допускаются.\r\n    4. Необходима титульная страница, на которой указывается тема, автор, организация, дата.\r\n    5. Оптимальное число строк на слайде — от 6 до 11. Перегруженность и мелкий шрифт тяжелы для восприятия. Недогруженность оставляет впечатление, что вы что-то не дописали, не объяснили.\r\n    6. Размещайте на слайде только минимально необходимое количество текста. Избыток информации на слайде помешает сфокусироваться на главных аспектах вашей презентации.\r\n\r\nПАМЯТКА ДЛЯ СОСТАВЛЕНИЯ ПРЕЗЕНТАЦИИ\r\n    1. Анализ состава, цели, характера и состояния аудитории (для кого создается презентация).\r\n    2. Продумать место презентации в структуре урока, цель презентации.\r\n    Выбор, разработка вариантов использования презентации определяется в соответствии с типом урока и дидактическими целями урока.\r\n•\tРекомендации по созданию презентации может целиком соответствовать структуре урока.\r\n•\tРекомендации по созданию презентации может быть одним из элементов урока (например, использоваться при опросе, закреплении или объяснении материала).\r\n•\tВ форме презентации может быть представлен методический аппарат урока (схемы, таблицы, познавательные задания, вопросы, текстовый материал и т.д.)\r\n•\tВ форме презентации-игры может быть урок или один из элементов урока.\r\n\r\nС точки зрения организации можно выделить\r\n•\tнепрерывно выполняющиеся презентации (видеоряд к лекции)\r\n•\tинтерактивные презентации (презентация-игра, презентация-тест, таблицы и т.д.)\r\n•\tпрезентация со сценарием (презентации в соответствии с типом и целью урока)\r\n\r\n    3. Отбор материала для презентации.\r\n•\tДля визуального отражения необходимо отбирать наиболее важные, значимые факты,     процессы, явления изучаемой темы.\r\n•\tПродумать, как идея каждого слайда раскрывает основную идею, цель  всей презентации?\r\n•\tПродумать какими наглядными средствами (карты, схемы, графики, таблицы фото, иллюстрации, тексты и т.д.) будут наиболее эффективно отражены  основные идеи урока.\r\n•\tНеобходимо оптимально сочетать визуальный и фактический материал. Продумать: что будет на слайде? что будет говориться? как будет сделан переход к следующему слайду?\r\n\r\n    4. Размещение визуального и фактического материала на слайде.\r\n    Рекомендации по созданию презентации не должна быть перегружена спецэффектами и текстом. Наиболее важные слова, идеи, фрагменты можно выделять цветом или жирным шрифтом  на слайде, чтобы они сразу бросались в глаза.\r\n    5. Подбор текста к слайду.\r\n    Подготовка к речи: написание текста, плана (соответствующего слайдам презентации).  Распространённая ошибка — читать слайд дословно. Лучше всего, если на слайде будет написано определение, а словами будет рассказываться его содержательный смысл. Информация на слайде может быть более формальной и строго изложенной, чем в речи. Речь и слайды не должны совпадать, тогда презентация станет «объёмной». Речь должна быть более популярна и образна.\r\n    6. Рассчитать время презентации в рамках урока.\r\n    7. Важное правило: сочетание презентации с другими видами работы на уроке.\r\n    8. Рекомендации по созданию презентации включает в себя следующие элементы:\r\n•\tнаглядность   (иллюстрации, карты)\r\n•\tчеткая структура темы и урока в целом (план урока, логические схемы)\r\n•\tметодический аппарат (вопросы и задания в течение урока)\r\n•\tзакрепление пройденного (задания, в том числе и в тестовой форме)\r\n•\tигровые элементы (анимация)\r\n•\tработа с источниками\r\n•\tматериалы исторических сайтов (гиперссылки – документы , Интернет)\r\n";
            OtherTextPanel.Visible = true;
            OtherTextPanel.Location = locationDefault;
            OtherTextPanel.Size = new Size(sizeDefault);
            OtherPanelTextBox.SelectionStart = 0;
            OtherPanelTextBox.ScrollToCaret();
        }
        private void OpenDiagnosticMotivationStudent(object sender, EventArgs e)
        {
            CloseAll();
            Text = "Диагностика учебной мотивации студента";
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
            Text = "Как мотивировать студентов к обучению";
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

                TestButtonOpenTestPanel2.Visible = false;
            }
            else
            {
                TestButtonOpenTestPanel2.Visible = true;
                if (k >= 5)
                {
                    TestBoxResult.Text = "Результат: Средний показатель. Нажмите на клавишу Рекомендации, чтобы прочитать советы по улучшению Вашего рабочего благополучия.";
                }
                else
                {
                    TestBoxResult.Text = "Результат: Низкий показатель. Нажмите на клавишу Рекомендации, чтобы прочитать советы по улучшению Вашего рабочего благополучия.";
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
                Text = "Методический прием";
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
                Text = "Методический прием";
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
                Text = "Методический прием";
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
                Text = "Методический прием";
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
                Text = "Методический прием";
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
                Text = "Методический прием";
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
                Text = "Методический прием";
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
                Text = "Методический прием";
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
                Text = "Методический прием";
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

        private void OpenTestPanel2(object sender, EventArgs e)
        {
            Text = "Рекомендации по тесту";
            CloseAll();
            Test2TextBox.Text = TestRecomendation;
            TestPanel2.Visible = true;
            TestPanel2.Size = new Size(sizeDefault);
            TestPanel2.Location = locationDefault;
        }

        // -------------------- Проверь себя ------------------------
        List<Button> CheckYListButton = new List<Button>();
        List<RichTextBox> CheckYListText = new List<RichTextBox>();
        List<string> answertemp = new List<string>();
        List<string> answer = new List<string>();
        List<string> answerList = new List<string>();
        List<string> checkY3 = new List<string>();
        byte checkYNum = 0; // номер задания
        byte checkScore = 0; // Очки
        byte maxCheckedY = 0;
        const bool isItRandom = true;

        private void AddListCheckY()
        {
            CheckYListButton.Add(CheckYButton1);
            CheckYListButton.Add(CheckYButton2);
            CheckYListButton.Add(CheckYButton3);
            CheckYListButton.Add(CheckYButton4);
            CheckYListButton.Add(CheckYButton5);
            CheckYListButton.Add(CheckYButton6);
            CheckYListButton.Add(CheckYButton7);

            CheckYListText.Add(CheckYTextBox1);
            CheckYListText.Add(CheckYTextBox2);
            CheckYListText.Add(CheckYTextBox3);
            CheckYListText.Add(CheckYTextBox4);
            CheckYListText.Add(CheckYTextBox5);
            CheckYListText.Add(CheckYTextBox6);
            CheckYListText.Add(CheckYTextBox7);
        }
        private void OpenCheckYourself(object sender, EventArgs e)
        {
            Text = "Проверь себя";
            CloseAll();
            CheckYourselfPanel.Visible = true;
            CheckYourselfPanel.Location = locationDefault;
            checkYNum = 0;
            answertemp.Clear();
            answer.Clear();
            answerList.Clear();
            checkY3.Clear();
            AddListCheckY();
            OpenHelper(CheckYourselfText1, 0, 0, 120, -130);
            HelperNewLocation(-20, 60);
            CheckY1();
            //answerList.Clear();
        }

        private void EnableCheckYourself(byte x, Point location, Size size, int widthButtom)
        {
            for (byte i = 0; i < CheckYListText.Count && i < CheckYListButton.Count; i++)
            {
                CheckYListButton[i].Visible = false;
                CheckYListButton[i].Enabled = true;
                CheckYListButton[i].BackColor = defaultButtonColor;
                CheckYListText[i].Visible = false;
            }
            for (byte i = 0; i < x && i < CheckYListText.Count && i < CheckYListButton.Count; i++)
            {
                CheckYListButton[i].Visible = true;
                CheckYListText[i].Visible = true;
                CheckYListText[i].Location = new Point(location.X, location.Y + (size.Height + 2) * i);
                CheckYListText[i].Size = size;
                CheckYListButton[i].Location = new Point(location.X + 4 + size.Width, location.Y + (size.Height + 2) * i);
                CheckYListButton[i].Size = new Size(widthButtom, size.Height);
            }
        }

        private void TextCheckYourself(List<string> temps, List<string> texts, bool randoms)
        {
            List<string> answers = new List<string>(temps);
            byte a, b, c, d;
            a = (byte)texts.Count;
            b = (byte)answers.Count;
            c = (byte)CheckYListButton.Count;
            d = (byte)CheckYListText.Count;
            if (randoms)
            {
                // Создание генератора случайных чисел
                Random random = new Random();

                // Перемешивание элементов в списке
                int n = answers.Count;
                while (n > 1)
                {
                    n--;
                    int k = random.Next(n + 1);
                    string value = answers[k];
                    answers[k] = answers[n];
                    answers[n] = value;
                }
            }

            for (byte i = 0; i < a && i < b && i < c && i < d; i++)
            {
                CheckYListButton[i].Text = answers[i];
                CheckYListText[i].Text = texts[i];
            }
        }

        private void CheckedScoreCheckYourself()
        {
            byte a, b;
            checkScore = 0;
            a = (byte)answer.Count;
            b = (byte)answerList.Count;
            for (byte i = 0; i < a && i < b; i++)
            {
                if (answer[i] == answerList[i])
                {
                    checkScore++;
                }
            }
            //MessageBox.Show(a.ToString() + ", " + b.ToString()+", ", checkScore.ToString());

            //CheckYLabel1.Text += ", " + checkScore.ToString();
        }

        private void CheckY1()
        {
            CheckYNextButton.Text = "Продолжить";
            CheckYLabel1.Size = new Size(370, 65);
            CheckYLabel1.Text = "В зависимости от дидактической цели урока, соотнесите между собой более подходящую формму занятий.";

            checkYNum += 1;
            List<string> texts = new List<string>();
            List<string> answers = new List<string>();
            //1
            texts.Add("Урок усвоения новых знаний");
            answers.Add("Лекция");
            //2
            texts.Add("Урок комплексного применения знаний (урок закрепления изученного материала)");
            answers.Add("Урок-суд");
            //3
            texts.Add("Урок рефлексии по ФГОС (систематизации и обобщения полученных знаний)");
            answers.Add("Диспут");
            //4
            texts.Add("Урок развивающего контроля");
            answers.Add("Коллоквиум");
            //5
            texts.Add("Урок коррекции знаний (работа над ошибками)");
            answers.Add("Экзамен");

            // string xy = (answerList.Count == checkYNum - 1).ToString() + " = " + (answerList.Count).ToString() + " == " + checkYNum.ToString();
            if (checkYNum == 1)
                foreach (var i in answers)
                {
                    answerList.Add(i);
                }

            EnableCheckYourself((byte)texts.Count, new Point(14, 85), new Size(284, 60), 185);
            TextCheckYourself(answers, texts, isItRandom);
            checkYNum = 1;
        }
        private void CheckY21()
        {
            CheckYLabel1.Size = new Size(370, 65);
            CheckYLabel1.Text = "Соотнесите между собой методические приёмы и этапы урока.";
            checkYNum += 1;
            List<string> texts = new List<string>();
            List<string> answers = new List<string>();
            //1
            texts.Add("Преподаватель начинает урок с пословицы или поговорки, относящейся к теме урока.");
            answers.Add("Организационные момент");
            //2
            texts.Add("Преподаватель вместе с обучающимися обсуждает вопрос: насколько качественно выполнено домашнее задание.");
            answers.Add("Актуализация знаний в начале урока или в процессе его по мере необходимости");
            //3
            texts.Add("Преподаватель намеренно неполно раскрывает тему, предложив обучающимся задать дораскрывающие ее вопросы.");
            answers.Add("«Открытие» новых знаний первичное восприятие и усвоение нового теоретического учебного материала (правил, понятий, алгоритмов…)");

            if (checkYNum == 21)
                foreach (var i in answers)
                {
                    answerList.Add(i);
                }
            EnableCheckYourself((byte)texts.Count, new Point(14, 85), new Size(284, 141), 185);
            TextCheckYourself(answers, texts, isItRandom);
            checkYNum = 21;
        }
        private void CheckY22()
        {
            CheckYLabel1.Size = new Size(370, 65);
            CheckYLabel1.Text = "Соотнесите между собой методические приёмы и этапы урока.";
            checkYNum += 1;
            List<string> texts = new List<string>();
            List<string> answers = new List<string>();
            //1
            texts.Add("Студентам раздаются распечатанные интеллект – карты с отсутствующими связями, понятиями. Ребята восполняют интеллект-кату. Прием эффективен, если преподаватель при объяснении нового материала демонстрировал полностью заполненную интеллект-карту.");
            answers.Add("Применение теоретических положений в условиях выполнения упражнений и решения задач");
            //2
            texts.Add("Студенты восстанавливают текстовый фрагмент, намеренно «поврежденный» преподавателем.");
            answers.Add("Самостоятельное творческое использование сформированных умений и навыков");
            //3
            texts.Add("Обучающиеся подбирают (или придумывают) свои примеры, задачи, гипотезы, идеи, вопросы, связывающие последний изученный материал с любой ранее изученной темой, указанной преподавателем.");
            answers.Add("Обобщение усвоенного и включение его в систему ранее усвоенных зун и ууд");

            if (checkYNum == 22)
                foreach (var i in answers)
                {
                    answerList.Add(i);
                }

            EnableCheckYourself((byte)texts.Count, new Point(14, 85), new Size(284, 141), 185);
            TextCheckYourself(answers, texts, isItRandom);
            checkYNum = 22;
        }
        private void CheckY23()
        {
            CheckYLabel1.Size = new Size(370, 65);
            CheckYLabel1.Text = "Соотнесите между собой методические приёмы и этапы урока.";
            checkYNum += 1;
            List<string> texts = new List<string>();
            List<string> answers = new List<string>();
            //1
            texts.Add("Рассказ одного обучающегося прерывается в любом месте и продолжается другим обучающимся. Прием применим в случае, когда предполагается развернутый, логически связный ответ.");
            answers.Add("Контроль за процессом и результатом учебной деятельности обучающихся");
            //2
            texts.Add("Обучающиеся моделируют или представляют свое понимание, действия в виде рисунка или схемы.");
            answers.Add("Рефлексия деятельности");
            //3
            texts.Add("Предлагается тема урока и слова \"помощники\": Повторим; Изучим; Узнаем; Проверим. С помощью слов \"помощников\" учащиеся формулируют цели урока.");
            answers.Add("Постановка целей урока, мотивация учебной деятельности");

            if (checkYNum == 23)
                foreach (var i in answers)
                {
                    answerList.Add(i);
                }

            EnableCheckYourself((byte)texts.Count, new Point(14, 85), new Size(284, 117), 185);
            TextCheckYourself(answers, texts, isItRandom);
            checkYNum = 23;
        }

        private void CheckY3()
        {
            OpenHelper(CheckYourselfText2, 0, 0, 0, 0);
            HelperNewLocation(-20, 60);
            checkYNum = 3;
            CheckYLabel1.Size = new Size(370, 65 + 50);
            CheckYLabel1.Text = "Педагог дает студенту задание, а тот не хочет его выполнять и при \r\nэтом заявляет: «Я не хочу это делать!» -Какой должна быть реакция \r\nпедагога? ";
            List<string> texts = new List<string>();
            texts.Add("пусто");
            texts.Add("пусто");
            texts.Add("пусто");
            texts.Add("пусто");
            texts.Add("пусто");
            texts.Add("пусто");
            checkY3.Clear();
            checkY3.Add("«Не хочешь -заставим!»");
            checkY3.Add("«Для чего же ты тогда пришел учиться?»");
            checkY3.Add("«Тем хуже для тебя, оставайся неучем. Твое поведение похоже на \r\nповедение человека, который назло своему лицу хотел бы отрезать себе \r\nнос.»");
            checkY3.Add("«Ты отдаешь себе отчет в том, чем это может для тебя окончиться?»");
            checkY3.Add("«Не мог бы ты объяснить, почему?»");
            checkY3.Add("«Давай сядем и обсудим -может быть, ты и прав»");

            maxCheckedY = 2;

            EnableCheckYourself((byte)texts.Count, new Point(14, 85 + 44), new Size(0, 65), 185 + 284);
            TextCheckYourself(checkY3, texts, isItRandom);
        }
        private void CheckY4()
        {
            checkYNum = 4;
            CheckYLabel1.Size = new Size(370, 65 + 127);
            CheckYLabel1.Text = "Студент разочарован своими учебными успехами, сомневается в своих \r\nспособностях и в том, что ему когда-либо удастся как следует понять и \r\nусвоить материал, и говорит педагогу: «Как вы думаете, удастся ли мне \r\nкогда-нибудь учиться на отлично и не отставать от остальных ребят?» -\r\nЧто должен на это ему ответить учитель?";
            List<string> texts = new List<string>();
            texts.Add("пусто");
            texts.Add("пусто");
            texts.Add("пусто");
            texts.Add("пусто");
            texts.Add("пусто");
            texts.Add("пусто");
            checkY3.Clear();
            checkY3.Add("«Если честно сказать -сомневаюсь»");
            checkY3.Add("«О, да, конечно, в этом ты можешь не сомневаться»");
            checkY3.Add("«У тебя прекрасные способности, и я связываю с тобой большие \r\nнадежды»");
            checkY3.Add("«Почему ты сомневаешься в себе?»");
            checkY3.Add("«Давай поговорим и выясним проблемы»");
            checkY3.Add("«Многое зависит от того, как мы с тобой будем работать»");


            maxCheckedY = 2;

            EnableCheckYourself((byte)texts.Count, new Point(14, 85 + 125), new Size(0, 42), 185 + 284);
            TextCheckYourself(checkY3, texts, isItRandom);
        }
        private void CheckY5()
        {
            CheckYNextButton.Text = "Завершить";
            
            checkYNum = 5;
            CheckYLabel1.Size = new Size(390, 65 + 82);
            CheckYLabel1.Text = "Студент, выразив педагогу свои сомнения по поводу возможности хорошего усвоения преподаваемого им предмета, говорит: «Я сказал вам о том, что меня беспокоит. Теперь вы скажите, в чем причина этого и как мне быть дальше?» -Что должен на это ответить педагог? ";
            List<string> texts = new List<string>();
            texts.Add("пусто");
            texts.Add("пусто");
            texts.Add("пусто");
            texts.Add("пусто");
            texts.Add("пусто");
            texts.Add("пусто");
            checkY3.Clear();
            checkY3.Add("«У тебя, как мне кажется, комплекс неполноценности».");
            checkY3.Add("«У тебя нет никаких оснований для беспокойства»");
            checkY3.Add("«Прежде, чем я смогу высказать обоснованное мнение, мне необходимо лучше разобраться в сути проблемы»");
            checkY3.Add("«Я не готов (а) сейчас дать тебе точный ответ, мне надо подумать»");
            checkY3.Add("«Давай подождем, поработаем и вернемся к обсуждению этой проблемы через некоторое время. Я думаю, что нам удастся ее решить»");
            checkY3.Add("«Не волнуйся, и у меня в свое время ничего не получалось»");

            maxCheckedY = 2;

            EnableCheckYourself((byte)texts.Count, new Point(14, 85+64), new Size(0, 65), 185 + 284);
            TextCheckYourself(checkY3, texts, isItRandom);
        }

        private void CheckYButtonX_Click(object sender, EventArgs e)
        {
            if (checkYNum >= 3 && checkYNum <= 5)
            {
                byte temp = 0;
                foreach (var i in CheckYListButton)
                {
                    if (!i.Visible) break;
                    if (!i.Enabled)
                    {
                        temp += 1;
                    }
                }
                if (temp == 2) return;
            }
            string buttonText = ((Button)sender).Text;
            if (!answertemp.Contains(buttonText))
            {
                answertemp.Add(buttonText);
                ((Button)sender).Enabled = false;
                ((Button)sender).BackColor = selectButtonColor;
            }

        }
        bool informationCheckY = false;
        private void CheckYNextButton_Click(object sender, EventArgs e)
        {
            HelperClose(sender, e);
            if (!(checkYNum >= 3 & checkYNum <= 5)) // 1,21,22,23
            {
                //MessageBox.Show("1Next");

                bool temp = true;
                foreach (var i in CheckYListButton)
                {
                    if (!i.Visible) break;
                    if (i.Enabled)
                    {
                        temp = false;
                        break;
                    }
                }
                if (!temp) return;
                foreach (var i in answertemp)
                {
                    answer.Add(i);
                }
                answertemp.Clear();
                if (informationCheckY)
                {
                    CheckedScoreCheckYourself();
                }
            }
            else // 3, 4, 5
            {
                //MessageBox.Show("2Next");

                byte temp = 0;
                foreach (var i in CheckYListButton)
                {
                    if (!i.Visible) break;
                    if (!i.Enabled)
                    {
                        temp += 1;
                    }
                }
                if (temp != 2) return;
                temp = 4;
                //MessageBox.Show("3Next");

                for (byte i = 0; i < checkY3.Count; i++)
                {
                    foreach (var j in answertemp)
                    {
                        if (checkY3[i] == j)
                        {
                            temp += (byte)(i / 2);
                        }
                    }
                }
                foreach (var i in answertemp)
                    answer.Add(i);
                checkScore += (byte)(temp / 2);
            }
            //MessageBox.Show(checkYNum.ToString());

            if (informationCheckY)
            {
                MessageBox.Show("Вы набрали: " + checkScore.ToString() + ",\nответов: " + answerList.Count.ToString() + ", выборов: " + answer.Count.ToString());
            }
            switch (checkYNum)
            {
                case 1:
                    checkYNum = 20;
                    CheckY21();
                    break;
                case 21:
                    CheckY22();
                    break;
                case 22:
                    CheckY23();
                    break;
                case 23:
                    CheckedScoreCheckYourself();
                    checkYNum = 2;
                    CheckY3();
                    break;
                case 3:
                    CheckY4();
                    break;
                case 4:
                    CheckY5();
                    break;
                case 5:
                    string inform = "";
                    if (checkScore <= 14)
                        inform = "плохо";
                    else if (checkScore <= 20)
                        inform = "хорошо";
                    else
                        inform = "отчлично";
                    MessageBox.Show("Вы набрали: " + checkScore.ToString() + " - " + inform);
                    OpenMenu(sender, e);
                    break;
            }
        }

        private void CheckYButtonReset_Click(object sender, EventArgs e)
        {
            //CheckedScoreCheckYourself();
            if (informationCheckY) MessageBox.Show("Вы набрали: " + checkScore.ToString());
            //MessageBox.Show("Reset");
            answertemp.Clear();
            switch (checkYNum)
            {
                case 1:
                    CheckY1();
                    break;
                case 21:
                    CheckY21();
                    break;
                case 22:
                    CheckY22();
                    break;
                case 23:
                    CheckY23();
                    break;
                case 3:
                    CheckY3();
                    break;
                case 4:
                    CheckY4();
                    break;
                case 5:
                    CheckY5();
                    break;
            }
        }
    }
}