using System.Drawing;

namespace LifeProj.View {
    
    public static class Utils {
        
        public static void FillCircle(Graphics g, Brush brush, float centerX, float centerY, float radius){
            g.FillEllipse(brush, centerX - radius, centerY - radius,radius + radius, radius + radius);
        }
        
        public static void FillRectangle( Graphics g, Brush brush, float centerX, float centerY, float radius){
            g.FillRectangle(brush, centerX - radius, centerY - radius, radius + radius, radius + radius);
        }
    }
}