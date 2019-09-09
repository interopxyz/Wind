using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wind.Graphics
{
    public class Effects
    {
        #region members

        protected string id = string.Empty;

        protected bool hasEffects = false;

        protected bool hasBlur = false;
        protected BlurEffect blur = new BlurEffect();

        protected bool hasShadow = false;
        protected ShadowEffect shadow = new ShadowEffect();

        #endregion

        #region contructors

        public Effects()
        {
            id = Guid.NewGuid().ToString();
        }

        public Effects(Effects effects)
        {
            id = Guid.NewGuid().ToString();
            this.hasEffects = effects.hasEffects;
            this.hasBlur = effects.hasBlur;
            this.blur = effects.blur;
            this.hasShadow = effects.hasShadow;
            this.shadow = effects.shadow;
        }

        protected Effects(BlurEffect blurEffect)
        {
            id = Guid.NewGuid().ToString();
            this.hasEffects = true;
            this.hasBlur = true;
            this.blur = new BlurEffect(blurEffect);
        }

        protected Effects(ShadowEffect shadowEffect)
        {
            id = Guid.NewGuid().ToString();
            this.hasEffects = true;
            this.shadow = new ShadowEffect(shadowEffect);
        }

        #endregion

        #region properties
        
        public virtual bool HasBlurEffect
        {
            get { return this.hasBlur; }
            set { this.hasBlur = value; }
        }

        public virtual BlurEffect Blur
        {
            get { return this.blur; }
            set
            {
                this.blur = value;
                this.hasBlur = true;
                this.hasEffects = true;
            }
        }

        public virtual bool HasShadowEffect
        {
            get { return this.hasShadow; }
            set { this.hasShadow = value; }
        }

        public virtual ShadowEffect Shadow
        {
            get { return this.shadow; }
            set
            {
                this.shadow = value;
                this.hasShadow = true;
                this.hasEffects = true;
            }
        }

        public virtual bool HasEffects
        {
            get { return this.hasEffects; }
        }

        public virtual string ID
        {
            get { return this.id; }
        }

        #endregion

        #region methods
        

        #endregion

    }
}
