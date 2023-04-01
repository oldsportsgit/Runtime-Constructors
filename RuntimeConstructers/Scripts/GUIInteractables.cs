using UnityEngine.UI;
using UnityEngine;
using System;

namespace RuntimeConstructers
{
    /// <summary>
    /// Class for creating basic UI Objects.
    /// </summary>
    public class GUIInteractables
    {
        protected static Sprite UISprite()
        {
            Texture2D tex = new Texture2D(2, 2);
            string UISprite = "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAACXBIWXMAAA7EAAAOxAGVKw4bAAACq0lEQVR4nO1XPYgaURAe3fW3iYVdtAiciEIgaGcjBAKmCoIggt1B4MAf8CcgpDwIBKKIgiBcJ4ooaIrAQSCQUkQJHATELtjYB/9/MrPxLc/DwGmUa/xgGN3Zne97896+fSPa7XbgodVqQalUSr9Xq5Xk1+s1KBQK2Af8M3y+yWSydZ+o0WhgOp0C8/TgcrkEQRDgmKCcDDRIEkJeJCK9Xg+j0UgKcsRWtLdobrQXFNqXE+0H2ne0IubtsQCREydBJGV8BTZKY2jXsVhM53Q6wWq1ymV8KLDcQq/Xc3Y6HWc6nb7CS+/R0hQjLhoweZFICRuvxnn77PP5PMFgEMxmMxwKEmyz2SRzu926Uqn0qV6vv8LQG+SaMU5pDXD4GAgEPIlEAo4JGkgqlQKVSuWpVCof8FKcxUSutM+xbKFoNCr9oRW7WCwkz96GfUG5yURRlHw4HIZyuRzFhX6D4Z+SAC75ZTKZFFClRDybzeB/wcRTPrVaLc05rishk8lcwqYKIne/x+Vy8QvxqKABUV7iQAEeWQC3wTwzGo0nIWeg3AaDgfaap+waXwH1vrvdIaDNB3me7BLwKDgLOAs4CzgLOAvgBczm87maPsenxHg8Jvd7l4Bfw+HwwmQynVQAckhcuwTctlqt0KkFtNtt+hx/lQVwn+AiHhSuvF6vsO8J+KHAKYZsNrvE/DeyAGpENrhDMYV8Ph+KRCInEVAoFMjl8Zh2Jwu41yrFa7XaBSr1+P1+ONZ0DAYDqFar0Gw2b/HI946P3W/NZliR141GI4Z2jadYncPhAIvFchBxv9+HbrcLuVyOlv5WY8I4/9Wa0Y1fcDqoNXsJf1uzQ0Ct2TfMWUQvt2ZELrdmrGNlDSM7lG56uTgcCfxhd6s1Y2uAeXorTvEWUGVZD8K3g38A8BxHBF/VD5oAAAAASUVORK5CYII=";
            tex.LoadImage(Convert.FromBase64String(UISprite));
            return Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(16f, 16f), 200.0f, 0, SpriteMeshType.Tight, new Vector4(10, 10, 10, 10));
        }

        protected static Sprite GetUISprite
        {
            get
            {
                if (uisp == null)
                {
                    uisp = UISprite();
                }
                return uisp;
            }
        }

        private static Sprite uisp;

        protected static Sprite Background()
        {
            Texture2D Backgroundtex = new Texture2D(2, 2);
            string BackgroundSprite = "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAACXBIWXMAAA7EAAAOxAGVKw4bAAACd0lEQVR4nO1Xv4saURAe3UU9m2AhFilEOIgIkeD9AYGoqFVKEVSEg8CBEDghVcpAIJBUgYBwIKJYpwgqSiD/QfBETGk6C7tgVPyRbzb7lndiQD2XNPvBMLqz++Z7897bnU8NhUIkw+Vykd1u136v12vNbzYbstlsdAjkZ+TxZrPZnftUp9NJ8/mchOcHV6sVKYpCpwSPKcCTZCLsVU7kdrtpOp1qQSnxI9gL2FPYEw4dmhP2HfYNVsa4P0SAk3NOhsrM5AroTK9hb7LZ7FkwGCS/32+UcV+g3MpoNLoYDocXtVrtCpdewz5wjHPxhNmrnJShewfW7XMsFkumUiny+Xx0LJhwIBDQLBKJnDWbzffdbjeO0HPkWoic2h6Q8C6RSCRzuRydEjyRQqHAy5tst9tvcakkYqpU2scoWzGTyZBZSKfT1Gq1XmKj3+DvQCMgjhpwmc/nFVVVTSPgcDgI+0qp1+uXpFdBzpYMh8NkNjgHCCQNAtILJuD1ek0n4PF4+F3zUPyXK+Aws/wCfP4x6Qe7CPwXWAQsAhYBi4BFQCawWC6Xpn8P9K741y4CPyeTyfl92rB9gBxarl0EWr1erxiPx00l0O/3+XPcMQhI/UC5UqlcRaNR5dAOeF9gialara4w/o1BgIWIjluQ+YRupXjqplSg0Wiw+4g28NYgsCWVSuhaz6EN7t2WyxiPx4S2nNCWt9CKv5Jj29JsgYqkOp3ONUwTJqwdWZgcAwgTGgwGBGHym7aEicj5L2nGN37BcrA0e0Z/pdkxYGn2FWOW4Q1pxskNaSYUqxCMQkTqWq5EJ4IsTu9IM7EHhOdTYcYp4MoKDSLLwT/3fBrTaDIx7wAAAABJRU5ErkJggg==";
            Backgroundtex.LoadImage(Convert.FromBase64String(BackgroundSprite));
            return Sprite.Create(Backgroundtex, new Rect(0.0f, 0.0f, Backgroundtex.width, Backgroundtex.height), new Vector2(16f, 16f), 200.0f, 0, SpriteMeshType.Tight, new Vector4(10, 10, 10, 10));
        }

        protected static Sprite GetBackground
        {
            get
            {
                if (background == null)
                {
                    background = Background();
                }
                return background;
            }
        }

        private static Sprite background;

        protected static Sprite Checkmark()
        {
            Texture2D Checkmark_image = new Texture2D(2, 2);
            string checkmarksp = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAABhWlDQ1BJQ0MgcHJvZmlsZQAAKJF9kT1Iw0AcxV9TpaKVInYQUchQnSz4hThKFYtgobQVWnUwufQLmjQkKS6OgmvBwY/FqoOLs64OroIg+AHi6OSk6CIl/i8ptIj14Lgf7+497t4BQq3EVLNjHFA1y0hEI2I6syr6XtGDAPowjAmJmXosuZhC2/F1Dw9f78I8q/25P0evkjUZ4BGJ55huWMQbxDObls55nzjICpJCfE48ZtAFiR+5Lrv8xjnvsMAzg0YqMU8cJBbzLSy3MCsYKvE0cUhRNcoX0i4rnLc4q6UKa9yTv9Cf1VaSXKc5hCiWEEMcImRUUEQJFsK0aqSYSNB+pI1/0PHHySWTqwhGjgWUoUJy/OB/8LtbMzc16Sb5I0Dni21/jAC+XaBete3vY9uunwDeZ+BKa/rLNWD2k/RqUwsdAYFt4OK6qcl7wOUOMPCkS4bkSF6aQi4HvJ/RN2WA/luge83trbGP0wcgRV0t3wAHh8BonrLX27y7q7W3f880+vsBvYNyxdTubWUAAAAGYktHRAAAAAAAAPlDu38AAAAJcEhZcwAALiMAAC4jAXilP3YAAAAHdElNRQfmCw8RHwdtoCECAAAAGXRFWHRDb21tZW50AENyZWF0ZWQgd2l0aCBHSU1QV4EOFwAAAaNJREFUWMPtlzFrwkAUx8+0KBShU0ALpYtroTyH0HQMVNwytOCQDimdHPMFDDgFBJdaLn6GFl2Li4t7QhcpblIMCQhFihhJr1NKCFIj1pjhfttBwvvxcv93F4QoFAqFQqH8N51O50HX9Voi5UzTvOQ4bgEAJIrkYZxyjuPkJUl6Xi6XaYQQmkwmZ4npnOu6aVmWBwBAAIBUKhVjPp8frXvvIC7BTCbz1O/3RYQQymazn61W65plWSsxofA7VywWv3u93k0iQwEApNFoNHdSSNf12qajwXGcfKlU+vDlZFkeuK6b3omcXySqZDgUgiDYlmWdblqbifIQISQVkFWjSGqa9miaJo8QQgzDePV6/S6Xy413tpcwxqrfjXWdDIYCAAjGWI1lw0eRDIeiWq2+ep4X2zj7U9K27ZNgKMrl8ng6nbKxj45VkuFQcBy3MAzjattaqW0k2+32b/cKhcLbaDQ699eKoiiSJDX3JrhK0kcQhBdN024ZhiF7PynCn1sUxffZbHacqDueL8nz/NdwOLxI5EUUY6x2u917+r9AoVAolGTxA15E9m3FZltgAAAAAElFTkSuQmCC";
            Checkmark_image.LoadImage(Convert.FromBase64String(checkmarksp));
            return Sprite.Create(Checkmark_image, new Rect(0.0f, 0.0f, Checkmark_image.width, Checkmark_image.height), new Vector2(20f, 20f), 200.0f, 0, SpriteMeshType.Tight, new Vector4(0, 0, 0, 0));
        }

        protected static Sprite GetCheckmark
        {
            get
            {
                if (checkmark == null)
                {
                    checkmark = Checkmark();
                }
                return checkmark;
            }
        }

        private static Sprite checkmark;

        protected static Sprite Knob()
        {
             string knobsp = "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";
             Texture2D Knob_Sprite = new Texture2D(2, 2);
             Knob_Sprite.LoadImage(Convert.FromBase64String(knobsp));
             return Sprite.Create(Knob_Sprite, new Rect(0.0f, 0.0f, Knob_Sprite.width, Knob_Sprite.height), new Vector2(20f, 20f), 200.0f, 0, SpriteMeshType.Tight, new Vector4(0, 0, 0, 0));
        }

        protected static Sprite GetKnob
        {
            get
            {
                if (knob == null)
                {
                    knob = Knob();
                }
                return knob;
            }
        }

        private static Sprite knob;

        protected static Sprite UIMask()
        {
            Texture2D UImasktex = new Texture2D(2, 2);
            string UImaskSprite = "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAACXBIWXMAAA7EAAAOxAGVKw4bAAAArUlEQVR4nO2W2QqAIBBFpQ36/2+NHiLNgYkKs0YdUWouXHpyPNJ2OmOMKplOFY4AvAH02DZy/mq7YIMAGtsRrylpsYPtbKupABybn7MfaKIA9MybnyFg9uV2+AByhQQQ+8BR4syu/jUUAAEQAAEQgM8BOAp+BwAaleuPSDKiJSOA44Y+AHA4bivSVAAICCSnF2qc6cQHAAtAIFO03Kjj1MFavudxMUd+9x2oD2AD0CEefVmsbD0AAAAASUVORK5CYII=";
            UImasktex.LoadImage(Convert.FromBase64String(UImaskSprite));
            return Sprite.Create(UImasktex, new Rect(0.0f, 0.0f, UImasktex.width, UImasktex.height), new Vector2(16f, 16f), 200.0f, 0, SpriteMeshType.Tight, new Vector4(10, 10, 10, 10));
        }

        protected static Sprite GetUIMask
        {
            get
            {
                if (uIMask == null)
                {
                    uIMask = UIMask();
                }
                return uIMask;
            }
        }

        private static Sprite uIMask;

        protected static Sprite DropdownArrow()
        {
            Texture2D DropdownArrowtex = new Texture2D(2, 2);
            string DropdownArrow = "iVBORw0KGgoAAAANSUhEUgAAACgAAAAoCAYAAACM/rhtAAABhGlDQ1BJQ0MgcHJvZmlsZQAAKJF9kT1Iw0AcxV9TpSoVBTuIOGSoThakijhKFYtgobQVWnUwufQLmjQkKS6OgmvBwY/FqoOLs64OroIg+AHi6OSk6CIl/i8ptIjx4Lgf7+497t4BQqPCVLNrElA1y0jFY2I2tyoGXhHAIHrhR1Ripp5IL2bgOb7u4ePrXYRneZ/7c/QreZMBPpF4jumGRbxBPLNp6Zz3iUOsJCnE58QTBl2Q+JHrsstvnIsOCzwzZGRS88QhYrHYwXIHs5KhEk8ThxVVo3wh67LCeYuzWqmx1j35C4N5bSXNdZqjiGMJCSQhQkYNZVRgIUKrRoqJFO3HPPwjjj9JLplcZTByLKAKFZLjB/+D392ahamomxSMAd0vtv0xBgR2gWbdtr+Pbbt5AvifgSut7a82gNlP0uttLXwEDGwDF9dtTd4DLneA4SddMiRH8tMUCgXg/Yy+KQcM3QJ9a25vrX2cPgAZ6mr5Bjg4BMaLlL3u8e6ezt7+PdPq7wdjgXKhFu6GPwAAAAZiS0dEAAAAAAAA+UO7fwAAAAlwSFlzAAAOwwAADsMBx2+oZAAAAAd0SU1FB+YHEAkEJyBHklAAAACcSURBVFjD7dNLDsMgDEXRpEt6iwJ2EXcXNpt1J6ViEKmQT0HVO8MowJVDloWIiIiIZmFmm5lto9Z/3RyAA/Ajhxxd/2h90d3X6jDpOeQ9Odnb61KqKmUKrZOoJwfAVVVuvYc9kT+P64kcFtcSeWXcejYy5/wJizFK+YnKsxDCM6U0JnAvsnY27rbPPeTO9UROF1dHThtHRERE/+kFyfmdhdXwERIAAAAASUVORK5CYII=";
            DropdownArrowtex.LoadImage(Convert.FromBase64String(DropdownArrow));
            return Sprite.Create(DropdownArrowtex, new Rect(0.0f, 0.0f, DropdownArrowtex.width, DropdownArrowtex.height), new Vector2(20f, 20f), 200.0f, 0, SpriteMeshType.Tight, new Vector4(0, 0, 0, 0));
        }

        protected static Sprite GetDropdownArrow
        {
            get
            {
                if (dropdownArrow == null)
                {
                    dropdownArrow = DropdownArrow();
                }
                return dropdownArrow;
            }
        }

        private static Sprite dropdownArrow;

        protected static Sprite InputFieldBackground()
        {
            Texture2D tex = new Texture2D(2, 2);
            string InputFieldBackground = "iVBORw0KGgoAAAANSUhEUgAAACAAAAAgCAYAAABzenr0AAAACXBIWXMAAA7EAAAOxAGVKw4bAAAC30lEQVR4nO1XTWhaQRAe856aqCBeI0EqAUEoFCSHnIqFBj316sE/CBYCQsGEnnoMFEpqQAqFQE4JJBAvPRSTFBp6E70UAgWP1oveiyYaY+fbuLKKLWh8tId8MKw4u/N9OzvvvR3d7/eTivn5eZqbmxO/b29vxdjr9chkMtEkUNeo8a6urobm6Varla6vr0mOWNjtdknTNJolEFMCm4QQjDqIbDYbNZtN4VSIfWwv2Z6yPYFrUk6272zf2PY4bkU6QA5OQIcyNQN9pRm27UgksuDz+cjj8UycEY6jVavVQKVSCRwfH2/wX2/YsvCBCxvGqIMU6I8WPrdPwWAwFA6Hye12C2Kc4TQ1gPrCBgKBwEKhUHh/cXHxnF0vmKstOUUNKHi3trYWSiaTQp3FYiFd1wciJgEKDtm8ubkRZ51KpchsNofOz8/fsntTztOVwI95UTqRSJDD4RCLIOI+GZAisFMmp1gsRmdnZ6/Yt89TfggB8lFjrPPONafTKQoEAlTyaQRIESBHJhErHo9rBwcH6zILurImtLq6Sna7/e7x6C+YFlI0YqibAAcLCA0EKDt7hGoXlXlP8lEgFmIi9uLiIjLjlj41AxakftbkoyJcLhcy4RwnwDByVcTo+2RIwKSFNq2IvwowUsS4+Dr9YzwIeBDwIOC/EtDudDoWXEKMRKvVwvBrnICfjUZj2ev1GiqgXq8LrnECTovFYtpoAaVSCZ/jLwMByrt5b2dnZ4NvwppRX8R2u027u7tdjr8/EIBrUx+XLOZjNptNb21tGSIgl8th+MDXtMuBgJFWafPo6GiZizEUjUZpaWlpJsS1Wo0ODw8pn8+f8gX1teobbc3anJHwyclJhm07k8ksrKysiLv9NOCmhMrlMnFWUfpDjYnk/FNrhomf+bzQmj2ju9ZsGqA1+8ox96BH/gnyQWsmO1bZMMomst/LbdKMoDanQ62ZrAE5yqv0rIHMyh5EbQd/A+JMPJandV0rAAAAAElFTkSuQmCC";
            tex.LoadImage(Convert.FromBase64String(InputFieldBackground));
            return Sprite.Create(tex, new Rect(0.0f, 0.0f, tex.width, tex.height), new Vector2(16f, 16f), 200.0f, 0, SpriteMeshType.Tight, new Vector4(10, 10, 10, 10));
        }

        protected static Sprite GetInputFieldBackground
        {
            get
            {
                if (inputFieldBackground == null)
                {
                    inputFieldBackground = InputFieldBackground();
                }
                return inputFieldBackground;
            }
        }

        private static Sprite inputFieldBackground;

        protected static void AddLayerForEach(GameObject Base)
        {
            Transform[] transforms = Base.GetComponentsInChildren<Transform>(true);
            for (int i = 0; i < transforms.Length; i++)
            {
                transforms[i].gameObject.layer = 5;
            }
        }

        protected static Font ArialFont
        {
            get
            {
                if (_arialFont == null)
                {
                    _arialFont = Resources.GetBuiltinResource<Font>("Arial.ttf");
                }
                return _arialFont;
            }
        }

        protected static Font _arialFont;

        /// <summary>
        /// Make a single press button.
        /// </summary>
        public static Button LegacyButton(string Name, GameObject Canvas, Vector2 Position, string text)
        {
            Button button = new GameObject(Name, typeof(Image), typeof(Button)).GetComponent<Button>();
            GameObject GUI_text = new GameObject("Text (Legacy)", typeof(Text));
            button.transform.SetParent(Canvas.transform);
            button.GetComponent<RectTransform>().sizeDelta = new Vector2(160, 30);
            button.GetComponent<Image>().sprite = GetUISprite;
            button.GetComponent<Image>().type = Image.Type.Sliced;
            GUI_text.transform.SetParent(button.transform);
            Text textt = GUI_text.GetComponent<Text>();
            textt.font = ArialFont;
            textt.text = text;
            textt.alignment = TextAnchor.MiddleCenter;
            textt.color = new Vector4(0.20f, 0.20f, 0.20f, 1);
            RectTransform rect = GUI_text.GetComponent<RectTransform>();
            rect.anchorMin = new Vector2(0, 0);
            rect.anchorMax = new Vector2(1, 1);
            rect.offsetMax = new Vector2(0, 0);
            rect.offsetMin = new Vector2(0, 0);
            button.GetComponent<RectTransform>().anchoredPosition = Position;
            AddLayerForEach(button.gameObject);
            return button;
        }

        /// <summary>
        /// Creates a Canvas.
        /// </summary>
        public static Canvas Canvas(string name)
        {
            Canvas Canvas = new GameObject(name, typeof(Canvas), typeof(CanvasScaler), typeof(GraphicRaycaster)).GetComponent<Canvas>();
            Canvas.renderMode = RenderMode.ScreenSpaceOverlay;
            Canvas.gameObject.layer = 5;
            return Canvas;
        }

        /// <summary>
        /// Make a Legacy UI text.
        /// </summary>
        public static Text LegacyText(string name, GameObject Canvas, Vector2 position, string text)
        {
            Text TMPtext = new GameObject(name, typeof(Text)).GetComponent<Text>();
            TMPtext.GetComponent<RectTransform>().sizeDelta = new Vector2(160, 30);
            TMPtext.transform.SetParent(Canvas.transform);
            Text textt = TMPtext.GetComponent<Text>();
            textt.text = text;
            textt.font = ArialFont;
            textt.color = new Vector4(0.20f, 0.20f, 0.20f, 1);
            TMPtext.gameObject.layer = 5;
            TMPtext.GetComponent<RectTransform>().anchoredPosition = position;
            return TMPtext;
        }

        /// <summary>
        /// Creates a panel.
        /// </summary>
        public static Image Panel(string name, GameObject Canvas, Vector2 Position)
        {
            Image Panel = new GameObject(name, typeof(Image)).GetComponent<Image>();
            Panel.transform.SetParent(Canvas.transform);
            Image PanelImg = Panel.GetComponent<Image>();
            PanelImg.sprite = GetBackground;
            PanelImg.type = Image.Type.Sliced;
            PanelImg.color = new Vector4(1, 1, 1, 0.39f);
            RectTransform PanelRect = Panel.GetComponent<RectTransform>();
            PanelRect.anchorMax = new Vector2(1, 1);
            PanelRect.anchorMin = new Vector2(0, 0);
            PanelRect.sizeDelta = new Vector2(0, 0);
            PanelRect.offsetMax = new Vector2(0, 0);
            PanelRect.offsetMin = new Vector2(0, 0);
            PanelRect.anchoredPosition = Position;
            Panel.gameObject.layer = 5;
            return Panel;
        }

        /// <summary>
        /// Creates a slider.
        /// </summary>
        public static Slider Slider(string name, GameObject Canvas, Vector2 position)
        {
            Slider Slider = new GameObject(name, typeof(Slider)).GetComponent<Slider>();
            GameObject Background = new GameObject("Background", typeof(Image));
            GameObject Fill_Area = new GameObject("Fill Area", typeof(RectTransform));
            GameObject Fill = new GameObject("Fill", typeof(Image));
            GameObject Handle_Slide_Area = new GameObject("Handle Slide Area", typeof(RectTransform));
            GameObject Handle = new GameObject("Handle", typeof(Image));
            Slider.transform.SetParent(Canvas.transform);
            Slider.GetComponent<RectTransform>().sizeDelta = new Vector2(160, 20);
            RectTransform BackgroundRect = Background.GetComponent<RectTransform>();
            Background.transform.SetParent(Slider.transform);
            Background.GetComponent<Image>().sprite = GetBackground;
            Background.GetComponent<Image>().type = Image.Type.Sliced;
            BackgroundRect.anchorMin = new Vector2(0f, 0.25f);
            BackgroundRect.anchorMax = new Vector2(1f, 0.75f);
            BackgroundRect.sizeDelta = new Vector2(0, 0);
            Fill_Area.transform.SetParent(Slider.transform);
            RectTransform Fill_AreaRect = Fill_Area.GetComponent<RectTransform>();
            Fill_AreaRect.anchorMin = new Vector2(0f, 0.25f);
            Fill_AreaRect.anchorMax = new Vector2(1f, 0.75f);
            Fill_AreaRect.sizeDelta = new Vector2(-20f, 0);
            Fill_AreaRect.position = new Vector3(-5, 0, 0);
            RectTransform FillRect = Fill.GetComponent<RectTransform>();
            Fill.GetComponent<Image>().type = Image.Type.Sliced;
            Fill.GetComponent<Image>().sprite = GetUISprite;
            Slider.GetComponent<Slider>().fillRect = Fill.GetComponent<RectTransform>();
            Fill.transform.SetParent(Fill_Area.transform);
            FillRect.position = new Vector3(-5, 0, 0);
            FillRect.sizeDelta = new Vector2(10, 0);
            Handle_Slide_Area.transform.SetParent(Slider.transform);
            RectTransform Handle_Slide_AreaRect = Handle_Slide_Area.GetComponent<RectTransform>();
            Handle_Slide_AreaRect.anchorMin = new Vector2(0f, 0f);
            Handle_Slide_AreaRect.anchorMax = new Vector2(1f, 1f);
            Handle_Slide_AreaRect.sizeDelta = new Vector2(-20, 0);
            Handle_Slide_AreaRect.position = new Vector3(0, 0, 0);
            RectTransform HandleRect = Handle.GetComponent<RectTransform>();
            Handle.transform.SetParent(Handle_Slide_Area.transform);
            Handle.GetComponent<Image>().sprite = GetKnob;
            HandleRect.localPosition = new Vector3(0, 0, 0);
            HandleRect.sizeDelta = new Vector2(20, 0);
            Slider.GetComponent<Slider>().handleRect = HandleRect;
            Slider.GetComponent<Slider>().targetGraphic = Handle.GetComponent<Image>();
            Slider.GetComponent<RectTransform>().anchoredPosition = position;
            AddLayerForEach(Slider.gameObject);
            return Slider;
        }



        /// <summary>
        /// Creates a Toggler.
        /// </summary>
        public static Toggle Toggler(string name, GameObject Canvas, Vector2 position,string Text)
        {
            Toggle Toggle = new GameObject(name, typeof(Toggle)).GetComponent<Toggle>();
            GameObject Background = new GameObject("Background", typeof(Image));
            GameObject Checkmark = new GameObject("Checkmark", typeof(Image));
            GameObject Label = new GameObject("Label", typeof(Text));
            Toggle.transform.SetParent(Canvas.transform);
            Background.transform.SetParent(Toggle.transform);
            Checkmark.transform.SetParent(Background.transform);
            Label.transform.SetParent(Toggle.transform);
            Toggle.GetComponent<Toggle>().isOn = true;
            Toggle.GetComponent<Toggle>().targetGraphic = Background.GetComponent<Image>();
            Toggle.GetComponent<RectTransform>().sizeDelta = new Vector2(160, 20);
            RectTransform BackgroundRect = Background.GetComponent<RectTransform>();
            BackgroundRect.anchoredPosition = new Vector3(10,-10);
            BackgroundRect.sizeDelta = new Vector2(20, 20);
            BackgroundRect.anchorMin = new Vector2(0, 1);
            BackgroundRect.anchorMax = new Vector2(0, 1);
            Background.GetComponent<Image>().type = Image.Type.Sliced;
            Background.GetComponent<Image>().sprite = GetUISprite;
            Text LabelText = Label.GetComponent<Text>();
            LabelText.GetComponent<Text>().text = Text;
            LabelText.GetComponent<Text>().font = ArialFont; 
            LabelText.GetComponent<Text>().color = new Vector4(0.20f, 0.20f, 0.20f, 1);
            RectTransform LabelRect = Label.GetComponent<RectTransform>();
            LabelRect.anchorMin = new Vector2(0, 0);
            LabelRect.anchorMax = new Vector2(1, 1);
            LabelRect.anchoredPosition = new Vector2(9, -0.50f);
            LabelRect.sizeDelta = new Vector2(-28, -3);
            Checkmark.GetComponent<Image>().sprite = GetCheckmark;
            RectTransform CheckmarkRect = Checkmark.GetComponent<RectTransform>();
            CheckmarkRect.offsetMin = new Vector2(-20, -20);
            CheckmarkRect.offsetMax = new Vector2(0, 0);
            CheckmarkRect.anchoredPosition = Vector3.zero;
            Toggle.GetComponent<RectTransform>().anchoredPosition = position;
            Toggle.GetComponent<Toggle>().graphic = Checkmark.GetComponent<Image>();
            AddLayerForEach(Toggle.gameObject);
            return Toggle;
        }

        /// <summary>
        /// Creates a ScrollView.
        /// </summary>
        public static ScrollRect ScrollView(string name, GameObject canvas, Vector2 position)
        {
            ScrollRect scrollView = new GameObject(name, typeof(Image), typeof(ScrollRect)).GetComponent<ScrollRect>();
            GameObject Viewport = new GameObject("Viewport", typeof(Image), typeof(Mask));
            GameObject Content = new GameObject("Content", typeof(RectTransform));
            GameObject ScrollbarH = new GameObject("Scrollbar Horizontal", typeof(Image), typeof(Scrollbar));
            GameObject slidingAreaH = new GameObject("Sliding Area", typeof(RectTransform));
            GameObject handleH = new GameObject("Handle", typeof(Image));
            GameObject ScrollbarV = new GameObject("Scrollbar Vertical", typeof(Image), typeof(Scrollbar));
            GameObject slidingAreaV = new GameObject("Sliding Area", typeof(RectTransform));
            GameObject handleV = new GameObject("Handle", typeof(Image));
            scrollView.transform.SetParent(canvas.transform);
            Image scrollViewImg = scrollView.GetComponent<Image>();
            scrollViewImg.type = Image.Type.Sliced;
            scrollViewImg.color = new Color(1f, 1f, 1f, 0.4f);
            scrollView.GetComponent<RectTransform>().sizeDelta = new Vector2(200, 200);
            scrollViewImg.sprite = GetBackground;
            Viewport.GetComponent<RectTransform>().pivot = new Vector2(0, 1);
            Viewport.transform.SetParent(scrollView.transform);
            Viewport.GetComponent<Image>().sprite = GetUIMask;
            Viewport.GetComponent<Image>().type = Image.Type.Sliced;
            Viewport.GetComponent<Mask>().showMaskGraphic = false;
            RectTransform ContentRect = Content.GetComponent<RectTransform>();
            ContentRect.sizeDelta = new Vector2(+100, +300);
            ContentRect.anchorMin = new Vector2(0, 1);
            ContentRect.anchorMax = new Vector2(1, 1);
            ContentRect.pivot = new Vector2(0, 1);
            Content.transform.SetParent(Viewport.transform);
            ScrollbarH.transform.SetParent(scrollView.transform);
            RectTransform ScrollbarHRect = ScrollbarH.GetComponent<RectTransform>();
            ScrollbarHRect.pivot = Vector2.zero;
            ScrollbarHRect.anchorMin = new Vector2(0, 0);
            ScrollbarHRect.anchorMax = new Vector2(0, 0);
            ScrollbarHRect.sizeDelta = new Vector2(0, 20);
            ScrollbarHRect.anchoredPosition = Vector2.zero;
            ScrollbarH.GetComponent<Image>().type = Image.Type.Sliced;
            slidingAreaH.transform.SetParent(ScrollbarH.transform);
            RectTransform slidingAreaRect = slidingAreaH.GetComponent<RectTransform>();
            slidingAreaRect.anchorMin = new Vector2(0, 0);
            slidingAreaRect.anchorMax = new Vector2(1, 1);
            slidingAreaRect.sizeDelta = new Vector2(-20, -20);
            slidingAreaRect.anchoredPosition = Vector2.zero;
            handleH.GetComponent<Image>().type = Image.Type.Sliced;
            handleH.GetComponent<Image>().sprite = GetUISprite;
            handleH.transform.SetParent(slidingAreaH.transform);
            handleH.GetComponent<RectTransform>().sizeDelta = new Vector2(20, 20);
            handleH.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
            ScrollbarV.transform.SetParent(scrollView.transform);
            RectTransform ScrollbarVRect = ScrollbarV.GetComponent<RectTransform>();
            ScrollbarVRect.sizeDelta = new Vector2(20, 0);
            ScrollbarVRect.anchorMin = new Vector2(1, 0);
            ScrollbarVRect.anchorMax = new Vector2(1, 0);
            ScrollbarVRect.pivot = new Vector2(1, 1);
            slidingAreaV.transform.SetParent(ScrollbarV.transform);
            RectTransform slidingAreaVRect = slidingAreaV.GetComponent<RectTransform>();
            slidingAreaVRect.sizeDelta = new Vector2(-20, -20);
            slidingAreaVRect.anchoredPosition = Vector2.zero;
            slidingAreaVRect.anchorMin = new Vector2(0, 0);
            slidingAreaVRect.anchorMax = new Vector2(1, 1);
            handleV.GetComponent<Image>().type = Image.Type.Sliced;
            handleV.GetComponent<Image>().sprite = GetUISprite;
            handleV.transform.SetParent(slidingAreaV.transform);
            handleV.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
            handleV.GetComponent<RectTransform>().sizeDelta = new Vector2(20, 20);
            ScrollRect scrollViewRect = scrollView.GetComponent<ScrollRect>();
            scrollViewRect.content = Content.GetComponent<RectTransform>();
            scrollViewRect.viewport = Viewport.GetComponent<RectTransform>();
            Scrollbar ScrollbarHScrollbar = ScrollbarH.GetComponent<Scrollbar>();
            scrollViewRect.horizontalScrollbar = ScrollbarHScrollbar.GetComponent<Scrollbar>();
            scrollViewRect.verticalScrollbar = ScrollbarV.GetComponent<Scrollbar>();
            scrollViewRect.horizontalScrollbarVisibility = ScrollRect.ScrollbarVisibility.AutoHideAndExpandViewport;
            scrollViewRect.verticalScrollbarVisibility = ScrollRect.ScrollbarVisibility.AutoHideAndExpandViewport;
            scrollViewRect.horizontalScrollbarSpacing = -3;
            scrollViewRect.verticalScrollbarSpacing = -3;
            ScrollbarHScrollbar.handleRect = handleH.GetComponent<RectTransform>();
            ScrollbarHScrollbar.targetGraphic = handleH.GetComponent<Image>(); 
            ScrollbarV.GetComponent<Scrollbar>().handleRect = handleV.GetComponent<RectTransform>();
            ScrollbarHScrollbar.GetComponent<Image>().sprite = scrollView.GetComponent<Image>().sprite;
            ScrollbarV.GetComponent<Image>().sprite = scrollView.GetComponent<Image>().sprite;
            ScrollbarV.GetComponent<Image>().type = Image.Type.Sliced;
            ScrollbarV.GetComponent<Scrollbar>().targetGraphic = handleV.GetComponent<Image>();
            ScrollbarV.GetComponent<Scrollbar>().direction = Scrollbar.Direction.BottomToTop;
            scrollView.GetComponent<RectTransform>().anchoredPosition = position;
            AddLayerForEach(scrollView.gameObject);
            return scrollView;
        }

        /// <summary>
        /// Creates a scrollbar.
        /// </summary>
        public static Scrollbar scrollbar(string name, GameObject Canvas, Vector2 position)
        {
            Scrollbar scrollbar = new GameObject(name, typeof(Image), typeof(Scrollbar)).GetComponent<Scrollbar>();
            GameObject slidingArea = new GameObject("Sliding Area", typeof(RectTransform));
            GameObject handle = new GameObject("Handle", typeof(Image));
            scrollbar.transform.SetParent(Canvas.transform);
            scrollbar.GetComponent<Image>().type = Image.Type.Sliced;
            scrollbar.GetComponent<RectTransform>().sizeDelta = new Vector2(160, 20);
            scrollbar.GetComponent<RectTransform>().anchoredPosition = position;
            scrollbar.GetComponent<Image>().sprite = GetBackground;
            slidingArea.transform.SetParent(scrollbar.transform, true);
            RectTransform slidingAreaRect = slidingArea.GetComponent<RectTransform>();
            slidingAreaRect.anchorMin = new Vector2(0, 0);
            slidingAreaRect.anchorMax = new Vector2(1, 1);
            slidingAreaRect.sizeDelta = new Vector2(-20, -20);
            slidingAreaRect.anchoredPosition = Vector2.zero;
            handle.GetComponent<Image>().type = Image.Type.Sliced;
            handle.GetComponent<Image>().sprite = GetUISprite;
            handle.transform.SetParent(slidingArea.transform);
            RectTransform handleRect = handle.GetComponent<RectTransform>();
            handleRect.sizeDelta = new Vector2(20, 20);
            handleRect.anchoredPosition = Vector2.zero;
            scrollbar.GetComponent<Scrollbar>().handleRect = handleRect;
            scrollbar.GetComponent<Scrollbar>().targetGraphic = handle.GetComponent<Image>();
            AddLayerForEach(scrollbar.gameObject);
            return scrollbar;
        }

        /// <summary>
        /// Creates a legacy InputField.
        /// </summary>
        public static InputField LegacyInputField(string name, GameObject Canvas, Vector2 position)
        {
            InputField InputField = new GameObject(name, typeof(Image), typeof(InputField)).GetComponent<InputField>();
            GameObject Placeholder = new GameObject("Placeholder", typeof(Text));
            GameObject text = new GameObject("Text (Legacy)", typeof(Text));
            InputField.transform.SetParent(Canvas.transform);
            InputField.GetComponent<Image>().type = Image.Type.Sliced;
            InputField.GetComponent<Image>().sprite = GetInputFieldBackground;
            InputField.GetComponent<RectTransform>().sizeDelta = new Vector2(160, 30);
            Placeholder.transform.SetParent(InputField.transform);
            RectTransform PlaceholderRect = Placeholder.GetComponent<RectTransform>();
            PlaceholderRect.anchorMax = new Vector2(1, 1);
            PlaceholderRect.anchorMin = new Vector2(0, 0);
            PlaceholderRect.offsetMax = new Vector2(0, 0);
            PlaceholderRect.offsetMin = new Vector2(0, 0);
            PlaceholderRect.anchoredPosition = new Vector2(0,-0.50f);
            PlaceholderRect.sizeDelta = new Vector2(-20,-13);
            Text PlaceholderText = Placeholder.GetComponent<Text>();
            PlaceholderText.text = "Enter text...";
            PlaceholderText.font = ArialFont;
            PlaceholderText.fontStyle = FontStyle.Italic;
            PlaceholderText.color = new Color(0.20f, 0.20f, 0.20f, 0.5f);
            text.transform.SetParent(InputField.transform);
            RectTransform textRect = text.GetComponent<RectTransform>();
            textRect.anchorMax = new Vector2(1, 1);
            textRect.anchorMin = new Vector2(0, 0);
            textRect.offsetMax = new Vector2(0, 0);
            textRect.offsetMin = new Vector2(0, 0);
            textRect.sizeDelta = new Vector2(-20,-13);
            textRect.anchoredPosition = new Vector2(0,-0.50f);
            Text textt = text.GetComponent<Text>();
            textt.fontSize = 14;
            textt.color = new Color(0.20f, 0.20f, 0.20f, 1f);
            textt.supportRichText = false;
            textt.font = ArialFont;
            InputField IFTMP = InputField.GetComponent<InputField>();
            IFTMP.textComponent = text.GetComponent<Text>();
            IFTMP.placeholder = Placeholder.GetComponent<Text>();
            InputField.GetComponent<RectTransform>().anchoredPosition = position;
            AddLayerForEach(InputField.gameObject);
            return InputField;
        }

        /// <summary>
        /// Creates a legacy DropDown.
        /// </summary>
        public static Dropdown LegacyDropDown(string name, GameObject Canvas, Vector2 position)
        {
            Dropdown Dropdown = new GameObject(name, typeof(Image), typeof(Dropdown)).GetComponent<Dropdown>();
            GameObject Label = new GameObject("Label", typeof(Text));
            GameObject Arrow = new GameObject("Arrow", typeof(Image));
            GameObject Template = new GameObject("Template", typeof(Image), typeof(ScrollRect));
            GameObject Viewport = new GameObject("Viewport", typeof(Image), typeof(Mask));
            GameObject Content = new GameObject("Content", typeof(RectTransform));
            GameObject Item = new GameObject("Item", typeof(Toggle));
            GameObject ItemBackground = new GameObject("Item Background", typeof(Image));
            GameObject ItemCheckmark = new GameObject("Item Checkmark", typeof(Image));
            GameObject ItemLabel = new GameObject("Item Label", typeof(Text));
            GameObject scrollbar = new GameObject("Scrollbar", typeof(Image), typeof(Scrollbar));
            GameObject slidingArea = new GameObject("Sliding Area", typeof(RectTransform));
            GameObject Handle = new GameObject("Handle", typeof(Image));
            Dropdown.transform.SetParent(Canvas.transform);
            Dropdown.GetComponent<RectTransform>().sizeDelta = new Vector2(160, 30);
            Dropdown.GetComponent<Image>().sprite = GetUISprite;
            Dropdown.GetComponent<RectTransform>().sizeDelta = new Vector2(160, 30);
            Dropdown.GetComponent<Image>().type = Image.Type.Sliced;
            Dropdown.GetComponent<Dropdown>().options.Add(new Dropdown.OptionData("Option A"));
            Dropdown.GetComponent<Dropdown>().options.Add(new Dropdown.OptionData("Option B"));
            Dropdown.GetComponent<Dropdown>().options.Add(new Dropdown.OptionData("Option C"));
            Label.transform.SetParent(Dropdown.transform);
            Text LabelText = Label.GetComponent<Text>();
            LabelText.font = ArialFont;
            LabelText.color = new Vector4(0.20f, 0.20f, 0.20f, 1);
            LabelText.alignment = TextAnchor.MiddleLeft;
            RectTransform LabelRT = Label.GetComponent<RectTransform>();
            LabelRT.anchorMax = new Vector2(1, 1);
            LabelRT.anchorMin = new Vector2(0, 0);
            LabelRT.sizeDelta = new Vector2(-35, -13);
            LabelRT.anchoredPosition = new Vector2(-7.50f, -0.50f);
            Arrow.transform.SetParent(Dropdown.transform);
            RectTransform ArrowRT = Arrow.GetComponent<RectTransform>();
            ArrowRT.anchorMax = new Vector2(1, 0.5f);
            ArrowRT.anchorMin = new Vector2(1, 0.5f);
            ArrowRT.sizeDelta = new Vector2(20, 20);
            ArrowRT.anchoredPosition = new Vector2(-15, 0);
            Arrow.GetComponent<Image>().sprite = GetDropdownArrow;
            Template.GetComponent<RectTransform>().sizeDelta = new Vector2(0, 150);
            Template.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 2);
            Template.transform.SetParent(Dropdown.transform);
            Template.SetActive(false);
            Template.GetComponent<Image>().sprite = Dropdown.GetComponent<Image>().sprite;
            Template.GetComponent<Image>().type = Image.Type.Sliced;
            RectTransform TPRT = Template.GetComponent<RectTransform>();
            TPRT.anchorMax = new Vector2(1, 0);
            TPRT.anchorMin = new Vector2(0, 0);
            TPRT.pivot = new Vector2(0.5f, 1);
            TPRT.sizeDelta = new Vector2(0, 150);
            TPRT.anchoredPosition = new Vector2(0, 2);
            ScrollRect TPTMP = Template.GetComponent<ScrollRect>();
            TPTMP.movementType = ScrollRect.MovementType.Clamped;
            TPTMP.horizontal = false;
            TPTMP.verticalScrollbarVisibility = ScrollRect.ScrollbarVisibility.AutoHideAndExpandViewport;
            TPTMP.verticalScrollbarSpacing = -3;
            Viewport.GetComponent<RectTransform>().sizeDelta = new Vector2(-18, -0);
            Viewport.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
            Viewport.transform.SetParent(Template.transform);
            Viewport.GetComponent<Image>().sprite = GetUIMask;
            Viewport.GetComponent<Image>().type = Image.Type.Sliced;
            Viewport.GetComponent<Mask>().showMaskGraphic = false;
            RectTransform VPTMP = Viewport.GetComponent<RectTransform>();
            VPTMP.pivot = new Vector2(0, 1);
            VPTMP.anchorMax = new Vector2(1, 1);
            VPTMP.anchorMin = new Vector2(0, 0);
            VPTMP.sizeDelta = new Vector2(-18, 0);
            VPTMP.anchoredPosition = Vector2.zero;
            scrollbar.transform.SetParent(Template.transform);
            scrollbar.GetComponent<Image>().sprite = GetBackground;
            scrollbar.GetComponent<Image>().type = Image.Type.Sliced;
            RectTransform sbrt = scrollbar.GetComponent<RectTransform>();
            sbrt.pivot = new Vector2(1, 1);
            sbrt.anchorMax = new Vector2(1, 1);
            sbrt.anchorMin = new Vector2(1, 0);
            sbrt.sizeDelta = new Vector2(20, 0);
            sbrt.anchoredPosition = Vector2.zero;
            slidingArea.transform.SetParent(scrollbar.transform);
            RectTransform slareart = slidingArea.GetComponent<RectTransform>();
            slareart.anchorMax = new Vector2(1, 1);
            slareart.anchorMin = new Vector2(0, 0);
            slareart.sizeDelta = new Vector2(-20, -20);
            slareart.anchoredPosition = Vector2.zero;
            Handle.transform.SetParent(slidingArea.transform);
            Handle.GetComponent<Image>().sprite = GetUISprite;
            Handle.GetComponent<Image>().type = Image.Type.Sliced;
            Handle.GetComponent<RectTransform>().sizeDelta = new Vector2(20, 20);
            Handle.GetComponent<RectTransform>().anchoredPosition = Vector2.zero;
            scrollbar.GetComponent<Scrollbar>().targetGraphic = Handle.GetComponent<Image>();
            scrollbar.GetComponent<Scrollbar>().handleRect = Handle.GetComponent<RectTransform>();
            scrollbar.GetComponent<Scrollbar>().direction = Scrollbar.Direction.BottomToTop;
            Content.transform.SetParent(Viewport.transform);
            RectTransform ContentRect = Content.GetComponent<RectTransform>();
            ContentRect.pivot = new Vector2(0.5f, 1);
            ContentRect.anchorMax = new Vector2(1, 1);
            ContentRect.anchorMin = new Vector2(0, 1);
            ContentRect.sizeDelta = new Vector2(0, 28);
            ContentRect.anchoredPosition = Vector2.zero;
            Item.GetComponent<Toggle>().isOn = true;
            Item.transform.SetParent(Content.transform);
            RectTransform ItemRect = Item.GetComponent<RectTransform>();
            ItemRect.anchorMax = new Vector2(1, 0.5f);
            ItemRect.anchorMin = new Vector2(0, 0.5f);
            ItemRect.sizeDelta = new Vector2(0, 20);
            ItemRect.anchoredPosition = Vector2.zero;
            Item.GetComponent<Toggle>().targetGraphic = ItemBackground.GetComponent<Image>();
            ItemBackground.transform.SetParent(Item.transform);
            RectTransform ItemBackgroundRect = ItemBackground.GetComponent<RectTransform>();
            ItemBackgroundRect.anchorMax = new Vector2(1, 1);
            ItemBackgroundRect.anchorMin = new Vector2(0, 0);
            ItemBackgroundRect.sizeDelta = Vector2.zero;
            ItemBackgroundRect.anchoredPosition = Vector2.zero;
            Item.GetComponent<Toggle>().graphic = ItemCheckmark.GetComponent<Image>();
            ItemCheckmark.transform.SetParent(Item.transform);
            ItemCheckmark.GetComponent<Image>().sprite = GetCheckmark;
            RectTransform ICRect = ItemCheckmark.GetComponent<RectTransform>();
            ICRect.anchorMax = new Vector2(0, 0.5f);
            ICRect.anchorMin = new Vector2(0, 0.5f);
            ICRect.sizeDelta = new Vector2(20, 20);
            ICRect.anchoredPosition = new Vector2(10, 0);
            ItemLabel.transform.SetParent(Item.transform);
            RectTransform ItemLabelRect = ItemLabel.GetComponent<RectTransform>();
            Text ItemLabelTMPU = ItemLabel.GetComponent<Text>();
            ItemLabelTMPU.alignment = TextAnchor.MiddleLeft;
            ItemLabelTMPU.font = ArialFont;
            ItemLabelTMPU.text = "Option A";
            ItemLabelTMPU.color = new Vector4(0.20f, 0.20f, 0.20f, 1);
            ItemLabelRect.anchorMax = new Vector2(1, 1);
            ItemLabelRect.anchorMin = new Vector2(0, 0);
            ItemLabelRect.sizeDelta = new Vector2(-30, -3);
            ItemLabelRect.anchoredPosition = new Vector2(5, -0.50f);
            Dropdown DDTMP = Dropdown.GetComponent<Dropdown>();
            DDTMP.targetGraphic = Dropdown.GetComponent<Image>();
            DDTMP.template = Template.GetComponent<RectTransform>();
            DDTMP.captionText = Label.GetComponent<Text>();
            DDTMP.itemText = ItemLabel.GetComponent<Text>();
            ScrollRect TemplateScrollRect = Template.GetComponent<ScrollRect>();
            TemplateScrollRect.content = Content.GetComponent<RectTransform>();
            TemplateScrollRect.viewport = Viewport.GetComponent<RectTransform>();
            TemplateScrollRect.verticalScrollbar = scrollbar.GetComponent<Scrollbar>();
            Dropdown.GetComponent<RectTransform>().anchoredPosition = position;
            AddLayerForEach(Dropdown.gameObject);
            return Dropdown;
        }
    }
}
