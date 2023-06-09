using System;
using System.Threading.Tasks;
using UnityEngine;

namespace Unity.Commander
{
    public class CanvasFadeCommand : ICommand
    {
        private readonly CanvasGroup canvasGroup;
        private readonly float newAlpha;
        private readonly float duration;

        public CanvasFadeCommand(CanvasGroup canvasGroup, float newAlpha, float duration)
        {
            this.canvasGroup = canvasGroup;
            this.newAlpha = newAlpha;
            this.duration = duration;
        }

        public async Task Execute()
        {
            var initialAlpha = this.canvasGroup.alpha;
            var alphaDifference = this.newAlpha - initialAlpha;
            var alphaIncrement = alphaDifference / this.duration;

            while (Math.Abs(this.canvasGroup.alpha - this.newAlpha) > .01f)
            {
                this.canvasGroup.alpha += alphaIncrement * Time.deltaTime;
                await Task.Yield();
            }
        }
    }
}
