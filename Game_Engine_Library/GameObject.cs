﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Engine_Library {
    public abstract class GameObject : IDrawable {
        protected double x, y, width, height;

        protected Texture texture;

        public Collision Collision { get; protected set; }

        public GameObject(double x, double y, double width, double height) {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;

            Collision = new Collision(x, y, width, height);
        }

        public abstract void Draw();

        public abstract void Update();
    }
}
